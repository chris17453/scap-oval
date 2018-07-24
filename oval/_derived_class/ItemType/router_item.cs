using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#ios")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#ios", IsNullable=false)]
    public class router_item : ItemType {
        private EntityItemRoutingProtocolType protocolField;
        private EntityItemIntType id1Field;
        private EntityItemStringType[] networkField;
        private EntityItemStringType[] bgp_neighborField;
        private router_itemOspf_authentication_area[] ospf_authentication_areaField;
        private EntityItemStringType router_config_linesField;
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
        [XmlElementAttribute("network")]
        public EntityItemStringType[] network {
            get {
                return this.networkField;
            }
            set {
                this.networkField = value;
            }
        }
        [XmlElementAttribute("bgp_neighbor")]
        public EntityItemStringType[] bgp_neighbor {
            get {
                return this.bgp_neighborField;
            }
            set {
                this.bgp_neighborField = value;
            }
        }
        [XmlElementAttribute("ospf_authentication_area")]
        public router_itemOspf_authentication_area[] ospf_authentication_area {
            get {
                return this.ospf_authentication_areaField;
            }
            set {
                this.ospf_authentication_areaField = value;
            }
        }
        public EntityItemStringType router_config_lines {
            get {
                return this.router_config_linesField;
            }
            set {
                this.router_config_linesField = value;
            }
        }
    }

}

