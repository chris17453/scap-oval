using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-results-5")]
    public class TestedItemType {
        private MessageType[] messageField;
        private string item_idField;
    [XmlIgnore]
    public ResultEnumeration? resultField       { get; set; }
    public bool resultSpecified=>resultField.HasValue;
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
        public string item_id {
            get {
                return this.item_idField;
            }
            set {
                this.item_idField = value;
            }
        }
        [XmlAttribute]
        public ResultEnumeration result {
            get {
                return this.resultField.Value;
            }
            set {
                this.resultField = value;
            }
        }
    }

}

