using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#iosxe")]
    [XmlRootAttribute("router_state", Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#iosxe", IsNullable=false)]
    public class router_state1 : StateType {
        private EntityStateRoutingProtocolType1 protocolField;
        private EntityStateIntType id1Field;
        private EntityStateStringType networkField;
        private EntityStateStringType bgp_neighborField;
        private router_stateOspf_authentication_area1 ospf_authentication_areaField;
        private EntityStateStringType router_config_linesField;
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
        public EntityStateStringType network {
            get {
                return this.networkField;
            }
            set {
                this.networkField = value;
            }
        }
        public EntityStateStringType bgp_neighbor {
            get {
                return this.bgp_neighborField;
            }
            set {
                this.bgp_neighborField = value;
            }
        }
        public router_stateOspf_authentication_area1 ospf_authentication_area {
            get {
                return this.ospf_authentication_areaField;
            }
            set {
                this.ospf_authentication_areaField = value;
            }
        }
        public EntityStateStringType router_config_lines {
            get {
                return this.router_config_linesField;
            }
            set {
                this.router_config_linesField = value;
            }
        }
    }

}

