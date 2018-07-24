using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#solaris")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#solaris", IsNullable=false)]
    public class patch_item : ItemType {
        private EntityItemIntType baseField;
        private EntityItemIntType versionField;
        public EntityItemIntType @base {
            get {
                return this.baseField;
            }
            set {
                this.baseField = value;
            }
        }
        public EntityItemIntType version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
    }

}

