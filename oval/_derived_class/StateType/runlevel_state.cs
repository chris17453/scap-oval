using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#unix")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#unix", IsNullable=false)]
    public class runlevel_state : StateType {
        private EntityStateStringType service_nameField;
        private EntityStateStringType runlevelField;
        private EntityStateBoolType startField;
        private EntityStateBoolType killField;
        public EntityStateStringType service_name {
            get {
                return this.service_nameField;
            }
            set {
                this.service_nameField = value;
            }
        }
        public EntityStateStringType runlevel {
            get {
                return this.runlevelField;
            }
            set {
                this.runlevelField = value;
            }
        }
        public EntityStateBoolType start {
            get {
                return this.startField;
            }
            set {
                this.startField = value;
            }
        }
        public EntityStateBoolType kill {
            get {
                return this.killField;
            }
            set {
                this.killField = value;
            }
        }
    }

}

