using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5")]
    //[XmlRoot ("time_difference")]
    public class TimeDifferenceFunctionType : recursive_base  {

    [XmlIgnore]
    public DateTimeFormatEnumeration? format_1Field       { get; set; }
    public bool format_1Specified=>format_1Field.HasValue;
    [XmlIgnore]
    public DateTimeFormatEnumeration? format_2Field       { get; set; }
    public bool format_2Specified=>format_2Field.HasValue;
        public TimeDifferenceFunctionType() {
            /*this.format_1Field = DateTimeFormatEnumeration.year_month_day;
            this.format_2Field = DateTimeFormatEnumeration.year_month_day;*/
        }

        [XmlAttribute]
        public DateTimeFormatEnumeration format_1 {
            get {
                return this.format_1Field.Value;
            }
            set {
                this.format_1Field = value;
            }
        }
        [XmlAttribute]
        public DateTimeFormatEnumeration format_2 {
            get {
                return this.format_2Field.Value;
            }
            set {
                this.format_2Field = value;
            }
        }
    }

}

