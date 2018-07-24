using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#android")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#android", IsNullable=false)]
    public class camera_state : StateType {
        private EntityStateBoolType camera_disabled_policyField;
        public EntityStateBoolType camera_disabled_policy {
            get {
                return this.camera_disabled_policyField;
            }
            set {
                this.camera_disabled_policyField = value;
            }
        }
    }

}

