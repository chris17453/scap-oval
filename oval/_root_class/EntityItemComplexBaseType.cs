using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [XmlIncludeAttribute(typeof(EntityItemRecordType))]
    [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5")]
    public abstract class EntityItemComplexBaseType {
        private string datatypeField;
    [XmlIgnore]
    public bool? maskField       { get; set; }
    public bool maskSpecified=>maskField.HasValue;
    [XmlIgnore]
    public StatusEnumeration? statusField       { get; set; }
    public bool statusSpecified=>statusField.HasValue;
        public EntityItemComplexBaseType() {
            //this.datatypeField = "string";
            //this.maskField = false;
            //this.statusField = StatusEnumeration.exists;
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
    }

}

