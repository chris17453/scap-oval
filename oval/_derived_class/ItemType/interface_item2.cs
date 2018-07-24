using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#ios")]
    [XmlRootAttribute("interface_item", Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#ios", IsNullable=false)]
    public class interface_item2 : ItemType {
        private EntityItemStringType nameField;
        private interface_itemIp_directed_broadcast_command ip_directed_broadcast_commandField;
        private EntityItemStringType no_ip_directed_broadcast_commandField;
        private interface_itemProxy_arp_command proxy_arp_commandField;
        private interface_itemShutdown_command shutdown_commandField;
        private EntityItemStringType hardware_addrField;
        private EntityItemIPAddressStringType ipv4_addressField;
        private EntityItemIPAddressStringType[] ipv6_addressField;
        private EntityItemStringType[] ipv4_access_listField;
        private EntityItemStringType[] ipv6_access_listField;
        private EntityItemStringType crypto_mapField;
        private EntityItemStringType ipv4_urpf_commandField;
        private EntityItemStringType ipv6_urpf_commandField;
        private EntityItemStringType urpf_commandField;
        private EntityItemTrunkEncapType switchport_trunk_encapsulationField;
        private EntityItemSwitchportModeType switchport_modeField;
        private interface_itemSwitchport_native_vlan switchport_native_vlanField;
        private interface_itemSwitchport_access_vlan switchport_access_vlanField;
        private EntityItemStringType switchport_trunked_vlansField;
        private EntityItemStringType switchport_pruned_vlansField;
        private EntityItemStringType switchport_port_securityField;
        public EntityItemStringType name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        public interface_itemIp_directed_broadcast_command ip_directed_broadcast_command {
            get {
                return this.ip_directed_broadcast_commandField;
            }
            set {
                this.ip_directed_broadcast_commandField = value;
            }
        }
        public EntityItemStringType no_ip_directed_broadcast_command {
            get {
                return this.no_ip_directed_broadcast_commandField;
            }
            set {
                this.no_ip_directed_broadcast_commandField = value;
            }
        }
        public interface_itemProxy_arp_command proxy_arp_command {
            get {
                return this.proxy_arp_commandField;
            }
            set {
                this.proxy_arp_commandField = value;
            }
        }
        public interface_itemShutdown_command shutdown_command {
            get {
                return this.shutdown_commandField;
            }
            set {
                this.shutdown_commandField = value;
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
        public EntityItemTrunkEncapType switchport_trunk_encapsulation {
            get {
                return this.switchport_trunk_encapsulationField;
            }
            set {
                this.switchport_trunk_encapsulationField = value;
            }
        }
        public EntityItemSwitchportModeType switchport_mode {
            get {
                return this.switchport_modeField;
            }
            set {
                this.switchport_modeField = value;
            }
        }
        public interface_itemSwitchport_native_vlan switchport_native_vlan {
            get {
                return this.switchport_native_vlanField;
            }
            set {
                this.switchport_native_vlanField = value;
            }
        }
        public interface_itemSwitchport_access_vlan switchport_access_vlan {
            get {
                return this.switchport_access_vlanField;
            }
            set {
                this.switchport_access_vlanField = value;
            }
        }
        public EntityItemStringType switchport_trunked_vlans {
            get {
                return this.switchport_trunked_vlansField;
            }
            set {
                this.switchport_trunked_vlansField = value;
            }
        }
        public EntityItemStringType switchport_pruned_vlans {
            get {
                return this.switchport_pruned_vlansField;
            }
            set {
                this.switchport_pruned_vlansField = value;
            }
        }
        public EntityItemStringType switchport_port_security {
            get {
                return this.switchport_port_securityField;
            }
            set {
                this.switchport_port_securityField = value;
            }
        }
    }

}

