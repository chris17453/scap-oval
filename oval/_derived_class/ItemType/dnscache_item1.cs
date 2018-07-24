using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#unix")]
    [XmlRootAttribute("dnscache_item", Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#unix", IsNullable=false)]
    public class dnscache_item1 : ItemType {
        private EntityItemStringType domain_nameField;
        private EntityItemIntType ttlField;
        private EntityItemIPAddressStringType[] ip_addressField;
        public EntityItemStringType domain_name {
            get {
                return this.domain_nameField;
            }
            set {
                this.domain_nameField = value;
            }
        }
        public EntityItemIntType ttl {
            get {
                return this.ttlField;
            }
            set {
                this.ttlField = value;
            }
        }
        [XmlElementAttribute("ip_address")]
        public EntityItemIPAddressStringType[] ip_address {
            get {
                return this.ip_addressField;
            }
            set {
                this.ip_addressField = value;
            }
        }
    }

}

