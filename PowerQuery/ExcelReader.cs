using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PowerQuery
{
    public class ExcelReader
    {
        private SharedStrings SharedStrings {  get; set; } = new SharedStrings();
        public Dictionary<string, List<List<object>>> SheetData { get; set; } = new Dictionary<string, List<List<object>>>();
        public ExcelReader(string path)
        {
            Task.Run(async () =>
            {
                await ReadSharedStrings(path);
            }).GetAwaiter().GetResult();
        }
        private static T DeserializeXml<T>(string xml)
        {
            var serializer = new XmlSerializer(typeof(T));
            using (var reader = new StringReader(xml))
            {
                return (T)serializer.Deserialize(reader);
            }
        }

        private async Task ReadSharedStrings(string path)
        {
            using var archive = ZipFile.OpenRead(path);
            var sEntry = archive.GetEntry("xl/sharedStrings.xml");
            using var reader = new StreamReader(sEntry.Open(), Encoding.UTF8);
            string content = await reader.ReadToEndAsync();
            SharedStrings = DeserializeXml<SharedStrings>(content);

            foreach (var entry in archive.Entries)
            {
                if (entry.FullName.StartsWith("xl/worksheets") && entry.FullName.EndsWith(".xml"))
                {
                    SheetData[entry.Name] = await ReadWorkSheets(entry);
                }                   
            }
        }
        private async Task<List<List<object>>> ReadWorkSheets(ZipArchiveEntry entry)
        {
            using var reader = new StreamReader(entry.Open(), Encoding.UTF8);
            string content = await reader.ReadToEndAsync();
            var WorkSheet = DeserializeXml<Worksheet>(content);
            var data = new List<List<object>>();

            foreach (var row in WorkSheet.sheetData)
            {
                var dataRow = new List<object>();
                int currentColumnIndex = 0;

                foreach (var cell in row.c)
                {
                    // Get column index from cell reference (e.g. "C1" → 2)
                    int columnIndex = GetColumnIndex(cell.r);

                    // Fill missing columns with empty values
                    while (currentColumnIndex < columnIndex)
                    {
                        dataRow.Add(string.Empty);
                        currentColumnIndex++;
                    }

                    // Read cell value
                    if (cell.t == "s")
                    {
                        int index = (int)cell.v;
                        string value = SharedStrings.si[index].t.Value;
                        dataRow.Add(value);
                    }
                    else
                    {
                        dataRow.Add(cell.v);
                    }

                    currentColumnIndex++;
                }

                data.Add(dataRow);
            }
            return data;
        }
        private int GetColumnIndex(string cellReference)
        {
            // Extract letters from "A1", "BC23" → "A", "BC"
            string columnPart = new string(cellReference
                .TakeWhile(c => char.IsLetter(c))
                .ToArray());

            int columnIndex = 0;
            foreach (char c in columnPart)
            {
                columnIndex *= 26;
                columnIndex += (c - 'A' + 1);
            }

            return columnIndex - 1; // zero-based index
        }
    }
}
