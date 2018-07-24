using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#android")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#android", IsNullable=false)]
    public class appmanager_state : StateType {
        private EntityStateStringType application_nameField;
        private EntityStateStringType uidField;
        private EntityStateStringType[] gidField;
        private EntityStateStringType package_nameField;
        private EntityStateStringType data_directoryField;
        private EntityStateStringType version1Field;
        private EntityStateBoolType current_statusField;
        private EntityStateStringType permissionField;
        private EntityStateStringType native_lib_dirField;
        private EntityStateBinaryType[] signing_certificateField;
        private EntityStateIntType first_install_timeField;
        private EntityStateIntType last_update_timeField;
        private EntityStateStringType package_file_locationField;
        public EntityStateStringType application_name {
            get {
                return this.application_nameField;
            }
            set {
                this.application_nameField = value;
            }
        }
        public EntityStateStringType uid {
            get {
                return this.uidField;
            }
            set {
                this.uidField = value;
            }
        }
        [XmlElementAttribute("gid")]
        public EntityStateStringType[] gid {
            get {
                return this.gidField;
            }
            set {
                this.gidField = value;
            }
        }
        public EntityStateStringType package_name {
            get {
                return this.package_nameField;
            }
            set {
                this.package_nameField = value;
            }
        }
        public EntityStateStringType data_directory {
            get {
                return this.data_directoryField;
            }
            set {
                this.data_directoryField = value;
            }
        }
        [XmlElementAttribute("version")]
        public EntityStateStringType version1 {
            get {
                return this.version1Field;
            }
            set {
                this.version1Field = value;
            }
        }
        public EntityStateBoolType current_status {
            get {
                return this.current_statusField;
            }
            set {
                this.current_statusField = value;
            }
        }
        public EntityStateStringType permission {
            get {
                return this.permissionField;
            }
            set {
                this.permissionField = value;
            }
        }
        public EntityStateStringType native_lib_dir {
            get {
                return this.native_lib_dirField;
            }
            set {
                this.native_lib_dirField = value;
            }
        }
        [XmlElementAttribute("signing_certificate")]
        public EntityStateBinaryType[] signing_certificate {
            get {
                return this.signing_certificateField;
            }
            set {
                this.signing_certificateField = value;
            }
        }
        public EntityStateIntType first_install_time {
            get {
                return this.first_install_timeField;
            }
            set {
                this.first_install_timeField = value;
            }
        }
        public EntityStateIntType last_update_time {
            get {
                return this.last_update_timeField;
            }
            set {
                this.last_update_timeField = value;
            }
        }
        public EntityStateStringType package_file_location {
            get {
                return this.package_file_locationField;
            }
            set {
                this.package_file_locationField = value;
            }
        }
    }

}

