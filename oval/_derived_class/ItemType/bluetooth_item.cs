using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#android")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#android", IsNullable=false)]
    public class bluetooth_item : ItemType {
        private EntityItemBoolType discoverableField;
        private EntityItemBoolType current_statusField;
        public EntityItemBoolType discoverable {
            get {
                return this.discoverableField;
            }
            set {
                this.discoverableField = value;
            }
        }
        public EntityItemBoolType current_status {
            get {
                return this.current_statusField;
            }
            set {
                this.current_statusField = value;
            }
        }
    }

}

