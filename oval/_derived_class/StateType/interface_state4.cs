using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#asa")]
    [XmlRootAttribute("interface_state", Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#asa", IsNullable=false)]
    public class interface_state4 : StateType {
        private EntityStateStringType nameField;
        private EntityStateBoolType proxy_arpField;
        private EntityStateBoolType shutdownField;
        private EntityStateStringType hardware_addrField;
        private EntityStateIPAddressStringType ipv4_addressField;
        private EntityStateIPAddressStringType ipv6_addressField;
        private EntityStateStringType ipv4_access_listField;
        private EntityStateStringType ipv6_access_listField;
        private EntityStateStringType ipv4_v6_access_listField;
        private EntityStateStringType crypto_mapField;
        private EntityStateStringType ipv4_urpf_commandField;
        private EntityStateStringType ipv6_urpf_commandField;
        private EntityStateStringType urpf_commandField;
        public EntityStateStringType name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        public EntityStateBoolType proxy_arp {
            get {
                return this.proxy_arpField;
            }
            set {
                this.proxy_arpField = value;
            }
        }
        public EntityStateBoolType shutdown {
            get {
                return this.shutdownField;
            }
            set {
                this.shutdownField = value;
            }
        }
        public EntityStateStringType hardware_addr {
            get {
                return this.hardware_addrField;
            }
            set {
                this.hardware_addrField = value;
            }
        }
        public EntityStateIPAddressStringType ipv4_address {
            get {
                return this.ipv4_addressField;
            }
            set {
                this.ipv4_addressField = value;
            }
        }
        public EntityStateIPAddressStringType ipv6_address {
            get {
                return this.ipv6_addressField;
            }
            set {
                this.ipv6_addressField = value;
            }
        }
        public EntityStateStringType ipv4_access_list {
            get {
                return this.ipv4_access_listField;
            }
            set {
                this.ipv4_access_listField = value;
            }
        }
        public EntityStateStringType ipv6_access_list {
            get {
                return this.ipv6_access_listField;
            }
            set {
                this.ipv6_access_listField = value;
            }
        }
        public EntityStateStringType ipv4_v6_access_list {
            get {
                return this.ipv4_v6_access_listField;
            }
            set {
                this.ipv4_v6_access_listField = value;
            }
        }
        public EntityStateStringType crypto_map {
            get {
                return this.crypto_mapField;
            }
            set {
                this.crypto_mapField = value;
            }
        }
        public EntityStateStringType ipv4_urpf_command {
            get {
                return this.ipv4_urpf_commandField;
            }
            set {
                this.ipv4_urpf_commandField = value;
            }
        }
        public EntityStateStringType ipv6_urpf_command {
            get {
                return this.ipv6_urpf_commandField;
            }
            set {
                this.ipv6_urpf_commandField = value;
            }
        }
        public EntityStateStringType urpf_command {
            get {
                return this.urpf_commandField;
            }
            set {
                this.urpf_commandField = value;
            }
        }
    }

}

