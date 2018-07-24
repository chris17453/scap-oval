using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#linux")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#linux", IsNullable=false)]
    public class partition_state : StateType {
        private EntityStateStringType mount_pointField;
        private EntityStateStringType deviceField;
        private EntityStateStringType uuidField;
        private EntityStateStringType fs_typeField;
        private EntityStateStringType mount_optionsField;
        private EntityStateIntType total_spaceField;
        private EntityStateIntType space_usedField;
        private EntityStateIntType space_leftField;
        private EntityStateIntType space_left_for_unprivileged_usersField;
        private EntityStateIntType block_sizeField;
        public EntityStateStringType mount_point {
            get {
                return this.mount_pointField;
            }
            set {
                this.mount_pointField = value;
            }
        }
        public EntityStateStringType device {
            get {
                return this.deviceField;
            }
            set {
                this.deviceField = value;
            }
        }
        public EntityStateStringType uuid {
            get {
                return this.uuidField;
            }
            set {
                this.uuidField = value;
            }
        }
        public EntityStateStringType fs_type {
            get {
                return this.fs_typeField;
            }
            set {
                this.fs_typeField = value;
            }
        }
        public EntityStateStringType mount_options {
            get {
                return this.mount_optionsField;
            }
            set {
                this.mount_optionsField = value;
            }
        }
        public EntityStateIntType total_space {
            get {
                return this.total_spaceField;
            }
            set {
                this.total_spaceField = value;
            }
        }
        public EntityStateIntType space_used {
            get {
                return this.space_usedField;
            }
            set {
                this.space_usedField = value;
            }
        }
        public EntityStateIntType space_left {
            get {
                return this.space_leftField;
            }
            set {
                this.space_leftField = value;
            }
        }
        public EntityStateIntType space_left_for_unprivileged_users {
            get {
                return this.space_left_for_unprivileged_usersField;
            }
            set {
                this.space_left_for_unprivileged_usersField = value;
            }
        }
        public EntityStateIntType block_size {
            get {
                return this.block_sizeField;
            }
            set {
                this.block_sizeField = value;
            }
        }
    }

}

