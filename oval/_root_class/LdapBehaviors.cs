using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#independent")]
    public class LdapBehaviors {
        private LdapBehaviorsScope scopeField;
        public LdapBehaviors() {
            //this.scopeField = LdapBehaviorsScope.BASE;
        }
        [XmlAttribute]
        public LdapBehaviorsScope scope {
            get {
                return this.scopeField;
            }
            set {
                this.scopeField = value;
            }
        }
    }

}

