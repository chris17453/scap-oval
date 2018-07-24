using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#esx")]
    [XmlRootAttribute("version_state", Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#esx", IsNullable=false)]
    public class version_state5 : StateType {
        private EntityStateVersionType releaseField;
        private EntityStateIntType buildField;
        public EntityStateVersionType release {
            get {
                return this.releaseField;
            }
            set {
                this.releaseField = value;
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
    }

}

