using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#catos")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#catos", IsNullable=false)]
    public class module_state : StateType {
        private EntityStateIntType module_numberField;
        private EntityStateStringType typeField;
        private EntityStateStringType modelField;
        private EntityStateVersionType software_major_releaseField;
        private EntityStateIntType software_individual_releaseField;
        private EntityStateStringType software_version_idField;
        private EntityStateVersionType hardware_major_releaseField;
        private EntityStateIntType hardware_individual_releaseField;
        private EntityStateVersionType firmware_major_releaseField;
        private EntityStateIntType firmware_individual_releaseField;
        public EntityStateIntType module_number {
            get {
                return this.module_numberField;
            }
            set {
                this.module_numberField = value;
            }
        }
        public EntityStateStringType type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
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
        public EntityStateVersionType software_major_release {
            get {
                return this.software_major_releaseField;
            }
            set {
                this.software_major_releaseField = value;
            }
        }
        public EntityStateIntType software_individual_release {
            get {
                return this.software_individual_releaseField;
            }
            set {
                this.software_individual_releaseField = value;
            }
        }
        public EntityStateStringType software_version_id {
            get {
                return this.software_version_idField;
            }
            set {
                this.software_version_idField = value;
            }
        }
        public EntityStateVersionType hardware_major_release {
            get {
                return this.hardware_major_releaseField;
            }
            set {
                this.hardware_major_releaseField = value;
            }
        }
        public EntityStateIntType hardware_individual_release {
            get {
                return this.hardware_individual_releaseField;
            }
            set {
                this.hardware_individual_releaseField = value;
            }
        }
        public EntityStateVersionType firmware_major_release {
            get {
                return this.firmware_major_releaseField;
            }
            set {
                this.firmware_major_releaseField = value;
            }
        }
        public EntityStateIntType firmware_individual_release {
            get {
                return this.firmware_individual_releaseField;
            }
            set {
                this.firmware_individual_releaseField = value;
            }
        }
    }

}

