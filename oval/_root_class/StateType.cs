using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5")]
    [XmlRootAttribute("state", Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5", IsNullable=false)]
    public class StateType {
        private SignatureType signatureField;
        private string[] notesField;
        private string idField;
        private string versionField;
    [XmlIgnore]
    public OperatorEnumeration? operatorField       { get; set; }
    public bool operatorSpecified=>operatorField.HasValue;
        private string commentField;
    [XmlIgnore]
    public bool? deprecatedField       { get; set; }
    public bool deprecatedSpecified=>deprecatedField.HasValue;
        public StateType() {
            /*this.operatorField = OperatorEnumeration.AND;
            this.deprecatedField = false;*/
        }
        [XmlElementAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
        public SignatureType Signature {
            get {
                return this.signatureField;
            }
            set {
                this.signatureField = value;
            }
        }
        [XmlArrayItemAttribute("note", IsNullable=false)]
        public string[] notes {
            get {
                return this.notesField;
            }
            set {
                this.notesField = value;
            }
        }
        [XmlAttribute]
        public string id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
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
        public string comment {
            get {
                return this.commentField;
            }
            set {
                this.commentField = value;
            }
        }
        [XmlAttribute]
        public bool deprecated {
            get {
                return this.deprecatedField.Value;
            }
            set {
                this.deprecatedField = value;
            }
        }
    }

}

