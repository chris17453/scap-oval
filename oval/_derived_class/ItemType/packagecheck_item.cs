using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#solaris")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#solaris", IsNullable=false)]
    public class packagecheck_item : ItemType {
        private EntityItemStringType pkginstField;
        private EntityItemStringType filepathField;
        private EntityItemBoolType checksum_differsField;
        private EntityItemBoolType size_differsField;
        private EntityItemBoolType mtime_differsField;
        private EntityItemPermissionCompareType ureadField;
        private EntityItemPermissionCompareType uwriteField;
        private EntityItemPermissionCompareType uexecField;
        private EntityItemPermissionCompareType greadField;
        private EntityItemPermissionCompareType gwriteField;
        private EntityItemPermissionCompareType gexecField;
        private EntityItemPermissionCompareType oreadField;
        private EntityItemPermissionCompareType owriteField;
        private EntityItemPermissionCompareType oexecField;
        public EntityItemStringType pkginst {
            get {
                return this.pkginstField;
            }
            set {
                this.pkginstField = value;
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
        public EntityItemBoolType checksum_differs {
            get {
                return this.checksum_differsField;
            }
            set {
                this.checksum_differsField = value;
            }
        }
        public EntityItemBoolType size_differs {
            get {
                return this.size_differsField;
            }
            set {
                this.size_differsField = value;
            }
        }
        public EntityItemBoolType mtime_differs {
            get {
                return this.mtime_differsField;
            }
            set {
                this.mtime_differsField = value;
            }
        }
        public EntityItemPermissionCompareType uread {
            get {
                return this.ureadField;
            }
            set {
                this.ureadField = value;
            }
        }
        public EntityItemPermissionCompareType uwrite {
            get {
                return this.uwriteField;
            }
            set {
                this.uwriteField = value;
            }
        }
        public EntityItemPermissionCompareType uexec {
            get {
                return this.uexecField;
            }
            set {
                this.uexecField = value;
            }
        }
        public EntityItemPermissionCompareType gread {
            get {
                return this.greadField;
            }
            set {
                this.greadField = value;
            }
        }
        public EntityItemPermissionCompareType gwrite {
            get {
                return this.gwriteField;
            }
            set {
                this.gwriteField = value;
            }
        }
        public EntityItemPermissionCompareType gexec {
            get {
                return this.gexecField;
            }
            set {
                this.gexecField = value;
            }
        }
        public EntityItemPermissionCompareType oread {
            get {
                return this.oreadField;
            }
            set {
                this.oreadField = value;
            }
        }
        public EntityItemPermissionCompareType owrite {
            get {
                return this.owriteField;
            }
            set {
                this.owriteField = value;
            }
        }
        public EntityItemPermissionCompareType oexec {
            get {
                return this.oexecField;
            }
            set {
                this.oexecField = value;
            }
        }
    }

}

