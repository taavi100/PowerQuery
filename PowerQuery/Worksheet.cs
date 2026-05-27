using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace PowerQuery
{


    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [System.Xml.Serialization.XmlRootAttribute("worksheet", Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = false)]
    public partial class Worksheet
    {
        private worksheetDimension dimensionField;

        private worksheetSheetViews sheetViewsField;

        private worksheetSheetFormatPr sheetFormatPrField;

        private worksheetCols colsField;

        private worksheetRow[] sheetDataField;

        private worksheetPageMargins pageMarginsField;

        private string ignorableField;

        private string uidField;

        /// <remarks/>
        public worksheetDimension dimension
        {
            get
            {
                return this.dimensionField;
            }
            set
            {
                this.dimensionField = value;
            }
        }

        /// <remarks/>
        public worksheetSheetViews sheetViews
        {
            get
            {
                return this.sheetViewsField;
            }
            set
            {
                this.sheetViewsField = value;
            }
        }

        /// <remarks/>
        public worksheetSheetFormatPr sheetFormatPr
        {
            get
            {
                return this.sheetFormatPrField;
            }
            set
            {
                this.sheetFormatPrField = value;
            }
        }

        /// <remarks/>
        public worksheetCols cols
        {
            get
            {
                return this.colsField;
            }
            set
            {
                this.colsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("row", IsNullable = false)]
        public worksheetRow[] sheetData
        {
            get
            {
                return this.sheetDataField;
            }
            set
            {
                this.sheetDataField = value;
            }
        }

        /// <remarks/>
        public worksheetPageMargins pageMargins
        {
            get
            {
                return this.pageMarginsField;
            }
            set
            {
                this.pageMarginsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.openxmlformats.org/markup-compatibility/2006")]
        public string Ignorable
        {
            get
            {
                return this.ignorableField;
            }
            set
            {
                this.ignorableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.microsoft.com/office/spreadsheetml/2014/revision")]
        public string uid
        {
            get
            {
                return this.uidField;
            }
            set
            {
                this.uidField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    public partial class worksheetDimension
    {

        private string refField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string @ref
        {
            get
            {
                return this.refField;
            }
            set
            {
                this.refField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    public partial class worksheetSheetViews
    {

        private worksheetSheetViewsSheetView sheetViewField;

        /// <remarks/>
        public worksheetSheetViewsSheetView sheetView
        {
            get
            {
                return this.sheetViewField;
            }
            set
            {
                this.sheetViewField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    public partial class worksheetSheetViewsSheetView
    {

        private worksheetSheetViewsSheetViewSelection selectionField;

        private byte tabSelectedField;

        private byte workbookViewIdField;

        /// <remarks/>
        public worksheetSheetViewsSheetViewSelection selection
        {
            get
            {
                return this.selectionField;
            }
            set
            {
                this.selectionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte tabSelected
        {
            get
            {
                return this.tabSelectedField;
            }
            set
            {
                this.tabSelectedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte workbookViewId
        {
            get
            {
                return this.workbookViewIdField;
            }
            set
            {
                this.workbookViewIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    public partial class worksheetSheetViewsSheetViewSelection
    {

        private string activeCellField;

        private string sqrefField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string activeCell
        {
            get
            {
                return this.activeCellField;
            }
            set
            {
                this.activeCellField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string sqref
        {
            get
            {
                return this.sqrefField;
            }
            set
            {
                this.sqrefField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    public partial class worksheetSheetFormatPr
    {

        private byte defaultRowHeightField;

        private decimal dyDescentField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte defaultRowHeight
        {
            get
            {
                return this.defaultRowHeightField;
            }
            set
            {
                this.defaultRowHeightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.microsoft.com/office/spreadsheetml/2009/9/ac")]
        public decimal dyDescent
        {
            get
            {
                return this.dyDescentField;
            }
            set
            {
                this.dyDescentField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    public partial class worksheetCols
    {

        private worksheetColsCol colField;

        /// <remarks/>
        public worksheetColsCol col
        {
            get
            {
                return this.colField;
            }
            set
            {
                this.colField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    public partial class worksheetColsCol
    {

        private byte minField;

        private byte maxField;

        private decimal widthField;

        private byte customWidthField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte min
        {
            get
            {
                return this.minField;
            }
            set
            {
                this.minField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte max
        {
            get
            {
                return this.maxField;
            }
            set
            {
                this.maxField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte customWidth
        {
            get
            {
                return this.customWidthField;
            }
            set
            {
                this.customWidthField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    public partial class worksheetRow
    {

        private worksheetRowC[] cField;

        private ushort rField;

        private string spansField;

        private decimal dyDescentField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("c")]
        public worksheetRowC[] c
        {
            get
            {
                return this.cField;
            }
            set
            {
                this.cField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort r
        {
            get
            {
                return this.rField;
            }
            set
            {
                this.rField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string spans
        {
            get
            {
                return this.spansField;
            }
            set
            {
                this.spansField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.microsoft.com/office/spreadsheetml/2009/9/ac")]
        public decimal dyDescent
        {
            get
            {
                return this.dyDescentField;
            }
            set
            {
                this.dyDescentField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    public partial class worksheetRowC
    {

        private short vField;

        private string rField;

        private byte sField;

        private string tField;

        /// <remarks/>
        public short v
        {
            get
            {
                return this.vField;
            }
            set
            {
                this.vField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string r
        {
            get
            {
                return this.rField;
            }
            set
            {
                this.rField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte s
        {
            get
            {
                return this.sField;
            }
            set
            {
                this.sField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string t
        {
            get
            {
                return this.tField;
            }
            set
            {
                this.tField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    public partial class worksheetPageMargins
    {

        private decimal leftField;

        private decimal rightField;

        private decimal topField;

        private decimal bottomField;

        private decimal headerField;

        private decimal footerField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal left
        {
            get
            {
                return this.leftField;
            }
            set
            {
                this.leftField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal right
        {
            get
            {
                return this.rightField;
            }
            set
            {
                this.rightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal top
        {
            get
            {
                return this.topField;
            }
            set
            {
                this.topField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal bottom
        {
            get
            {
                return this.bottomField;
            }
            set
            {
                this.bottomField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal header
        {
            get
            {
                return this.headerField;
            }
            set
            {
                this.headerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal footer
        {
            get
            {
                return this.footerField;
            }
            set
            {
                this.footerField = value;
            }
        }
    }
}
