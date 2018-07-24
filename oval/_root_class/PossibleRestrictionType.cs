using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5")]
    public class PossibleRestrictionType {
        private RestrictionType[] itemsField;
    [XmlIgnore]
    public OperatorEnumeration? operatorField       { get; set; }
    public bool operatorSpecified=>operatorField.HasValue;
        private string hintField;
        public PossibleRestrictionType() {
            this.operatorField = OperatorEnumeration.AND;
        }
        [XmlElementAttribute("restriction")]
        public RestrictionType[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
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
        public string hint {
            get {
                return this.hintField;
            }
            set {
                this.hintField = value;
            }
        }
    }

}

