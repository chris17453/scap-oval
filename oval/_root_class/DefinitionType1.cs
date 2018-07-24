using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(TypeName="DefinitionType", Namespace="http://oval.mitre.org/XMLSchema/oval-results-5")]
    public class DefinitionType1 {
        private MessageType[] messageField;
        private CriteriaType1 criteriaField;
        private string definition_idField;
        private string versionField;
        private string variable_instanceField;
    [XmlIgnore]
    public ClassEnumeration? classField       { get; set; }
    public bool classSpecified=>classField.HasValue;
    [XmlIgnore]
    public bool? classFieldSpecified       { get; set; }
    public bool classSpecifiedSpecified=>classFieldSpecified.HasValue;
    [XmlIgnore]
    public ResultEnumeration? resultField       { get; set; }
    public bool resultSpecified=>resultField.HasValue;
        public DefinitionType1() {
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
        public CriteriaType1 criteria {
            get {
                return this.criteriaField;
            }
            set {
                this.criteriaField = value;
            }
        }
        [XmlAttribute]
        public string definition_id {
            get {
                return this.definition_idField;
            }
            set {
                this.definition_idField = value;
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
        public ClassEnumeration @class {
            get {
                return this.classField.Value;
            }
            set {
                this.classField = value;
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

