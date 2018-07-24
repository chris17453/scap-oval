using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#solaris")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#solaris", IsNullable=false)]
    public class packagecheck_state : StateType {
        private EntityStateStringType pkginstField;
        private EntityStateStringType filepathField;
        private EntityStateBoolType checksum_differsField;
        private EntityStateBoolType size_differsField;
        private EntityStateBoolType mtime_differsField;
        private EntityStatePermissionCompareType ureadField;
        private EntityStatePermissionCompareType uwriteField;
        private EntityStatePermissionCompareType uexecField;
        private EntityStatePermissionCompareType greadField;
        private EntityStatePermissionCompareType gwriteField;
        private EntityStatePermissionCompareType gexecField;
        private EntityStatePermissionCompareType oreadField;
        private EntityStatePermissionCompareType owriteField;
        private EntityStatePermissionCompareType oexecField;
        public EntityStateStringType pkginst {
            get {
                return this.pkginstField;
            }
            set {
                this.pkginstField = value;
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
        public EntityStateBoolType checksum_differs {
            get {
                return this.checksum_differsField;
            }
            set {
                this.checksum_differsField = value;
            }
        }
        public EntityStateBoolType size_differs {
            get {
                return this.size_differsField;
            }
            set {
                this.size_differsField = value;
            }
        }
        public EntityStateBoolType mtime_differs {
            get {
                return this.mtime_differsField;
            }
            set {
                this.mtime_differsField = value;
            }
        }
        public EntityStatePermissionCompareType uread {
            get {
                return this.ureadField;
            }
            set {
                this.ureadField = value;
            }
        }
        public EntityStatePermissionCompareType uwrite {
            get {
                return this.uwriteField;
            }
            set {
                this.uwriteField = value;
            }
        }
        public EntityStatePermissionCompareType uexec {
            get {
                return this.uexecField;
            }
            set {
                this.uexecField = value;
            }
        }
        public EntityStatePermissionCompareType gread {
            get {
                return this.greadField;
            }
            set {
                this.greadField = value;
            }
        }
        public EntityStatePermissionCompareType gwrite {
            get {
                return this.gwriteField;
            }
            set {
                this.gwriteField = value;
            }
        }
        public EntityStatePermissionCompareType gexec {
            get {
                return this.gexecField;
            }
            set {
                this.gexecField = value;
            }
        }
        public EntityStatePermissionCompareType oread {
            get {
                return this.oreadField;
            }
            set {
                this.oreadField = value;
            }
        }
        public EntityStatePermissionCompareType owrite {
            get {
                return this.owriteField;
            }
            set {
                this.owriteField = value;
            }
        }
        public EntityStatePermissionCompareType oexec {
            get {
                return this.oexecField;
            }
            set {
                this.oexecField = value;
            }
        }
    }

}

