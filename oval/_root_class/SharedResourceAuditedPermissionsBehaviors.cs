using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#windows")]
    public class SharedResourceAuditedPermissionsBehaviors {
    [XmlIgnore]
    public bool? include_groupField       { get; set; }
    public bool include_groupSpecified=>include_groupField.HasValue;
        public SharedResourceAuditedPermissionsBehaviors() {
            //this.include_groupField = true;
        }
        [XmlAttribute]
        public bool include_group {
            get {
                return this.include_groupField.Value;
            }
            set {
                this.include_groupField = value;
            }
        }
    }

}

