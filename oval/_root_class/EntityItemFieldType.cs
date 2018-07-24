using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5")]
    public class EntityItemFieldType {
        private string nameField;
        private string datatypeField;
    [XmlIgnore]
    public bool? maskField       { get; set; }
    public bool maskSpecified=>maskField.HasValue;
    [XmlIgnore]
    public StatusEnumeration? statusField       { get; set; }
    public bool statusSpecified=>statusField.HasValue;
        private string valueField;
        public EntityItemFieldType() {
            //this.datatypeField = "string";
            //this.maskField = false;
            //this.statusField = StatusEnumeration.exists;
        }
        [XmlAttribute]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        [XmlAttribute]
        public string datatype {
            get {
                return this.datatypeField;
            }
            set {
                this.datatypeField = value;
            }
        }
        [XmlAttribute]
        public bool mask {
            get {
                return this.maskField.Value;
            }
            set {
                this.maskField = value;
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

