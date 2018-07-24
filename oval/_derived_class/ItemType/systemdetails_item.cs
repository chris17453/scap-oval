using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#android")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#android", IsNullable=false)]
    public class systemdetails_item : ItemType {
        private EntityItemStringType hardwareField;
        private EntityItemStringType manufacturerField;
        private EntityItemStringType modelField;
        private EntityItemStringType productField;
        private EntityItemStringType cpu_abiField;
        private EntityItemStringType cpu_abi2Field;
        private EntityItemStringType build_fingerprintField;
        private EntityItemStringType os_version_code_nameField;
        private EntityItemStringType os_version_build_numberField;
        private EntityItemStringType os_version_release_nameField;
        private EntityItemIntType os_version_sdk_numberField;
        private EntityItemBoolType hardware_keystoreField;
        public EntityItemStringType hardware {
            get {
                return this.hardwareField;
            }
            set {
                this.hardwareField = value;
            }
        }
        public EntityItemStringType manufacturer {
            get {
                return this.manufacturerField;
            }
            set {
                this.manufacturerField = value;
            }
        }
        public EntityItemStringType model {
            get {
                return this.modelField;
            }
            set {
                this.modelField = value;
            }
        }
        public EntityItemStringType product {
            get {
                return this.productField;
            }
            set {
                this.productField = value;
            }
        }
        public EntityItemStringType cpu_abi {
            get {
                return this.cpu_abiField;
            }
            set {
                this.cpu_abiField = value;
            }
        }
        public EntityItemStringType cpu_abi2 {
            get {
                return this.cpu_abi2Field;
            }
            set {
                this.cpu_abi2Field = value;
            }
        }
        public EntityItemStringType build_fingerprint {
            get {
                return this.build_fingerprintField;
            }
            set {
                this.build_fingerprintField = value;
            }
        }
        public EntityItemStringType os_version_code_name {
            get {
                return this.os_version_code_nameField;
            }
            set {
                this.os_version_code_nameField = value;
            }
        }
        public EntityItemStringType os_version_build_number {
            get {
                return this.os_version_build_numberField;
            }
            set {
                this.os_version_build_numberField = value;
            }
        }
        public EntityItemStringType os_version_release_name {
            get {
                return this.os_version_release_nameField;
            }
            set {
                this.os_version_release_nameField = value;
            }
        }
        public EntityItemIntType os_version_sdk_number {
            get {
                return this.os_version_sdk_numberField;
            }
            set {
                this.os_version_sdk_numberField = value;
            }
        }
        public EntityItemBoolType hardware_keystore {
            get {
                return this.hardware_keystoreField;
            }
            set {
                this.hardware_keystoreField = value;
            }
        }
    }

}

