using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5")]
    [XmlRootAttribute("test", Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5", IsNullable=false)]
    public class TestType {
        [XmlIgnore]
        public ExistenceEnumeration? check_existenceField       { get; set; }
        public bool check_existenceSpecified=>check_existenceField.HasValue;
        [XmlIgnore]
        public CheckEnumeration? checkField       { get; set; }
        public bool checkSpecified=>checkField.HasValue;
        [XmlIgnore]
        public OperatorEnumeration? state_operatorField       { get; set; }
        public bool state_operatorSpecified=>state_operatorField.HasValue;
        private string commentField;
        [XmlIgnore]
        public bool? deprecatedField       { get; set; }
        public bool deprecatedSpecified=>deprecatedField.HasValue;
        [XmlIgnore]
        public string[] notesField;
        public bool noteSpecified { get { if(null==notesField) return false; return true; } }
        [XmlIgnore]
        public SignatureType signatureField;
        public bool signatureSpecified { get { if(null==signatureField) return false; return true; } }

        private string idField;
        private string versionField;


        public TestType() {
            /*this.check_existenceField = ExistenceEnumeration.at_least_one_exists;
            this.state_operatorField = OperatorEnumeration.AND;
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
        //[XmlArrayAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-common-5")]
        [XmlArrayItemAttribute("note")]
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
        public ExistenceEnumeration check_existence {
            get {
                return this.check_existenceField.Value;
            }
            set {
                this.check_existenceField = value;
            }
        }
        [XmlAttribute]
        public CheckEnumeration check {
            get {
                return this.checkField.Value;
            }
            set {
                this.checkField = value;
            }
        }
        [XmlAttribute]
        public OperatorEnumeration state_operator {
            get {
                return this.state_operatorField.Value;
            }
            set {
                this.state_operatorField = value;
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

