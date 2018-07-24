using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#hpux")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#hpux", IsNullable=false)]
    public class trusted_state : StateType {
        private EntityStateStringType usernameField;
        private EntityStateIntType uidField;
        private EntityStateStringType passwordField;
        private EntityStateIntType account_ownerField;
        private EntityStateStringType boot_authField;
        private EntityStateStringType audit_idField;
        private EntityStateStringType audit_flagField;
        private EntityStateStringType pw_change_minField;
        private EntityStateIntType pw_max_sizeField;
        private EntityStateIntType pw_expirationField;
        private EntityStateStringType pw_lifeField;
        private EntityStateStringType pw_change_sField;
        private EntityStateStringType pw_change_uField;
        private EntityStateIntType acct_expireField;
        private EntityStateStringType max_lloginField;
        private EntityStateIntType exp_warningField;
        private EntityStateStringType usr_chg_pwField;
        private EntityStateStringType gen_pwField;
        private EntityStateStringType pw_restrictField;
        private EntityStateStringType pw_nullField;
        private EntityStateStringType pw_gen_charField;
        private EntityStateStringType pw_gen_letField;
        private EntityStateStringType login_timeField;
        private EntityStateIntType pw_changerField;
        private EntityStateStringType login_time_sField;
        private EntityStateStringType login_time_uField;
        private EntityStateStringType login_tty_sField;
        private EntityStateStringType login_tty_uField;
        private EntityStateIntType num_u_loginsField;
        private EntityStateIntType max_u_loginsField;
        private EntityStateBoolType lock_flagField;
        public EntityStateStringType username {
            get {
                return this.usernameField;
            }
            set {
                this.usernameField = value;
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
        public EntityStateStringType password {
            get {
                return this.passwordField;
            }
            set {
                this.passwordField = value;
            }
        }
        public EntityStateIntType account_owner {
            get {
                return this.account_ownerField;
            }
            set {
                this.account_ownerField = value;
            }
        }
        public EntityStateStringType boot_auth {
            get {
                return this.boot_authField;
            }
            set {
                this.boot_authField = value;
            }
        }
        public EntityStateStringType audit_id {
            get {
                return this.audit_idField;
            }
            set {
                this.audit_idField = value;
            }
        }
        public EntityStateStringType audit_flag {
            get {
                return this.audit_flagField;
            }
            set {
                this.audit_flagField = value;
            }
        }
        public EntityStateStringType pw_change_min {
            get {
                return this.pw_change_minField;
            }
            set {
                this.pw_change_minField = value;
            }
        }
        public EntityStateIntType pw_max_size {
            get {
                return this.pw_max_sizeField;
            }
            set {
                this.pw_max_sizeField = value;
            }
        }
        public EntityStateIntType pw_expiration {
            get {
                return this.pw_expirationField;
            }
            set {
                this.pw_expirationField = value;
            }
        }
        public EntityStateStringType pw_life {
            get {
                return this.pw_lifeField;
            }
            set {
                this.pw_lifeField = value;
            }
        }
        public EntityStateStringType pw_change_s {
            get {
                return this.pw_change_sField;
            }
            set {
                this.pw_change_sField = value;
            }
        }
        public EntityStateStringType pw_change_u {
            get {
                return this.pw_change_uField;
            }
            set {
                this.pw_change_uField = value;
            }
        }
        public EntityStateIntType acct_expire {
            get {
                return this.acct_expireField;
            }
            set {
                this.acct_expireField = value;
            }
        }
        public EntityStateStringType max_llogin {
            get {
                return this.max_lloginField;
            }
            set {
                this.max_lloginField = value;
            }
        }
        public EntityStateIntType exp_warning {
            get {
                return this.exp_warningField;
            }
            set {
                this.exp_warningField = value;
            }
        }
        public EntityStateStringType usr_chg_pw {
            get {
                return this.usr_chg_pwField;
            }
            set {
                this.usr_chg_pwField = value;
            }
        }
        public EntityStateStringType gen_pw {
            get {
                return this.gen_pwField;
            }
            set {
                this.gen_pwField = value;
            }
        }
        public EntityStateStringType pw_restrict {
            get {
                return this.pw_restrictField;
            }
            set {
                this.pw_restrictField = value;
            }
        }
        public EntityStateStringType pw_null {
            get {
                return this.pw_nullField;
            }
            set {
                this.pw_nullField = value;
            }
        }
        public EntityStateStringType pw_gen_char {
            get {
                return this.pw_gen_charField;
            }
            set {
                this.pw_gen_charField = value;
            }
        }
        public EntityStateStringType pw_gen_let {
            get {
                return this.pw_gen_letField;
            }
            set {
                this.pw_gen_letField = value;
            }
        }
        public EntityStateStringType login_time {
            get {
                return this.login_timeField;
            }
            set {
                this.login_timeField = value;
            }
        }
        public EntityStateIntType pw_changer {
            get {
                return this.pw_changerField;
            }
            set {
                this.pw_changerField = value;
            }
        }
        public EntityStateStringType login_time_s {
            get {
                return this.login_time_sField;
            }
            set {
                this.login_time_sField = value;
            }
        }
        public EntityStateStringType login_time_u {
            get {
                return this.login_time_uField;
            }
            set {
                this.login_time_uField = value;
            }
        }
        public EntityStateStringType login_tty_s {
            get {
                return this.login_tty_sField;
            }
            set {
                this.login_tty_sField = value;
            }
        }
        public EntityStateStringType login_tty_u {
            get {
                return this.login_tty_uField;
            }
            set {
                this.login_tty_uField = value;
            }
        }
        public EntityStateIntType num_u_logins {
            get {
                return this.num_u_loginsField;
            }
            set {
                this.num_u_loginsField = value;
            }
        }
        public EntityStateIntType max_u_logins {
            get {
                return this.max_u_loginsField;
            }
            set {
                this.max_u_loginsField = value;
            }
        }
        public EntityStateBoolType lock_flag {
            get {
                return this.lock_flagField;
            }
            set {
                this.lock_flagField = value;
            }
        }
    }

}

