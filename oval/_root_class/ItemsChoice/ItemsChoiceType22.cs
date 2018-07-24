using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#windows", IncludeInSchema=false)]
    public enum ItemsChoiceType22 {
        behaviors,
        printer_name,
        trustee_sid,
        [XmlEnumAttribute("http://oval.mitre.org/XMLSchema/oval-definitions-5:filter")]
        filter,
        [XmlEnumAttribute("http://oval.mitre.org/XMLSchema/oval-definitions-5:set")]
        set,
    }

}

