using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#ios")]
    [XmlRootAttribute("version_item", Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#ios", IsNullable=false)]
    public class version_item2 : ItemType {
        private EntityItemStringType major_releaseField;
        private EntityItemStringType train_numberField;
        private EntityItemIntType major_versionField;
        private EntityItemIntType minor_versionField;
        private EntityItemIntType releaseField;
        private EntityItemStringType train_identifierField;
        private EntityItemIntType rebuildField;
        private EntityItemStringType subrebuildField;
        private EntityItemStringType mainline_rebuildField;
        private EntityItemIOSVersionType version_stringField;
        public EntityItemStringType major_release {
            get {
                return this.major_releaseField;
            }
            set {
                this.major_releaseField = value;
            }
        }
        public EntityItemStringType train_number {
            get {
                return this.train_numberField;
            }
            set {
                this.train_numberField = value;
            }
        }
        public EntityItemIntType major_version {
            get {
                return this.major_versionField;
            }
            set {
                this.major_versionField = value;
            }
        }
        public EntityItemIntType minor_version {
            get {
                return this.minor_versionField;
            }
            set {
                this.minor_versionField = value;
            }
        }
        public EntityItemIntType release {
            get {
                return this.releaseField;
            }
            set {
                this.releaseField = value;
            }
        }
        public EntityItemStringType train_identifier {
            get {
                return this.train_identifierField;
            }
            set {
                this.train_identifierField = value;
            }
        }
        public EntityItemIntType rebuild {
            get {
                return this.rebuildField;
            }
            set {
                this.rebuildField = value;
            }
        }
        public EntityItemStringType subrebuild {
            get {
                return this.subrebuildField;
            }
            set {
                this.subrebuildField = value;
            }
        }
        public EntityItemStringType mainline_rebuild {
            get {
                return this.mainline_rebuildField;
            }
            set {
                this.mainline_rebuildField = value;
            }
        }
        public EntityItemIOSVersionType version_string {
            get {
                return this.version_stringField;
            }
            set {
                this.version_stringField = value;
            }
        }
    }

}

