using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#macos")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#macos", IsNullable=false)]
    public class gatekeeper_state : StateType {
        private EntityStateBoolType enabledField;
        private EntityStateStringType unlabeledField;
        public EntityStateBoolType enabled {
            get {
                return this.enabledField;
            }
            set {
                this.enabledField = value;
            }
        }
        public EntityStateStringType unlabeled {
            get {
                return this.unlabeledField;
            }
            set {
                this.unlabeledField = value;
            }
        }
    }

}

