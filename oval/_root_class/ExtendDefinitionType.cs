using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5")]
    public class ExtendDefinitionType {
    [XmlIgnore]
    public bool? applicability_checkField       { get; set; }
    public bool applicability_checkSpecified=>applicability_checkField.HasValue;
    [XmlIgnore]
    public bool? applicability_checkFieldSpecified       { get; set; }
    public bool applicability_checkSpecifiedSpecified=>applicability_checkFieldSpecified.HasValue;
        private string definition_refField;
    [XmlIgnore]
    public bool? negateField       { get; set; }
    public bool negateSpecified=>negateField.HasValue;
        private string commentField;
        public ExtendDefinitionType() {
            //this.negateField = false;
        }
        [XmlAttribute]
        public bool applicability_check {
            get {
                return this.applicability_checkField.Value;
            }
            set {
                this.applicability_checkField = value;
            }
        }
      
        [XmlAttribute]
        public string definition_ref {
            get {
                return this.definition_refField;
            }
            set {
                this.definition_refField = value;
            }
        }
        [XmlAttribute]
        public bool negate {
            get {
                return this.negateField.Value;
            }
            set {
                this.negateField = value;
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
    }

}

