using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#windows")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#windows", IsNullable=false)]
    public class peheader_state : StateType {
        private EntityStateStringType filepathField;
        private EntityStateStringType pathField;
        private EntityStateStringType filenameField;
        private EntityStateStringType header_signatureField;
        private EntityStatePeTargetMachineType target_machine_typeField;
        private EntityStateIntType number_of_sectionsField;
        private EntityStateIntType time_date_stampField;
        private EntityStateIntType pointer_to_symbol_tableField;
        private EntityStateIntType number_of_symbolsField;
        private EntityStateIntType size_of_optional_headerField;
        private EntityStateBoolType image_file_relocs_strippedField;
        private EntityStateBoolType image_file_executable_imageField;
        private EntityStateBoolType image_file_line_nums_strippedField;
        private EntityStateBoolType image_file_local_syms_strippedField;
        private EntityStateBoolType image_file_aggresive_ws_trimField;
        private EntityStateBoolType image_file_large_address_awareField;
        private EntityStateBoolType image_file_16bit_machineField;
        private EntityStateBoolType image_file_bytes_reversed_loField;
        private EntityStateBoolType image_file_32bit_machineField;
        private EntityStateBoolType image_file_debug_strippedField;
        private EntityStateBoolType image_file_removable_run_from_swapField;
        private EntityStateBoolType image_file_systemField;
        private EntityStateBoolType image_file_dllField;
        private EntityStateBoolType image_file_up_system_onlyField;
        private EntityStateBoolType image_file_bytes_reveresed_hiField;
        private EntityStateIntType magic_numberField;
        private EntityStateIntType major_linker_versionField;
        private EntityStateIntType minor_linker_versionField;
        private EntityStateIntType size_of_codeField;
        private EntityStateIntType size_of_initialized_dataField;
        private EntityStateIntType size_of_uninitialized_dataField;
        private EntityStateIntType address_of_entry_pointField;
        private EntityStateIntType base_of_codeField;
        private EntityStateIntType base_of_dataField;
        private EntityStateIntType image_base_addressField;
        private EntityStateIntType section_alignmentField;
        private EntityStateIntType file_alignmentField;
        private EntityStateIntType major_operating_system_versionField;
        private EntityStateIntType minor_operating_system_versionField;
        private EntityStateIntType major_image_versionField;
        private EntityStateIntType minor_image_versionField;
        private EntityStateIntType major_subsystem_versionField;
        private EntityStateIntType minor_susbsystem_versionField;
        private EntityStateIntType size_of_imageField;
        private EntityStateIntType size_of_headersField;
        private EntityStateIntType checksumField;
        private EntityStatePeSubsystemType subsystemField;
        private EntityStateIntType dll_characteristicsField;
        private EntityStateIntType size_of_stack_reserveField;
        private EntityStateIntType size_of_stack_commitField;
        private EntityStateIntType size_of_heap_reserveField;
        private EntityStateIntType size_of_heap_commitField;
        private EntityStateIntType loader_flagsField;
        private EntityStateIntType number_of_rva_and_sizesField;
        private EntityStateIntType real_number_of_directory_entriesField;
        private EntityStateWindowsViewType1 windows_viewField;
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
        public EntityStateStringType header_signature {
            get {
                return this.header_signatureField;
            }
            set {
                this.header_signatureField = value;
            }
        }
        public EntityStatePeTargetMachineType target_machine_type {
            get {
                return this.target_machine_typeField;
            }
            set {
                this.target_machine_typeField = value;
            }
        }
        public EntityStateIntType number_of_sections {
            get {
                return this.number_of_sectionsField;
            }
            set {
                this.number_of_sectionsField = value;
            }
        }
        public EntityStateIntType time_date_stamp {
            get {
                return this.time_date_stampField;
            }
            set {
                this.time_date_stampField = value;
            }
        }
        public EntityStateIntType pointer_to_symbol_table {
            get {
                return this.pointer_to_symbol_tableField;
            }
            set {
                this.pointer_to_symbol_tableField = value;
            }
        }
        public EntityStateIntType number_of_symbols {
            get {
                return this.number_of_symbolsField;
            }
            set {
                this.number_of_symbolsField = value;
            }
        }
        public EntityStateIntType size_of_optional_header {
            get {
                return this.size_of_optional_headerField;
            }
            set {
                this.size_of_optional_headerField = value;
            }
        }
        // CODEGEN Warning: DefaultValue attribute on members of type EntityStateBoolType is not supported in this version of the .Net Framework.
        // CODEGEN Warning: 'default' attribute supported only for primitive types.  Ignoring default='false' attribute.
        public EntityStateBoolType image_file_relocs_stripped {
            get {
                return this.image_file_relocs_strippedField;
            }
            set {
                this.image_file_relocs_strippedField = value;
            }
        }
        // CODEGEN Warning: DefaultValue attribute on members of type EntityStateBoolType is not supported in this version of the .Net Framework.
        // CODEGEN Warning: 'default' attribute supported only for primitive types.  Ignoring default='false' attribute.
        public EntityStateBoolType image_file_executable_image {
            get {
                return this.image_file_executable_imageField;
            }
            set {
                this.image_file_executable_imageField = value;
            }
        }
        // CODEGEN Warning: DefaultValue attribute on members of type EntityStateBoolType is not supported in this version of the .Net Framework.
        // CODEGEN Warning: 'default' attribute supported only for primitive types.  Ignoring default='false' attribute.
        public EntityStateBoolType image_file_line_nums_stripped {
            get {
                return this.image_file_line_nums_strippedField;
            }
            set {
                this.image_file_line_nums_strippedField = value;
            }
        }
        // CODEGEN Warning: DefaultValue attribute on members of type EntityStateBoolType is not supported in this version of the .Net Framework.
        // CODEGEN Warning: 'default' attribute supported only for primitive types.  Ignoring default='false' attribute.
        public EntityStateBoolType image_file_local_syms_stripped {
            get {
                return this.image_file_local_syms_strippedField;
            }
            set {
                this.image_file_local_syms_strippedField = value;
            }
        }
        // CODEGEN Warning: DefaultValue attribute on members of type EntityStateBoolType is not supported in this version of the .Net Framework.
        // CODEGEN Warning: 'default' attribute supported only for primitive types.  Ignoring default='false' attribute.
        public EntityStateBoolType image_file_aggresive_ws_trim {
            get {
                return this.image_file_aggresive_ws_trimField;
            }
            set {
                this.image_file_aggresive_ws_trimField = value;
            }
        }
        // CODEGEN Warning: DefaultValue attribute on members of type EntityStateBoolType is not supported in this version of the .Net Framework.
        // CODEGEN Warning: 'default' attribute supported only for primitive types.  Ignoring default='false' attribute.
        public EntityStateBoolType image_file_large_address_aware {
            get {
                return this.image_file_large_address_awareField;
            }
            set {
                this.image_file_large_address_awareField = value;
            }
        }
        // CODEGEN Warning: DefaultValue attribute on members of type EntityStateBoolType is not supported in this version of the .Net Framework.
        // CODEGEN Warning: 'default' attribute supported only for primitive types.  Ignoring default='false' attribute.
        public EntityStateBoolType image_file_16bit_machine {
            get {
                return this.image_file_16bit_machineField;
            }
            set {
                this.image_file_16bit_machineField = value;
            }
        }
        // CODEGEN Warning: DefaultValue attribute on members of type EntityStateBoolType is not supported in this version of the .Net Framework.
        // CODEGEN Warning: 'default' attribute supported only for primitive types.  Ignoring default='false' attribute.
        public EntityStateBoolType image_file_bytes_reversed_lo {
            get {
                return this.image_file_bytes_reversed_loField;
            }
            set {
                this.image_file_bytes_reversed_loField = value;
            }
        }
        // CODEGEN Warning: DefaultValue attribute on members of type EntityStateBoolType is not supported in this version of the .Net Framework.
        // CODEGEN Warning: 'default' attribute supported only for primitive types.  Ignoring default='false' attribute.
        public EntityStateBoolType image_file_32bit_machine {
            get {
                return this.image_file_32bit_machineField;
            }
            set {
                this.image_file_32bit_machineField = value;
            }
        }
        // CODEGEN Warning: DefaultValue attribute on members of type EntityStateBoolType is not supported in this version of the .Net Framework.
        // CODEGEN Warning: 'default' attribute supported only for primitive types.  Ignoring default='false' attribute.
        public EntityStateBoolType image_file_debug_stripped {
            get {
                return this.image_file_debug_strippedField;
            }
            set {
                this.image_file_debug_strippedField = value;
            }
        }
        // CODEGEN Warning: DefaultValue attribute on members of type EntityStateBoolType is not supported in this version of the .Net Framework.
        // CODEGEN Warning: 'default' attribute supported only for primitive types.  Ignoring default='false' attribute.
        public EntityStateBoolType image_file_removable_run_from_swap {
            get {
                return this.image_file_removable_run_from_swapField;
            }
            set {
                this.image_file_removable_run_from_swapField = value;
            }
        }
        // CODEGEN Warning: DefaultValue attribute on members of type EntityStateBoolType is not supported in this version of the .Net Framework.
        // CODEGEN Warning: 'default' attribute supported only for primitive types.  Ignoring default='false' attribute.
        public EntityStateBoolType image_file_system {
            get {
                return this.image_file_systemField;
            }
            set {
                this.image_file_systemField = value;
            }
        }
        // CODEGEN Warning: DefaultValue attribute on members of type EntityStateBoolType is not supported in this version of the .Net Framework.
        // CODEGEN Warning: 'default' attribute supported only for primitive types.  Ignoring default='false' attribute.
        public EntityStateBoolType image_file_dll {
            get {
                return this.image_file_dllField;
            }
            set {
                this.image_file_dllField = value;
            }
        }
        // CODEGEN Warning: DefaultValue attribute on members of type EntityStateBoolType is not supported in this version of the .Net Framework.
        // CODEGEN Warning: 'default' attribute supported only for primitive types.  Ignoring default='false' attribute.
        public EntityStateBoolType image_file_up_system_only {
            get {
                return this.image_file_up_system_onlyField;
            }
            set {
                this.image_file_up_system_onlyField = value;
            }
        }
        // CODEGEN Warning: DefaultValue attribute on members of type EntityStateBoolType is not supported in this version of the .Net Framework.
        // CODEGEN Warning: 'default' attribute supported only for primitive types.  Ignoring default='false' attribute.
        public EntityStateBoolType image_file_bytes_reveresed_hi {
            get {
                return this.image_file_bytes_reveresed_hiField;
            }
            set {
                this.image_file_bytes_reveresed_hiField = value;
            }
        }
        public EntityStateIntType magic_number {
            get {
                return this.magic_numberField;
            }
            set {
                this.magic_numberField = value;
            }
        }
        public EntityStateIntType major_linker_version {
            get {
                return this.major_linker_versionField;
            }
            set {
                this.major_linker_versionField = value;
            }
        }
        public EntityStateIntType minor_linker_version {
            get {
                return this.minor_linker_versionField;
            }
            set {
                this.minor_linker_versionField = value;
            }
        }
        public EntityStateIntType size_of_code {
            get {
                return this.size_of_codeField;
            }
            set {
                this.size_of_codeField = value;
            }
        }
        public EntityStateIntType size_of_initialized_data {
            get {
                return this.size_of_initialized_dataField;
            }
            set {
                this.size_of_initialized_dataField = value;
            }
        }
        public EntityStateIntType size_of_uninitialized_data {
            get {
                return this.size_of_uninitialized_dataField;
            }
            set {
                this.size_of_uninitialized_dataField = value;
            }
        }
        public EntityStateIntType address_of_entry_point {
            get {
                return this.address_of_entry_pointField;
            }
            set {
                this.address_of_entry_pointField = value;
            }
        }
        public EntityStateIntType base_of_code {
            get {
                return this.base_of_codeField;
            }
            set {
                this.base_of_codeField = value;
            }
        }
        public EntityStateIntType base_of_data {
            get {
                return this.base_of_dataField;
            }
            set {
                this.base_of_dataField = value;
            }
        }
        public EntityStateIntType image_base_address {
            get {
                return this.image_base_addressField;
            }
            set {
                this.image_base_addressField = value;
            }
        }
        public EntityStateIntType section_alignment {
            get {
                return this.section_alignmentField;
            }
            set {
                this.section_alignmentField = value;
            }
        }
        public EntityStateIntType file_alignment {
            get {
                return this.file_alignmentField;
            }
            set {
                this.file_alignmentField = value;
            }
        }
        public EntityStateIntType major_operating_system_version {
            get {
                return this.major_operating_system_versionField;
            }
            set {
                this.major_operating_system_versionField = value;
            }
        }
        public EntityStateIntType minor_operating_system_version {
            get {
                return this.minor_operating_system_versionField;
            }
            set {
                this.minor_operating_system_versionField = value;
            }
        }
        public EntityStateIntType major_image_version {
            get {
                return this.major_image_versionField;
            }
            set {
                this.major_image_versionField = value;
            }
        }
        public EntityStateIntType minor_image_version {
            get {
                return this.minor_image_versionField;
            }
            set {
                this.minor_image_versionField = value;
            }
        }
        public EntityStateIntType major_subsystem_version {
            get {
                return this.major_subsystem_versionField;
            }
            set {
                this.major_subsystem_versionField = value;
            }
        }
        public EntityStateIntType minor_susbsystem_version {
            get {
                return this.minor_susbsystem_versionField;
            }
            set {
                this.minor_susbsystem_versionField = value;
            }
        }
        public EntityStateIntType size_of_image {
            get {
                return this.size_of_imageField;
            }
            set {
                this.size_of_imageField = value;
            }
        }
        public EntityStateIntType size_of_headers {
            get {
                return this.size_of_headersField;
            }
            set {
                this.size_of_headersField = value;
            }
        }
        public EntityStateIntType checksum {
            get {
                return this.checksumField;
            }
            set {
                this.checksumField = value;
            }
        }
        public EntityStatePeSubsystemType subsystem {
            get {
                return this.subsystemField;
            }
            set {
                this.subsystemField = value;
            }
        }
        public EntityStateIntType dll_characteristics {
            get {
                return this.dll_characteristicsField;
            }
            set {
                this.dll_characteristicsField = value;
            }
        }
        public EntityStateIntType size_of_stack_reserve {
            get {
                return this.size_of_stack_reserveField;
            }
            set {
                this.size_of_stack_reserveField = value;
            }
        }
        public EntityStateIntType size_of_stack_commit {
            get {
                return this.size_of_stack_commitField;
            }
            set {
                this.size_of_stack_commitField = value;
            }
        }
        public EntityStateIntType size_of_heap_reserve {
            get {
                return this.size_of_heap_reserveField;
            }
            set {
                this.size_of_heap_reserveField = value;
            }
        }
        public EntityStateIntType size_of_heap_commit {
            get {
                return this.size_of_heap_commitField;
            }
            set {
                this.size_of_heap_commitField = value;
            }
        }
        public EntityStateIntType loader_flags {
            get {
                return this.loader_flagsField;
            }
            set {
                this.loader_flagsField = value;
            }
        }
        public EntityStateIntType number_of_rva_and_sizes {
            get {
                return this.number_of_rva_and_sizesField;
            }
            set {
                this.number_of_rva_and_sizesField = value;
            }
        }
        public EntityStateIntType real_number_of_directory_entries {
            get {
                return this.real_number_of_directory_entriesField;
            }
            set {
                this.real_number_of_directory_entriesField = value;
            }
        }
        public EntityStateWindowsViewType1 windows_view {
            get {
                return this.windows_viewField;
            }
            set {
                this.windows_viewField = value;
            }
        }
    }

}

