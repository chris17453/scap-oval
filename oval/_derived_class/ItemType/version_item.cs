using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#pixos")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#pixos", IsNullable=false)]
    public class version_item : ItemType {
        private EntityItemStringType pix_releaseField;
        private EntityItemVersionType pix_major_releaseField;
        private EntityItemVersionType pix_minor_releaseField;
        private EntityItemIntType pix_buildField;
        public EntityItemStringType pix_release {
            get {
                return this.pix_releaseField;
            }
            set {
                this.pix_releaseField = value;
            }
        }
        public EntityItemVersionType pix_major_release {
            get {
                return this.pix_major_releaseField;
            }
            set {
                this.pix_major_releaseField = value;
            }
        }
        public EntityItemVersionType pix_minor_release {
            get {
                return this.pix_minor_releaseField;
            }
            set {
                this.pix_minor_releaseField = value;
            }
        }
        public EntityItemIntType pix_build {
            get {
                return this.pix_buildField;
            }
            set {
                this.pix_buildField = value;
            }
        }
    }

}

