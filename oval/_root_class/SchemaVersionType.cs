using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-common-5")]
    public class SchemaVersionType {
        private string platformField;
        private string valueField;
        [XmlAttribute(DataType="anyURI")]
        public string platform {
            get {
                return this.platformField;
            }
            set {
                this.platformField = value;
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

