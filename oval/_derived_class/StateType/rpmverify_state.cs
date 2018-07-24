using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#linux")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#linux", IsNullable=false)]
    public class rpmverify_state : StateType {
        private EntityStateStringType nameField;
        private EntityStateStringType filepathField;
        private EntityStateRpmVerifyResultType size_differsField;
        private EntityStateRpmVerifyResultType mode_differsField;
        private EntityStateRpmVerifyResultType md5_differsField;
        private EntityStateRpmVerifyResultType device_differsField;
        private EntityStateRpmVerifyResultType link_mismatchField;
        private EntityStateRpmVerifyResultType ownership_differsField;
        private EntityStateRpmVerifyResultType group_differsField;
        private EntityStateRpmVerifyResultType mtime_differsField;
        private EntityStateRpmVerifyResultType capabilities_differField;
        private EntityStateBoolType configuration_fileField;
        private EntityStateBoolType documentation_fileField;
        private EntityStateBoolType ghost_fileField;
        private EntityStateBoolType license_fileField;
        private EntityStateBoolType readme_fileField;
        public EntityStateStringType name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        public EntityStateStringType filepath {
            get {
                return this.filepathField;
            }
            set {
                this.filepathField = value;
            }
        }
        public EntityStateRpmVerifyResultType size_differs {
            get {
                return this.size_differsField;
            }
            set {
                this.size_differsField = value;
            }
        }
        public EntityStateRpmVerifyResultType mode_differs {
            get {
                return this.mode_differsField;
            }
            set {
                this.mode_differsField = value;
            }
        }
        public EntityStateRpmVerifyResultType md5_differs {
            get {
                return this.md5_differsField;
            }
            set {
                this.md5_differsField = value;
            }
        }
        public EntityStateRpmVerifyResultType device_differs {
            get {
                return this.device_differsField;
            }
            set {
                this.device_differsField = value;
            }
        }
        public EntityStateRpmVerifyResultType link_mismatch {
            get {
                return this.link_mismatchField;
            }
            set {
                this.link_mismatchField = value;
            }
        }
        public EntityStateRpmVerifyResultType ownership_differs {
            get {
                return this.ownership_differsField;
            }
            set {
                this.ownership_differsField = value;
            }
        }
        public EntityStateRpmVerifyResultType group_differs {
            get {
                return this.group_differsField;
            }
            set {
                this.group_differsField = value;
            }
        }
        public EntityStateRpmVerifyResultType mtime_differs {
            get {
                return this.mtime_differsField;
            }
            set {
                this.mtime_differsField = value;
            }
        }
        public EntityStateRpmVerifyResultType capabilities_differ {
            get {
                return this.capabilities_differField;
            }
            set {
                this.capabilities_differField = value;
            }
        }
        public EntityStateBoolType configuration_file {
            get {
                return this.configuration_fileField;
            }
            set {
                this.configuration_fileField = value;
            }
        }
        public EntityStateBoolType documentation_file {
            get {
                return this.documentation_fileField;
            }
            set {
                this.documentation_fileField = value;
            }
        }
        public EntityStateBoolType ghost_file {
            get {
                return this.ghost_fileField;
            }
            set {
                this.ghost_fileField = value;
            }
        }
        public EntityStateBoolType license_file {
            get {
                return this.license_fileField;
            }
            set {
                this.license_fileField = value;
            }
        }
        public EntityStateBoolType readme_file {
            get {
                return this.readme_fileField;
            }
            set {
                this.readme_fileField = value;
            }
        }
    }

}

