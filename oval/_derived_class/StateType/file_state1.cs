using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#unix")]
    [XmlRootAttribute("file_state", Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#unix", IsNullable=false)]
    public class file_state1 : StateType {
        private EntityStateStringType filepathField;
        private EntityStateStringType pathField;
        private EntityStateStringType filenameField;
        private EntityStateStringType typeField;
        private file_stateGroup_id group_idField;
        private file_stateUser_id user_idField;
        private file_stateA_time a_timeField;
        private file_stateC_time c_timeField;
        private file_stateM_time m_timeField;
        private EntityStateIntType sizeField;
        private EntityStateBoolType suidField;
        private EntityStateBoolType sgidField;
        private EntityStateBoolType stickyField;
        private EntityStateBoolType ureadField;
        private EntityStateBoolType uwriteField;
        private EntityStateBoolType uexecField;
        private EntityStateBoolType greadField;
        private EntityStateBoolType gwriteField;
        private EntityStateBoolType gexecField;
        private EntityStateBoolType oreadField;
        private EntityStateBoolType owriteField;
        private EntityStateBoolType oexecField;
        private EntityStateBoolType has_extended_aclField;
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
        public EntityStateStringType type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        public file_stateGroup_id group_id {
            get {
                return this.group_idField;
            }
            set {
                this.group_idField = value;
            }
        }
        public file_stateUser_id user_id {
            get {
                return this.user_idField;
            }
            set {
                this.user_idField = value;
            }
        }
        public file_stateA_time a_time {
            get {
                return this.a_timeField;
            }
            set {
                this.a_timeField = value;
            }
        }
        public file_stateC_time c_time {
            get {
                return this.c_timeField;
            }
            set {
                this.c_timeField = value;
            }
        }
        public file_stateM_time m_time {
            get {
                return this.m_timeField;
            }
            set {
                this.m_timeField = value;
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
        public EntityStateBoolType suid {
            get {
                return this.suidField;
            }
            set {
                this.suidField = value;
            }
        }
        public EntityStateBoolType sgid {
            get {
                return this.sgidField;
            }
            set {
                this.sgidField = value;
            }
        }
        public EntityStateBoolType sticky {
            get {
                return this.stickyField;
            }
            set {
                this.stickyField = value;
            }
        }
        public EntityStateBoolType uread {
            get {
                return this.ureadField;
            }
            set {
                this.ureadField = value;
            }
        }
        public EntityStateBoolType uwrite {
            get {
                return this.uwriteField;
            }
            set {
                this.uwriteField = value;
            }
        }
        public EntityStateBoolType uexec {
            get {
                return this.uexecField;
            }
            set {
                this.uexecField = value;
            }
        }
        public EntityStateBoolType gread {
            get {
                return this.greadField;
            }
            set {
                this.greadField = value;
            }
        }
        public EntityStateBoolType gwrite {
            get {
                return this.gwriteField;
            }
            set {
                this.gwriteField = value;
            }
        }
        public EntityStateBoolType gexec {
            get {
                return this.gexecField;
            }
            set {
                this.gexecField = value;
            }
        }
        public EntityStateBoolType oread {
            get {
                return this.oreadField;
            }
            set {
                this.oreadField = value;
            }
        }
        public EntityStateBoolType owrite {
            get {
                return this.owriteField;
            }
            set {
                this.owriteField = value;
            }
        }
        public EntityStateBoolType oexec {
            get {
                return this.oexecField;
            }
            set {
                this.oexecField = value;
            }
        }
        public EntityStateBoolType has_extended_acl {
            get {
                return this.has_extended_aclField;
            }
            set {
                this.has_extended_aclField = value;
            }
        }
    }

}

