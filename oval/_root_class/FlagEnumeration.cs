using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5")]
    public enum FlagEnumeration {
        error,
        complete,
        incomplete,
        [XmlEnumAttribute("does not exist")]
        doesnotexist,
        [XmlEnumAttribute("not collected")]
        notcollected,
        [XmlEnumAttribute("not applicable")]
        notapplicable,
    }

}

