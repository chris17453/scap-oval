using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#unix")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#unix", IsNullable=false)]
    public class shadow_item : ItemType {
        private EntityItemStringType usernameField;
        private EntityItemStringType passwordField;
        private shadow_itemChg_lst chg_lstField;
        private shadow_itemChg_allow chg_allowField;
        private shadow_itemChg_req chg_reqField;
        private shadow_itemExp_warn exp_warnField;
        private shadow_itemExp_inact exp_inactField;
        private shadow_itemExp_date exp_dateField;
        private shadow_itemFlag flagField;
        private EntityItemEncryptMethodType encrypt_methodField;
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
        public shadow_itemChg_lst chg_lst {
            get {
                return this.chg_lstField;
            }
            set {
                this.chg_lstField = value;
            }
        }
        public shadow_itemChg_allow chg_allow {
            get {
                return this.chg_allowField;
            }
            set {
                this.chg_allowField = value;
            }
        }
        public shadow_itemChg_req chg_req {
            get {
                return this.chg_reqField;
            }
            set {
                this.chg_reqField = value;
            }
        }
        public shadow_itemExp_warn exp_warn {
            get {
                return this.exp_warnField;
            }
            set {
                this.exp_warnField = value;
            }
        }
        public shadow_itemExp_inact exp_inact {
            get {
                return this.exp_inactField;
            }
            set {
                this.exp_inactField = value;
            }
        }
        public shadow_itemExp_date exp_date {
            get {
                return this.exp_dateField;
            }
            set {
                this.exp_dateField = value;
            }
        }
        public shadow_itemFlag flag {
            get {
                return this.flagField;
            }
            set {
                this.flagField = value;
            }
        }
        public EntityItemEncryptMethodType encrypt_method {
            get {
                return this.encrypt_methodField;
            }
            set {
                this.encrypt_methodField = value;
            }
        }
    }

}

