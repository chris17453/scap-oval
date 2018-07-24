using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#linux")]
    [XmlRootAttribute("inetlisteningservers_object", Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#linux", IsNullable=false)]
    public class inetlisteningservers_object1 : ObjectType1 {
        private object[] itemsField;
        [XmlElementAttribute("local_address", typeof(EntityObjectIPAddressStringType))]
        [XmlElementAttribute("local_port", typeof(EntityObjectIntType))]
        [XmlElementAttribute("protocol", typeof(EntityObjectStringType))]
        [XmlElementAttribute("filter", typeof(filter), Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5")]
        [XmlElementAttribute("set", typeof(set), Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5")]
        public object[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
    }

}

