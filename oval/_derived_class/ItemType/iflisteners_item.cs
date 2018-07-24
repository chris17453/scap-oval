using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#linux")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#linux", IsNullable=false)]
    public class iflisteners_item : ItemType {
        private EntityItemStringType interface_nameField;
        private EntityItemProtocolType1 protocolField;
        private EntityItemStringType hw_addressField;
        private EntityItemStringType program_nameField;
        private EntityItemIntType pidField;
        private EntityItemIntType user_idField;
        public EntityItemStringType interface_name {
            get {
                return this.interface_nameField;
            }
            set {
                this.interface_nameField = value;
            }
        }
        public EntityItemProtocolType1 protocol {
            get {
                return this.protocolField;
            }
            set {
                this.protocolField = value;
            }
        }
        public EntityItemStringType hw_address {
            get {
                return this.hw_addressField;
            }
            set {
                this.hw_addressField = value;
            }
        }
        public EntityItemStringType program_name {
            get {
                return this.program_nameField;
            }
            set {
                this.program_nameField = value;
            }
        }
        public EntityItemIntType pid {
            get {
                return this.pidField;
            }
            set {
                this.pidField = value;
            }
        }
        public EntityItemIntType user_id {
            get {
                return this.user_idField;
            }
            set {
                this.user_idField = value;
            }
        }
    }

}

