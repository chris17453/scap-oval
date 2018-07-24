using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#android")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#android", IsNullable=false)]
    public class devicesettings_state : StateType {
        private EntityStateBoolType adb_enabledField;
        private EntityStateBoolType allow_mock_locationField;
        private EntityStateBoolType install_non_market_appsField;
        private EntityStateStringType[] device_adminField;
        private EntityStateBoolType auto_timeField;
        private EntityStateBoolType auto_time_zoneField;
        private EntityStateBoolType usb_mass_storage_enabledField;
        public EntityStateBoolType adb_enabled {
            get {
                return this.adb_enabledField;
            }
            set {
                this.adb_enabledField = value;
            }
        }
        public EntityStateBoolType allow_mock_location {
            get {
                return this.allow_mock_locationField;
            }
            set {
                this.allow_mock_locationField = value;
            }
        }
        public EntityStateBoolType install_non_market_apps {
            get {
                return this.install_non_market_appsField;
            }
            set {
                this.install_non_market_appsField = value;
            }
        }
        [XmlElementAttribute("device_admin")]
        public EntityStateStringType[] device_admin {
            get {
                return this.device_adminField;
            }
            set {
                this.device_adminField = value;
            }
        }
        public EntityStateBoolType auto_time {
            get {
                return this.auto_timeField;
            }
            set {
                this.auto_timeField = value;
            }
        }
        public EntityStateBoolType auto_time_zone {
            get {
                return this.auto_time_zoneField;
            }
            set {
                this.auto_time_zoneField = value;
            }
        }
        public EntityStateBoolType usb_mass_storage_enabled {
            get {
                return this.usb_mass_storage_enabledField;
            }
            set {
                this.usb_mass_storage_enabledField = value;
            }
        }
    }

}

