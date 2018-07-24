using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#linux")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#linux", IsNullable=false)]
    public class iflisteners_state : StateType {
        private EntityStateStringType interface_nameField;
        private EntityStateProtocolType1 protocolField;
        private EntityStateStringType hw_addressField;
        private EntityStateStringType program_nameField;
        private EntityStateIntType pidField;
        private EntityStateIntType user_idField;
        public EntityStateStringType interface_name {
            get {
                return this.interface_nameField;
            }
            set {
                this.interface_nameField = value;
            }
        }
        public EntityStateProtocolType1 protocol {
            get {
                return this.protocolField;
            }
            set {
                this.protocolField = value;
            }
        }
        public EntityStateStringType hw_address {
            get {
                return this.hw_addressField;
            }
            set {
                this.hw_addressField = value;
            }
        }
        public EntityStateStringType program_name {
            get {
                return this.program_nameField;
            }
            set {
                this.program_nameField = value;
            }
        }
        public EntityStateIntType pid {
            get {
                return this.pidField;
            }
            set {
                this.pidField = value;
            }
        }
        public EntityStateIntType user_id {
            get {
                return this.user_idField;
            }
            set {
                this.user_idField = value;
            }
        }
    }

}

