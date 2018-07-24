using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#catos")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#catos", IsNullable=false)]
    public class module_item : ItemType {
        private EntityItemIntType module_numberField;
        private EntityItemStringType typeField;
        private EntityItemStringType modelField;
        private EntityItemVersionType software_major_releaseField;
        private EntityItemIntType software_individual_releaseField;
        private EntityItemStringType software_version_idField;
        private EntityItemVersionType hardware_major_releaseField;
        private EntityItemIntType hardware_individual_releaseField;
        private EntityItemVersionType firmware_major_releaseField;
        private EntityItemIntType firmware_individual_releaseField;
        public EntityItemIntType module_number {
            get {
                return this.module_numberField;
            }
            set {
                this.module_numberField = value;
            }
        }
        public EntityItemStringType type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
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
        public EntityItemVersionType software_major_release {
            get {
                return this.software_major_releaseField;
            }
            set {
                this.software_major_releaseField = value;
            }
        }
        public EntityItemIntType software_individual_release {
            get {
                return this.software_individual_releaseField;
            }
            set {
                this.software_individual_releaseField = value;
            }
        }
        public EntityItemStringType software_version_id {
            get {
                return this.software_version_idField;
            }
            set {
                this.software_version_idField = value;
            }
        }
        public EntityItemVersionType hardware_major_release {
            get {
                return this.hardware_major_releaseField;
            }
            set {
                this.hardware_major_releaseField = value;
            }
        }
        public EntityItemIntType hardware_individual_release {
            get {
                return this.hardware_individual_releaseField;
            }
            set {
                this.hardware_individual_releaseField = value;
            }
        }
        public EntityItemVersionType firmware_major_release {
            get {
                return this.firmware_major_releaseField;
            }
            set {
                this.firmware_major_releaseField = value;
            }
        }
        public EntityItemIntType firmware_individual_release {
            get {
                return this.firmware_individual_releaseField;
            }
            set {
                this.firmware_individual_releaseField = value;
            }
        }
    }

}

