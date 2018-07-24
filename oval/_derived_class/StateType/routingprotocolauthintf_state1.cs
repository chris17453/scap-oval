using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#iosxe")]
    [XmlRootAttribute("routingprotocolauthintf_state", Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#iosxe", IsNullable=false)]
    public class routingprotocolauthintf_state1 : StateType {
        private EntityStateStringType interfaceField;
        private EntityStateRoutingProtocolType1 protocolField;
        private EntityStateIntType id1Field;
        private EntityStateRoutingAuthTypeStringType1 auth_typeField;
        private routingprotocolauthintf_stateOspf_area1 ospf_areaField;
        private EntityStateStringType key_chainField;
        public EntityStateStringType @interface {
            get {
                return this.interfaceField;
            }
            set {
                this.interfaceField = value;
            }
        }
        public EntityStateRoutingProtocolType1 protocol {
            get {
                return this.protocolField;
            }
            set {
                this.protocolField = value;
            }
        }
        [XmlElementAttribute("id")]
        public EntityStateIntType id1 {
            get {
                return this.id1Field;
            }
            set {
                this.id1Field = value;
            }
        }
        public EntityStateRoutingAuthTypeStringType1 auth_type {
            get {
                return this.auth_typeField;
            }
            set {
                this.auth_typeField = value;
            }
        }
        public routingprotocolauthintf_stateOspf_area1 ospf_area {
            get {
                return this.ospf_areaField;
            }
            set {
                this.ospf_areaField = value;
            }
        }
        public EntityStateStringType key_chain {
            get {
                return this.key_chainField;
            }
            set {
                this.key_chainField = value;
            }
        }
    }

}

