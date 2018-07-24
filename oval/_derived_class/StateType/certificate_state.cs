using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#android")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#android", IsNullable=false)]
    public class certificate_state : StateType {
        private EntityStateBinaryType[] trusted_certificateField;
        [XmlElementAttribute("trusted_certificate")]
        public EntityStateBinaryType[] trusted_certificate {
            get {
                return this.trusted_certificateField;
            }
            set {
                this.trusted_certificateField = value;
            }
        }
    }

}

