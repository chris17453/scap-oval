using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#apple_ios")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#apple_ios", IsNullable=false)]
    public class globalrestrictions_state : StateType {
        private EntityStateBoolType allow_account_modificationField;
        private EntityStateBoolType allow_airdropField;
        private EntityStateBoolType allow_app_cellular_data_modificationField;
        private EntityStateBoolType allow_app_installationField;
        private EntityStateBoolType allow_assistantField;
        private EntityStateBoolType allow_assistant_user_generated_contentField;
        private EntityStateBoolType allow_assistant_while_lockedField;
        private EntityStateBoolType allow_bookstoreField;
        private EntityStateBoolType allow_bookstore_eroticaField;
        private EntityStateBoolType allow_cameraField;
        private EntityStateBoolType allow_cloud_backupField;
        private EntityStateBoolType allow_cloud_document_syncField;
        private EntityStateBoolType allow_cloud_keychain_syncField;
        private EntityStateBoolType allow_diagnostic_submissionField;
        private EntityStateBoolType allow_explicit_contentField;
        private EntityStateBoolType allow_find_my_friends_modificationField;
        private EntityStateBoolType allow_fingerprint_for_unlockField;
        private EntityStateBoolType allow_game_centerField;
        private EntityStateBoolType allow_host_pairingField;
        private EntityStateBoolType allow_lock_screen_control_centerField;
        private EntityStateBoolType allow_lock_screen_notifications_viewField;
        private EntityStateBoolType allow_lock_screen_today_viewField;
        private EntityStateBoolType allow_open_from_managed_to_unmanagedField;
        private EntityStateBoolType allow_open_from_unmanaged_to_managedField;
        private EntityStateBoolType allow_ota_pki_updatesField;
        private EntityStateBoolType allow_passbook_while_lockedField;
        private EntityStateBoolType allow_photo_streamField;
        private EntityStateBoolType allow_safariField;
        private EntityStateBoolType allow_screen_shotField;
        private EntityStateBoolType allow_shared_streamField;
        private EntityStateBoolType allow_ui_configuration_profile_installationField;
        private EntityStateBoolType allow_untrusted_tls_promptField;
        private EntityStateBoolType allow_voice_dialingField;
        private EntityStateBoolType allow_youtubeField;
        private EntityStateBoolType allow_itunesField;
        private EntityStateStringType autonomous_single_app_mode_permitted_appidsField;
        private EntityStateBoolType force_encrypted_backupField;
        private EntityStateBoolType force_itunes_store_password_entryField;
        private EntityStateBoolType force_limit_ad_trackingField;
        private EntityStateBoolType safari_allow_auto_fillField;
        public EntityStateBoolType allow_account_modification {
            get {
                return this.allow_account_modificationField;
            }
            set {
                this.allow_account_modificationField = value;
            }
        }
        public EntityStateBoolType allow_airdrop {
            get {
                return this.allow_airdropField;
            }
            set {
                this.allow_airdropField = value;
            }
        }
        public EntityStateBoolType allow_app_cellular_data_modification {
            get {
                return this.allow_app_cellular_data_modificationField;
            }
            set {
                this.allow_app_cellular_data_modificationField = value;
            }
        }
        public EntityStateBoolType allow_app_installation {
            get {
                return this.allow_app_installationField;
            }
            set {
                this.allow_app_installationField = value;
            }
        }
        public EntityStateBoolType allow_assistant {
            get {
                return this.allow_assistantField;
            }
            set {
                this.allow_assistantField = value;
            }
        }
        public EntityStateBoolType allow_assistant_user_generated_content {
            get {
                return this.allow_assistant_user_generated_contentField;
            }
            set {
                this.allow_assistant_user_generated_contentField = value;
            }
        }
        public EntityStateBoolType allow_assistant_while_locked {
            get {
                return this.allow_assistant_while_lockedField;
            }
            set {
                this.allow_assistant_while_lockedField = value;
            }
        }
        public EntityStateBoolType allow_bookstore {
            get {
                return this.allow_bookstoreField;
            }
            set {
                this.allow_bookstoreField = value;
            }
        }
        public EntityStateBoolType allow_bookstore_erotica {
            get {
                return this.allow_bookstore_eroticaField;
            }
            set {
                this.allow_bookstore_eroticaField = value;
            }
        }
        public EntityStateBoolType allow_camera {
            get {
                return this.allow_cameraField;
            }
            set {
                this.allow_cameraField = value;
            }
        }
        public EntityStateBoolType allow_cloud_backup {
            get {
                return this.allow_cloud_backupField;
            }
            set {
                this.allow_cloud_backupField = value;
            }
        }
        public EntityStateBoolType allow_cloud_document_sync {
            get {
                return this.allow_cloud_document_syncField;
            }
            set {
                this.allow_cloud_document_syncField = value;
            }
        }
        public EntityStateBoolType allow_cloud_keychain_sync {
            get {
                return this.allow_cloud_keychain_syncField;
            }
            set {
                this.allow_cloud_keychain_syncField = value;
            }
        }
        public EntityStateBoolType allow_diagnostic_submission {
            get {
                return this.allow_diagnostic_submissionField;
            }
            set {
                this.allow_diagnostic_submissionField = value;
            }
        }
        public EntityStateBoolType allow_explicit_content {
            get {
                return this.allow_explicit_contentField;
            }
            set {
                this.allow_explicit_contentField = value;
            }
        }
        public EntityStateBoolType allow_find_my_friends_modification {
            get {
                return this.allow_find_my_friends_modificationField;
            }
            set {
                this.allow_find_my_friends_modificationField = value;
            }
        }
        public EntityStateBoolType allow_fingerprint_for_unlock {
            get {
                return this.allow_fingerprint_for_unlockField;
            }
            set {
                this.allow_fingerprint_for_unlockField = value;
            }
        }
        public EntityStateBoolType allow_game_center {
            get {
                return this.allow_game_centerField;
            }
            set {
                this.allow_game_centerField = value;
            }
        }
        public EntityStateBoolType allow_host_pairing {
            get {
                return this.allow_host_pairingField;
            }
            set {
                this.allow_host_pairingField = value;
            }
        }
        public EntityStateBoolType allow_lock_screen_control_center {
            get {
                return this.allow_lock_screen_control_centerField;
            }
            set {
                this.allow_lock_screen_control_centerField = value;
            }
        }
        public EntityStateBoolType allow_lock_screen_notifications_view {
            get {
                return this.allow_lock_screen_notifications_viewField;
            }
            set {
                this.allow_lock_screen_notifications_viewField = value;
            }
        }
        public EntityStateBoolType allow_lock_screen_today_view {
            get {
                return this.allow_lock_screen_today_viewField;
            }
            set {
                this.allow_lock_screen_today_viewField = value;
            }
        }
        public EntityStateBoolType allow_open_from_managed_to_unmanaged {
            get {
                return this.allow_open_from_managed_to_unmanagedField;
            }
            set {
                this.allow_open_from_managed_to_unmanagedField = value;
            }
        }
        public EntityStateBoolType allow_open_from_unmanaged_to_managed {
            get {
                return this.allow_open_from_unmanaged_to_managedField;
            }
            set {
                this.allow_open_from_unmanaged_to_managedField = value;
            }
        }
        public EntityStateBoolType allow_ota_pki_updates {
            get {
                return this.allow_ota_pki_updatesField;
            }
            set {
                this.allow_ota_pki_updatesField = value;
            }
        }
        public EntityStateBoolType allow_passbook_while_locked {
            get {
                return this.allow_passbook_while_lockedField;
            }
            set {
                this.allow_passbook_while_lockedField = value;
            }
        }
        public EntityStateBoolType allow_photo_stream {
            get {
                return this.allow_photo_streamField;
            }
            set {
                this.allow_photo_streamField = value;
            }
        }
        public EntityStateBoolType allow_safari {
            get {
                return this.allow_safariField;
            }
            set {
                this.allow_safariField = value;
            }
        }
        public EntityStateBoolType allow_screen_shot {
            get {
                return this.allow_screen_shotField;
            }
            set {
                this.allow_screen_shotField = value;
            }
        }
        public EntityStateBoolType allow_shared_stream {
            get {
                return this.allow_shared_streamField;
            }
            set {
                this.allow_shared_streamField = value;
            }
        }
        public EntityStateBoolType allow_ui_configuration_profile_installation {
            get {
                return this.allow_ui_configuration_profile_installationField;
            }
            set {
                this.allow_ui_configuration_profile_installationField = value;
            }
        }
        public EntityStateBoolType allow_untrusted_tls_prompt {
            get {
                return this.allow_untrusted_tls_promptField;
            }
            set {
                this.allow_untrusted_tls_promptField = value;
            }
        }
        public EntityStateBoolType allow_voice_dialing {
            get {
                return this.allow_voice_dialingField;
            }
            set {
                this.allow_voice_dialingField = value;
            }
        }
        public EntityStateBoolType allow_youtube {
            get {
                return this.allow_youtubeField;
            }
            set {
                this.allow_youtubeField = value;
            }
        }
        public EntityStateBoolType allow_itunes {
            get {
                return this.allow_itunesField;
            }
            set {
                this.allow_itunesField = value;
            }
        }
        public EntityStateStringType autonomous_single_app_mode_permitted_appids {
            get {
                return this.autonomous_single_app_mode_permitted_appidsField;
            }
            set {
                this.autonomous_single_app_mode_permitted_appidsField = value;
            }
        }
        public EntityStateBoolType force_encrypted_backup {
            get {
                return this.force_encrypted_backupField;
            }
            set {
                this.force_encrypted_backupField = value;
            }
        }
        public EntityStateBoolType force_itunes_store_password_entry {
            get {
                return this.force_itunes_store_password_entryField;
            }
            set {
                this.force_itunes_store_password_entryField = value;
            }
        }
        public EntityStateBoolType force_limit_ad_tracking {
            get {
                return this.force_limit_ad_trackingField;
            }
            set {
                this.force_limit_ad_trackingField = value;
            }
        }
        public EntityStateBoolType safari_allow_auto_fill {
            get {
                return this.safari_allow_auto_fillField;
            }
            set {
                this.safari_allow_auto_fillField = value;
            }
        }
    }

}

