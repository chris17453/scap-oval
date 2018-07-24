using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#esx")]
    [XmlRootAttribute("version_item", Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#esx", IsNullable=false)]
    public class version_item5 : ItemType {
        private EntityItemVersionType releaseField;
        private EntityItemIntType buildField;
        public EntityItemVersionType release {
            get {
                return this.releaseField;
            }
            set {
                this.releaseField = value;
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
    }

}

