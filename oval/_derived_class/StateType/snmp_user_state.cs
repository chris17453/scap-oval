using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#asa")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#asa", IsNullable=false)]
    public class snmp_user_state : StateType {
        private EntityStateStringType nameField;
        private EntityStateStringType groupField;
        private EntityStateSNMPPrivStringType2 privField;
        private EntityStateSNMPAuthStringType2 authField;
        public EntityStateStringType name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
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
        public EntityStateSNMPPrivStringType2 priv {
            get {
                return this.privField;
            }
            set {
                this.privField = value;
            }
        }
        public EntityStateSNMPAuthStringType2 auth {
            get {
                return this.authField;
            }
            set {
                this.authField = value;
            }
        }
    }

}

