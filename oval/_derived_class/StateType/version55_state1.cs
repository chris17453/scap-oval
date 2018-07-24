using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#catos")]
    [XmlRootAttribute("version55_state", Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#catos", IsNullable=false)]
    public class version55_state1 : StateType {
        private EntityStateStringType switch_seriesField;
        private EntityStateStringType image_nameField;
        private EntityStateVersionType catos_releaseField;
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
        public EntityStateVersionType catos_release {
            get {
                return this.catos_releaseField;
            }
            set {
                this.catos_releaseField = value;
            }
        }
    }

}

