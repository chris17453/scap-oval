using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-common-5")]
    public class MessageType {
    [XmlIgnore]
    public MessageLevelEnumeration? levelField       { get; set; }
    public bool levelSpecified=>levelField.HasValue;
        private string valueField;
        public MessageType() {
            //this.levelField = MessageLevelEnumeration.info;
        }
        [XmlAttribute]
        public MessageLevelEnumeration level {
            get {
                return this.levelField.Value;
            }
            set {
                this.levelField = value;
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

