using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#unix")]
    [XmlRootAttribute("interface_state", Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#unix", IsNullable=false)]
    public class interface_state1 : StateType {
        private EntityStateStringType nameField;
        private EntityStateInterfaceType typeField;
        private EntityStateStringType hardware_addrField;
        private EntityStateIPAddressStringType inet_addrField;
        private EntityStateIPAddressStringType broadcast_addrField;
        private EntityStateIPAddressStringType netmaskField;
        private EntityStateStringType flagField;
        public EntityStateStringType name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        public EntityStateInterfaceType type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
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
        public EntityStateIPAddressStringType inet_addr {
            get {
                return this.inet_addrField;
            }
            set {
                this.inet_addrField = value;
            }
        }
        public EntityStateIPAddressStringType broadcast_addr {
            get {
                return this.broadcast_addrField;
            }
            set {
                this.broadcast_addrField = value;
            }
        }
        public EntityStateIPAddressStringType netmask {
            get {
                return this.netmaskField;
            }
            set {
                this.netmaskField = value;
            }
        }
        public EntityStateStringType flag {
            get {
                return this.flagField;
            }
            set {
                this.flagField = value;
            }
        }
    }

}

