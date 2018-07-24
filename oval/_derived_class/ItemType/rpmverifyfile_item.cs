using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#linux")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#linux", IsNullable=false)]
    public class rpmverifyfile_item : ItemType {
        private EntityItemStringType nameField;
        private rpmverifyfile_itemEpoch epochField;
        private rpmverifyfile_itemVersion versionField;
        private rpmverifyfile_itemRelease releaseField;
        private EntityItemStringType archField;
        private EntityItemStringType filepathField;
        private EntityItemStringType extended_nameField;
        private EntityItemRpmVerifyResultType size_differsField;
        private EntityItemRpmVerifyResultType mode_differsField;
        private EntityItemRpmVerifyResultType md5_differsField;
        private EntityItemRpmVerifyResultType filedigest_differsField;
        private EntityItemRpmVerifyResultType device_differsField;
        private EntityItemRpmVerifyResultType link_mismatchField;
        private EntityItemRpmVerifyResultType ownership_differsField;
        private EntityItemRpmVerifyResultType group_differsField;
        private EntityItemRpmVerifyResultType mtime_differsField;
        private EntityItemRpmVerifyResultType capabilities_differField;
        private EntityItemBoolType configuration_fileField;
        private EntityItemBoolType documentation_fileField;
        private EntityItemBoolType ghost_fileField;
        private EntityItemBoolType license_fileField;
        private EntityItemBoolType readme_fileField;
        public EntityItemStringType name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        public rpmverifyfile_itemEpoch epoch {
            get {
                return this.epochField;
            }
            set {
                this.epochField = value;
            }
        }
        public rpmverifyfile_itemVersion version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
        public rpmverifyfile_itemRelease release {
            get {
                return this.releaseField;
            }
            set {
                this.releaseField = value;
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
        public EntityItemStringType filepath {
            get {
                return this.filepathField;
            }
            set {
                this.filepathField = value;
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
        public EntityItemRpmVerifyResultType size_differs {
            get {
                return this.size_differsField;
            }
            set {
                this.size_differsField = value;
            }
        }
        public EntityItemRpmVerifyResultType mode_differs {
            get {
                return this.mode_differsField;
            }
            set {
                this.mode_differsField = value;
            }
        }
        public EntityItemRpmVerifyResultType md5_differs {
            get {
                return this.md5_differsField;
            }
            set {
                this.md5_differsField = value;
            }
        }
        public EntityItemRpmVerifyResultType filedigest_differs {
            get {
                return this.filedigest_differsField;
            }
            set {
                this.filedigest_differsField = value;
            }
        }
        public EntityItemRpmVerifyResultType device_differs {
            get {
                return this.device_differsField;
            }
            set {
                this.device_differsField = value;
            }
        }
        public EntityItemRpmVerifyResultType link_mismatch {
            get {
                return this.link_mismatchField;
            }
            set {
                this.link_mismatchField = value;
            }
        }
        public EntityItemRpmVerifyResultType ownership_differs {
            get {
                return this.ownership_differsField;
            }
            set {
                this.ownership_differsField = value;
            }
        }
        public EntityItemRpmVerifyResultType group_differs {
            get {
                return this.group_differsField;
            }
            set {
                this.group_differsField = value;
            }
        }
        public EntityItemRpmVerifyResultType mtime_differs {
            get {
                return this.mtime_differsField;
            }
            set {
                this.mtime_differsField = value;
            }
        }
        public EntityItemRpmVerifyResultType capabilities_differ {
            get {
                return this.capabilities_differField;
            }
            set {
                this.capabilities_differField = value;
            }
        }
        public EntityItemBoolType configuration_file {
            get {
                return this.configuration_fileField;
            }
            set {
                this.configuration_fileField = value;
            }
        }
        public EntityItemBoolType documentation_file {
            get {
                return this.documentation_fileField;
            }
            set {
                this.documentation_fileField = value;
            }
        }
        public EntityItemBoolType ghost_file {
            get {
                return this.ghost_fileField;
            }
            set {
                this.ghost_fileField = value;
            }
        }
        public EntityItemBoolType license_file {
            get {
                return this.license_fileField;
            }
            set {
                this.license_fileField = value;
            }
        }
        public EntityItemBoolType readme_file {
            get {
                return this.readme_fileField;
            }
            set {
                this.readme_fileField = value;
            }
        }
    }

}

