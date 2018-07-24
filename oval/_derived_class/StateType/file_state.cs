using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#windows")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#windows", IsNullable=false)]
    public class file_state : StateType {
        private EntityStateStringType filepathField;
        private EntityStateStringType pathField;
        private EntityStateStringType filenameField;
        private EntityStateStringType ownerField;
        private EntityStateIntType sizeField;
        private EntityStateIntType a_timeField;
        private EntityStateIntType c_timeField;
        private EntityStateIntType m_timeField;
        private EntityStateStringType ms_checksumField;
        private EntityStateVersionType version1Field;
        private EntityStateFileTypeType typeField;
        private EntityStateFileAttributeType attributeField;
        private EntityStateStringType development_classField;
        private EntityStateStringType companyField;
        private EntityStateStringType internal_nameField;
        private EntityStateStringType languageField;
        private EntityStateStringType original_filenameField;
        private EntityStateStringType product_nameField;
        private file_stateProduct_version product_versionField;
        private EntityStateWindowsViewType1 windows_viewField;
        public EntityStateStringType filepath {
            get {
                return this.filepathField;
            }
            set {
                this.filepathField = value;
            }
        }
        public EntityStateStringType path {
            get {
                return this.pathField;
            }
            set {
                this.pathField = value;
            }
        }
        public EntityStateStringType filename {
            get {
                return this.filenameField;
            }
            set {
                this.filenameField = value;
            }
        }
        public EntityStateStringType owner {
            get {
                return this.ownerField;
            }
            set {
                this.ownerField = value;
            }
        }
        public EntityStateIntType size {
            get {
                return this.sizeField;
            }
            set {
                this.sizeField = value;
            }
        }
        public EntityStateIntType a_time {
            get {
                return this.a_timeField;
            }
            set {
                this.a_timeField = value;
            }
        }
        public EntityStateIntType c_time {
            get {
                return this.c_timeField;
            }
            set {
                this.c_timeField = value;
            }
        }
        public EntityStateIntType m_time {
            get {
                return this.m_timeField;
            }
            set {
                this.m_timeField = value;
            }
        }
        public EntityStateStringType ms_checksum {
            get {
                return this.ms_checksumField;
            }
            set {
                this.ms_checksumField = value;
            }
        }
        [XmlElementAttribute("version")]
        public EntityStateVersionType version1 {
            get {
                return this.version1Field;
            }
            set {
                this.version1Field = value;
            }
        }
        public EntityStateFileTypeType type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        public EntityStateFileAttributeType attribute {
            get {
                return this.attributeField;
            }
            set {
                this.attributeField = value;
            }
        }
        public EntityStateStringType development_class {
            get {
                return this.development_classField;
            }
            set {
                this.development_classField = value;
            }
        }
        public EntityStateStringType company {
            get {
                return this.companyField;
            }
            set {
                this.companyField = value;
            }
        }
        public EntityStateStringType internal_name {
            get {
                return this.internal_nameField;
            }
            set {
                this.internal_nameField = value;
            }
        }
        public EntityStateStringType language {
            get {
                return this.languageField;
            }
            set {
                this.languageField = value;
            }
        }
        public EntityStateStringType original_filename {
            get {
                return this.original_filenameField;
            }
            set {
                this.original_filenameField = value;
            }
        }
        public EntityStateStringType product_name {
            get {
                return this.product_nameField;
            }
            set {
                this.product_nameField = value;
            }
        }
        public file_stateProduct_version product_version {
            get {
                return this.product_versionField;
            }
            set {
                this.product_versionField = value;
            }
        }
        public EntityStateWindowsViewType1 windows_view {
            get {
                return this.windows_viewField;
            }
            set {
                this.windows_viewField = value;
            }
        }
    }

}

