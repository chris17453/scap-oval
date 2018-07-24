using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#linux")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#linux", IsNullable=false)]
    public class dpkginfo_item : ItemType {
        private EntityItemStringType nameField;
        private EntityItemStringType archField;
        private dpkginfo_itemEpoch epochField;
        private dpkginfo_itemRelease releaseField;
        private dpkginfo_itemVersion versionField;
        private dpkginfo_itemEvr evrField;
        public EntityItemStringType name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        public EntityItemStringType arch {
            get {
                return this.archField;
            }
            set {
                this.archField = value;
            }
        }
        public dpkginfo_itemEpoch epoch {
            get {
                return this.epochField;
            }
            set {
                this.epochField = value;
            }
        }
        public dpkginfo_itemRelease release {
            get {
                return this.releaseField;
            }
            set {
                this.releaseField = value;
            }
        }
        public dpkginfo_itemVersion version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
        public dpkginfo_itemEvr evr {
            get {
                return this.evrField;
            }
            set {
                this.evrField = value;
            }
        }
    }

}

