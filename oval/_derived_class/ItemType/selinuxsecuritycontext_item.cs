using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#linux")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#linux", IsNullable=false)]
    public class selinuxsecuritycontext_item : ItemType {
        private EntityItemStringType filepathField;
        private EntityItemStringType pathField;
        private EntityItemStringType filenameField;
        private EntityItemIntType pidField;
        private EntityItemStringType userField;
        private EntityItemStringType roleField;
        private EntityItemStringType typeField;
        private EntityItemStringType low_sensitivityField;
        private EntityItemStringType low_categoryField;
        private EntityItemStringType high_sensitivityField;
        private EntityItemStringType high_categoryField;
        private EntityItemStringType rawlow_sensitivityField;
        private EntityItemStringType rawlow_categoryField;
        private EntityItemStringType rawhigh_sensitivityField;
        private EntityItemStringType rawhigh_categoryField;
        public EntityItemStringType filepath {
            get {
                return this.filepathField;
            }
            set {
                this.filepathField = value;
            }
        }
        public EntityItemStringType path {
            get {
                return this.pathField;
            }
            set {
                this.pathField = value;
            }
        }
        [XmlElementAttribute(IsNullable=true)]
        public EntityItemStringType filename {
            get {
                return this.filenameField;
            }
            set {
                this.filenameField = value;
            }
        }
        public EntityItemIntType pid {
            get {
                return this.pidField;
            }
            set {
                this.pidField = value;
            }
        }
        public EntityItemStringType user {
            get {
                return this.userField;
            }
            set {
                this.userField = value;
            }
        }
        public EntityItemStringType role {
            get {
                return this.roleField;
            }
            set {
                this.roleField = value;
            }
        }
        public EntityItemStringType type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        public EntityItemStringType low_sensitivity {
            get {
                return this.low_sensitivityField;
            }
            set {
                this.low_sensitivityField = value;
            }
        }
        public EntityItemStringType low_category {
            get {
                return this.low_categoryField;
            }
            set {
                this.low_categoryField = value;
            }
        }
        public EntityItemStringType high_sensitivity {
            get {
                return this.high_sensitivityField;
            }
            set {
                this.high_sensitivityField = value;
            }
        }
        public EntityItemStringType high_category {
            get {
                return this.high_categoryField;
            }
            set {
                this.high_categoryField = value;
            }
        }
        public EntityItemStringType rawlow_sensitivity {
            get {
                return this.rawlow_sensitivityField;
            }
            set {
                this.rawlow_sensitivityField = value;
            }
        }
        public EntityItemStringType rawlow_category {
            get {
                return this.rawlow_categoryField;
            }
            set {
                this.rawlow_categoryField = value;
            }
        }
        public EntityItemStringType rawhigh_sensitivity {
            get {
                return this.rawhigh_sensitivityField;
            }
            set {
                this.rawhigh_sensitivityField = value;
            }
        }
        public EntityItemStringType rawhigh_category {
            get {
                return this.rawhigh_categoryField;
            }
            set {
                this.rawhigh_categoryField = value;
            }
        }
    }

}

