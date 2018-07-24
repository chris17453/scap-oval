using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#macos")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#macos", IsNullable=false)]
    public class diskutil_state : StateType {
        private EntityStateStringType deviceField;
        private EntityStateStringType filepathField;
        private EntityStatePermissionCompareType1 ureadField;
        private EntityStatePermissionCompareType1 uwriteField;
        private EntityStatePermissionCompareType1 uexecField;
        private EntityStatePermissionCompareType1 greadField;
        private EntityStatePermissionCompareType1 gwriteField;
        private EntityStatePermissionCompareType1 gexecField;
        private EntityStatePermissionCompareType1 oreadField;
        private EntityStatePermissionCompareType1 owriteField;
        private EntityStatePermissionCompareType1 oexecField;
        private EntityStateBoolType user_differsField;
        private EntityStateIntType actual_userField;
        private EntityStateIntType expected_userField;
        private EntityStateBoolType group_differsField;
        private EntityStateIntType actual_groupField;
        private EntityStateIntType expected_groupField;
        private EntityStateBoolType symlink_differsField;
        private EntityStateStringType actual_symlinkField;
        private EntityStateStringType expected_symlinkField;
        public EntityStateStringType device {
            get {
                return this.deviceField;
            }
            set {
                this.deviceField = value;
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
        public EntityStatePermissionCompareType1 uread {
            get {
                return this.ureadField;
            }
            set {
                this.ureadField = value;
            }
        }
        public EntityStatePermissionCompareType1 uwrite {
            get {
                return this.uwriteField;
            }
            set {
                this.uwriteField = value;
            }
        }
        public EntityStatePermissionCompareType1 uexec {
            get {
                return this.uexecField;
            }
            set {
                this.uexecField = value;
            }
        }
        public EntityStatePermissionCompareType1 gread {
            get {
                return this.greadField;
            }
            set {
                this.greadField = value;
            }
        }
        public EntityStatePermissionCompareType1 gwrite {
            get {
                return this.gwriteField;
            }
            set {
                this.gwriteField = value;
            }
        }
        public EntityStatePermissionCompareType1 gexec {
            get {
                return this.gexecField;
            }
            set {
                this.gexecField = value;
            }
        }
        public EntityStatePermissionCompareType1 oread {
            get {
                return this.oreadField;
            }
            set {
                this.oreadField = value;
            }
        }
        public EntityStatePermissionCompareType1 owrite {
            get {
                return this.owriteField;
            }
            set {
                this.owriteField = value;
            }
        }
        public EntityStatePermissionCompareType1 oexec {
            get {
                return this.oexecField;
            }
            set {
                this.oexecField = value;
            }
        }
        public EntityStateBoolType user_differs {
            get {
                return this.user_differsField;
            }
            set {
                this.user_differsField = value;
            }
        }
        public EntityStateIntType actual_user {
            get {
                return this.actual_userField;
            }
            set {
                this.actual_userField = value;
            }
        }
        public EntityStateIntType expected_user {
            get {
                return this.expected_userField;
            }
            set {
                this.expected_userField = value;
            }
        }
        public EntityStateBoolType group_differs {
            get {
                return this.group_differsField;
            }
            set {
                this.group_differsField = value;
            }
        }
        public EntityStateIntType actual_group {
            get {
                return this.actual_groupField;
            }
            set {
                this.actual_groupField = value;
            }
        }
        public EntityStateIntType expected_group {
            get {
                return this.expected_groupField;
            }
            set {
                this.expected_groupField = value;
            }
        }
        public EntityStateBoolType symlink_differs {
            get {
                return this.symlink_differsField;
            }
            set {
                this.symlink_differsField = value;
            }
        }
        public EntityStateStringType actual_symlink {
            get {
                return this.actual_symlinkField;
            }
            set {
                this.actual_symlinkField = value;
            }
        }
        public EntityStateStringType expected_symlink {
            get {
                return this.expected_symlinkField;
            }
            set {
                this.expected_symlinkField = value;
            }
        }
    }

}

