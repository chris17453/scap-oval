using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5")]
    public class AffectedType {
        private string[] platformField;
        private string[] productField;
    [XmlIgnore]
    public FamilyEnumeration? familyField       { get; set; }
    public bool familySpecified=>familyField.HasValue;
        [XmlElementAttribute("platform")]
        public string[] platform {
            get {
                return this.platformField;
            }
            set {
                this.platformField = value;
            }
        }
        [XmlElementAttribute("product")]
        public string[] product {
            get {
                return this.productField;
            }
            set {
                this.productField = value;
            }
        }
        [XmlAttribute]
        public FamilyEnumeration family {
            get {
                return this.familyField.Value;
            }
            set {
                this.familyField = value;
            }
        }
    }

}

