using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(TypeName="ReferenceType", Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5")]
    public class ReferenceType1 {
        private string sourceField;
        private string ref_idField;
        private string ref_urlField;
        [XmlAttribute]
        public string source {
            get {
                return this.sourceField;
            }
            set {
                this.sourceField = value;
            }
        }
        [XmlAttribute]
        public string ref_id {
            get {
                return this.ref_idField;
            }
            set {
                this.ref_idField = value;
            }
        }
        [XmlAttribute(DataType="anyURI")]
        public string ref_url {
            get {
                return this.ref_urlField;
            }
            set {
                this.ref_urlField = value;
            }
        }
    }

}

