using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#iosxe")]
    [XmlRootAttribute("version_state", Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#iosxe", IsNullable=false)]
    public class version_state3 : StateType {
        private EntityStateStringType platformField;
        private EntityStateIntType rpField;
        private EntityStateStringType pkgField;
        private EntityStateStringType version_stringField;
        private EntityStateIntType major_releaseField;
        private EntityStateIntType releaseField;
        private EntityStateIntType rebuildField;
        private EntityStateStringType trainField;
        private EntityStateStringType ios_releaseField;
        private EntityStateStringType ios_trainField;
        public EntityStateStringType platform {
            get {
                return this.platformField;
            }
            set {
                this.platformField = value;
            }
        }
        public EntityStateIntType rp {
            get {
                return this.rpField;
            }
            set {
                this.rpField = value;
            }
        }
        public EntityStateStringType pkg {
            get {
                return this.pkgField;
            }
            set {
                this.pkgField = value;
            }
        }
        public EntityStateStringType version_string {
            get {
                return this.version_stringField;
            }
            set {
                this.version_stringField = value;
            }
        }
        public EntityStateIntType major_release {
            get {
                return this.major_releaseField;
            }
            set {
                this.major_releaseField = value;
            }
        }
        public EntityStateIntType release {
            get {
                return this.releaseField;
            }
            set {
                this.releaseField = value;
            }
        }
        public EntityStateIntType rebuild {
            get {
                return this.rebuildField;
            }
            set {
                this.rebuildField = value;
            }
        }
        public EntityStateStringType train {
            get {
                return this.trainField;
            }
            set {
                this.trainField = value;
            }
        }
        public EntityStateStringType ios_release {
            get {
                return this.ios_releaseField;
            }
            set {
                this.ios_releaseField = value;
            }
        }
        public EntityStateStringType ios_train {
            get {
                return this.ios_trainField;
            }
            set {
                this.ios_trainField = value;
            }
        }
    }

}

