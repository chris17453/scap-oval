using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#apple_ios")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#apple_ios", IsNullable=false)]
    public class globalrestrictions_item : ItemType {
        private EntityItemBoolType allow_account_modificationField;
        private EntityItemBoolType allow_airdropField;
        private EntityItemBoolType allow_app_cellular_data_modificationField;
        private EntityItemBoolType allow_app_installationField;
        private EntityItemBoolType allow_assistantField;
        private EntityItemBoolType allow_assistant_user_generated_contentField;
        private EntityItemBoolType allow_assistant_while_lockedField;
        private EntityItemBoolType allow_bookstoreField;
        private EntityItemBoolType allow_bookstore_eroticaField;
        private EntityItemBoolType allow_cameraField;
        private EntityItemBoolType allow_cloud_backupField;
        private EntityItemBoolType allow_cloud_document_syncField;
        private EntityItemBoolType allow_cloud_keychain_syncField;
        private EntityItemBoolType allow_diagnostic_submissionField;
        private EntityItemBoolType allow_explicit_contentField;
        private EntityItemBoolType allow_find_my_friends_modificationField;
        private EntityItemBoolType allow_fingerprint_for_unlockField;
        private EntityItemBoolType allow_game_centerField;
        private EntityItemBoolType allow_host_pairingField;
        private EntityItemBoolType allow_lock_screen_control_centerField;
        private EntityItemBoolType allow_lock_screen_notifications_viewField;
        private EntityItemBoolType allow_lock_screen_today_viewField;
        private EntityItemBoolType allow_open_from_managed_to_unmanagedField;
        private EntityItemBoolType allow_open_from_unmanaged_to_managedField;
        private EntityItemBoolType allow_ota_pki_updatesField;
        private EntityItemBoolType allow_passbook_while_lockedField;
        private EntityItemBoolType allow_photo_streamField;
        private EntityItemBoolType allow_safariField;
        private EntityItemBoolType allow_screen_shotField;
        private EntityItemBoolType allow_shared_streamField;
        private EntityItemBoolType allow_ui_configuration_profile_installationField;
        private EntityItemBoolType allow_untrusted_tls_promptField;
        private EntityItemBoolType allow_voice_dialingField;
        private EntityItemBoolType allow_youtubeField;
        private EntityItemBoolType allow_itunesField;
        private EntityItemStringType[] autonomous_single_app_mode_permitted_appidsField;
        private EntityItemBoolType force_encrypted_backupField;
        private EntityItemBoolType force_itunes_store_password_entryField;
        private EntityItemBoolType force_limit_ad_trackingField;
        private EntityItemBoolType safari_allow_auto_fillField;
        public EntityItemBoolType allow_account_modification {
            get {
                return this.allow_account_modificationField;
            }
            set {
                this.allow_account_modificationField = value;
            }
        }
        public EntityItemBoolType allow_airdrop {
            get {
                return this.allow_airdropField;
            }
            set {
                this.allow_airdropField = value;
            }
        }
        public EntityItemBoolType allow_app_cellular_data_modification {
            get {
                return this.allow_app_cellular_data_modificationField;
            }
            set {
                this.allow_app_cellular_data_modificationField = value;
            }
        }
        public EntityItemBoolType allow_app_installation {
            get {
                return this.allow_app_installationField;
            }
            set {
                this.allow_app_installationField = value;
            }
        }
        public EntityItemBoolType allow_assistant {
            get {
                return this.allow_assistantField;
            }
            set {
                this.allow_assistantField = value;
            }
        }
        public EntityItemBoolType allow_assistant_user_generated_content {
            get {
                return this.allow_assistant_user_generated_contentField;
            }
            set {
                this.allow_assistant_user_generated_contentField = value;
            }
        }
        public EntityItemBoolType allow_assistant_while_locked {
            get {
                return this.allow_assistant_while_lockedField;
            }
            set {
                this.allow_assistant_while_lockedField = value;
            }
        }
        public EntityItemBoolType allow_bookstore {
            get {
                return this.allow_bookstoreField;
            }
            set {
                this.allow_bookstoreField = value;
            }
        }
        public EntityItemBoolType allow_bookstore_erotica {
            get {
                return this.allow_bookstore_eroticaField;
            }
            set {
                this.allow_bookstore_eroticaField = value;
            }
        }
        public EntityItemBoolType allow_camera {
            get {
                return this.allow_cameraField;
            }
            set {
                this.allow_cameraField = value;
            }
        }
        public EntityItemBoolType allow_cloud_backup {
            get {
                return this.allow_cloud_backupField;
            }
            set {
                this.allow_cloud_backupField = value;
            }
        }
        public EntityItemBoolType allow_cloud_document_sync {
            get {
                return this.allow_cloud_document_syncField;
            }
            set {
                this.allow_cloud_document_syncField = value;
            }
        }
        public EntityItemBoolType allow_cloud_keychain_sync {
            get {
                return this.allow_cloud_keychain_syncField;
            }
            set {
                this.allow_cloud_keychain_syncField = value;
            }
        }
        public EntityItemBoolType allow_diagnostic_submission {
            get {
                return this.allow_diagnostic_submissionField;
            }
            set {
                this.allow_diagnostic_submissionField = value;
            }
        }
        public EntityItemBoolType allow_explicit_content {
            get {
                return this.allow_explicit_contentField;
            }
            set {
                this.allow_explicit_contentField = value;
            }
        }
        public EntityItemBoolType allow_find_my_friends_modification {
            get {
                return this.allow_find_my_friends_modificationField;
            }
            set {
                this.allow_find_my_friends_modificationField = value;
            }
        }
        public EntityItemBoolType allow_fingerprint_for_unlock {
            get {
                return this.allow_fingerprint_for_unlockField;
            }
            set {
                this.allow_fingerprint_for_unlockField = value;
            }
        }
        public EntityItemBoolType allow_game_center {
            get {
                return this.allow_game_centerField;
            }
            set {
                this.allow_game_centerField = value;
            }
        }
        public EntityItemBoolType allow_host_pairing {
            get {
                return this.allow_host_pairingField;
            }
            set {
                this.allow_host_pairingField = value;
            }
        }
        public EntityItemBoolType allow_lock_screen_control_center {
            get {
                return this.allow_lock_screen_control_centerField;
            }
            set {
                this.allow_lock_screen_control_centerField = value;
            }
        }
        public EntityItemBoolType allow_lock_screen_notifications_view {
            get {
                return this.allow_lock_screen_notifications_viewField;
            }
            set {
                this.allow_lock_screen_notifications_viewField = value;
            }
        }
        public EntityItemBoolType allow_lock_screen_today_view {
            get {
                return this.allow_lock_screen_today_viewField;
            }
            set {
                this.allow_lock_screen_today_viewField = value;
            }
        }
        public EntityItemBoolType allow_open_from_managed_to_unmanaged {
            get {
                return this.allow_open_from_managed_to_unmanagedField;
            }
            set {
                this.allow_open_from_managed_to_unmanagedField = value;
            }
        }
        public EntityItemBoolType allow_open_from_unmanaged_to_managed {
            get {
                return this.allow_open_from_unmanaged_to_managedField;
            }
            set {
                this.allow_open_from_unmanaged_to_managedField = value;
            }
        }
        public EntityItemBoolType allow_ota_pki_updates {
            get {
                return this.allow_ota_pki_updatesField;
            }
            set {
                this.allow_ota_pki_updatesField = value;
            }
        }
        public EntityItemBoolType allow_passbook_while_locked {
            get {
                return this.allow_passbook_while_lockedField;
            }
            set {
                this.allow_passbook_while_lockedField = value;
            }
        }
        public EntityItemBoolType allow_photo_stream {
            get {
                return this.allow_photo_streamField;
            }
            set {
                this.allow_photo_streamField = value;
            }
        }
        public EntityItemBoolType allow_safari {
            get {
                return this.allow_safariField;
            }
            set {
                this.allow_safariField = value;
            }
        }
        public EntityItemBoolType allow_screen_shot {
            get {
                return this.allow_screen_shotField;
            }
            set {
                this.allow_screen_shotField = value;
            }
        }
        public EntityItemBoolType allow_shared_stream {
            get {
                return this.allow_shared_streamField;
            }
            set {
                this.allow_shared_streamField = value;
            }
        }
        public EntityItemBoolType allow_ui_configuration_profile_installation {
            get {
                return this.allow_ui_configuration_profile_installationField;
            }
            set {
                this.allow_ui_configuration_profile_installationField = value;
            }
        }
        public EntityItemBoolType allow_untrusted_tls_prompt {
            get {
                return this.allow_untrusted_tls_promptField;
            }
            set {
                this.allow_untrusted_tls_promptField = value;
            }
        }
        public EntityItemBoolType allow_voice_dialing {
            get {
                return this.allow_voice_dialingField;
            }
            set {
                this.allow_voice_dialingField = value;
            }
        }
        public EntityItemBoolType allow_youtube {
            get {
                return this.allow_youtubeField;
            }
            set {
                this.allow_youtubeField = value;
            }
        }
        public EntityItemBoolType allow_itunes {
            get {
                return this.allow_itunesField;
            }
            set {
                this.allow_itunesField = value;
            }
        }
        [XmlElementAttribute("autonomous_single_app_mode_permitted_appids")]
        public EntityItemStringType[] autonomous_single_app_mode_permitted_appids {
            get {
                return this.autonomous_single_app_mode_permitted_appidsField;
            }
            set {
                this.autonomous_single_app_mode_permitted_appidsField = value;
            }
        }
        public EntityItemBoolType force_encrypted_backup {
            get {
                return this.force_encrypted_backupField;
            }
            set {
                this.force_encrypted_backupField = value;
            }
        }
        public EntityItemBoolType force_itunes_store_password_entry {
            get {
                return this.force_itunes_store_password_entryField;
            }
            set {
                this.force_itunes_store_password_entryField = value;
            }
        }
        public EntityItemBoolType force_limit_ad_tracking {
            get {
                return this.force_limit_ad_trackingField;
            }
            set {
                this.force_limit_ad_trackingField = value;
            }
        }
        public EntityItemBoolType safari_allow_auto_fill {
            get {
                return this.safari_allow_auto_fillField;
            }
            set {
                this.safari_allow_auto_fillField = value;
            }
        }
    }

}

