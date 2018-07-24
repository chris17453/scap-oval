using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#windows")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#windows", IsNullable=false)]
    public class auditeventpolicysubcategories_state : StateType {
        private EntityStateAuditType credential_validationField;
        private EntityStateAuditType kerberos_authentication_serviceField;
        private EntityStateAuditType kerberos_service_ticket_operationsField;
        private EntityStateAuditType kerberos_ticket_eventsField;
        private EntityStateAuditType other_account_logon_eventsField;
        private EntityStateAuditType application_group_managementField;
        private EntityStateAuditType computer_account_managementField;
        private EntityStateAuditType distribution_group_managementField;
        private EntityStateAuditType other_account_management_eventsField;
        private EntityStateAuditType security_group_managementField;
        private EntityStateAuditType user_account_managementField;
        private EntityStateAuditType dpapi_activityField;
        private EntityStateAuditType process_creationField;
        private EntityStateAuditType process_terminationField;
        private EntityStateAuditType rpc_eventsField;
        private EntityStateAuditType directory_service_accessField;
        private EntityStateAuditType directory_service_changesField;
        private EntityStateAuditType directory_service_replicationField;
        private EntityStateAuditType detailed_directory_service_replicationField;
        private EntityStateAuditType account_lockoutField;
        private EntityStateAuditType ipsec_extended_modeField;
        private EntityStateAuditType ipsec_main_modeField;
        private EntityStateAuditType ipsec_quick_modeField;
        private EntityStateAuditType logoffField;
        private EntityStateAuditType logonField;
        private EntityStateAuditType network_policy_serverField;
        private EntityStateAuditType other_logon_logoff_eventsField;
        private EntityStateAuditType special_logonField;
        private EntityStateAuditType logon_claimsField;
        private EntityStateAuditType application_generatedField;
        private EntityStateAuditType certification_servicesField;
        private EntityStateAuditType detailed_file_shareField;
        private EntityStateAuditType file_shareField;
        private EntityStateAuditType file_systemField;
        private EntityStateAuditType filtering_platform_connectionField;
        private EntityStateAuditType filtering_platform_packet_dropField;
        private EntityStateAuditType handle_manipulationField;
        private EntityStateAuditType kernel_objectField;
        private EntityStateAuditType other_object_access_eventsField;
        private EntityStateAuditType registryField;
        private EntityStateAuditType samField;
        private EntityStateAuditType removable_storageField;
        private EntityStateAuditType central_access_policy_stagingField;
        private EntityStateAuditType audit_policy_changeField;
        private EntityStateAuditType authentication_policy_changeField;
        private EntityStateAuditType authorization_policy_changeField;
        private EntityStateAuditType filtering_platform_policy_changeField;
        private EntityStateAuditType mpssvc_rule_level_policy_changeField;
        private EntityStateAuditType other_policy_change_eventsField;
        private EntityStateAuditType non_sensitive_privilege_useField;
        private EntityStateAuditType other_privilege_use_eventsField;
        private EntityStateAuditType sensitive_privilege_useField;
        private EntityStateAuditType ipsec_driverField;
        private EntityStateAuditType other_system_eventsField;
        private EntityStateAuditType security_state_changeField;
        private EntityStateAuditType security_system_extensionField;
        private EntityStateAuditType system_integrityField;
        private EntityStateAuditType group_membershipField;
        private EntityStateAuditType pnp_activityField;
        private EntityStateAuditType user_device_claimsField;
        private EntityStateAuditType audit_detailedtracking_tokenrightadjustedField;
        public EntityStateAuditType credential_validation {
            get {
                return this.credential_validationField;
            }
            set {
                this.credential_validationField = value;
            }
        }
        public EntityStateAuditType kerberos_authentication_service {
            get {
                return this.kerberos_authentication_serviceField;
            }
            set {
                this.kerberos_authentication_serviceField = value;
            }
        }
        public EntityStateAuditType kerberos_service_ticket_operations {
            get {
                return this.kerberos_service_ticket_operationsField;
            }
            set {
                this.kerberos_service_ticket_operationsField = value;
            }
        }
        public EntityStateAuditType kerberos_ticket_events {
            get {
                return this.kerberos_ticket_eventsField;
            }
            set {
                this.kerberos_ticket_eventsField = value;
            }
        }
        public EntityStateAuditType other_account_logon_events {
            get {
                return this.other_account_logon_eventsField;
            }
            set {
                this.other_account_logon_eventsField = value;
            }
        }
        public EntityStateAuditType application_group_management {
            get {
                return this.application_group_managementField;
            }
            set {
                this.application_group_managementField = value;
            }
        }
        public EntityStateAuditType computer_account_management {
            get {
                return this.computer_account_managementField;
            }
            set {
                this.computer_account_managementField = value;
            }
        }
        public EntityStateAuditType distribution_group_management {
            get {
                return this.distribution_group_managementField;
            }
            set {
                this.distribution_group_managementField = value;
            }
        }
        public EntityStateAuditType other_account_management_events {
            get {
                return this.other_account_management_eventsField;
            }
            set {
                this.other_account_management_eventsField = value;
            }
        }
        public EntityStateAuditType security_group_management {
            get {
                return this.security_group_managementField;
            }
            set {
                this.security_group_managementField = value;
            }
        }
        public EntityStateAuditType user_account_management {
            get {
                return this.user_account_managementField;
            }
            set {
                this.user_account_managementField = value;
            }
        }
        public EntityStateAuditType dpapi_activity {
            get {
                return this.dpapi_activityField;
            }
            set {
                this.dpapi_activityField = value;
            }
        }
        public EntityStateAuditType process_creation {
            get {
                return this.process_creationField;
            }
            set {
                this.process_creationField = value;
            }
        }
        public EntityStateAuditType process_termination {
            get {
                return this.process_terminationField;
            }
            set {
                this.process_terminationField = value;
            }
        }
        public EntityStateAuditType rpc_events {
            get {
                return this.rpc_eventsField;
            }
            set {
                this.rpc_eventsField = value;
            }
        }
        public EntityStateAuditType directory_service_access {
            get {
                return this.directory_service_accessField;
            }
            set {
                this.directory_service_accessField = value;
            }
        }
        public EntityStateAuditType directory_service_changes {
            get {
                return this.directory_service_changesField;
            }
            set {
                this.directory_service_changesField = value;
            }
        }
        public EntityStateAuditType directory_service_replication {
            get {
                return this.directory_service_replicationField;
            }
            set {
                this.directory_service_replicationField = value;
            }
        }
        public EntityStateAuditType detailed_directory_service_replication {
            get {
                return this.detailed_directory_service_replicationField;
            }
            set {
                this.detailed_directory_service_replicationField = value;
            }
        }
        public EntityStateAuditType account_lockout {
            get {
                return this.account_lockoutField;
            }
            set {
                this.account_lockoutField = value;
            }
        }
        public EntityStateAuditType ipsec_extended_mode {
            get {
                return this.ipsec_extended_modeField;
            }
            set {
                this.ipsec_extended_modeField = value;
            }
        }
        public EntityStateAuditType ipsec_main_mode {
            get {
                return this.ipsec_main_modeField;
            }
            set {
                this.ipsec_main_modeField = value;
            }
        }
        public EntityStateAuditType ipsec_quick_mode {
            get {
                return this.ipsec_quick_modeField;
            }
            set {
                this.ipsec_quick_modeField = value;
            }
        }
        public EntityStateAuditType logoff {
            get {
                return this.logoffField;
            }
            set {
                this.logoffField = value;
            }
        }
        public EntityStateAuditType logon {
            get {
                return this.logonField;
            }
            set {
                this.logonField = value;
            }
        }
        public EntityStateAuditType network_policy_server {
            get {
                return this.network_policy_serverField;
            }
            set {
                this.network_policy_serverField = value;
            }
        }
        public EntityStateAuditType other_logon_logoff_events {
            get {
                return this.other_logon_logoff_eventsField;
            }
            set {
                this.other_logon_logoff_eventsField = value;
            }
        }
        public EntityStateAuditType special_logon {
            get {
                return this.special_logonField;
            }
            set {
                this.special_logonField = value;
            }
        }
        public EntityStateAuditType logon_claims {
            get {
                return this.logon_claimsField;
            }
            set {
                this.logon_claimsField = value;
            }
        }
        public EntityStateAuditType application_generated {
            get {
                return this.application_generatedField;
            }
            set {
                this.application_generatedField = value;
            }
        }
        public EntityStateAuditType certification_services {
            get {
                return this.certification_servicesField;
            }
            set {
                this.certification_servicesField = value;
            }
        }
        public EntityStateAuditType detailed_file_share {
            get {
                return this.detailed_file_shareField;
            }
            set {
                this.detailed_file_shareField = value;
            }
        }
        public EntityStateAuditType file_share {
            get {
                return this.file_shareField;
            }
            set {
                this.file_shareField = value;
            }
        }
        public EntityStateAuditType file_system {
            get {
                return this.file_systemField;
            }
            set {
                this.file_systemField = value;
            }
        }
        public EntityStateAuditType filtering_platform_connection {
            get {
                return this.filtering_platform_connectionField;
            }
            set {
                this.filtering_platform_connectionField = value;
            }
        }
        public EntityStateAuditType filtering_platform_packet_drop {
            get {
                return this.filtering_platform_packet_dropField;
            }
            set {
                this.filtering_platform_packet_dropField = value;
            }
        }
        public EntityStateAuditType handle_manipulation {
            get {
                return this.handle_manipulationField;
            }
            set {
                this.handle_manipulationField = value;
            }
        }
        public EntityStateAuditType kernel_object {
            get {
                return this.kernel_objectField;
            }
            set {
                this.kernel_objectField = value;
            }
        }
        public EntityStateAuditType other_object_access_events {
            get {
                return this.other_object_access_eventsField;
            }
            set {
                this.other_object_access_eventsField = value;
            }
        }
        public EntityStateAuditType registry {
            get {
                return this.registryField;
            }
            set {
                this.registryField = value;
            }
        }
        public EntityStateAuditType sam {
            get {
                return this.samField;
            }
            set {
                this.samField = value;
            }
        }
        public EntityStateAuditType removable_storage {
            get {
                return this.removable_storageField;
            }
            set {
                this.removable_storageField = value;
            }
        }
        public EntityStateAuditType central_access_policy_staging {
            get {
                return this.central_access_policy_stagingField;
            }
            set {
                this.central_access_policy_stagingField = value;
            }
        }
        public EntityStateAuditType audit_policy_change {
            get {
                return this.audit_policy_changeField;
            }
            set {
                this.audit_policy_changeField = value;
            }
        }
        public EntityStateAuditType authentication_policy_change {
            get {
                return this.authentication_policy_changeField;
            }
            set {
                this.authentication_policy_changeField = value;
            }
        }
        public EntityStateAuditType authorization_policy_change {
            get {
                return this.authorization_policy_changeField;
            }
            set {
                this.authorization_policy_changeField = value;
            }
        }
        public EntityStateAuditType filtering_platform_policy_change {
            get {
                return this.filtering_platform_policy_changeField;
            }
            set {
                this.filtering_platform_policy_changeField = value;
            }
        }
        public EntityStateAuditType mpssvc_rule_level_policy_change {
            get {
                return this.mpssvc_rule_level_policy_changeField;
            }
            set {
                this.mpssvc_rule_level_policy_changeField = value;
            }
        }
        public EntityStateAuditType other_policy_change_events {
            get {
                return this.other_policy_change_eventsField;
            }
            set {
                this.other_policy_change_eventsField = value;
            }
        }
        public EntityStateAuditType non_sensitive_privilege_use {
            get {
                return this.non_sensitive_privilege_useField;
            }
            set {
                this.non_sensitive_privilege_useField = value;
            }
        }
        public EntityStateAuditType other_privilege_use_events {
            get {
                return this.other_privilege_use_eventsField;
            }
            set {
                this.other_privilege_use_eventsField = value;
            }
        }
        public EntityStateAuditType sensitive_privilege_use {
            get {
                return this.sensitive_privilege_useField;
            }
            set {
                this.sensitive_privilege_useField = value;
            }
        }
        public EntityStateAuditType ipsec_driver {
            get {
                return this.ipsec_driverField;
            }
            set {
                this.ipsec_driverField = value;
            }
        }
        public EntityStateAuditType other_system_events {
            get {
                return this.other_system_eventsField;
            }
            set {
                this.other_system_eventsField = value;
            }
        }
        public EntityStateAuditType security_state_change {
            get {
                return this.security_state_changeField;
            }
            set {
                this.security_state_changeField = value;
            }
        }
        public EntityStateAuditType security_system_extension {
            get {
                return this.security_system_extensionField;
            }
            set {
                this.security_system_extensionField = value;
            }
        }
        public EntityStateAuditType system_integrity {
            get {
                return this.system_integrityField;
            }
            set {
                this.system_integrityField = value;
            }
        }
        public EntityStateAuditType group_membership {
            get {
                return this.group_membershipField;
            }
            set {
                this.group_membershipField = value;
            }
        }
        public EntityStateAuditType pnp_activity {
            get {
                return this.pnp_activityField;
            }
            set {
                this.pnp_activityField = value;
            }
        }
        public EntityStateAuditType user_device_claims {
            get {
                return this.user_device_claimsField;
            }
            set {
                this.user_device_claimsField = value;
            }
        }
        public EntityStateAuditType audit_detailedtracking_tokenrightadjusted {
            get {
                return this.audit_detailedtracking_tokenrightadjustedField;
            }
            set {
                this.audit_detailedtracking_tokenrightadjustedField = value;
            }
        }
    }

}

