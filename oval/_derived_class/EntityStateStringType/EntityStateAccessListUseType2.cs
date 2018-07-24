using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(TypeName="EntityStateAccessListUseType", Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#asa")]
    public class EntityStateAccessListUseType2 : EntityStateStringType {
    }

}

