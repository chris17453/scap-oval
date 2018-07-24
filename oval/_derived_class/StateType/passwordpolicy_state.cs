using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#windows")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#windows", IsNullable=false)]
    public class passwordpolicy_state : StateType {
        private EntityStateIntType max_passwd_ageField;
        private EntityStateIntType min_passwd_ageField;
        private EntityStateIntType min_passwd_lenField;
        private EntityStateIntType password_hist_lenField;
        private EntityStateBoolType password_complexityField;
        private EntityStateBoolType reversible_encryptionField;
        private EntityStateBoolType anonymous_name_lookupField;
        public EntityStateIntType max_passwd_age {
            get {
                return this.max_passwd_ageField;
            }
            set {
                this.max_passwd_ageField = value;
            }
        }
        public EntityStateIntType min_passwd_age {
            get {
                return this.min_passwd_ageField;
            }
            set {
                this.min_passwd_ageField = value;
            }
        }
        public EntityStateIntType min_passwd_len {
            get {
                return this.min_passwd_lenField;
            }
            set {
                this.min_passwd_lenField = value;
            }
        }
        public EntityStateIntType password_hist_len {
            get {
                return this.password_hist_lenField;
            }
            set {
                this.password_hist_lenField = value;
            }
        }
        public EntityStateBoolType password_complexity {
            get {
                return this.password_complexityField;
            }
            set {
                this.password_complexityField = value;
            }
        }
        public EntityStateBoolType reversible_encryption {
            get {
                return this.reversible_encryptionField;
            }
            set {
                this.reversible_encryptionField = value;
            }
        }
        public EntityStateBoolType anonymous_name_lookup {
            get {
                return this.anonymous_name_lookupField;
            }
            set {
                this.anonymous_name_lookupField = value;
            }
        }
    }

}

