using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(TypeName="EntityStateSNMPPrivStringType", Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#asa")]
    public class EntityStateSNMPPrivStringType2 : EntityStateStringType {
    }

}

