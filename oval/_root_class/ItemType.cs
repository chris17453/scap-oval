using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5")]
    [XmlRootAttribute("item", Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5", IsNullable=false)]
    public class ItemType {
        private MessageType[] messageField;
        private string idField;
    [XmlIgnore]
    public StatusEnumeration? statusField       { get; set; }
    public bool statusSpecified=>statusField.HasValue;
        public ItemType() {
            //this.statusField = StatusEnumeration.exists;
        }
        [XmlElementAttribute("message")]
        public MessageType[] message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
            }
        }
        [XmlAttribute(DataType="integer")]
        public string id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        [XmlAttribute]
        public StatusEnumeration status {
            get {
                return this.statusField.Value;
            }
            set {
                this.statusField = value;
            }
        }
    }

}

