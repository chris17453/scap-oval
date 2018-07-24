using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#esx")]
    [XmlRootAttribute("version_object", Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#esx", IsNullable=false)]
    public class version_object5 : ObjectType1 {
    }

}

