using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#junos")]
    [XmlRootAttribute("version_item", Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#junos", IsNullable=false)]
    public class version_item1 : ItemType {
        private EntityItemStringType componentField;
        private EntityItemStringType raw_valueField;
        private EntityItemIntType majorField;
        private EntityItemIntType minorField;
        private EntityItemJunosReleaseTypeType typeField;
        private EntityItemIntType buildField;
        private EntityItemIntType maintenance_releaseField;
        private EntityItemIntType spinField;
        private EntityItemIntType build_dateField;
        public EntityItemStringType component {
            get {
                return this.componentField;
            }
            set {
                this.componentField = value;
            }
        }
        public EntityItemStringType raw_value {
            get {
                return this.raw_valueField;
            }
            set {
                this.raw_valueField = value;
            }
        }
        public EntityItemIntType major {
            get {
                return this.majorField;
            }
            set {
                this.majorField = value;
            }
        }
        public EntityItemIntType minor {
            get {
                return this.minorField;
            }
            set {
                this.minorField = value;
            }
        }
        public EntityItemJunosReleaseTypeType type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        public EntityItemIntType build {
            get {
                return this.buildField;
            }
            set {
                this.buildField = value;
            }
        }
        public EntityItemIntType maintenance_release {
            get {
                return this.maintenance_releaseField;
            }
            set {
                this.maintenance_releaseField = value;
            }
        }
        public EntityItemIntType spin {
            get {
                return this.spinField;
            }
            set {
                this.spinField = value;
            }
        }
        public EntityItemIntType build_date {
            get {
                return this.build_dateField;
            }
            set {
                this.build_dateField = value;
            }
        }
    }

}

