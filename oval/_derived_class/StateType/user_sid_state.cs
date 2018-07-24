using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#windows")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#windows", IsNullable=false)]
    public class user_sid_state : StateType {
        private EntityStateStringType userField;
        private EntityStateBoolType enabledField;
        private EntityStateStringType groupField;
        public EntityStateStringType user {
            get {
                return this.userField;
            }
            set {
                this.userField = value;
            }
        }
        public EntityStateBoolType enabled {
            get {
                return this.enabledField;
            }
            set {
                this.enabledField = value;
            }
        }
        public EntityStateStringType group {
            get {
                return this.groupField;
            }
            set {
                this.groupField = value;
            }
        }
    }

}

