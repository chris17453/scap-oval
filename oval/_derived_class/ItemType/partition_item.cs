using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#linux")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#linux", IsNullable=false)]
    public class partition_item : ItemType {
        private EntityItemStringType mount_pointField;
        private EntityItemStringType deviceField;
        private EntityItemStringType uuidField;
        private EntityItemStringType fs_typeField;
        private EntityItemStringType[] mount_optionsField;
        private EntityItemIntType total_spaceField;
        private EntityItemIntType space_usedField;
        private EntityItemIntType space_leftField;
        private EntityItemIntType space_left_for_unprivileged_usersField;
        private EntityItemIntType block_sizeField;
        public EntityItemStringType mount_point {
            get {
                return this.mount_pointField;
            }
            set {
                this.mount_pointField = value;
            }
        }
        public EntityItemStringType device {
            get {
                return this.deviceField;
            }
            set {
                this.deviceField = value;
            }
        }
        public EntityItemStringType uuid {
            get {
                return this.uuidField;
            }
            set {
                this.uuidField = value;
            }
        }
        public EntityItemStringType fs_type {
            get {
                return this.fs_typeField;
            }
            set {
                this.fs_typeField = value;
            }
        }
        [XmlElementAttribute("mount_options")]
        public EntityItemStringType[] mount_options {
            get {
                return this.mount_optionsField;
            }
            set {
                this.mount_optionsField = value;
            }
        }
        public EntityItemIntType total_space {
            get {
                return this.total_spaceField;
            }
            set {
                this.total_spaceField = value;
            }
        }
        public EntityItemIntType space_used {
            get {
                return this.space_usedField;
            }
            set {
                this.space_usedField = value;
            }
        }
        public EntityItemIntType space_left {
            get {
                return this.space_leftField;
            }
            set {
                this.space_leftField = value;
            }
        }
        public EntityItemIntType space_left_for_unprivileged_users {
            get {
                return this.space_left_for_unprivileged_usersField;
            }
            set {
                this.space_left_for_unprivileged_usersField = value;
            }
        }
        public EntityItemIntType block_size {
            get {
                return this.block_sizeField;
            }
            set {
                this.block_sizeField = value;
            }
        }
    }

}

