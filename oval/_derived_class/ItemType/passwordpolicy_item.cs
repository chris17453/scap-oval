using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#windows")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#windows", IsNullable=false)]
    public class passwordpolicy_item : ItemType {
        private EntityItemIntType max_passwd_ageField;
        private EntityItemIntType min_passwd_ageField;
        private EntityItemIntType min_passwd_lenField;
        private EntityItemIntType password_hist_lenField;
        private EntityItemBoolType password_complexityField;
        private EntityItemBoolType reversible_encryptionField;
        private EntityItemBoolType anonymous_name_lookupField;
        public EntityItemIntType max_passwd_age {
            get {
                return this.max_passwd_ageField;
            }
            set {
                this.max_passwd_ageField = value;
            }
        }
        public EntityItemIntType min_passwd_age {
            get {
                return this.min_passwd_ageField;
            }
            set {
                this.min_passwd_ageField = value;
            }
        }
        public EntityItemIntType min_passwd_len {
            get {
                return this.min_passwd_lenField;
            }
            set {
                this.min_passwd_lenField = value;
            }
        }
        public EntityItemIntType password_hist_len {
            get {
                return this.password_hist_lenField;
            }
            set {
                this.password_hist_lenField = value;
            }
        }
        public EntityItemBoolType password_complexity {
            get {
                return this.password_complexityField;
            }
            set {
                this.password_complexityField = value;
            }
        }
        public EntityItemBoolType reversible_encryption {
            get {
                return this.reversible_encryptionField;
            }
            set {
                this.reversible_encryptionField = value;
            }
        }
        public EntityItemBoolType anonymous_name_lookup {
            get {
                return this.anonymous_name_lookupField;
            }
            set {
                this.anonymous_name_lookupField = value;
            }
        }
    }

}

