using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#linux")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#linux", IsNullable=false)]
    public class rpminfo_item : ItemType {
        private EntityItemStringType nameField;
        private EntityItemStringType archField;
        private rpminfo_itemEpoch epochField;
        private rpminfo_itemRelease releaseField;
        private rpminfo_itemVersion versionField;
        private EntityItemEVRStringType evrField;
        private EntityItemStringType signature_keyidField;
        private EntityItemStringType extended_nameField;
        private EntityItemStringType[] filepathField;
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
        public rpminfo_itemEpoch epoch {
            get {
                return this.epochField;
            }
            set {
                this.epochField = value;
            }
        }
        public rpminfo_itemRelease release {
            get {
                return this.releaseField;
            }
            set {
                this.releaseField = value;
            }
        }
        public rpminfo_itemVersion version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
        public EntityItemEVRStringType evr {
            get {
                return this.evrField;
            }
            set {
                this.evrField = value;
            }
        }
        public EntityItemStringType signature_keyid {
            get {
                return this.signature_keyidField;
            }
            set {
                this.signature_keyidField = value;
            }
        }
        public EntityItemStringType extended_name {
            get {
                return this.extended_nameField;
            }
            set {
                this.extended_nameField = value;
            }
        }
        [XmlElementAttribute("filepath")]
        public EntityItemStringType[] filepath {
            get {
                return this.filepathField;
            }
            set {
                this.filepathField = value;
            }
        }
    }

}

