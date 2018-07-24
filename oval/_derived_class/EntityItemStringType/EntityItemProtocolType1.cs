using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(TypeName="EntityItemProtocolType", Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#linux")]
    public class EntityItemProtocolType1 : EntityItemStringType {
    }

}

