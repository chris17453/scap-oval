﻿using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#windows")]
    public enum FileBehaviorsRecurse1 {
        directories,
        junctions,
        [XmlEnumAttribute("junctions and directories")]
        junctionsanddirectories,
    }

}

