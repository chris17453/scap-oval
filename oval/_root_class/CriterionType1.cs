using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(TypeName="CriterionType", Namespace="http://oval.mitre.org/XMLSchema/oval-results-5")]
    public class CriterionType1 {
    [XmlIgnore]
    public bool? applicability_checkField       { get; set; }
    public bool applicability_checkSpecified=>applicability_checkField.HasValue;
    [XmlIgnore]
    public bool? applicability_checkFieldSpecified       { get; set; }
    public bool applicability_checkSpecifiedSpecified=>applicability_checkFieldSpecified.HasValue;
        private string test_refField;
        private string versionField;
        private string variable_instanceField;
    [XmlIgnore]
    public bool? negateField       { get; set; }
    public bool negateSpecified=>negateField.HasValue;
    [XmlIgnore]
    public ResultEnumeration? resultField       { get; set; }
    public bool resultSpecified=>resultField.HasValue;
        public CriterionType1() {
            //this.variable_instanceField = "1";
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
        public string test_ref {
            get {
                return this.test_refField;
            }
            set {
                this.test_refField = value;
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
        public bool negate {
            get {
                return this.negateField.Value;
            }
            set {
                this.negateField = value;
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

