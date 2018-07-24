using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#netconf")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#netconf", IsNullable=false)]
    public class config_state : StateType {
        private EntityStateStringType xpathField;
        private EntityStateAnySimpleType value_ofField;
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

