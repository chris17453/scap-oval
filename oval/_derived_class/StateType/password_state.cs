using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#unix")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#unix", IsNullable=false)]
    public class password_state : StateType {
        private EntityStateStringType usernameField;
        private EntityStateStringType passwordField;
        private password_stateUser_id user_idField;
        private password_stateGroup_id group_idField;
        private EntityStateStringType gcosField;
        private EntityStateStringType home_dirField;
        private EntityStateStringType login_shellField;
        private EntityStateIntType last_loginField;
        public EntityStateStringType username {
            get {
                return this.usernameField;
            }
            set {
                this.usernameField = value;
            }
        }
        public EntityStateStringType password {
            get {
                return this.passwordField;
            }
            set {
                this.passwordField = value;
            }
        }
        public password_stateUser_id user_id {
            get {
                return this.user_idField;
            }
            set {
                this.user_idField = value;
            }
        }
        public password_stateGroup_id group_id {
            get {
                return this.group_idField;
            }
            set {
                this.group_idField = value;
            }
        }
        public EntityStateStringType gcos {
            get {
                return this.gcosField;
            }
            set {
                this.gcosField = value;
            }
        }
        public EntityStateStringType home_dir {
            get {
                return this.home_dirField;
            }
            set {
                this.home_dirField = value;
            }
        }
        public EntityStateStringType login_shell {
            get {
                return this.login_shellField;
            }
            set {
                this.login_shellField = value;
            }
        }
        public EntityStateIntType last_login {
            get {
                return this.last_loginField;
            }
            set {
                this.last_loginField = value;
            }
        }
    }

}

