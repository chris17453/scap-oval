using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#android")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#android", IsNullable=false)]
    public class devicesettings_item : ItemType {
        private EntityItemBoolType adb_enabledField;
        private EntityItemBoolType allow_mock_locationField;
        private EntityItemBoolType install_non_market_appsField;
        private EntityItemStringType[] device_adminField;
        private EntityItemBoolType auto_timeField;
        private EntityItemBoolType auto_time_zoneField;
        private EntityItemBoolType usb_mass_storage_enabledField;
        public EntityItemBoolType adb_enabled {
            get {
                return this.adb_enabledField;
            }
            set {
                this.adb_enabledField = value;
            }
        }
        public EntityItemBoolType allow_mock_location {
            get {
                return this.allow_mock_locationField;
            }
            set {
                this.allow_mock_locationField = value;
            }
        }
        public EntityItemBoolType install_non_market_apps {
            get {
                return this.install_non_market_appsField;
            }
            set {
                this.install_non_market_appsField = value;
            }
        }
        [XmlElementAttribute("device_admin")]
        public EntityItemStringType[] device_admin {
            get {
                return this.device_adminField;
            }
            set {
                this.device_adminField = value;
            }
        }
        public EntityItemBoolType auto_time {
            get {
                return this.auto_timeField;
            }
            set {
                this.auto_timeField = value;
            }
        }
        public EntityItemBoolType auto_time_zone {
            get {
                return this.auto_time_zoneField;
            }
            set {
                this.auto_time_zoneField = value;
            }
        }
        public EntityItemBoolType usb_mass_storage_enabled {
            get {
                return this.usb_mass_storage_enabledField;
            }
            set {
                this.usb_mass_storage_enabledField = value;
            }
        }
    }

}

