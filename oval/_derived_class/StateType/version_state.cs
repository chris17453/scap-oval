using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#pixos")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#pixos", IsNullable=false)]
    public class version_state : StateType {
        private EntityStateStringType pix_releaseField;
        private EntityStateVersionType pix_major_releaseField;
        private EntityStateVersionType pix_minor_releaseField;
        private EntityStateIntType pix_buildField;
        public EntityStateStringType pix_release {
            get {
                return this.pix_releaseField;
            }
            set {
                this.pix_releaseField = value;
            }
        }
        public EntityStateVersionType pix_major_release {
            get {
                return this.pix_major_releaseField;
            }
            set {
                this.pix_major_releaseField = value;
            }
        }
        public EntityStateVersionType pix_minor_release {
            get {
                return this.pix_minor_releaseField;
            }
            set {
                this.pix_minor_releaseField = value;
            }
        }
        public EntityStateIntType pix_build {
            get {
                return this.pix_buildField;
            }
            set {
                this.pix_buildField = value;
            }
        }
    }

}

