using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(TypeName="EntityStateProtocolType", Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#linux")]
    public class EntityStateProtocolType1 : EntityStateStringType {
    }

}

