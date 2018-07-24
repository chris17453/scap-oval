using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5")]
    public class CriteriaType {
        private object[] itemsField;
        private bool applicability_checkField;
        private bool applicability_checkFieldSpecified;
        private OperatorEnumeration operatorField;
        private bool negateField;
        private string commentField;
        public CriteriaType() {
            //this.operatorField = OperatorEnumeration.AND;
            //this.negateField = false;
        }
        [XmlElementAttribute("criteria", typeof(CriteriaType))]
        [XmlElementAttribute("criterion", typeof(CriterionType))]
        [XmlElementAttribute("extend_definition", typeof(ExtendDefinitionType))]
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
                return this.applicability_checkField;
            }
            set {
                this.applicability_checkField = value;
            }
        }

        [XmlAttribute]
        public OperatorEnumeration @operator {
            get {
                return this.operatorField;
            }
            set {
                this.operatorField = value;
            }
        }
        [XmlAttribute]
        public bool negate {
            get {
                return this.negateField;
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
