using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#linux")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#linux", IsNullable=false)]
    public class selinuxsecuritycontext_state : StateType {
        private EntityStateStringType filepathField;
        private EntityStateStringType pathField;
        private EntityStateStringType filenameField;
        private EntityStateIntType pidField;
        private EntityStateStringType userField;
        private EntityStateStringType roleField;
        private EntityStateStringType typeField;
        private EntityStateStringType low_sensitivityField;
        private EntityStateStringType low_categoryField;
        private EntityStateStringType high_sensitivityField;
        private EntityStateStringType high_categoryField;
        private EntityStateStringType rawlow_sensitivityField;
        private EntityStateStringType rawlow_categoryField;
        private EntityStateStringType rawhigh_sensitivityField;
        private EntityStateStringType rawhigh_categoryField;
        public EntityStateStringType filepath {
            get {
                return this.filepathField;
            }
            set {
                this.filepathField = value;
            }
        }
        public EntityStateStringType path {
            get {
                return this.pathField;
            }
            set {
                this.pathField = value;
            }
        }
        public EntityStateStringType filename {
            get {
                return this.filenameField;
            }
            set {
                this.filenameField = value;
            }
        }
        public EntityStateIntType pid {
            get {
                return this.pidField;
            }
            set {
                this.pidField = value;
            }
        }
        public EntityStateStringType user {
            get {
                return this.userField;
            }
            set {
                this.userField = value;
            }
        }
        public EntityStateStringType role {
            get {
                return this.roleField;
            }
            set {
                this.roleField = value;
            }
        }
        public EntityStateStringType type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        public EntityStateStringType low_sensitivity {
            get {
                return this.low_sensitivityField;
            }
            set {
                this.low_sensitivityField = value;
            }
        }
        public EntityStateStringType low_category {
            get {
                return this.low_categoryField;
            }
            set {
                this.low_categoryField = value;
            }
        }
        public EntityStateStringType high_sensitivity {
            get {
                return this.high_sensitivityField;
            }
            set {
                this.high_sensitivityField = value;
            }
        }
        public EntityStateStringType high_category {
            get {
                return this.high_categoryField;
            }
            set {
                this.high_categoryField = value;
            }
        }
        public EntityStateStringType rawlow_sensitivity {
            get {
                return this.rawlow_sensitivityField;
            }
            set {
                this.rawlow_sensitivityField = value;
            }
        }
        public EntityStateStringType rawlow_category {
            get {
                return this.rawlow_categoryField;
            }
            set {
                this.rawlow_categoryField = value;
            }
        }
        public EntityStateStringType rawhigh_sensitivity {
            get {
                return this.rawhigh_sensitivityField;
            }
            set {
                this.rawhigh_sensitivityField = value;
            }
        }
        public EntityStateStringType rawhigh_category {
            get {
                return this.rawhigh_categoryField;
            }
            set {
                this.rawhigh_categoryField = value;
            }
        }
    }

}

