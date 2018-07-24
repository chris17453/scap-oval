using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5")]
    [XmlRootAttribute("definition", Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5", IsNullable=false)]
    public class DefinitionType {
        private SignatureType signatureField;
        private MetadataType metadataField;
        private string[] notesField;
        private CriteriaType criteriaField;
        private string idField;
        private string versionField;
    [XmlIgnore]
    public ClassEnumeration? classField       { get; set; }
    public bool classSpecified=>classField.HasValue;
    [XmlIgnore]
    public bool? deprecatedField       { get; set; }
    public bool deprecatedSpecified=>deprecatedField.HasValue;
        public DefinitionType() {
            //this.deprecatedField = false;
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
        public MetadataType metadata {
            get {
                return this.metadataField;
            }
            set {
                this.metadataField = value;
            }
        }
        [XmlArrayAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-common-5")]
        [XmlArrayItemAttribute("note", IsNullable=false)]
        public string[] notes {
            get {
                return this.notesField;
            }
            set {
                this.notesField = value;
            }
        }
        public CriteriaType criteria {
            get {
                return this.criteriaField;
            }
            set {
                this.criteriaField = value;
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
        public ClassEnumeration @class {
            get {
                return this.classField.Value;
            }
            set {
                this.classField = value;
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

