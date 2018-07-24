using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#junos")]
    [XmlRootAttribute("version_state", Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#junos", IsNullable=false)]
    public class version_state1 : StateType {
        private EntityStateStringType componentField;
        private EntityStateStringType raw_valueField;
        private EntityStateIntType majorField;
        private EntityStateIntType minorField;
        private EntityStateJunosReleaseTypeType typeField;
        private EntityStateIntType buildField;
        private EntityStateIntType maintenance_releaseField;
        private EntityStateIntType spinField;
        private EntityStateIntType build_dateField;
        public EntityStateStringType component {
            get {
                return this.componentField;
            }
            set {
                this.componentField = value;
            }
        }
        public EntityStateStringType raw_value {
            get {
                return this.raw_valueField;
            }
            set {
                this.raw_valueField = value;
            }
        }
        public EntityStateIntType major {
            get {
                return this.majorField;
            }
            set {
                this.majorField = value;
            }
        }
        public EntityStateIntType minor {
            get {
                return this.minorField;
            }
            set {
                this.minorField = value;
            }
        }
        public EntityStateJunosReleaseTypeType type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        public EntityStateIntType build {
            get {
                return this.buildField;
            }
            set {
                this.buildField = value;
            }
        }
        public EntityStateIntType maintenance_release {
            get {
                return this.maintenance_releaseField;
            }
            set {
                this.maintenance_releaseField = value;
            }
        }
        public EntityStateIntType spin {
            get {
                return this.spinField;
            }
            set {
                this.spinField = value;
            }
        }
        public EntityStateIntType build_date {
            get {
                return this.build_dateField;
            }
            set {
                this.build_dateField = value;
            }
        }
    }

}

