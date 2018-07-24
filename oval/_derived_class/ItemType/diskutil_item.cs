using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#macos")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#macos", IsNullable=false)]
    public class diskutil_item : ItemType {
        private EntityItemStringType deviceField;
        private EntityItemStringType filepathField;
        private EntityItemPermissionCompareType1 ureadField;
        private EntityItemPermissionCompareType1 uwriteField;
        private EntityItemPermissionCompareType1 uexecField;
        private EntityItemPermissionCompareType1 greadField;
        private EntityItemPermissionCompareType1 gwriteField;
        private EntityItemPermissionCompareType1 gexecField;
        private EntityItemPermissionCompareType1 oreadField;
        private EntityItemPermissionCompareType1 owriteField;
        private EntityItemPermissionCompareType1 oexecField;
        private EntityItemBoolType user_differsField;
        private EntityItemIntType actual_userField;
        private EntityItemIntType expected_userField;
        private EntityItemBoolType group_differsField;
        private EntityItemIntType actual_groupField;
        private EntityItemIntType expected_groupField;
        private EntityItemBoolType symlink_differsField;
        private EntityItemStringType actual_symlinkField;
        private EntityItemStringType expected_symlinkField;
        public EntityItemStringType device {
            get {
                return this.deviceField;
            }
            set {
                this.deviceField = value;
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
        public EntityItemPermissionCompareType1 uread {
            get {
                return this.ureadField;
            }
            set {
                this.ureadField = value;
            }
        }
        public EntityItemPermissionCompareType1 uwrite {
            get {
                return this.uwriteField;
            }
            set {
                this.uwriteField = value;
            }
        }
        public EntityItemPermissionCompareType1 uexec {
            get {
                return this.uexecField;
            }
            set {
                this.uexecField = value;
            }
        }
        public EntityItemPermissionCompareType1 gread {
            get {
                return this.greadField;
            }
            set {
                this.greadField = value;
            }
        }
        public EntityItemPermissionCompareType1 gwrite {
            get {
                return this.gwriteField;
            }
            set {
                this.gwriteField = value;
            }
        }
        public EntityItemPermissionCompareType1 gexec {
            get {
                return this.gexecField;
            }
            set {
                this.gexecField = value;
            }
        }
        public EntityItemPermissionCompareType1 oread {
            get {
                return this.oreadField;
            }
            set {
                this.oreadField = value;
            }
        }
        public EntityItemPermissionCompareType1 owrite {
            get {
                return this.owriteField;
            }
            set {
                this.owriteField = value;
            }
        }
        public EntityItemPermissionCompareType1 oexec {
            get {
                return this.oexecField;
            }
            set {
                this.oexecField = value;
            }
        }
        public EntityItemBoolType user_differs {
            get {
                return this.user_differsField;
            }
            set {
                this.user_differsField = value;
            }
        }
        public EntityItemIntType actual_user {
            get {
                return this.actual_userField;
            }
            set {
                this.actual_userField = value;
            }
        }
        public EntityItemIntType expected_user {
            get {
                return this.expected_userField;
            }
            set {
                this.expected_userField = value;
            }
        }
        public EntityItemBoolType group_differs {
            get {
                return this.group_differsField;
            }
            set {
                this.group_differsField = value;
            }
        }
        public EntityItemIntType actual_group {
            get {
                return this.actual_groupField;
            }
            set {
                this.actual_groupField = value;
            }
        }
        public EntityItemIntType expected_group {
            get {
                return this.expected_groupField;
            }
            set {
                this.expected_groupField = value;
            }
        }
        public EntityItemBoolType symlink_differs {
            get {
                return this.symlink_differsField;
            }
            set {
                this.symlink_differsField = value;
            }
        }
        public EntityItemStringType actual_symlink {
            get {
                return this.actual_symlinkField;
            }
            set {
                this.actual_symlinkField = value;
            }
        }
        public EntityItemStringType expected_symlink {
            get {
                return this.expected_symlinkField;
            }
            set {
                this.expected_symlinkField = value;
            }
        }
    }

}

