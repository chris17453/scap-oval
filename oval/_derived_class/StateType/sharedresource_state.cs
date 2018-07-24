using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#windows")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#windows", IsNullable=false)]
    public class sharedresource_state : StateType {
        private EntityStateStringType netnameField;
        private EntityStateSharedResourceTypeType shared_typeField;
        private EntityStateIntType max_usesField;
        private EntityStateIntType current_usesField;
        private EntityStateStringType local_pathField;
        private EntityStateBoolType access_read_permissionField;
        private EntityStateBoolType access_write_permissionField;
        private EntityStateBoolType access_create_permissionField;
        private EntityStateBoolType access_exec_permissionField;
        private EntityStateBoolType access_delete_permissionField;
        private EntityStateBoolType access_atrib_permissionField;
        private EntityStateBoolType access_perm_permissionField;
        private EntityStateBoolType access_all_permissionField;
        public EntityStateStringType netname {
            get {
                return this.netnameField;
            }
            set {
                this.netnameField = value;
            }
        }
        public EntityStateSharedResourceTypeType shared_type {
            get {
                return this.shared_typeField;
            }
            set {
                this.shared_typeField = value;
            }
        }
        public EntityStateIntType max_uses {
            get {
                return this.max_usesField;
            }
            set {
                this.max_usesField = value;
            }
        }
        public EntityStateIntType current_uses {
            get {
                return this.current_usesField;
            }
            set {
                this.current_usesField = value;
            }
        }
        public EntityStateStringType local_path {
            get {
                return this.local_pathField;
            }
            set {
                this.local_pathField = value;
            }
        }
        public EntityStateBoolType access_read_permission {
            get {
                return this.access_read_permissionField;
            }
            set {
                this.access_read_permissionField = value;
            }
        }
        public EntityStateBoolType access_write_permission {
            get {
                return this.access_write_permissionField;
            }
            set {
                this.access_write_permissionField = value;
            }
        }
        public EntityStateBoolType access_create_permission {
            get {
                return this.access_create_permissionField;
            }
            set {
                this.access_create_permissionField = value;
            }
        }
        public EntityStateBoolType access_exec_permission {
            get {
                return this.access_exec_permissionField;
            }
            set {
                this.access_exec_permissionField = value;
            }
        }
        public EntityStateBoolType access_delete_permission {
            get {
                return this.access_delete_permissionField;
            }
            set {
                this.access_delete_permissionField = value;
            }
        }
        public EntityStateBoolType access_atrib_permission {
            get {
                return this.access_atrib_permissionField;
            }
            set {
                this.access_atrib_permissionField = value;
            }
        }
        public EntityStateBoolType access_perm_permission {
            get {
                return this.access_perm_permissionField;
            }
            set {
                this.access_perm_permissionField = value;
            }
        }
        public EntityStateBoolType access_all_permission {
            get {
                return this.access_all_permissionField;
            }
            set {
                this.access_all_permissionField = value;
            }
        }
    }

}

