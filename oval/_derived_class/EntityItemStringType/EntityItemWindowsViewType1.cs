using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(TypeName="EntityItemWindowsViewType", Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#windows")]
    public class EntityItemWindowsViewType1 : EntityItemStringType {
    }

}

