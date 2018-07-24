using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5")]
    //[XmlRoot ("substring")]
    public class SubstringFunctionType : recursive_base  {
    [XmlIgnore]
    public int? substring_startField       { get; set; }
    public bool substring_startSpecified=>substring_startField.HasValue;
    [XmlIgnore]
    public int? substring_lengthField       { get; set; }
    public bool substring_lengthSpecified=>substring_lengthField.HasValue;
       
        [XmlAttribute]
        public int substring_start {
            get {
                return this.substring_startField.Value;
            }
            set {
                this.substring_startField = value;
            }
        }
        [XmlAttribute]
        public int substring_length {
            get {
                return this.substring_lengthField.Value;
            }
            set {
                this.substring_lengthField = value;
            }
        }
    }

}

