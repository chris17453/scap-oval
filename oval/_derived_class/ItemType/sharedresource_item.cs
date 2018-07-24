using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#windows")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#windows", IsNullable=false)]
    public class sharedresource_item : ItemType {
        private EntityItemStringType netnameField;
        private EntityItemSharedResourceTypeType shared_typeField;
        private EntityItemIntType max_usesField;
        private EntityItemIntType current_usesField;
        private EntityItemStringType local_pathField;
        private EntityItemBoolType access_read_permissionField;
        private EntityItemBoolType access_write_permissionField;
        private EntityItemBoolType access_create_permissionField;
        private EntityItemBoolType access_exec_permissionField;
        private EntityItemBoolType access_delete_permissionField;
        private EntityItemBoolType access_atrib_permissionField;
        private EntityItemBoolType access_perm_permissionField;
        private EntityItemBoolType access_all_permissionField;
        public EntityItemStringType netname {
            get {
                return this.netnameField;
            }
            set {
                this.netnameField = value;
            }
        }
        public EntityItemSharedResourceTypeType shared_type {
            get {
                return this.shared_typeField;
            }
            set {
                this.shared_typeField = value;
            }
        }
        public EntityItemIntType max_uses {
            get {
                return this.max_usesField;
            }
            set {
                this.max_usesField = value;
            }
        }
        public EntityItemIntType current_uses {
            get {
                return this.current_usesField;
            }
            set {
                this.current_usesField = value;
            }
        }
        public EntityItemStringType local_path {
            get {
                return this.local_pathField;
            }
            set {
                this.local_pathField = value;
            }
        }
        public EntityItemBoolType access_read_permission {
            get {
                return this.access_read_permissionField;
            }
            set {
                this.access_read_permissionField = value;
            }
        }
        public EntityItemBoolType access_write_permission {
            get {
                return this.access_write_permissionField;
            }
            set {
                this.access_write_permissionField = value;
            }
        }
        public EntityItemBoolType access_create_permission {
            get {
                return this.access_create_permissionField;
            }
            set {
                this.access_create_permissionField = value;
            }
        }
        public EntityItemBoolType access_exec_permission {
            get {
                return this.access_exec_permissionField;
            }
            set {
                this.access_exec_permissionField = value;
            }
        }
        public EntityItemBoolType access_delete_permission {
            get {
                return this.access_delete_permissionField;
            }
            set {
                this.access_delete_permissionField = value;
            }
        }
        public EntityItemBoolType access_atrib_permission {
            get {
                return this.access_atrib_permissionField;
            }
            set {
                this.access_atrib_permissionField = value;
            }
        }
        public EntityItemBoolType access_perm_permission {
            get {
                return this.access_perm_permissionField;
            }
            set {
                this.access_perm_permissionField = value;
            }
        }
        public EntityItemBoolType access_all_permission {
            get {
                return this.access_all_permissionField;
            }
            set {
                this.access_all_permissionField = value;
            }
        }
    }

}

