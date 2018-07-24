using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(TypeName="EntityItemAccessListUseType", Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#asa")]
    public class EntityItemAccessListUseType2 : EntityItemStringType {
    }

}

