using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
    [XmlRootAttribute("SignedInfo", Namespace="http://www.w3.org/2000/09/xmldsig#", IsNullable=false)]
    public class SignedInfoType {
        private CanonicalizationMethodType canonicalizationMethodField;
        private SignatureMethodType signatureMethodField;
        private ReferenceType[] referenceField;
        private string idField;
        public CanonicalizationMethodType CanonicalizationMethod {
            get {
                return this.canonicalizationMethodField;
            }
            set {
                this.canonicalizationMethodField = value;
            }
        }
        public SignatureMethodType SignatureMethod {
            get {
                return this.signatureMethodField;
            }
            set {
                this.signatureMethodField = value;
            }
        }
        [XmlElementAttribute("Reference")]
        public ReferenceType[] Reference {
            get {
                return this.referenceField;
            }
            set {
                this.referenceField = value;
            }
        }
        [XmlAttribute(DataType="ID")]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    }

}

