using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#ios")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#ios", IsNullable=false)]
    public class version55_state : StateType {
        private EntityStateIntType major_versionField;
        private EntityStateIntType minor_versionField;
        private EntityStateIntType releaseField;
        private EntityStateStringType train_identifierField;
        private EntityStateIntType rebuildField;
        private EntityStateStringType subrebuildField;
        private EntityStateStringType mainline_rebuildField;
        private EntityStateIOSVersionType version_stringField;
        public EntityStateIntType major_version {
            get {
                return this.major_versionField;
            }
            set {
                this.major_versionField = value;
            }
        }
        public EntityStateIntType minor_version {
            get {
                return this.minor_versionField;
            }
            set {
                this.minor_versionField = value;
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
        public EntityStateStringType train_identifier {
            get {
                return this.train_identifierField;
            }
            set {
                this.train_identifierField = value;
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
        public EntityStateStringType subrebuild {
            get {
                return this.subrebuildField;
            }
            set {
                this.subrebuildField = value;
            }
        }
        public EntityStateStringType mainline_rebuild {
            get {
                return this.mainline_rebuildField;
            }
            set {
                this.mainline_rebuildField = value;
            }
        }
        public EntityStateIOSVersionType version_string {
            get {
                return this.version_stringField;
            }
            set {
                this.version_stringField = value;
            }
        }
    }

}

