﻿using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#unix", IncludeInSchema=false)]
    public enum ItemsChoiceType46 {
        behaviors,
        filename,
        filepath,
        path,
        [XmlEnumAttribute("http://oval.mitre.org/XMLSchema/oval-definitions-5:filter")]
        filter,
        [XmlEnumAttribute("http://oval.mitre.org/XMLSchema/oval-definitions-5:set")]
        set,
    }

}

