using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#windows")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#windows", IsNullable=false)]
    public class volume_state : StateType {
        private EntityStateStringType rootpathField;
        private EntityStateStringType file_systemField;
        private EntityStateStringType nameField;
        private EntityStateDriveTypeType drive_typeField;
        private EntityStateIntType volume_max_component_lengthField;
        private EntityStateIntType serial_numberField;
        private EntityStateBoolType file_case_sensitive_searchField;
        private EntityStateBoolType file_case_preserved_namesField;
        private EntityStateBoolType file_unicode_on_diskField;
        private EntityStateBoolType file_persistent_aclsField;
        private EntityStateBoolType file_file_compressionField;
        private EntityStateBoolType file_volume_quotasField;
        private EntityStateBoolType file_supports_sparse_filesField;
        private EntityStateBoolType file_supports_reparse_pointsField;
        private EntityStateBoolType file_supports_remote_storageField;
        private EntityStateBoolType file_volume_is_compressedField;
        private EntityStateBoolType file_supports_object_idsField;
        private EntityStateBoolType file_supports_encryptionField;
        private EntityStateBoolType file_named_streamsField;
        private EntityStateBoolType file_read_only_volumeField;
        private EntityStateBoolType file_sequential_write_onceField;
        private EntityStateBoolType file_supports_transactionsField;
        private EntityStateBoolType file_supports_hard_linksField;
        private EntityStateBoolType file_supports_extended_attributesField;
        private EntityStateBoolType file_supports_open_by_file_idField;
        private EntityStateBoolType file_supports_usn_journalField;
        public EntityStateStringType rootpath {
            get {
                return this.rootpathField;
            }
            set {
                this.rootpathField = value;
            }
        }
        public EntityStateStringType file_system {
            get {
                return this.file_systemField;
            }
            set {
                this.file_systemField = value;
            }
        }
        public EntityStateStringType name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        public EntityStateDriveTypeType drive_type {
            get {
                return this.drive_typeField;
            }
            set {
                this.drive_typeField = value;
            }
        }
        public EntityStateIntType volume_max_component_length {
            get {
                return this.volume_max_component_lengthField;
            }
            set {
                this.volume_max_component_lengthField = value;
            }
        }
        public EntityStateIntType serial_number {
            get {
                return this.serial_numberField;
            }
            set {
                this.serial_numberField = value;
            }
        }
        public EntityStateBoolType file_case_sensitive_search {
            get {
                return this.file_case_sensitive_searchField;
            }
            set {
                this.file_case_sensitive_searchField = value;
            }
        }
        public EntityStateBoolType file_case_preserved_names {
            get {
                return this.file_case_preserved_namesField;
            }
            set {
                this.file_case_preserved_namesField = value;
            }
        }
        public EntityStateBoolType file_unicode_on_disk {
            get {
                return this.file_unicode_on_diskField;
            }
            set {
                this.file_unicode_on_diskField = value;
            }
        }
        public EntityStateBoolType file_persistent_acls {
            get {
                return this.file_persistent_aclsField;
            }
            set {
                this.file_persistent_aclsField = value;
            }
        }
        public EntityStateBoolType file_file_compression {
            get {
                return this.file_file_compressionField;
            }
            set {
                this.file_file_compressionField = value;
            }
        }
        public EntityStateBoolType file_volume_quotas {
            get {
                return this.file_volume_quotasField;
            }
            set {
                this.file_volume_quotasField = value;
            }
        }
        public EntityStateBoolType file_supports_sparse_files {
            get {
                return this.file_supports_sparse_filesField;
            }
            set {
                this.file_supports_sparse_filesField = value;
            }
        }
        public EntityStateBoolType file_supports_reparse_points {
            get {
                return this.file_supports_reparse_pointsField;
            }
            set {
                this.file_supports_reparse_pointsField = value;
            }
        }
        public EntityStateBoolType file_supports_remote_storage {
            get {
                return this.file_supports_remote_storageField;
            }
            set {
                this.file_supports_remote_storageField = value;
            }
        }
        public EntityStateBoolType file_volume_is_compressed {
            get {
                return this.file_volume_is_compressedField;
            }
            set {
                this.file_volume_is_compressedField = value;
            }
        }
        public EntityStateBoolType file_supports_object_ids {
            get {
                return this.file_supports_object_idsField;
            }
            set {
                this.file_supports_object_idsField = value;
            }
        }
        public EntityStateBoolType file_supports_encryption {
            get {
                return this.file_supports_encryptionField;
            }
            set {
                this.file_supports_encryptionField = value;
            }
        }
        public EntityStateBoolType file_named_streams {
            get {
                return this.file_named_streamsField;
            }
            set {
                this.file_named_streamsField = value;
            }
        }
        public EntityStateBoolType file_read_only_volume {
            get {
                return this.file_read_only_volumeField;
            }
            set {
                this.file_read_only_volumeField = value;
            }
        }
        public EntityStateBoolType file_sequential_write_once {
            get {
                return this.file_sequential_write_onceField;
            }
            set {
                this.file_sequential_write_onceField = value;
            }
        }
        public EntityStateBoolType file_supports_transactions {
            get {
                return this.file_supports_transactionsField;
            }
            set {
                this.file_supports_transactionsField = value;
            }
        }
        public EntityStateBoolType file_supports_hard_links {
            get {
                return this.file_supports_hard_linksField;
            }
            set {
                this.file_supports_hard_linksField = value;
            }
        }
        public EntityStateBoolType file_supports_extended_attributes {
            get {
                return this.file_supports_extended_attributesField;
            }
            set {
                this.file_supports_extended_attributesField = value;
            }
        }
        public EntityStateBoolType file_supports_open_by_file_id {
            get {
                return this.file_supports_open_by_file_idField;
            }
            set {
                this.file_supports_open_by_file_idField = value;
            }
        }
        public EntityStateBoolType file_supports_usn_journal {
            get {
                return this.file_supports_usn_journalField;
            }
            set {
                this.file_supports_usn_journalField = value;
            }
        }
    }

}

