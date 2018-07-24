using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#unix")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#unix", IsNullable=false)]
    public class routingtable_item : ItemType {
        private EntityItemIPAddressType destinationField;
        private EntityItemIPAddressType gatewayField;
        private EntityItemRoutingTableFlagsType[] flagsField;
        private EntityItemStringType interface_nameField;
        public EntityItemIPAddressType destination {
            get {
                return this.destinationField;
            }
            set {
                this.destinationField = value;
            }
        }
        public EntityItemIPAddressType gateway {
            get {
                return this.gatewayField;
            }
            set {
                this.gatewayField = value;
            }
        }
        [XmlElementAttribute("flags")]
        public EntityItemRoutingTableFlagsType[] flags {
            get {
                return this.flagsField;
            }
            set {
                this.flagsField = value;
            }
        }
        public EntityItemStringType interface_name {
            get {
                return this.interface_nameField;
            }
            set {
                this.interface_nameField = value;
            }
        }
    }

}

