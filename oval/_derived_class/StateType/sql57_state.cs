using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#independent")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#independent", IsNullable=false)]
    public class sql57_state : StateType {
        private EntityStateEngineType engineField;
        private EntityStateStringType version1Field;
        private EntityStateStringType connection_stringField;
        private EntityStateStringType sqlField;
        private EntityStateRecordType resultField;
        public EntityStateEngineType engine {
            get {
                return this.engineField;
            }
            set {
                this.engineField = value;
            }
        }
        [XmlElementAttribute("version")]
        public EntityStateStringType version1 {
            get {
                return this.version1Field;
            }
            set {
                this.version1Field = value;
            }
        }
        public EntityStateStringType connection_string {
            get {
                return this.connection_stringField;
            }
            set {
                this.connection_stringField = value;
            }
        }
        public EntityStateStringType sql {
            get {
                return this.sqlField;
            }
            set {
                this.sqlField = value;
            }
        }
        public EntityStateRecordType result {
            get {
                return this.resultField;
            }
            set {
                this.resultField = value;
            }
        }
    }

}

