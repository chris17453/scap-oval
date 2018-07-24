using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#solaris", IncludeInSchema=false)]
    public enum ItemsChoiceType35 {
        name,
        publisher,
        timestamp,
        version,
        [XmlEnumAttribute("http://oval.mitre.org/XMLSchema/oval-definitions-5:filter")]
        filter,
        [XmlEnumAttribute("http://oval.mitre.org/XMLSchema/oval-definitions-5:set")]
        set,
    }

}

