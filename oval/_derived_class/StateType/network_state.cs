using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#android")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#android", IsNullable=false)]
    public class network_state : StateType {
        private EntityStateBoolType airplane_modeField;
        private EntityStateBoolType nfc_enabledField;
        public EntityStateBoolType airplane_mode {
            get {
                return this.airplane_modeField;
            }
            set {
                this.airplane_modeField = value;
            }
        }
        public EntityStateBoolType nfc_enabled {
            get {
                return this.nfc_enabledField;
            }
            set {
                this.nfc_enabledField = value;
            }
        }
    }

}

