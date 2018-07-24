using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#independent", IncludeInSchema=false)]
    public enum ItemsChoiceType9 {
        behaviors,
        filename,
        filepath,
        //[XmlEnumAttribute("http://oval.mitre.org/XMLSchema/oval-definitions-5:instance")]
        instance,
        path,
        pattern,
        [XmlEnumAttribute("http://oval.mitre.org/XMLSchema/oval-definitions-5:filter")]
        filter,
        [XmlEnumAttribute("http://oval.mitre.org/XMLSchema/oval-definitions-5:set")]
        set
    }

}

