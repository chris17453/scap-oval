using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5")]
    public class RestrictionType {
    [XmlIgnore]
    public OperationEnumeration? operationField       { get; set; }
    public bool operationSpecified=>operationField.HasValue;
        private string valueField;
        [XmlAttribute]
        public OperationEnumeration operation {
            get {
                return this.operationField.Value;
            }
            set {
                this.operationField = value;
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

