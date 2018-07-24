using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#freebsd")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#freebsd", IsNullable=false)]
    public class portinfo_item : ItemType {
        private EntityItemStringType pkginstField;
        private EntityItemStringType nameField;
        private EntityItemStringType categoryField;
        private portinfo_itemVersion versionField;
        private EntityItemStringType vendorField;
        private EntityItemStringType descriptionField;
        public EntityItemStringType pkginst {
            get {
                return this.pkginstField;
            }
            set {
                this.pkginstField = value;
            }
        }
        public EntityItemStringType name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        public EntityItemStringType category {
            get {
                return this.categoryField;
            }
            set {
                this.categoryField = value;
            }
        }
        public portinfo_itemVersion version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
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
        public EntityItemStringType description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
    }

}

