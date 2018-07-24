using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#android")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#android", IsNullable=false)]
    public class certificate_item : ItemType {
        private EntityItemBinaryType[] trusted_certificateField;
        [XmlElementAttribute("trusted_certificate")]
        public EntityItemBinaryType[] trusted_certificate {
            get {
                return this.trusted_certificateField;
            }
            set {
                this.trusted_certificateField = value;
            }
        }
    }

}

