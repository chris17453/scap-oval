using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#windows")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#windows", IsNullable=false)]
    public class interface_item : ItemType {
        private EntityItemStringType nameField;
        private EntityItemIntType indexField;
        private EntityItemInterfaceTypeType typeField;
        private EntityItemStringType hardware_addrField;
        private EntityItemIPAddressStringType inet_addrField;
        private EntityItemIPAddressStringType broadcast_addrField;
        private EntityItemIPAddressStringType netmaskField;
        private EntityItemAddrTypeType[] addr_typeField;
        public EntityItemStringType name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        public EntityItemIntType index {
            get {
                return this.indexField;
            }
            set {
                this.indexField = value;
            }
        }
        public EntityItemInterfaceTypeType type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
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
        public EntityItemIPAddressStringType inet_addr {
            get {
                return this.inet_addrField;
            }
            set {
                this.inet_addrField = value;
            }
        }
        public EntityItemIPAddressStringType broadcast_addr {
            get {
                return this.broadcast_addrField;
            }
            set {
                this.broadcast_addrField = value;
            }
        }
        public EntityItemIPAddressStringType netmask {
            get {
                return this.netmaskField;
            }
            set {
                this.netmaskField = value;
            }
        }
        [XmlElementAttribute("addr_type")]
        public EntityItemAddrTypeType[] addr_type {
            get {
                return this.addr_typeField;
            }
            set {
                this.addr_typeField = value;
            }
        }
    }

}

