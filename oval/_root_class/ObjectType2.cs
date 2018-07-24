using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(TypeName="ObjectType", Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5")]
    public class ObjectType2 {
        private MessageType[] messageField;
        private VariableValueType[] variable_valueField;
        private ReferenceType2[] referenceField;
        private string idField;
        private string versionField;
        private string variable_instanceField;
        private string commentField;
    [XmlIgnore]
    public FlagEnumeration? flagField       { get; set; }
    public bool flagSpecified=>flagField.HasValue;
        public ObjectType2() {
            //this.variable_instanceField = "1";
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
        [XmlElementAttribute("variable_value")]
        public VariableValueType[] variable_value {
            get {
                return this.variable_valueField;
            }
            set {
                this.variable_valueField = value;
            }
        }
        [XmlElementAttribute("reference")]
        public ReferenceType2[] reference {
            get {
                return this.referenceField;
            }
            set {
                this.referenceField = value;
            }
        }
        [XmlAttribute]
        public string id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        [XmlAttribute(DataType="nonNegativeInteger")]
        public string version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
        [XmlAttribute(DataType="nonNegativeInteger")]
        public string variable_instance {
            get {
                return this.variable_instanceField;
            }
            set {
                this.variable_instanceField = value;
            }
        }
        [XmlAttribute]
        public string comment {
            get {
                return this.commentField;
            }
            set {
                this.commentField = value;
            }
        }
        [XmlAttribute]
        public FlagEnumeration flag {
            get {
                return this.flagField.Value;
            }
            set {
                this.flagField = value;
            }
        }
    }

}

