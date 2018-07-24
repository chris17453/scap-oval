using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#android")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#android", IsNullable=false)]
    public class network_item : ItemType {
        private EntityItemBoolType airplane_modeField;
        private EntityItemBoolType nfc_enabledField;
        public EntityItemBoolType airplane_mode {
            get {
                return this.airplane_modeField;
            }
            set {
                this.airplane_modeField = value;
            }
        }
        public EntityItemBoolType nfc_enabled {
            get {
                return this.nfc_enabledField;
            }
            set {
                this.nfc_enabledField = value;
            }
        }
    }

}

