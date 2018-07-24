using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-common-5")]
    public class GeneratorType {
        private string product_nameField;
        private string product_versionField;
        private SchemaVersionType[] schema_versionField;
        private System.DateTime timestampField;
        private System.Xml.XmlElement[] anyField;
        public string product_name {
            get {
                return this.product_nameField;
            }
            set {
                this.product_nameField = value;
            }
        }
        public string product_version {
            get {
                return this.product_versionField;
            }
            set {
                this.product_versionField = value;
            }
        }
        [XmlElementAttribute("schema_version")]
        public SchemaVersionType[] schema_version {
            get {
                return this.schema_versionField;
            }
            set {
                this.schema_versionField = value;
            }
        }
        public System.DateTime timestamp {
            get {
                return this.timestampField;
            }
            set {
                this.timestampField = value;
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

