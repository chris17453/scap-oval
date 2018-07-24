using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#ios")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#ios", IsNullable=false)]
    public class routingprotocolauthintf_item : ItemType {
        private EntityItemStringType interfaceField;
        private EntityItemRoutingProtocolType protocolField;
        private EntityItemIntType id1Field;
        private EntityItemRoutingAuthTypeStringType auth_typeField;
        private routingprotocolauthintf_itemOspf_area ospf_areaField;
        private EntityItemStringType key_chainField;
        public EntityItemStringType @interface {
            get {
                return this.interfaceField;
            }
            set {
                this.interfaceField = value;
            }
        }
        public EntityItemRoutingProtocolType protocol {
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
        public EntityItemRoutingAuthTypeStringType auth_type {
            get {
                return this.auth_typeField;
            }
            set {
                this.auth_typeField = value;
            }
        }
        public routingprotocolauthintf_itemOspf_area ospf_area {
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

