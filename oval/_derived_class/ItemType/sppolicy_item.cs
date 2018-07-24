using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#sharepoint")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#sharepoint", IsNullable=false)]
    public class sppolicy_item : ItemType {
        private EntityItemStringType webappuriField;
        private EntityItemUrlZoneType urlzoneField;
        private EntityItemStringType displaynameField;
        private EntityItemBoolType issystemuserField;
        private EntityItemStringType usernameField;
        private EntityItemPolicyRoleType policyroletypeField;
        public EntityItemStringType webappuri {
            get {
                return this.webappuriField;
            }
            set {
                this.webappuriField = value;
            }
        }
        public EntityItemUrlZoneType urlzone {
            get {
                return this.urlzoneField;
            }
            set {
                this.urlzoneField = value;
            }
        }
        public EntityItemStringType displayname {
            get {
                return this.displaynameField;
            }
            set {
                this.displaynameField = value;
            }
        }
        public EntityItemBoolType issystemuser {
            get {
                return this.issystemuserField;
            }
            set {
                this.issystemuserField = value;
            }
        }
        public EntityItemStringType username {
            get {
                return this.usernameField;
            }
            set {
                this.usernameField = value;
            }
        }
        public EntityItemPolicyRoleType policyroletype {
            get {
                return this.policyroletypeField;
            }
            set {
                this.policyroletypeField = value;
            }
        }
    }

}

