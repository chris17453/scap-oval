using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#macos")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#macos", IsNullable=false)]
    public class accountinfo_item : ItemType {
        private EntityItemStringType usernameField;
        private EntityItemStringType passwordField;
        private EntityItemIntType uidField;
        private EntityItemIntType gidField;
        private EntityItemStringType realnameField;
        private EntityItemStringType home_dirField;
        private EntityItemStringType login_shellField;
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
        public EntityItemIntType uid {
            get {
                return this.uidField;
            }
            set {
                this.uidField = value;
            }
        }
        public EntityItemIntType gid {
            get {
                return this.gidField;
            }
            set {
                this.gidField = value;
            }
        }
        public EntityItemStringType realname {
            get {
                return this.realnameField;
            }
            set {
                this.realnameField = value;
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
    }

}

