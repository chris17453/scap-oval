using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(TypeName="EntityStateWindowsViewType", Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#windows")]
    public class EntityStateWindowsViewType1 : EntityStateStringType {
    }

}

