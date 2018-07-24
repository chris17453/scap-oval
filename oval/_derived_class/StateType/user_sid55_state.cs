using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#windows")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#windows", IsNullable=false)]
    public class user_sid55_state : StateType {
        private EntityStateStringType user_sidField;
        private EntityStateBoolType enabledField;
        private EntityStateStringType group_sidField;
        private EntityStateIntType last_logonField;
        public EntityStateStringType user_sid {
            get {
                return this.user_sidField;
            }
            set {
                this.user_sidField = value;
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
        public EntityStateStringType group_sid {
            get {
                return this.group_sidField;
            }
            set {
                this.group_sidField = value;
            }
        }
        public EntityStateIntType last_logon {
            get {
                return this.last_logonField;
            }
            set {
                this.last_logonField = value;
            }
        }
    }

}

