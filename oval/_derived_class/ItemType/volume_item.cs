using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#windows")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#windows", IsNullable=false)]
    public class volume_item : ItemType {
        private EntityItemStringType rootpathField;
        private EntityItemStringType file_systemField;
        private EntityItemStringType nameField;
        private EntityItemDriveTypeType drive_typeField;
        private EntityItemIntType volume_max_component_lengthField;
        private EntityItemIntType serial_numberField;
        private EntityItemBoolType file_case_sensitive_searchField;
        private EntityItemBoolType file_case_preserved_namesField;
        private EntityItemBoolType file_unicode_on_diskField;
        private EntityItemBoolType file_persistent_aclsField;
        private EntityItemBoolType file_file_compressionField;
        private EntityItemBoolType file_volume_quotasField;
        private EntityItemBoolType file_supports_sparse_filesField;
        private EntityItemBoolType file_supports_reparse_pointsField;
        private EntityItemBoolType file_supports_remote_storageField;
        private EntityItemBoolType file_volume_is_compressedField;
        private EntityItemBoolType file_supports_object_idsField;
        private EntityItemBoolType file_supports_encryptionField;
        private EntityItemBoolType file_named_streamsField;
        private EntityItemBoolType file_read_only_volumeField;
        private EntityItemBoolType file_sequential_write_onceField;
        private EntityItemBoolType file_supports_transactionsField;
        private EntityItemBoolType file_supports_hard_linksField;
        private EntityItemBoolType file_supports_extended_attributesField;
        private EntityItemBoolType file_supports_open_by_file_idField;
        private EntityItemBoolType file_supports_usn_journalField;
        public EntityItemStringType rootpath {
            get {
                return this.rootpathField;
            }
            set {
                this.rootpathField = value;
            }
        }
        public EntityItemStringType file_system {
            get {
                return this.file_systemField;
            }
            set {
                this.file_systemField = value;
            }
        }
        public EntityItemStringType name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        public EntityItemDriveTypeType drive_type {
            get {
                return this.drive_typeField;
            }
            set {
                this.drive_typeField = value;
            }
        }
        public EntityItemIntType volume_max_component_length {
            get {
                return this.volume_max_component_lengthField;
            }
            set {
                this.volume_max_component_lengthField = value;
            }
        }
        public EntityItemIntType serial_number {
            get {
                return this.serial_numberField;
            }
            set {
                this.serial_numberField = value;
            }
        }
        public EntityItemBoolType file_case_sensitive_search {
            get {
                return this.file_case_sensitive_searchField;
            }
            set {
                this.file_case_sensitive_searchField = value;
            }
        }
        public EntityItemBoolType file_case_preserved_names {
            get {
                return this.file_case_preserved_namesField;
            }
            set {
                this.file_case_preserved_namesField = value;
            }
        }
        public EntityItemBoolType file_unicode_on_disk {
            get {
                return this.file_unicode_on_diskField;
            }
            set {
                this.file_unicode_on_diskField = value;
            }
        }
        public EntityItemBoolType file_persistent_acls {
            get {
                return this.file_persistent_aclsField;
            }
            set {
                this.file_persistent_aclsField = value;
            }
        }
        public EntityItemBoolType file_file_compression {
            get {
                return this.file_file_compressionField;
            }
            set {
                this.file_file_compressionField = value;
            }
        }
        public EntityItemBoolType file_volume_quotas {
            get {
                return this.file_volume_quotasField;
            }
            set {
                this.file_volume_quotasField = value;
            }
        }
        public EntityItemBoolType file_supports_sparse_files {
            get {
                return this.file_supports_sparse_filesField;
            }
            set {
                this.file_supports_sparse_filesField = value;
            }
        }
        public EntityItemBoolType file_supports_reparse_points {
            get {
                return this.file_supports_reparse_pointsField;
            }
            set {
                this.file_supports_reparse_pointsField = value;
            }
        }
        public EntityItemBoolType file_supports_remote_storage {
            get {
                return this.file_supports_remote_storageField;
            }
            set {
                this.file_supports_remote_storageField = value;
            }
        }
        public EntityItemBoolType file_volume_is_compressed {
            get {
                return this.file_volume_is_compressedField;
            }
            set {
                this.file_volume_is_compressedField = value;
            }
        }
        public EntityItemBoolType file_supports_object_ids {
            get {
                return this.file_supports_object_idsField;
            }
            set {
                this.file_supports_object_idsField = value;
            }
        }
        public EntityItemBoolType file_supports_encryption {
            get {
                return this.file_supports_encryptionField;
            }
            set {
                this.file_supports_encryptionField = value;
            }
        }
        public EntityItemBoolType file_named_streams {
            get {
                return this.file_named_streamsField;
            }
            set {
                this.file_named_streamsField = value;
            }
        }
        public EntityItemBoolType file_read_only_volume {
            get {
                return this.file_read_only_volumeField;
            }
            set {
                this.file_read_only_volumeField = value;
            }
        }
        public EntityItemBoolType file_sequential_write_once {
            get {
                return this.file_sequential_write_onceField;
            }
            set {
                this.file_sequential_write_onceField = value;
            }
        }
        public EntityItemBoolType file_supports_transactions {
            get {
                return this.file_supports_transactionsField;
            }
            set {
                this.file_supports_transactionsField = value;
            }
        }
        public EntityItemBoolType file_supports_hard_links {
            get {
                return this.file_supports_hard_linksField;
            }
            set {
                this.file_supports_hard_linksField = value;
            }
        }
        public EntityItemBoolType file_supports_extended_attributes {
            get {
                return this.file_supports_extended_attributesField;
            }
            set {
                this.file_supports_extended_attributesField = value;
            }
        }
        public EntityItemBoolType file_supports_open_by_file_id {
            get {
                return this.file_supports_open_by_file_idField;
            }
            set {
                this.file_supports_open_by_file_idField = value;
            }
        }
        public EntityItemBoolType file_supports_usn_journal {
            get {
                return this.file_supports_usn_journalField;
            }
            set {
                this.file_supports_usn_journalField = value;
            }
        }
    }

}

