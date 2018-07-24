using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#unix")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#unix", IsNullable=false)]
    public class routingtable_state : StateType {
        private EntityStateIPAddressType destinationField;
        private EntityStateIPAddressType gatewayField;
        private EntityStateRoutingTableFlagsType flagsField;
        private EntityStateStringType interface_nameField;
        public EntityStateIPAddressType destination {
            get {
                return this.destinationField;
            }
            set {
                this.destinationField = value;
            }
        }
        public EntityStateIPAddressType gateway {
            get {
                return this.gatewayField;
            }
            set {
                this.gatewayField = value;
            }
        }
        public EntityStateRoutingTableFlagsType flags {
            get {
                return this.flagsField;
            }
            set {
                this.flagsField = value;
            }
        }
        public EntityStateStringType interface_name {
            get {
                return this.interface_nameField;
            }
            set {
                this.interface_nameField = value;
            }
        }
    }

}

