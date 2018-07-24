using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#catos")]
    [XmlRootAttribute("version_item", Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#catos", IsNullable=false)]
    public class version_item4 : ItemType {
        private EntityItemStringType switch_seriesField;
        private EntityItemStringType image_nameField;
        private EntityItemVersionType catos_releaseField;
        private EntityItemVersionType catos_major_releaseField;
        private EntityItemIntType catos_individual_releaseField;
        private EntityItemStringType catos_version_idField;
        public EntityItemStringType switch_series {
            get {
                return this.switch_seriesField;
            }
            set {
                this.switch_seriesField = value;
            }
        }
        public EntityItemStringType image_name {
            get {
                return this.image_nameField;
            }
            set {
                this.image_nameField = value;
            }
        }
        public EntityItemVersionType catos_release {
            get {
                return this.catos_releaseField;
            }
            set {
                this.catos_releaseField = value;
            }
        }
        public EntityItemVersionType catos_major_release {
            get {
                return this.catos_major_releaseField;
            }
            set {
                this.catos_major_releaseField = value;
            }
        }
        public EntityItemIntType catos_individual_release {
            get {
                return this.catos_individual_releaseField;
            }
            set {
                this.catos_individual_releaseField = value;
            }
        }
        public EntityItemStringType catos_version_id {
            get {
                return this.catos_version_idField;
            }
            set {
                this.catos_version_idField = value;
            }
        }
    }

}

