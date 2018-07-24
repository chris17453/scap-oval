using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#catos")]
    [XmlRootAttribute("version_object", Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#catos", IsNullable=false)]
    public class version_object4 : ObjectType1 {
    }

}

