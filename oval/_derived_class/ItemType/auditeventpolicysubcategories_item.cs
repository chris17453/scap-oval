using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#windows")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#windows", IsNullable=false)]
    public class auditeventpolicysubcategories_item : ItemType {
        private EntityItemAuditType credential_validationField;
        private EntityItemAuditType kerberos_authentication_serviceField;
        private EntityItemAuditType kerberos_service_ticket_operationsField;
        private EntityItemAuditType kerberos_ticket_eventsField;
        private EntityItemAuditType other_account_logon_eventsField;
        private EntityItemAuditType application_group_managementField;
        private EntityItemAuditType computer_account_managementField;
        private EntityItemAuditType distribution_group_managementField;
        private EntityItemAuditType other_account_management_eventsField;
        private EntityItemAuditType security_group_managementField;
        private EntityItemAuditType user_account_managementField;
        private EntityItemAuditType dpapi_activityField;
        private EntityItemAuditType process_creationField;
        private EntityItemAuditType process_terminationField;
        private EntityItemAuditType rpc_eventsField;
        private EntityItemAuditType directory_service_accessField;
        private EntityItemAuditType directory_service_changesField;
        private EntityItemAuditType directory_service_replicationField;
        private EntityItemAuditType detailed_directory_service_replicationField;
        private EntityItemAuditType account_lockoutField;
        private EntityItemAuditType ipsec_extended_modeField;
        private EntityItemAuditType ipsec_main_modeField;
        private EntityItemAuditType ipsec_quick_modeField;
        private EntityItemAuditType logoffField;
        private EntityItemAuditType logonField;
        private EntityItemAuditType network_policy_serverField;
        private EntityItemAuditType other_logon_logoff_eventsField;
        private EntityItemAuditType special_logonField;
        private EntityItemAuditType logon_claimsField;
        private EntityItemAuditType application_generatedField;
        private EntityItemAuditType certification_servicesField;
        private EntityItemAuditType detailed_file_shareField;
        private EntityItemAuditType file_shareField;
        private EntityItemAuditType file_systemField;
        private EntityItemAuditType filtering_platform_connectionField;
        private EntityItemAuditType filtering_platform_packet_dropField;
        private EntityItemAuditType handle_manipulationField;
        private EntityItemAuditType kernel_objectField;
        private EntityItemAuditType other_object_access_eventsField;
        private EntityItemAuditType registryField;
        private EntityItemAuditType samField;
        private EntityItemAuditType removable_storageField;
        private EntityItemAuditType central_access_policy_stagingField;
        private EntityItemAuditType audit_policy_changeField;
        private EntityItemAuditType authentication_policy_changeField;
        private EntityItemAuditType authorization_policy_changeField;
        private EntityItemAuditType filtering_platform_policy_changeField;
        private EntityItemAuditType mpssvc_rule_level_policy_changeField;
        private EntityItemAuditType other_policy_change_eventsField;
        private EntityItemAuditType non_sensitive_privilege_useField;
        private EntityItemAuditType other_privilege_use_eventsField;
        private EntityItemAuditType sensitive_privilege_useField;
        private EntityItemAuditType ipsec_driverField;
        private EntityItemAuditType other_system_eventsField;
        private EntityItemAuditType security_state_changeField;
        private EntityItemAuditType security_system_extensionField;
        private EntityItemAuditType system_integrityField;
        private EntityItemAuditType group_membershipField;
        private EntityItemAuditType pnp_activityField;
        private EntityItemAuditType user_device_claimsField;
        private EntityItemAuditType audit_detailedtracking_tokenrightadjustedField;
        public EntityItemAuditType credential_validation {
            get {
                return this.credential_validationField;
            }
            set {
                this.credential_validationField = value;
            }
        }
        public EntityItemAuditType kerberos_authentication_service {
            get {
                return this.kerberos_authentication_serviceField;
            }
            set {
                this.kerberos_authentication_serviceField = value;
            }
        }
        public EntityItemAuditType kerberos_service_ticket_operations {
            get {
                return this.kerberos_service_ticket_operationsField;
            }
            set {
                this.kerberos_service_ticket_operationsField = value;
            }
        }
        public EntityItemAuditType kerberos_ticket_events {
            get {
                return this.kerberos_ticket_eventsField;
            }
            set {
                this.kerberos_ticket_eventsField = value;
            }
        }
        public EntityItemAuditType other_account_logon_events {
            get {
                return this.other_account_logon_eventsField;
            }
            set {
                this.other_account_logon_eventsField = value;
            }
        }
        public EntityItemAuditType application_group_management {
            get {
                return this.application_group_managementField;
            }
            set {
                this.application_group_managementField = value;
            }
        }
        public EntityItemAuditType computer_account_management {
            get {
                return this.computer_account_managementField;
            }
            set {
                this.computer_account_managementField = value;
            }
        }
        public EntityItemAuditType distribution_group_management {
            get {
                return this.distribution_group_managementField;
            }
            set {
                this.distribution_group_managementField = value;
            }
        }
        public EntityItemAuditType other_account_management_events {
            get {
                return this.other_account_management_eventsField;
            }
            set {
                this.other_account_management_eventsField = value;
            }
        }
        public EntityItemAuditType security_group_management {
            get {
                return this.security_group_managementField;
            }
            set {
                this.security_group_managementField = value;
            }
        }
        public EntityItemAuditType user_account_management {
            get {
                return this.user_account_managementField;
            }
            set {
                this.user_account_managementField = value;
            }
        }
        public EntityItemAuditType dpapi_activity {
            get {
                return this.dpapi_activityField;
            }
            set {
                this.dpapi_activityField = value;
            }
        }
        public EntityItemAuditType process_creation {
            get {
                return this.process_creationField;
            }
            set {
                this.process_creationField = value;
            }
        }
        public EntityItemAuditType process_termination {
            get {
                return this.process_terminationField;
            }
            set {
                this.process_terminationField = value;
            }
        }
        public EntityItemAuditType rpc_events {
            get {
                return this.rpc_eventsField;
            }
            set {
                this.rpc_eventsField = value;
            }
        }
        public EntityItemAuditType directory_service_access {
            get {
                return this.directory_service_accessField;
            }
            set {
                this.directory_service_accessField = value;
            }
        }
        public EntityItemAuditType directory_service_changes {
            get {
                return this.directory_service_changesField;
            }
            set {
                this.directory_service_changesField = value;
            }
        }
        public EntityItemAuditType directory_service_replication {
            get {
                return this.directory_service_replicationField;
            }
            set {
                this.directory_service_replicationField = value;
            }
        }
        public EntityItemAuditType detailed_directory_service_replication {
            get {
                return this.detailed_directory_service_replicationField;
            }
            set {
                this.detailed_directory_service_replicationField = value;
            }
        }
        public EntityItemAuditType account_lockout {
            get {
                return this.account_lockoutField;
            }
            set {
                this.account_lockoutField = value;
            }
        }
        public EntityItemAuditType ipsec_extended_mode {
            get {
                return this.ipsec_extended_modeField;
            }
            set {
                this.ipsec_extended_modeField = value;
            }
        }
        public EntityItemAuditType ipsec_main_mode {
            get {
                return this.ipsec_main_modeField;
            }
            set {
                this.ipsec_main_modeField = value;
            }
        }
        public EntityItemAuditType ipsec_quick_mode {
            get {
                return this.ipsec_quick_modeField;
            }
            set {
                this.ipsec_quick_modeField = value;
            }
        }
        public EntityItemAuditType logoff {
            get {
                return this.logoffField;
            }
            set {
                this.logoffField = value;
            }
        }
        public EntityItemAuditType logon {
            get {
                return this.logonField;
            }
            set {
                this.logonField = value;
            }
        }
        public EntityItemAuditType network_policy_server {
            get {
                return this.network_policy_serverField;
            }
            set {
                this.network_policy_serverField = value;
            }
        }
        public EntityItemAuditType other_logon_logoff_events {
            get {
                return this.other_logon_logoff_eventsField;
            }
            set {
                this.other_logon_logoff_eventsField = value;
            }
        }
        public EntityItemAuditType special_logon {
            get {
                return this.special_logonField;
            }
            set {
                this.special_logonField = value;
            }
        }
        public EntityItemAuditType logon_claims {
            get {
                return this.logon_claimsField;
            }
            set {
                this.logon_claimsField = value;
            }
        }
        public EntityItemAuditType application_generated {
            get {
                return this.application_generatedField;
            }
            set {
                this.application_generatedField = value;
            }
        }
        public EntityItemAuditType certification_services {
            get {
                return this.certification_servicesField;
            }
            set {
                this.certification_servicesField = value;
            }
        }
        public EntityItemAuditType detailed_file_share {
            get {
                return this.detailed_file_shareField;
            }
            set {
                this.detailed_file_shareField = value;
            }
        }
        public EntityItemAuditType file_share {
            get {
                return this.file_shareField;
            }
            set {
                this.file_shareField = value;
            }
        }
        public EntityItemAuditType file_system {
            get {
                return this.file_systemField;
            }
            set {
                this.file_systemField = value;
            }
        }
        public EntityItemAuditType filtering_platform_connection {
            get {
                return this.filtering_platform_connectionField;
            }
            set {
                this.filtering_platform_connectionField = value;
            }
        }
        public EntityItemAuditType filtering_platform_packet_drop {
            get {
                return this.filtering_platform_packet_dropField;
            }
            set {
                this.filtering_platform_packet_dropField = value;
            }
        }
        public EntityItemAuditType handle_manipulation {
            get {
                return this.handle_manipulationField;
            }
            set {
                this.handle_manipulationField = value;
            }
        }
        public EntityItemAuditType kernel_object {
            get {
                return this.kernel_objectField;
            }
            set {
                this.kernel_objectField = value;
            }
        }
        public EntityItemAuditType other_object_access_events {
            get {
                return this.other_object_access_eventsField;
            }
            set {
                this.other_object_access_eventsField = value;
            }
        }
        public EntityItemAuditType registry {
            get {
                return this.registryField;
            }
            set {
                this.registryField = value;
            }
        }
        public EntityItemAuditType sam {
            get {
                return this.samField;
            }
            set {
                this.samField = value;
            }
        }
        public EntityItemAuditType removable_storage {
            get {
                return this.removable_storageField;
            }
            set {
                this.removable_storageField = value;
            }
        }
        public EntityItemAuditType central_access_policy_staging {
            get {
                return this.central_access_policy_stagingField;
            }
            set {
                this.central_access_policy_stagingField = value;
            }
        }
        public EntityItemAuditType audit_policy_change {
            get {
                return this.audit_policy_changeField;
            }
            set {
                this.audit_policy_changeField = value;
            }
        }
        public EntityItemAuditType authentication_policy_change {
            get {
                return this.authentication_policy_changeField;
            }
            set {
                this.authentication_policy_changeField = value;
            }
        }
        public EntityItemAuditType authorization_policy_change {
            get {
                return this.authorization_policy_changeField;
            }
            set {
                this.authorization_policy_changeField = value;
            }
        }
        public EntityItemAuditType filtering_platform_policy_change {
            get {
                return this.filtering_platform_policy_changeField;
            }
            set {
                this.filtering_platform_policy_changeField = value;
            }
        }
        public EntityItemAuditType mpssvc_rule_level_policy_change {
            get {
                return this.mpssvc_rule_level_policy_changeField;
            }
            set {
                this.mpssvc_rule_level_policy_changeField = value;
            }
        }
        public EntityItemAuditType other_policy_change_events {
            get {
                return this.other_policy_change_eventsField;
            }
            set {
                this.other_policy_change_eventsField = value;
            }
        }
        public EntityItemAuditType non_sensitive_privilege_use {
            get {
                return this.non_sensitive_privilege_useField;
            }
            set {
                this.non_sensitive_privilege_useField = value;
            }
        }
        public EntityItemAuditType other_privilege_use_events {
            get {
                return this.other_privilege_use_eventsField;
            }
            set {
                this.other_privilege_use_eventsField = value;
            }
        }
        public EntityItemAuditType sensitive_privilege_use {
            get {
                return this.sensitive_privilege_useField;
            }
            set {
                this.sensitive_privilege_useField = value;
            }
        }
        public EntityItemAuditType ipsec_driver {
            get {
                return this.ipsec_driverField;
            }
            set {
                this.ipsec_driverField = value;
            }
        }
        public EntityItemAuditType other_system_events {
            get {
                return this.other_system_eventsField;
            }
            set {
                this.other_system_eventsField = value;
            }
        }
        public EntityItemAuditType security_state_change {
            get {
                return this.security_state_changeField;
            }
            set {
                this.security_state_changeField = value;
            }
        }
        public EntityItemAuditType security_system_extension {
            get {
                return this.security_system_extensionField;
            }
            set {
                this.security_system_extensionField = value;
            }
        }
        public EntityItemAuditType system_integrity {
            get {
                return this.system_integrityField;
            }
            set {
                this.system_integrityField = value;
            }
        }
        public EntityItemAuditType group_membership {
            get {
                return this.group_membershipField;
            }
            set {
                this.group_membershipField = value;
            }
        }
        public EntityItemAuditType pnp_activity {
            get {
                return this.pnp_activityField;
            }
            set {
                this.pnp_activityField = value;
            }
        }
        public EntityItemAuditType user_device_claims {
            get {
                return this.user_device_claimsField;
            }
            set {
                this.user_device_claimsField = value;
            }
        }
        public EntityItemAuditType audit_detailedtracking_tokenrightadjusted {
            get {
                return this.audit_detailedtracking_tokenrightadjustedField;
            }
            set {
                this.audit_detailedtracking_tokenrightadjustedField = value;
            }
        }
    }

}

