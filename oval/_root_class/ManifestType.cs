using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
    [XmlRootAttribute("Manifest", Namespace="http://www.w3.org/2000/09/xmldsig#", IsNullable=false)]
    public class ManifestType {
        private ReferenceType[] referenceField;
        private string idField;
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

