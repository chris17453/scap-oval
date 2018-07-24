using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#iosxe")]
    [XmlRootAttribute("interface_state", Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#iosxe", IsNullable=false)]
    public class interface_state3 : StateType {
        private EntityStateStringType nameField;
        private EntityStateBoolType ip_directed_broadcastField;
        private EntityStateBoolType proxy_arpField;
        private EntityStateBoolType shutdownField;
        private EntityStateStringType hardware_addrField;
        private EntityStateIPAddressStringType ipv4_addressField;
        private EntityStateIPAddressStringType ipv6_addressField;
        private EntityStateStringType ipv4_access_listField;
        private EntityStateStringType ipv6_access_listField;
        private EntityStateStringType crypto_mapField;
        private EntityStateStringType ipv4_urpf_commandField;
        private EntityStateStringType ipv6_urpf_commandField;
        private EntityStateStringType urpf_commandField;
        private EntityStateTrunkEncapType1 switchport_trunk_encapsulationField;
        private EntityStateSwitchportModeType1 switchport_modeField;
        private interface_stateSwitchport_native_vlan1 switchport_native_vlanField;
        private interface_stateSwitchport_access_vlan1 switchport_access_vlanField;
        private EntityStateStringType switchport_trunked_vlansField;
        private EntityStateStringType switchport_pruned_vlansField;
        private EntityStateStringType switchport_port_securityField;
        public EntityStateStringType name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        public EntityStateBoolType ip_directed_broadcast {
            get {
                return this.ip_directed_broadcastField;
            }
            set {
                this.ip_directed_broadcastField = value;
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
        public EntityStateTrunkEncapType1 switchport_trunk_encapsulation {
            get {
                return this.switchport_trunk_encapsulationField;
            }
            set {
                this.switchport_trunk_encapsulationField = value;
            }
        }
        public EntityStateSwitchportModeType1 switchport_mode {
            get {
                return this.switchport_modeField;
            }
            set {
                this.switchport_modeField = value;
            }
        }
        public interface_stateSwitchport_native_vlan1 switchport_native_vlan {
            get {
                return this.switchport_native_vlanField;
            }
            set {
                this.switchport_native_vlanField = value;
            }
        }
        public interface_stateSwitchport_access_vlan1 switchport_access_vlan {
            get {
                return this.switchport_access_vlanField;
            }
            set {
                this.switchport_access_vlanField = value;
            }
        }
        public EntityStateStringType switchport_trunked_vlans {
            get {
                return this.switchport_trunked_vlansField;
            }
            set {
                this.switchport_trunked_vlansField = value;
            }
        }
        public EntityStateStringType switchport_pruned_vlans {
            get {
                return this.switchport_pruned_vlansField;
            }
            set {
                this.switchport_pruned_vlansField = value;
            }
        }
        public EntityStateStringType switchport_port_security {
            get {
                return this.switchport_port_securityField;
            }
            set {
                this.switchport_port_securityField = value;
            }
        }
    }

}

