using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#catos")]
    [XmlRootAttribute("version_state", Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#catos", IsNullable=false)]
    public class version_state4 : StateType {
        private EntityStateStringType switch_seriesField;
        private EntityStateStringType image_nameField;
        private EntityStateVersionType catos_major_releaseField;
        private EntityStateIntType catos_individual_releaseField;
        private EntityStateStringType catos_version_idField;
        public EntityStateStringType switch_series {
            get {
                return this.switch_seriesField;
            }
            set {
                this.switch_seriesField = value;
            }
        }
        public EntityStateStringType image_name {
            get {
                return this.image_nameField;
            }
            set {
                this.image_nameField = value;
            }
        }
        public EntityStateVersionType catos_major_release {
            get {
                return this.catos_major_releaseField;
            }
            set {
                this.catos_major_releaseField = value;
            }
        }
        public EntityStateIntType catos_individual_release {
            get {
                return this.catos_individual_releaseField;
            }
            set {
                this.catos_individual_releaseField = value;
            }
        }
        public EntityStateStringType catos_version_id {
            get {
                return this.catos_version_idField;
            }
            set {
                this.catos_version_idField = value;
            }
        }
    }

}

