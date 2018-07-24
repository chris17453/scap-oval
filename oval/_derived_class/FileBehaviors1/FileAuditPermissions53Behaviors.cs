using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#windows")]
    public class FileAuditPermissions53Behaviors : FileBehaviors1 {
    [XmlIgnore]
    public bool? include_groupField       { get; set; }
    public bool include_groupSpecified=>include_groupField.HasValue;
    [XmlIgnore]
    public bool? resolve_groupField       { get; set; }
    public bool resolve_groupSpecified=>resolve_groupField.HasValue;
        public FileAuditPermissions53Behaviors() {
            //this.include_groupField = true;
            //this.resolve_groupField = false;
        }
        [XmlAttribute]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool include_group {
            get {
                return this.include_groupField.Value;
            }
            set {
                this.include_groupField = value;
            }
        }
        [XmlAttribute]
        public bool resolve_group {
            get {
                return this.resolve_groupField.Value;
            }
            set {
                this.resolve_groupField = value;
            }
        }
    }

}

