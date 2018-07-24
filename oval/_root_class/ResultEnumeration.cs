using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-results-5")]
    public enum ResultEnumeration {
        @true,
        @false,
        unknown,
        error,
        [XmlEnumAttribute("not evaluated")]
        notevaluated,
        [XmlEnumAttribute("not applicable")]
        notapplicable,
    }

}

