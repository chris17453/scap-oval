using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#windows")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#windows", IsNullable=false)]
    public class file_item : ItemType {
        private EntityItemStringType filepathField;
        private EntityItemStringType pathField;
        private EntityItemStringType filenameField;
        private EntityItemStringType ownerField;
        private EntityItemIntType sizeField;
        private EntityItemIntType a_timeField;
        private EntityItemIntType c_timeField;
        private EntityItemIntType m_timeField;
        private EntityItemStringType ms_checksumField;
        private EntityItemVersionType versionField;
        private EntityItemFileTypeType typeField;
        private EntityItemFileAttributeType[] attributeField;
        private EntityItemStringType development_classField;
        private EntityItemStringType companyField;
        private EntityItemStringType internal_nameField;
        private EntityItemStringType languageField;
        private EntityItemStringType original_filenameField;
        private EntityItemStringType product_nameField;
        private file_itemProduct_version product_versionField;
        private EntityItemWindowsViewType1 windows_viewField;
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
        public EntityItemStringType owner {
            get {
                return this.ownerField;
            }
            set {
                this.ownerField = value;
            }
        }
        public EntityItemIntType size {
            get {
                return this.sizeField;
            }
            set {
                this.sizeField = value;
            }
        }
        public EntityItemIntType a_time {
            get {
                return this.a_timeField;
            }
            set {
                this.a_timeField = value;
            }
        }
        public EntityItemIntType c_time {
            get {
                return this.c_timeField;
            }
            set {
                this.c_timeField = value;
            }
        }
        public EntityItemIntType m_time {
            get {
                return this.m_timeField;
            }
            set {
                this.m_timeField = value;
            }
        }
        public EntityItemStringType ms_checksum {
            get {
                return this.ms_checksumField;
            }
            set {
                this.ms_checksumField = value;
            }
        }
        public EntityItemVersionType version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
        public EntityItemFileTypeType type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        [XmlElementAttribute("attribute")]
        public EntityItemFileAttributeType[] attribute {
            get {
                return this.attributeField;
            }
            set {
                this.attributeField = value;
            }
        }
        public EntityItemStringType development_class {
            get {
                return this.development_classField;
            }
            set {
                this.development_classField = value;
            }
        }
        public EntityItemStringType company {
            get {
                return this.companyField;
            }
            set {
                this.companyField = value;
            }
        }
        public EntityItemStringType internal_name {
            get {
                return this.internal_nameField;
            }
            set {
                this.internal_nameField = value;
            }
        }
        public EntityItemStringType language {
            get {
                return this.languageField;
            }
            set {
                this.languageField = value;
            }
        }
        public EntityItemStringType original_filename {
            get {
                return this.original_filenameField;
            }
            set {
                this.original_filenameField = value;
            }
        }
        public EntityItemStringType product_name {
            get {
                return this.product_nameField;
            }
            set {
                this.product_nameField = value;
            }
        }
        public file_itemProduct_version product_version {
            get {
                return this.product_versionField;
            }
            set {
                this.product_versionField = value;
            }
        }
        public EntityItemWindowsViewType1 windows_view {
            get {
                return this.windows_viewField;
            }
            set {
                this.windows_viewField = value;
            }
        }
    }

}

