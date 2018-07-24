using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#android")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#android", IsNullable=false)]
    public class appmanager_item : ItemType {
        private EntityItemStringType application_nameField;
        private EntityItemStringType uidField;
        private EntityItemStringType[] gidField;
        private EntityItemStringType package_nameField;
        private EntityItemStringType data_directoryField;
        private EntityItemStringType versionField;
        private EntityItemBoolType current_statusField;
        private EntityItemStringType[] permissionField;
        private EntityItemStringType native_lib_dirField;
        private EntityItemBinaryType[] signing_certificateField;
        private EntityItemIntType first_install_timeField;
        private EntityItemIntType last_update_timeField;
        private EntityItemStringType package_file_locationField;
        public EntityItemStringType application_name {
            get {
                return this.application_nameField;
            }
            set {
                this.application_nameField = value;
            }
        }
        public EntityItemStringType uid {
            get {
                return this.uidField;
            }
            set {
                this.uidField = value;
            }
        }
        [XmlElementAttribute("gid")]
        public EntityItemStringType[] gid {
            get {
                return this.gidField;
            }
            set {
                this.gidField = value;
            }
        }
        public EntityItemStringType package_name {
            get {
                return this.package_nameField;
            }
            set {
                this.package_nameField = value;
            }
        }
        public EntityItemStringType data_directory {
            get {
                return this.data_directoryField;
            }
            set {
                this.data_directoryField = value;
            }
        }
        public EntityItemStringType version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
        public EntityItemBoolType current_status {
            get {
                return this.current_statusField;
            }
            set {
                this.current_statusField = value;
            }
        }
        [XmlElementAttribute("permission")]
        public EntityItemStringType[] permission {
            get {
                return this.permissionField;
            }
            set {
                this.permissionField = value;
            }
        }
        public EntityItemStringType native_lib_dir {
            get {
                return this.native_lib_dirField;
            }
            set {
                this.native_lib_dirField = value;
            }
        }
        [XmlElementAttribute("signing_certificate")]
        public EntityItemBinaryType[] signing_certificate {
            get {
                return this.signing_certificateField;
            }
            set {
                this.signing_certificateField = value;
            }
        }
        public EntityItemIntType first_install_time {
            get {
                return this.first_install_timeField;
            }
            set {
                this.first_install_timeField = value;
            }
        }
        public EntityItemIntType last_update_time {
            get {
                return this.last_update_timeField;
            }
            set {
                this.last_update_timeField = value;
            }
        }
        public EntityItemStringType package_file_location {
            get {
                return this.package_file_locationField;
            }
            set {
                this.package_file_locationField = value;
            }
        }
    }

}

