using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#hpux")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#hpux", IsNullable=false)]
    public class swlist_item : ItemType {
        private EntityItemStringType swlistField;
        private EntityItemStringType bundleField;
        private EntityItemStringType filesetField;
        private swlist_itemVersion versionField;
        private EntityItemStringType titleField;
        private EntityItemStringType vendorField;
        public EntityItemStringType swlist {
            get {
                return this.swlistField;
            }
            set {
                this.swlistField = value;
            }
        }
        public EntityItemStringType bundle {
            get {
                return this.bundleField;
            }
            set {
                this.bundleField = value;
            }
        }
        public EntityItemStringType fileset {
            get {
                return this.filesetField;
            }
            set {
                this.filesetField = value;
            }
        }
        public swlist_itemVersion version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
        public EntityItemStringType title {
            get {
                return this.titleField;
            }
            set {
                this.titleField = value;
            }
        }
        public EntityItemStringType vendor {
            get {
                return this.vendorField;
            }
            set {
                this.vendorField = value;
            }
        }
    }

}

