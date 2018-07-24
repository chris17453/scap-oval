using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#solaris")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#solaris", IsNullable=false)]
    public class patch_object : ObjectType1 {
        private object itemField;
        [XmlElementAttribute("base", typeof(EntityObjectIntType))]
        [XmlElementAttribute("set", typeof(set), Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5")]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
    }

}

