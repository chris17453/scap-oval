using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#android")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#android", IsNullable=false)]
    public class locationservice_state : StateType {
        private EntityStateBoolType gps_enabledField;
        private EntityStateBoolType network_enabledField;
        public EntityStateBoolType gps_enabled {
            get {
                return this.gps_enabledField;
            }
            set {
                this.gps_enabledField = value;
            }
        }
        public EntityStateBoolType network_enabled {
            get {
                return this.network_enabledField;
            }
            set {
                this.network_enabledField = value;
            }
        }
    }

}

