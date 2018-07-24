using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#windows")]
    public enum FileBehaviorsWindows_view1 {
        [XmlEnumAttribute("32_bit")]
        Item32_bit,
        [XmlEnumAttribute("64_bit")]
        Item64_bit,
    }

}

