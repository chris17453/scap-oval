using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(TypeName="CriteriaType", Namespace="http://oval.mitre.org/XMLSchema/oval-results-5")]
    public class CriteriaType1 {
        private object[] itemsField;
    [XmlIgnore]
    public bool? applicability_checkField       { get; set; }
    public bool applicability_checkSpecified=>applicability_checkField.HasValue;
    [XmlIgnore]
    public bool? applicability_checkFieldSpecified       { get; set; }
    public bool applicability_checkSpecifiedSpecified=>applicability_checkFieldSpecified.HasValue;
    [XmlIgnore]
    public OperatorEnumeration? operatorField       { get; set; }
    public bool operatorSpecified=>operatorField.HasValue;
    [XmlIgnore]
    public bool? negateField       { get; set; }
    public bool negateSpecified=>negateField.HasValue;
    [XmlIgnore]
    public ResultEnumeration? resultField       { get; set; }
    public bool resultSpecified=>resultField.HasValue;
        public CriteriaType1() {
            //this.negateField = false;
        }
        [XmlElementAttribute("criteria", typeof(CriteriaType1))]
        [XmlElementAttribute("criterion", typeof(CriterionType1))]
        [XmlElementAttribute("extend_definition", typeof(ExtendDefinitionType1))]
        public object[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
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
        public OperatorEnumeration @operator {
            get {
                return this.operatorField.Value;
            }
            set {
                this.operatorField = value;
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

