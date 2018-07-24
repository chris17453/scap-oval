using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#android")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#android", IsNullable=false)]
    public class systemdetails_state : StateType {
        private EntityStateStringType hardwareField;
        private EntityStateStringType manufacturerField;
        private EntityStateStringType modelField;
        private EntityStateStringType productField;
        private EntityStateStringType cpu_abiField;
        private EntityStateStringType cpu_abi2Field;
        private EntityStateStringType build_fingerprintField;
        private EntityStateStringType os_version_code_nameField;
        private EntityStateStringType os_version_build_numberField;
        private EntityStateStringType os_version_release_nameField;
        private EntityStateIntType os_version_sdk_numberField;
        private EntityStateBoolType hardware_keystoreField;
        public EntityStateStringType hardware {
            get {
                return this.hardwareField;
            }
            set {
                this.hardwareField = value;
            }
        }
        public EntityStateStringType manufacturer {
            get {
                return this.manufacturerField;
            }
            set {
                this.manufacturerField = value;
            }
        }
        public EntityStateStringType model {
            get {
                return this.modelField;
            }
            set {
                this.modelField = value;
            }
        }
        public EntityStateStringType product {
            get {
                return this.productField;
            }
            set {
                this.productField = value;
            }
        }
        public EntityStateStringType cpu_abi {
            get {
                return this.cpu_abiField;
            }
            set {
                this.cpu_abiField = value;
            }
        }
        public EntityStateStringType cpu_abi2 {
            get {
                return this.cpu_abi2Field;
            }
            set {
                this.cpu_abi2Field = value;
            }
        }
        public EntityStateStringType build_fingerprint {
            get {
                return this.build_fingerprintField;
            }
            set {
                this.build_fingerprintField = value;
            }
        }
        public EntityStateStringType os_version_code_name {
            get {
                return this.os_version_code_nameField;
            }
            set {
                this.os_version_code_nameField = value;
            }
        }
        public EntityStateStringType os_version_build_number {
            get {
                return this.os_version_build_numberField;
            }
            set {
                this.os_version_build_numberField = value;
            }
        }
        public EntityStateStringType os_version_release_name {
            get {
                return this.os_version_release_nameField;
            }
            set {
                this.os_version_release_nameField = value;
            }
        }
        public EntityStateIntType os_version_sdk_number {
            get {
                return this.os_version_sdk_numberField;
            }
            set {
                this.os_version_sdk_numberField = value;
            }
        }
        public EntityStateBoolType hardware_keystore {
            get {
                return this.hardware_keystoreField;
            }
            set {
                this.hardware_keystoreField = value;
            }
        }
    }

}

