using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5")]
    public class EntityStateFieldType {
        private string nameField;
        private string datatypeField;
    [XmlIgnore]
    public OperationEnumeration? operationField       { get; set; }
    public bool operationSpecified=>operationField.HasValue;
    [XmlIgnore]
    public bool? maskField       { get; set; }
    public bool maskSpecified=>maskField.HasValue;
        private string var_refField;
    [XmlIgnore]
    public CheckEnumeration? var_checkField       { get; set; }
    public bool var_checkSpecified=>var_checkField.HasValue;
    [XmlIgnore]
    public bool? var_checkFieldSpecified       { get; set; }
    public bool var_checkSpecifiedSpecified=>var_checkFieldSpecified.HasValue;
    [XmlIgnore]
    public CheckEnumeration? entity_checkField       { get; set; }
    public bool entity_checkSpecified=>entity_checkField.HasValue;
        private string valueField;
        public EntityStateFieldType() {
            //this.datatypeField = "string";
            //this.operationField = OperationEnumeration.equals;
            //this.maskField = false;
            //this.entity_checkField = CheckEnumeration.all;
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
        public OperationEnumeration operation {
            get {
                return this.operationField.Value;
            }
            set {
                this.operationField = value;
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
        public string var_ref {
            get {
                return this.var_refField;
            }
            set {
                this.var_refField = value;
            }
        }
        [XmlAttribute]
        public CheckEnumeration var_check {
            get {
                return this.var_checkField.Value;
            }
            set {
                this.var_checkField = value;
            }
        }
    
        [XmlAttribute]
        public CheckEnumeration entity_check {
            get {
                return this.entity_checkField.Value;
            }
            set {
                this.entity_checkField = value;
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

