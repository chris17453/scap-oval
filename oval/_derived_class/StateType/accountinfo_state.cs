using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#macos")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#macos", IsNullable=false)]
    public class accountinfo_state : StateType {
        private EntityStateStringType usernameField;
        private EntityStateStringType passwordField;
        private EntityStateIntType uidField;
        private EntityStateIntType gidField;
        private EntityStateStringType realnameField;
        private EntityStateStringType home_dirField;
        private EntityStateStringType login_shellField;
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
        public EntityStateIntType uid {
            get {
                return this.uidField;
            }
            set {
                this.uidField = value;
            }
        }
        public EntityStateIntType gid {
            get {
                return this.gidField;
            }
            set {
                this.gidField = value;
            }
        }
        public EntityStateStringType realname {
            get {
                return this.realnameField;
            }
            set {
                this.realnameField = value;
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
    }

}

