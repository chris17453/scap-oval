using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5")]
    [XmlRoot("literal_component")]
    public class LiteralComponentType   {
        [XmlIgnore]
        public SimpleDatatypeEnumeration? datatypeField;
        public bool datatypeSpecified=>datatypeField.HasValue;
        private string valueField;
        public LiteralComponentType() {
            //this.datatypeField = SimpleDatatypeEnumeration.@string;
        }
        [XmlAttribute]
        public SimpleDatatypeEnumeration datatype {
            get {
                return this.datatypeField.Value;
            }
            set {
                this.datatypeField = value;
            }
        }
        [XmlTextAttribute]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }

}
