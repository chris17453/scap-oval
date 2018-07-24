using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#macos")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#macos", IsNullable=false)]
    public class corestorage_state : StateType {
        private EntityStateStringType uuidField;
        private EntityStateStringType xpathField;
        private EntityStateAnySimpleType value_ofField;
        public EntityStateStringType uuid {
            get {
                return this.uuidField;
            }
            set {
                this.uuidField = value;
            }
        }
        public EntityStateStringType xpath {
            get {
                return this.xpathField;
            }
            set {
                this.xpathField = value;
            }
        }
        public EntityStateAnySimpleType value_of {
            get {
                return this.value_ofField;
            }
            set {
                this.value_ofField = value;
            }
        }
    }

}

