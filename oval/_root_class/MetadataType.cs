using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5")]
    public class MetadataType {
        private string titleField;
        private AffectedType[] affectedField;
        private ReferenceType1[] referenceField;
        private string descriptionField;
        private System.Xml.XmlElement[] anyField;
        public string title {
            get {
                return this.titleField;
            }
            set {
                this.titleField = value;
            }
        }
        [XmlElementAttribute("affected")]
        public AffectedType[] affected {
            get {
                return this.affectedField;
            }
            set {
                this.affectedField = value;
            }
        }
        [XmlElementAttribute("reference")]
        public ReferenceType1[] reference {
            get {
                return this.referenceField;
            }
            set {
                this.referenceField = value;
            }
        }
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        [XmlAnyElementAttribute]
        public System.Xml.XmlElement[] Any {
            get {
                return this.anyField;
            }
            set {
                this.anyField = value;
            }
        }
    }

}

