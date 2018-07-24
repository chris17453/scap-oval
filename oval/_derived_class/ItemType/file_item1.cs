using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#unix")]
    [XmlRootAttribute("file_item", Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#unix", IsNullable=false)]
    public class file_item1 : ItemType {
        private EntityItemStringType filepathField;
        private EntityItemStringType pathField;
        private EntityItemStringType filenameField;
        private EntityItemStringType typeField;
        private file_itemGroup_id group_idField;
        private file_itemUser_id user_idField;
        private file_itemA_time a_timeField;
        private file_itemC_time c_timeField;
        private file_itemM_time m_timeField;
        private EntityItemIntType sizeField;
        private EntityItemBoolType suidField;
        private EntityItemBoolType sgidField;
        private EntityItemBoolType stickyField;
        private EntityItemBoolType ureadField;
        private EntityItemBoolType uwriteField;
        private EntityItemBoolType uexecField;
        private EntityItemBoolType greadField;
        private EntityItemBoolType gwriteField;
        private EntityItemBoolType gexecField;
        private EntityItemBoolType oreadField;
        private EntityItemBoolType owriteField;
        private EntityItemBoolType oexecField;
        private EntityItemBoolType has_extended_aclField;
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
        public EntityItemStringType type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        public file_itemGroup_id group_id {
            get {
                return this.group_idField;
            }
            set {
                this.group_idField = value;
            }
        }
        public file_itemUser_id user_id {
            get {
                return this.user_idField;
            }
            set {
                this.user_idField = value;
            }
        }
        public file_itemA_time a_time {
            get {
                return this.a_timeField;
            }
            set {
                this.a_timeField = value;
            }
        }
        public file_itemC_time c_time {
            get {
                return this.c_timeField;
            }
            set {
                this.c_timeField = value;
            }
        }
        public file_itemM_time m_time {
            get {
                return this.m_timeField;
            }
            set {
                this.m_timeField = value;
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
        public EntityItemBoolType suid {
            get {
                return this.suidField;
            }
            set {
                this.suidField = value;
            }
        }
        public EntityItemBoolType sgid {
            get {
                return this.sgidField;
            }
            set {
                this.sgidField = value;
            }
        }
        public EntityItemBoolType sticky {
            get {
                return this.stickyField;
            }
            set {
                this.stickyField = value;
            }
        }
        public EntityItemBoolType uread {
            get {
                return this.ureadField;
            }
            set {
                this.ureadField = value;
            }
        }
        public EntityItemBoolType uwrite {
            get {
                return this.uwriteField;
            }
            set {
                this.uwriteField = value;
            }
        }
        public EntityItemBoolType uexec {
            get {
                return this.uexecField;
            }
            set {
                this.uexecField = value;
            }
        }
        public EntityItemBoolType gread {
            get {
                return this.greadField;
            }
            set {
                this.greadField = value;
            }
        }
        public EntityItemBoolType gwrite {
            get {
                return this.gwriteField;
            }
            set {
                this.gwriteField = value;
            }
        }
        public EntityItemBoolType gexec {
            get {
                return this.gexecField;
            }
            set {
                this.gexecField = value;
            }
        }
        public EntityItemBoolType oread {
            get {
                return this.oreadField;
            }
            set {
                this.oreadField = value;
            }
        }
        public EntityItemBoolType owrite {
            get {
                return this.owriteField;
            }
            set {
                this.owriteField = value;
            }
        }
        public EntityItemBoolType oexec {
            get {
                return this.oexecField;
            }
            set {
                this.oexecField = value;
            }
        }
        public EntityItemBoolType has_extended_acl {
            get {
                return this.has_extended_aclField;
            }
            set {
                this.has_extended_aclField = value;
            }
        }
    }

}

