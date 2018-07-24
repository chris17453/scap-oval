using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#android")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#android", IsNullable=false)]
    public class camera_item : ItemType {
        private EntityItemBoolType camera_disabled_policyField;
        public EntityItemBoolType camera_disabled_policy {
            get {
                return this.camera_disabled_policyField;
            }
            set {
                this.camera_disabled_policyField = value;
            }
        }
    }

}

