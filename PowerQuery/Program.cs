using System.Text.Json;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System;


namespace PowerQuery
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Power Query M code generator for Excel workbooks");
            if(args.Length == 0) {
                Console.WriteLine("Please provide the path to the Excel file.");
                return;
            }

            try
            {
                string path = args[0];
                ExcelReader reader = new ExcelReader(path);
                foreach (var sheet in reader.SheetData)
                {
                    WriteDataFile(sheet.Value, sheet.Key);
                    Console.WriteLine($"Excel workseet {sheet.Key} file created");
                }
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }

        private static string CompressData(string data)
        {
            string base64;
            using (Stream originalStream = GenerateStreamFromString(data))
            using (MemoryStream compressedStream = new MemoryStream())
            using (DeflateStream compressor = new DeflateStream(compressedStream, CompressionMode.Compress))            
            {
                originalStream.CopyTo(compressor);
                compressor.Flush();
                base64 = Convert.ToBase64String(compressedStream.ToArray());
            }
            return base64;
        }

        private static string DeCompressData(string encodedString)
        {
            byte[] data = Convert.FromBase64String(encodedString);
            string result;

            using (Stream compressedStream = new MemoryStream(data))
            using (MemoryStream decompressedStream = new MemoryStream())
            using (DeflateStream decompressor = new DeflateStream(compressedStream, CompressionMode.Decompress))
            {
                decompressor.CopyTo(decompressedStream);
                result = System.Text.Encoding.UTF8.GetString(decompressedStream.ToArray(), 0, (int)decompressedStream.Length);
            }

            return result;
        }

        private static Stream GenerateStreamFromString(string s)
        {
            var stream = new MemoryStream();
            var writer = new StreamWriter(stream);
            writer.Write(s);
            writer.Flush();
            stream.Position = 0;
            return stream;
        }

        private static void WriteDataFile(List<List<object>> data, string table)
        {
            Dictionary<string, string> dataTypes = new Dictionary<string, string>
            {
                {"int", "Int64" },
                {"nvarchar", "Text" },
                {"datetime", "DateTime" },
                {"binary", "Binary"},
                {"decimal", "Decimal"},
                {"date", "Date"},
                {"timestamp", "DateTime" },
                {"char", "Text" },
                {"tinyint", "Int64" },
                {"varchar", "Text" },
                {"smallint", "Int64" },
            };


            List<string> nameList = data
                .FirstOrDefault()?
                .Select(x => x?.ToString() ?? "")
                .ToList()
                ?? new List<string>();

            List<string> typeList = data
                .FirstOrDefault()?
                .Select(x => "nvarchar")
                .ToList()
                ?? new List<string>();

            string json = JsonSerializer.Serialize(data.Skip(1).ToList());

            using (StreamWriter outputFile = new StreamWriter($"{table}.m", false))
            {
                string columns = string.Join(", ", nameList.Select((value, index) => $"Column{index} = _t"));
                string names = string.Join(", ", nameList.Select((value, index) => $"{{\"Column{index}\", \"{value}\"}}"));
                string types = string.Join(", ", typeList.Select((value, index) => $"{{\"Column{index}\", {dataTypes[value]}.Type}}")); ;
                outputFile.WriteLine("let");
                outputFile.Write("    Source = Table.FromRows(Json.Document(Binary.Decompress(Binary.FromText(\"");
                outputFile.Write(CompressData(json));
                outputFile.WriteLine("\", BinaryEncoding.Base64), Compression.Deflate)),");
                outputFile.WriteLine($"        let _t = ((type nullable text) meta [Serialized.Text = true]) in type table [{columns}]),");
                outputFile.WriteLine($"    #\"Changed Type\" = Table.TransformColumnTypes(Source,{{{types}}}),");
                outputFile.WriteLine($"    #\"Renamed Columns\" = Table.RenameColumns(#\"Changed Type\",{{{names}}})");
                outputFile.WriteLine("in\n    #\"Renamed Columns\"");
            }
        }
    }
}
