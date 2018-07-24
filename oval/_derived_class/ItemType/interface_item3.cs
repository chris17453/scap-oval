using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#iosxe")]
    [XmlRootAttribute("interface_item", Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#iosxe", IsNullable=false)]
    public class interface_item3 : ItemType {
        private EntityItemStringType nameField;
        private EntityItemBoolType ip_directed_broadcastField;
        private EntityItemBoolType proxy_arpField;
        private EntityItemBoolType shutdownField;
        private EntityItemStringType hardware_addrField;
        private EntityItemIPAddressStringType ipv4_addressField;
        private EntityItemIPAddressStringType[] ipv6_addressField;
        private EntityItemStringType[] ipv4_access_listField;
        private EntityItemStringType[] ipv6_access_listField;
        private EntityItemStringType crypto_mapField;
        private EntityItemStringType ipv4_urpf_commandField;
        private EntityItemStringType ipv6_urpf_commandField;
        private EntityItemStringType urpf_commandField;
        private EntityItemTrunkEncapType1 switchport_trunk_encapsulationField;
        private EntityItemSwitchportModeType1 switchport_modeField;
        private interface_itemSwitchport_native_vlan1 switchport_native_vlanField;
        private interface_itemSwitchport_access_vlan1 switchport_access_vlanField;
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
        public EntityItemBoolType ip_directed_broadcast {
            get {
                return this.ip_directed_broadcastField;
            }
            set {
                this.ip_directed_broadcastField = value;
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
        public EntityItemTrunkEncapType1 switchport_trunk_encapsulation {
            get {
                return this.switchport_trunk_encapsulationField;
            }
            set {
                this.switchport_trunk_encapsulationField = value;
            }
        }
        public EntityItemSwitchportModeType1 switchport_mode {
            get {
                return this.switchport_modeField;
            }
            set {
                this.switchport_modeField = value;
            }
        }
        public interface_itemSwitchport_native_vlan1 switchport_native_vlan {
            get {
                return this.switchport_native_vlanField;
            }
            set {
                this.switchport_native_vlanField = value;
            }
        }
        public interface_itemSwitchport_access_vlan1 switchport_access_vlan {
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

