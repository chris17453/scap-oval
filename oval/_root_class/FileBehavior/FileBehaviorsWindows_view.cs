using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#independent")]
    public enum FileBehaviorsWindows_view {
        [XmlEnumAttribute("32_bit")]
        Item32_bit,
        [XmlEnumAttribute("64_bit")]
        Item64_bit,
    }

}

