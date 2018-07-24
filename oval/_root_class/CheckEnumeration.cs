using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-common-5")]
    public enum CheckEnumeration {
        all,
        [XmlEnumAttribute("at least one")]
        atleastone,
        [XmlEnumAttribute("none exist")]
        noneexist,
        [XmlEnumAttribute("none satisfy")]
        nonesatisfy,
        [XmlEnumAttribute("only one")]
        onlyone,
    }

}

