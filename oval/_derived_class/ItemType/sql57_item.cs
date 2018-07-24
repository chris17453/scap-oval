using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#independent")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#independent", IsNullable=false)]
    public class sql57_item : ItemType {
        private EntityItemEngineType engineField;
        private EntityItemStringType versionField;
        private EntityItemStringType connection_stringField;
        private EntityItemStringType sqlField;
        private EntityItemRecordType[] resultField;
        public EntityItemEngineType engine {
            get {
                return this.engineField;
            }
            set {
                this.engineField = value;
            }
        }
        public EntityItemStringType version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
        public EntityItemStringType connection_string {
            get {
                return this.connection_stringField;
            }
            set {
                this.connection_stringField = value;
            }
        }
        public EntityItemStringType sql {
            get {
                return this.sqlField;
            }
            set {
                this.sqlField = value;
            }
        }
        [XmlElementAttribute("result")]
        public EntityItemRecordType[] result {
            get {
                return this.resultField;
            }
            set {
                this.resultField = value;
            }
        }
    }

}

