using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#asa")]
    [XmlRootAttribute("version_state", Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#asa", IsNullable=false)]
    public class version_state6 : StateType {
        private EntityStateStringType asa_releaseField;
        private EntityStateVersionType asa_major_releaseField;
        private EntityStateVersionType asa_minor_releaseField;
        private EntityStateIntType asa_buildField;
        public EntityStateStringType asa_release {
            get {
                return this.asa_releaseField;
            }
            set {
                this.asa_releaseField = value;
            }
        }
        public EntityStateVersionType asa_major_release {
            get {
                return this.asa_major_releaseField;
            }
            set {
                this.asa_major_releaseField = value;
            }
        }
        public EntityStateVersionType asa_minor_release {
            get {
                return this.asa_minor_releaseField;
            }
            set {
                this.asa_minor_releaseField = value;
            }
        }
        public EntityStateIntType asa_build {
            get {
                return this.asa_buildField;
            }
            set {
                this.asa_buildField = value;
            }
        }
    }

}

