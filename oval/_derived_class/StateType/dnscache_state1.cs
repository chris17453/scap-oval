using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#unix")]
    [XmlRootAttribute("dnscache_state", Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#unix", IsNullable=false)]
    public class dnscache_state1 : StateType {
        private EntityStateStringType domain_nameField;
        private EntityStateIntType ttlField;
        private EntityStateIPAddressStringType ip_addressField;
        public EntityStateStringType domain_name {
            get {
                return this.domain_nameField;
            }
            set {
                this.domain_nameField = value;
            }
        }
        public EntityStateIntType ttl {
            get {
                return this.ttlField;
            }
            set {
                this.ttlField = value;
            }
        }
        public EntityStateIPAddressStringType ip_address {
            get {
                return this.ip_addressField;
            }
            set {
                this.ip_addressField = value;
            }
        }
    }

}

