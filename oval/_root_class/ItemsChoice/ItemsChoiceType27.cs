﻿using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#windows", IncludeInSchema=false)]
    public enum ItemsChoiceType27 {
        behaviors,
        hive,
        key,
        trustee_name,
        [XmlEnumAttribute("http://oval.mitre.org/XMLSchema/oval-definitions-5:set")]
        set,
    }

}

