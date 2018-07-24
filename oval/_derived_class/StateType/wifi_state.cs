using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#android")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#android", IsNullable=false)]
    public class wifi_state : StateType {
        private EntityStateBoolType wifi_statusField;
        private EntityStateBoolType network_availability_notificationField;
        public EntityStateBoolType wifi_status {
            get {
                return this.wifi_statusField;
            }
            set {
                this.wifi_statusField = value;
            }
        }
        public EntityStateBoolType network_availability_notification {
            get {
                return this.network_availability_notificationField;
            }
            set {
                this.network_availability_notificationField = value;
            }
        }
    }

}

