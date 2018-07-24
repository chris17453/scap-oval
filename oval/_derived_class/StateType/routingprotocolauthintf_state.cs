using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#ios")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#ios", IsNullable=false)]
    public class routingprotocolauthintf_state : StateType {
        private EntityStateStringType interfaceField;
        private EntityStateRoutingProtocolType protocolField;
        private EntityStateIntType id1Field;
        private EntityStateRoutingAuthTypeStringType auth_typeField;
        private routingprotocolauthintf_stateOspf_area ospf_areaField;
        private EntityStateStringType key_chainField;
        public EntityStateStringType @interface {
            get {
                return this.interfaceField;
            }
            set {
                this.interfaceField = value;
            }
        }
        public EntityStateRoutingProtocolType protocol {
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
        public EntityStateRoutingAuthTypeStringType auth_type {
            get {
                return this.auth_typeField;
            }
            set {
                this.auth_typeField = value;
            }
        }
        public routingprotocolauthintf_stateOspf_area ospf_area {
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

