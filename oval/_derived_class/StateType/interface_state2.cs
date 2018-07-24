using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#ios")]
    [XmlRootAttribute("interface_state", Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#ios", IsNullable=false)]
    public class interface_state2 : StateType {
        private EntityStateStringType nameField;
        private interface_stateIp_directed_broadcast_command ip_directed_broadcast_commandField;
        private EntityStateStringType no_ip_directed_broadcast_commandField;
        private interface_stateProxy_arp_command proxy_arp_commandField;
        private interface_stateShutdown_command shutdown_commandField;
        private EntityStateStringType hardware_addrField;
        private EntityStateIPAddressStringType ipv4_addressField;
        private EntityStateIPAddressStringType ipv6_addressField;
        private EntityStateStringType ipv4_access_listField;
        private EntityStateStringType ipv6_access_listField;
        private EntityStateStringType crypto_mapField;
        private EntityStateStringType ipv4_urpf_commandField;
        private EntityStateStringType ipv6_urpf_commandField;
        private EntityStateStringType urpf_commandField;
        private EntityStateTrunkEncapType switchport_trunk_encapsulationField;
        private EntityStateSwitchportModeType switchport_modeField;
        private interface_stateSwitchport_native_vlan switchport_native_vlanField;
        private interface_stateSwitchport_access_vlan switchport_access_vlanField;
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
        public interface_stateIp_directed_broadcast_command ip_directed_broadcast_command {
            get {
                return this.ip_directed_broadcast_commandField;
            }
            set {
                this.ip_directed_broadcast_commandField = value;
            }
        }
        public EntityStateStringType no_ip_directed_broadcast_command {
            get {
                return this.no_ip_directed_broadcast_commandField;
            }
            set {
                this.no_ip_directed_broadcast_commandField = value;
            }
        }
        public interface_stateProxy_arp_command proxy_arp_command {
            get {
                return this.proxy_arp_commandField;
            }
            set {
                this.proxy_arp_commandField = value;
            }
        }
        public interface_stateShutdown_command shutdown_command {
            get {
                return this.shutdown_commandField;
            }
            set {
                this.shutdown_commandField = value;
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
        public EntityStateTrunkEncapType switchport_trunk_encapsulation {
            get {
                return this.switchport_trunk_encapsulationField;
            }
            set {
                this.switchport_trunk_encapsulationField = value;
            }
        }
        public EntityStateSwitchportModeType switchport_mode {
            get {
                return this.switchport_modeField;
            }
            set {
                this.switchport_modeField = value;
            }
        }
        public interface_stateSwitchport_native_vlan switchport_native_vlan {
            get {
                return this.switchport_native_vlanField;
            }
            set {
                this.switchport_native_vlanField = value;
            }
        }
        public interface_stateSwitchport_access_vlan switchport_access_vlan {
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

