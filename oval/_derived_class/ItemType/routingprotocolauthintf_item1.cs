using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#iosxe")]
    [XmlRootAttribute("routingprotocolauthintf_item", Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#iosxe", IsNullable=false)]
    public class routingprotocolauthintf_item1 : ItemType {
        private EntityItemStringType interfaceField;
        private EntityItemRoutingProtocolType1 protocolField;
        private EntityItemIntType id1Field;
        private EntityItemRoutingAuthTypeStringType1 auth_typeField;
        private routingprotocolauthintf_itemOspf_area1 ospf_areaField;
        private EntityItemStringType key_chainField;
        public EntityItemStringType @interface {
            get {
                return this.interfaceField;
            }
            set {
                this.interfaceField = value;
            }
        }
        public EntityItemRoutingProtocolType1 protocol {
            get {
                return this.protocolField;
            }
            set {
                this.protocolField = value;
            }
        }
        [XmlElementAttribute("id")]
        public EntityItemIntType id1 {
            get {
                return this.id1Field;
            }
            set {
                this.id1Field = value;
            }
        }
        public EntityItemRoutingAuthTypeStringType1 auth_type {
            get {
                return this.auth_typeField;
            }
            set {
                this.auth_typeField = value;
            }
        }
        public routingprotocolauthintf_itemOspf_area1 ospf_area {
            get {
                return this.ospf_areaField;
            }
            set {
                this.ospf_areaField = value;
            }
        }
        public EntityItemStringType key_chain {
            get {
                return this.key_chainField;
            }
            set {
                this.key_chainField = value;
            }
        }
    }

}

