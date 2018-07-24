using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#android")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#android", IsNullable=false)]
    public class locationservice_item : ItemType {
        private EntityItemBoolType gps_enabledField;
        private EntityItemBoolType network_enabledField;
        public EntityItemBoolType gps_enabled {
            get {
                return this.gps_enabledField;
            }
            set {
                this.gps_enabledField = value;
            }
        }
        public EntityItemBoolType network_enabled {
            get {
                return this.network_enabledField;
            }
            set {
                this.network_enabledField = value;
            }
        }
    }

}

