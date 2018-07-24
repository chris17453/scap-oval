using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#sharepoint")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#sharepoint", IsNullable=false)]
    public class sppolicy_state : StateType {
        private EntityStateStringType webappuriField;
        private EntityStateUrlZoneType urlzoneField;
        private EntityStateStringType displaynameField;
        private EntityStateBoolType issystemuserField;
        private EntityStateStringType usernameField;
        private EntityStatePolicyRoleType policyroletypeField;
        public EntityStateStringType webappuri {
            get {
                return this.webappuriField;
            }
            set {
                this.webappuriField = value;
            }
        }
        public EntityStateUrlZoneType urlzone {
            get {
                return this.urlzoneField;
            }
            set {
                this.urlzoneField = value;
            }
        }
        public EntityStateStringType displayname {
            get {
                return this.displaynameField;
            }
            set {
                this.displaynameField = value;
            }
        }
        public EntityStateBoolType issystemuser {
            get {
                return this.issystemuserField;
            }
            set {
                this.issystemuserField = value;
            }
        }
        public EntityStateStringType username {
            get {
                return this.usernameField;
            }
            set {
                this.usernameField = value;
            }
        }
        public EntityStatePolicyRoleType policyroletype {
            get {
                return this.policyroletypeField;
            }
            set {
                this.policyroletypeField = value;
            }
        }
    }

}

