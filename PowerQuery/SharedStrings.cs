using System;
using System.Collections.Generic;
using System.Text;

namespace PowerQuery
{
    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    [System.Xml.Serialization.XmlRootAttribute("sst", Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = false)]
    public partial class SharedStrings
    {
        public SharedStrings() { }

        private sstSI[] siField;

        private byte countField;

        private byte uniqueCountField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("si")]
        public sstSI[] si
        {
            get
            {
                return this.siField;
            }
            set
            {
                this.siField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte count
        {
            get
            {
                return this.countField;
            }
            set
            {
                this.countField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte uniqueCount
        {
            get
            {
                return this.uniqueCountField;
            }
            set
            {
                this.uniqueCountField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
    public partial class sstSI
    {
        public sstSI() { }

        private string tField;

        /// <remarks/>
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
}
