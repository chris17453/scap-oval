﻿using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#junos")]
    public class EntityStateJunosReleaseTypeType : EntityStateStringType {
    }

}
