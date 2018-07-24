using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#iosxe")]
    [XmlRootAttribute("version_item", Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#iosxe", IsNullable=false)]
    public class version_item3 : ItemType {
        private EntityItemStringType platformField;
        private EntityItemIntType rpField;
        private EntityItemStringType pkgField;
        private EntityItemStringType version_stringField;
        private EntityItemIntType major_releaseField;
        private EntityItemIntType releaseField;
        private EntityItemIntType rebuildField;
        private EntityItemStringType trainField;
        private EntityItemStringType ios_releaseField;
        private EntityItemStringType ios_trainField;
        public EntityItemStringType platform {
            get {
                return this.platformField;
            }
            set {
                this.platformField = value;
            }
        }
        public EntityItemIntType rp {
            get {
                return this.rpField;
            }
            set {
                this.rpField = value;
            }
        }
        public EntityItemStringType pkg {
            get {
                return this.pkgField;
            }
            set {
                this.pkgField = value;
            }
        }
        public EntityItemStringType version_string {
            get {
                return this.version_stringField;
            }
            set {
                this.version_stringField = value;
            }
        }
        public EntityItemIntType major_release {
            get {
                return this.major_releaseField;
            }
            set {
                this.major_releaseField = value;
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
        public EntityItemIntType rebuild {
            get {
                return this.rebuildField;
            }
            set {
                this.rebuildField = value;
            }
        }
        public EntityItemStringType train {
            get {
                return this.trainField;
            }
            set {
                this.trainField = value;
            }
        }
        public EntityItemStringType ios_release {
            get {
                return this.ios_releaseField;
            }
            set {
                this.ios_releaseField = value;
            }
        }
        public EntityItemStringType ios_train {
            get {
                return this.ios_trainField;
            }
            set {
                this.ios_trainField = value;
            }
        }
    }

}

