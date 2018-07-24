using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#unix")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#unix", IsNullable=false)]
    public class password_item : ItemType {
        private EntityItemStringType usernameField;
        private EntityItemStringType passwordField;
        private password_itemUser_id user_idField;
        private password_itemGroup_id group_idField;
        private EntityItemStringType gcosField;
        private EntityItemStringType home_dirField;
        private EntityItemStringType login_shellField;
        private EntityItemIntType last_loginField;
        public EntityItemStringType username {
            get {
                return this.usernameField;
            }
            set {
                this.usernameField = value;
            }
        }
        public EntityItemStringType password {
            get {
                return this.passwordField;
            }
            set {
                this.passwordField = value;
            }
        }
        public password_itemUser_id user_id {
            get {
                return this.user_idField;
            }
            set {
                this.user_idField = value;
            }
        }
        public password_itemGroup_id group_id {
            get {
                return this.group_idField;
            }
            set {
                this.group_idField = value;
            }
        }
        public EntityItemStringType gcos {
            get {
                return this.gcosField;
            }
            set {
                this.gcosField = value;
            }
        }
        public EntityItemStringType home_dir {
            get {
                return this.home_dirField;
            }
            set {
                this.home_dirField = value;
            }
        }
        public EntityItemStringType login_shell {
            get {
                return this.login_shellField;
            }
            set {
                this.login_shellField = value;
            }
        }
        public EntityItemIntType last_login {
            get {
                return this.last_loginField;
            }
            set {
                this.last_loginField = value;
            }
        }
    }

}

