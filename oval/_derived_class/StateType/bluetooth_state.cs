using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#android")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#android", IsNullable=false)]
    public class bluetooth_state : StateType {
        private EntityStateBoolType discoverableField;
        private EntityStateBoolType current_statusField;
        public EntityStateBoolType discoverable {
            get {
                return this.discoverableField;
            }
            set {
                this.discoverableField = value;
            }
        }
        public EntityStateBoolType current_status {
            get {
                return this.current_statusField;
            }
            set {
                this.current_statusField = value;
            }
        }
    }

}

