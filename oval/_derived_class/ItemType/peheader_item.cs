using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#windows")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#windows", IsNullable=false)]
    public class peheader_item : ItemType {
        private EntityItemStringType filepathField;
        private EntityItemStringType pathField;
        private EntityItemStringType filenameField;
        private EntityItemStringType header_signatureField;
        private EntityItemPeTargetMachineType target_machine_typeField;
        private EntityItemIntType number_of_sectionsField;
        private EntityItemIntType time_date_stampField;
        private EntityItemIntType pointer_to_symbol_tableField;
        private EntityItemIntType number_of_symbolsField;
        private EntityItemIntType size_of_optional_headerField;
        private EntityItemBoolType image_file_relocs_strippedField;
        private EntityItemBoolType image_file_executable_imageField;
        private EntityItemBoolType image_file_line_nums_strippedField;
        private EntityItemBoolType image_file_local_syms_strippedField;
        private EntityItemBoolType image_file_aggresive_ws_trimField;
        private EntityItemBoolType image_file_large_address_awareField;
        private EntityItemBoolType image_file_16bit_machineField;
        private EntityItemBoolType image_file_bytes_reversed_loField;
        private EntityItemBoolType image_file_32bit_machineField;
        private EntityItemBoolType image_file_debug_strippedField;
        private EntityItemBoolType image_file_removable_run_from_swapField;
        private EntityItemBoolType image_file_systemField;
        private EntityItemBoolType image_file_dllField;
        private EntityItemBoolType image_file_up_system_onlyField;
        private EntityItemBoolType image_file_bytes_reveresed_hiField;
        private EntityItemIntType magic_numberField;
        private EntityItemIntType major_linker_versionField;
        private EntityItemIntType minor_linker_versionField;
        private EntityItemIntType size_of_codeField;
        private EntityItemIntType size_of_initialized_dataField;
        private EntityItemIntType size_of_uninitialized_dataField;
        private EntityItemIntType address_of_entry_pointField;
        private EntityItemIntType base_of_codeField;
        private EntityItemIntType base_of_dataField;
        private EntityItemIntType image_base_addressField;
        private EntityItemIntType section_alignmentField;
        private EntityItemIntType file_alignmentField;
        private EntityItemIntType major_operating_system_versionField;
        private EntityItemIntType minor_operating_system_versionField;
        private EntityItemIntType major_image_versionField;
        private EntityItemIntType minor_image_versionField;
        private EntityItemIntType major_subsystem_versionField;
        private EntityItemIntType minor_susbsystem_versionField;
        private EntityItemIntType size_of_imageField;
        private EntityItemIntType size_of_headersField;
        private EntityItemIntType checksumField;
        private EntityItemPeSubsystemType subsystemField;
        private EntityItemIntType[] dll_characteristicsField;
        private EntityItemIntType size_of_stack_reserveField;
        private EntityItemIntType size_of_stack_commitField;
        private EntityItemIntType size_of_heap_reserveField;
        private EntityItemIntType size_of_heap_commitField;
        private EntityItemIntType loader_flagsField;
        private EntityItemIntType number_of_rva_and_sizesField;
        private EntityItemIntType real_number_of_directory_entriesField;
        private EntityItemWindowsViewType1 windows_viewField;
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
        public EntityItemStringType filename {
            get {
                return this.filenameField;
            }
            set {
                this.filenameField = value;
            }
        }
        public EntityItemStringType header_signature {
            get {
                return this.header_signatureField;
            }
            set {
                this.header_signatureField = value;
            }
        }
        public EntityItemPeTargetMachineType target_machine_type {
            get {
                return this.target_machine_typeField;
            }
            set {
                this.target_machine_typeField = value;
            }
        }
        public EntityItemIntType number_of_sections {
            get {
                return this.number_of_sectionsField;
            }
            set {
                this.number_of_sectionsField = value;
            }
        }
        public EntityItemIntType time_date_stamp {
            get {
                return this.time_date_stampField;
            }
            set {
                this.time_date_stampField = value;
            }
        }
        public EntityItemIntType pointer_to_symbol_table {
            get {
                return this.pointer_to_symbol_tableField;
            }
            set {
                this.pointer_to_symbol_tableField = value;
            }
        }
        public EntityItemIntType number_of_symbols {
            get {
                return this.number_of_symbolsField;
            }
            set {
                this.number_of_symbolsField = value;
            }
        }
        public EntityItemIntType size_of_optional_header {
            get {
                return this.size_of_optional_headerField;
            }
            set {
                this.size_of_optional_headerField = value;
            }
        }
        // CODEGEN Warning: DefaultValue attribute on members of type EntityItemBoolType is not supported in this version of the .Net Framework.
        // CODEGEN Warning: 'default' attribute supported only for primitive types.  Ignoring default='false' attribute.
        public EntityItemBoolType image_file_relocs_stripped {
            get {
                return this.image_file_relocs_strippedField;
            }
            set {
                this.image_file_relocs_strippedField = value;
            }
        }
        // CODEGEN Warning: DefaultValue attribute on members of type EntityItemBoolType is not supported in this version of the .Net Framework.
        // CODEGEN Warning: 'default' attribute supported only for primitive types.  Ignoring default='false' attribute.
        public EntityItemBoolType image_file_executable_image {
            get {
                return this.image_file_executable_imageField;
            }
            set {
                this.image_file_executable_imageField = value;
            }
        }
        // CODEGEN Warning: DefaultValue attribute on members of type EntityItemBoolType is not supported in this version of the .Net Framework.
        // CODEGEN Warning: 'default' attribute supported only for primitive types.  Ignoring default='false' attribute.
        public EntityItemBoolType image_file_line_nums_stripped {
            get {
                return this.image_file_line_nums_strippedField;
            }
            set {
                this.image_file_line_nums_strippedField = value;
            }
        }
        // CODEGEN Warning: DefaultValue attribute on members of type EntityItemBoolType is not supported in this version of the .Net Framework.
        // CODEGEN Warning: 'default' attribute supported only for primitive types.  Ignoring default='false' attribute.
        public EntityItemBoolType image_file_local_syms_stripped {
            get {
                return this.image_file_local_syms_strippedField;
            }
            set {
                this.image_file_local_syms_strippedField = value;
            }
        }
        // CODEGEN Warning: DefaultValue attribute on members of type EntityItemBoolType is not supported in this version of the .Net Framework.
        // CODEGEN Warning: 'default' attribute supported only for primitive types.  Ignoring default='false' attribute.
        public EntityItemBoolType image_file_aggresive_ws_trim {
            get {
                return this.image_file_aggresive_ws_trimField;
            }
            set {
                this.image_file_aggresive_ws_trimField = value;
            }
        }
        // CODEGEN Warning: DefaultValue attribute on members of type EntityItemBoolType is not supported in this version of the .Net Framework.
        // CODEGEN Warning: 'default' attribute supported only for primitive types.  Ignoring default='false' attribute.
        public EntityItemBoolType image_file_large_address_aware {
            get {
                return this.image_file_large_address_awareField;
            }
            set {
                this.image_file_large_address_awareField = value;
            }
        }
        // CODEGEN Warning: DefaultValue attribute on members of type EntityItemBoolType is not supported in this version of the .Net Framework.
        // CODEGEN Warning: 'default' attribute supported only for primitive types.  Ignoring default='false' attribute.
        public EntityItemBoolType image_file_16bit_machine {
            get {
                return this.image_file_16bit_machineField;
            }
            set {
                this.image_file_16bit_machineField = value;
            }
        }
        // CODEGEN Warning: DefaultValue attribute on members of type EntityItemBoolType is not supported in this version of the .Net Framework.
        // CODEGEN Warning: 'default' attribute supported only for primitive types.  Ignoring default='false' attribute.
        public EntityItemBoolType image_file_bytes_reversed_lo {
            get {
                return this.image_file_bytes_reversed_loField;
            }
            set {
                this.image_file_bytes_reversed_loField = value;
            }
        }
        // CODEGEN Warning: DefaultValue attribute on members of type EntityItemBoolType is not supported in this version of the .Net Framework.
        // CODEGEN Warning: 'default' attribute supported only for primitive types.  Ignoring default='false' attribute.
        public EntityItemBoolType image_file_32bit_machine {
            get {
                return this.image_file_32bit_machineField;
            }
            set {
                this.image_file_32bit_machineField = value;
            }
        }
        // CODEGEN Warning: DefaultValue attribute on members of type EntityItemBoolType is not supported in this version of the .Net Framework.
        // CODEGEN Warning: 'default' attribute supported only for primitive types.  Ignoring default='false' attribute.
        public EntityItemBoolType image_file_debug_stripped {
            get {
                return this.image_file_debug_strippedField;
            }
            set {
                this.image_file_debug_strippedField = value;
            }
        }
        // CODEGEN Warning: DefaultValue attribute on members of type EntityItemBoolType is not supported in this version of the .Net Framework.
        // CODEGEN Warning: 'default' attribute supported only for primitive types.  Ignoring default='false' attribute.
        public EntityItemBoolType image_file_removable_run_from_swap {
            get {
                return this.image_file_removable_run_from_swapField;
            }
            set {
                this.image_file_removable_run_from_swapField = value;
            }
        }
        // CODEGEN Warning: DefaultValue attribute on members of type EntityItemBoolType is not supported in this version of the .Net Framework.
        // CODEGEN Warning: 'default' attribute supported only for primitive types.  Ignoring default='false' attribute.
        public EntityItemBoolType image_file_system {
            get {
                return this.image_file_systemField;
            }
            set {
                this.image_file_systemField = value;
            }
        }
        // CODEGEN Warning: DefaultValue attribute on members of type EntityItemBoolType is not supported in this version of the .Net Framework.
        // CODEGEN Warning: 'default' attribute supported only for primitive types.  Ignoring default='false' attribute.
        public EntityItemBoolType image_file_dll {
            get {
                return this.image_file_dllField;
            }
            set {
                this.image_file_dllField = value;
            }
        }
        // CODEGEN Warning: DefaultValue attribute on members of type EntityItemBoolType is not supported in this version of the .Net Framework.
        // CODEGEN Warning: 'default' attribute supported only for primitive types.  Ignoring default='false' attribute.
        public EntityItemBoolType image_file_up_system_only {
            get {
                return this.image_file_up_system_onlyField;
            }
            set {
                this.image_file_up_system_onlyField = value;
            }
        }
        // CODEGEN Warning: DefaultValue attribute on members of type EntityItemBoolType is not supported in this version of the .Net Framework.
        // CODEGEN Warning: 'default' attribute supported only for primitive types.  Ignoring default='false' attribute.
        public EntityItemBoolType image_file_bytes_reveresed_hi {
            get {
                return this.image_file_bytes_reveresed_hiField;
            }
            set {
                this.image_file_bytes_reveresed_hiField = value;
            }
        }
        public EntityItemIntType magic_number {
            get {
                return this.magic_numberField;
            }
            set {
                this.magic_numberField = value;
            }
        }
        public EntityItemIntType major_linker_version {
            get {
                return this.major_linker_versionField;
            }
            set {
                this.major_linker_versionField = value;
            }
        }
        public EntityItemIntType minor_linker_version {
            get {
                return this.minor_linker_versionField;
            }
            set {
                this.minor_linker_versionField = value;
            }
        }
        public EntityItemIntType size_of_code {
            get {
                return this.size_of_codeField;
            }
            set {
                this.size_of_codeField = value;
            }
        }
        public EntityItemIntType size_of_initialized_data {
            get {
                return this.size_of_initialized_dataField;
            }
            set {
                this.size_of_initialized_dataField = value;
            }
        }
        public EntityItemIntType size_of_uninitialized_data {
            get {
                return this.size_of_uninitialized_dataField;
            }
            set {
                this.size_of_uninitialized_dataField = value;
            }
        }
        public EntityItemIntType address_of_entry_point {
            get {
                return this.address_of_entry_pointField;
            }
            set {
                this.address_of_entry_pointField = value;
            }
        }
        public EntityItemIntType base_of_code {
            get {
                return this.base_of_codeField;
            }
            set {
                this.base_of_codeField = value;
            }
        }
        public EntityItemIntType base_of_data {
            get {
                return this.base_of_dataField;
            }
            set {
                this.base_of_dataField = value;
            }
        }
        public EntityItemIntType image_base_address {
            get {
                return this.image_base_addressField;
            }
            set {
                this.image_base_addressField = value;
            }
        }
        public EntityItemIntType section_alignment {
            get {
                return this.section_alignmentField;
            }
            set {
                this.section_alignmentField = value;
            }
        }
        public EntityItemIntType file_alignment {
            get {
                return this.file_alignmentField;
            }
            set {
                this.file_alignmentField = value;
            }
        }
        public EntityItemIntType major_operating_system_version {
            get {
                return this.major_operating_system_versionField;
            }
            set {
                this.major_operating_system_versionField = value;
            }
        }
        public EntityItemIntType minor_operating_system_version {
            get {
                return this.minor_operating_system_versionField;
            }
            set {
                this.minor_operating_system_versionField = value;
            }
        }
        public EntityItemIntType major_image_version {
            get {
                return this.major_image_versionField;
            }
            set {
                this.major_image_versionField = value;
            }
        }
        public EntityItemIntType minor_image_version {
            get {
                return this.minor_image_versionField;
            }
            set {
                this.minor_image_versionField = value;
            }
        }
        public EntityItemIntType major_subsystem_version {
            get {
                return this.major_subsystem_versionField;
            }
            set {
                this.major_subsystem_versionField = value;
            }
        }
        public EntityItemIntType minor_susbsystem_version {
            get {
                return this.minor_susbsystem_versionField;
            }
            set {
                this.minor_susbsystem_versionField = value;
            }
        }
        public EntityItemIntType size_of_image {
            get {
                return this.size_of_imageField;
            }
            set {
                this.size_of_imageField = value;
            }
        }
        public EntityItemIntType size_of_headers {
            get {
                return this.size_of_headersField;
            }
            set {
                this.size_of_headersField = value;
            }
        }
        public EntityItemIntType checksum {
            get {
                return this.checksumField;
            }
            set {
                this.checksumField = value;
            }
        }
        public EntityItemPeSubsystemType subsystem {
            get {
                return this.subsystemField;
            }
            set {
                this.subsystemField = value;
            }
        }
        [XmlElementAttribute("dll_characteristics")]
        public EntityItemIntType[] dll_characteristics {
            get {
                return this.dll_characteristicsField;
            }
            set {
                this.dll_characteristicsField = value;
            }
        }
        public EntityItemIntType size_of_stack_reserve {
            get {
                return this.size_of_stack_reserveField;
            }
            set {
                this.size_of_stack_reserveField = value;
            }
        }
        public EntityItemIntType size_of_stack_commit {
            get {
                return this.size_of_stack_commitField;
            }
            set {
                this.size_of_stack_commitField = value;
            }
        }
        public EntityItemIntType size_of_heap_reserve {
            get {
                return this.size_of_heap_reserveField;
            }
            set {
                this.size_of_heap_reserveField = value;
            }
        }
        public EntityItemIntType size_of_heap_commit {
            get {
                return this.size_of_heap_commitField;
            }
            set {
                this.size_of_heap_commitField = value;
            }
        }
        public EntityItemIntType loader_flags {
            get {
                return this.loader_flagsField;
            }
            set {
                this.loader_flagsField = value;
            }
        }
        public EntityItemIntType number_of_rva_and_sizes {
            get {
                return this.number_of_rva_and_sizesField;
            }
            set {
                this.number_of_rva_and_sizesField = value;
            }
        }
        public EntityItemIntType real_number_of_directory_entries {
            get {
                return this.real_number_of_directory_entriesField;
            }
            set {
                this.real_number_of_directory_entriesField = value;
            }
        }
        public EntityItemWindowsViewType1 windows_view {
            get {
                return this.windows_viewField;
            }
            set {
                this.windows_viewField = value;
            }
        }
    }

}

