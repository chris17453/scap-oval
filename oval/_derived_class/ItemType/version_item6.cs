using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#asa")]
    [XmlRootAttribute("version_item", Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#asa", IsNullable=false)]
    public class version_item6 : ItemType {
        private EntityItemStringType asa_releaseField;
        private EntityItemVersionType asa_major_releaseField;
        private EntityItemVersionType asa_minor_releaseField;
        private EntityItemIntType asa_buildField;
        public EntityItemStringType asa_release {
            get {
                return this.asa_releaseField;
            }
            set {
                this.asa_releaseField = value;
            }
        }
        public EntityItemVersionType asa_major_release {
            get {
                return this.asa_major_releaseField;
            }
            set {
                this.asa_major_releaseField = value;
            }
        }
        public EntityItemVersionType asa_minor_release {
            get {
                return this.asa_minor_releaseField;
            }
            set {
                this.asa_minor_releaseField = value;
            }
        }
        public EntityItemIntType asa_build {
            get {
                return this.asa_buildField;
            }
            set {
                this.asa_buildField = value;
            }
        }
    }

}

