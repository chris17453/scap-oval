using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#asa")]
    [XmlRootAttribute("interface_item", Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#asa", IsNullable=false)]
    public class interface_item4 : ItemType {
        private EntityItemStringType nameField;
        private EntityItemBoolType proxy_arpField;
        private EntityItemBoolType shutdownField;
        private EntityItemStringType hardware_addrField;
        private EntityItemIPAddressStringType ipv4_addressField;
        private EntityItemIPAddressStringType[] ipv6_addressField;
        private EntityItemStringType[] ipv4_access_listField;
        private EntityItemStringType[] ipv6_access_listField;
        private EntityItemStringType[] ipv4_v6_access_listField;
        private EntityItemStringType crypto_mapField;
        private EntityItemStringType ipv4_urpf_commandField;
        private EntityItemStringType ipv6_urpf_commandField;
        private EntityItemStringType urpf_commandField;
        public EntityItemStringType name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        public EntityItemBoolType proxy_arp {
            get {
                return this.proxy_arpField;
            }
            set {
                this.proxy_arpField = value;
            }
        }
        public EntityItemBoolType shutdown {
            get {
                return this.shutdownField;
            }
            set {
                this.shutdownField = value;
            }
        }
        public EntityItemStringType hardware_addr {
            get {
                return this.hardware_addrField;
            }
            set {
                this.hardware_addrField = value;
            }
        }
        public EntityItemIPAddressStringType ipv4_address {
            get {
                return this.ipv4_addressField;
            }
            set {
                this.ipv4_addressField = value;
            }
        }
        [XmlElementAttribute("ipv6_address")]
        public EntityItemIPAddressStringType[] ipv6_address {
            get {
                return this.ipv6_addressField;
            }
            set {
                this.ipv6_addressField = value;
            }
        }
        [XmlElementAttribute("ipv4_access_list")]
        public EntityItemStringType[] ipv4_access_list {
            get {
                return this.ipv4_access_listField;
            }
            set {
                this.ipv4_access_listField = value;
            }
        }
        [XmlElementAttribute("ipv6_access_list")]
        public EntityItemStringType[] ipv6_access_list {
            get {
                return this.ipv6_access_listField;
            }
            set {
                this.ipv6_access_listField = value;
            }
        }
        [XmlElementAttribute("ipv4_v6_access_list")]
        public EntityItemStringType[] ipv4_v6_access_list {
            get {
                return this.ipv4_v6_access_listField;
            }
            set {
                this.ipv4_v6_access_listField = value;
            }
        }
        public EntityItemStringType crypto_map {
            get {
                return this.crypto_mapField;
            }
            set {
                this.crypto_mapField = value;
            }
        }
        public EntityItemStringType ipv4_urpf_command {
            get {
                return this.ipv4_urpf_commandField;
            }
            set {
                this.ipv4_urpf_commandField = value;
            }
        }
        public EntityItemStringType ipv6_urpf_command {
            get {
                return this.ipv6_urpf_commandField;
            }
            set {
                this.ipv6_urpf_commandField = value;
            }
        }
        public EntityItemStringType urpf_command {
            get {
                return this.urpf_commandField;
            }
            set {
                this.urpf_commandField = value;
            }
        }
    }

}

