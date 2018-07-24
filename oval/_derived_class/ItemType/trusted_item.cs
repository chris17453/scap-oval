using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#hpux")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#hpux", IsNullable=false)]
    public class trusted_item : ItemType {
        private EntityItemStringType usernameField;
        private EntityItemIntType uidField;
        private EntityItemStringType passwordField;
        private EntityItemIntType account_ownerField;
        private EntityItemStringType boot_authField;
        private EntityItemStringType audit_idField;
        private EntityItemStringType audit_flagField;
        private EntityItemStringType pw_change_minField;
        private EntityItemIntType pw_max_sizeField;
        private EntityItemIntType pw_expirationField;
        private EntityItemStringType pw_lifeField;
        private EntityItemStringType pw_change_sField;
        private EntityItemStringType pw_change_uField;
        private EntityItemIntType acct_expireField;
        private EntityItemStringType max_lloginField;
        private EntityItemIntType exp_warningField;
        private EntityItemStringType usr_chg_pwField;
        private EntityItemStringType gen_pwField;
        private EntityItemStringType pw_restrictField;
        private EntityItemStringType pw_nullField;
        private EntityItemStringType pw_gen_charField;
        private EntityItemStringType pw_gen_letField;
        private EntityItemStringType login_timeField;
        private EntityItemIntType pw_changerField;
        private EntityItemStringType login_time_sField;
        private EntityItemStringType login_time_uField;
        private EntityItemStringType login_tty_sField;
        private EntityItemStringType login_tty_uField;
        private EntityItemIntType num_u_loginsField;
        private EntityItemIntType max_u_loginsField;
        private EntityItemBoolType lock_flagField;
        public EntityItemStringType username {
            get {
                return this.usernameField;
            }
            set {
                this.usernameField = value;
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
        public EntityItemStringType password {
            get {
                return this.passwordField;
            }
            set {
                this.passwordField = value;
            }
        }
        public EntityItemIntType account_owner {
            get {
                return this.account_ownerField;
            }
            set {
                this.account_ownerField = value;
            }
        }
        public EntityItemStringType boot_auth {
            get {
                return this.boot_authField;
            }
            set {
                this.boot_authField = value;
            }
        }
        public EntityItemStringType audit_id {
            get {
                return this.audit_idField;
            }
            set {
                this.audit_idField = value;
            }
        }
        public EntityItemStringType audit_flag {
            get {
                return this.audit_flagField;
            }
            set {
                this.audit_flagField = value;
            }
        }
        public EntityItemStringType pw_change_min {
            get {
                return this.pw_change_minField;
            }
            set {
                this.pw_change_minField = value;
            }
        }
        public EntityItemIntType pw_max_size {
            get {
                return this.pw_max_sizeField;
            }
            set {
                this.pw_max_sizeField = value;
            }
        }
        public EntityItemIntType pw_expiration {
            get {
                return this.pw_expirationField;
            }
            set {
                this.pw_expirationField = value;
            }
        }
        public EntityItemStringType pw_life {
            get {
                return this.pw_lifeField;
            }
            set {
                this.pw_lifeField = value;
            }
        }
        public EntityItemStringType pw_change_s {
            get {
                return this.pw_change_sField;
            }
            set {
                this.pw_change_sField = value;
            }
        }
        public EntityItemStringType pw_change_u {
            get {
                return this.pw_change_uField;
            }
            set {
                this.pw_change_uField = value;
            }
        }
        public EntityItemIntType acct_expire {
            get {
                return this.acct_expireField;
            }
            set {
                this.acct_expireField = value;
            }
        }
        public EntityItemStringType max_llogin {
            get {
                return this.max_lloginField;
            }
            set {
                this.max_lloginField = value;
            }
        }
        public EntityItemIntType exp_warning {
            get {
                return this.exp_warningField;
            }
            set {
                this.exp_warningField = value;
            }
        }
        public EntityItemStringType usr_chg_pw {
            get {
                return this.usr_chg_pwField;
            }
            set {
                this.usr_chg_pwField = value;
            }
        }
        public EntityItemStringType gen_pw {
            get {
                return this.gen_pwField;
            }
            set {
                this.gen_pwField = value;
            }
        }
        public EntityItemStringType pw_restrict {
            get {
                return this.pw_restrictField;
            }
            set {
                this.pw_restrictField = value;
            }
        }
        public EntityItemStringType pw_null {
            get {
                return this.pw_nullField;
            }
            set {
                this.pw_nullField = value;
            }
        }
        public EntityItemStringType pw_gen_char {
            get {
                return this.pw_gen_charField;
            }
            set {
                this.pw_gen_charField = value;
            }
        }
        public EntityItemStringType pw_gen_let {
            get {
                return this.pw_gen_letField;
            }
            set {
                this.pw_gen_letField = value;
            }
        }
        public EntityItemStringType login_time {
            get {
                return this.login_timeField;
            }
            set {
                this.login_timeField = value;
            }
        }
        public EntityItemIntType pw_changer {
            get {
                return this.pw_changerField;
            }
            set {
                this.pw_changerField = value;
            }
        }
        public EntityItemStringType login_time_s {
            get {
                return this.login_time_sField;
            }
            set {
                this.login_time_sField = value;
            }
        }
        public EntityItemStringType login_time_u {
            get {
                return this.login_time_uField;
            }
            set {
                this.login_time_uField = value;
            }
        }
        public EntityItemStringType login_tty_s {
            get {
                return this.login_tty_sField;
            }
            set {
                this.login_tty_sField = value;
            }
        }
        public EntityItemStringType login_tty_u {
            get {
                return this.login_tty_uField;
            }
            set {
                this.login_tty_uField = value;
            }
        }
        public EntityItemIntType num_u_logins {
            get {
                return this.num_u_loginsField;
            }
            set {
                this.num_u_loginsField = value;
            }
        }
        public EntityItemIntType max_u_logins {
            get {
                return this.max_u_loginsField;
            }
            set {
                this.max_u_loginsField = value;
            }
        }
        public EntityItemBoolType lock_flag {
            get {
                return this.lock_flagField;
            }
            set {
                this.lock_flagField = value;
            }
        }
    }

}

