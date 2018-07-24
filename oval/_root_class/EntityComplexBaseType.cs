using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [XmlIncludeAttribute(typeof(EntityStateComplexBaseType))]
    [XmlIncludeAttribute(typeof(EntityStateRecordType))]
    [XmlIncludeAttribute(typeof(EntityObjectRecordType))]
    [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5")]
    public abstract class EntityComplexBaseType {
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
        public EntityComplexBaseType() {
            //this.datatypeField = "string";
            //this.operationField = OperationEnumeration.equals;
            //this.maskField = false;
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
       
    }

}

