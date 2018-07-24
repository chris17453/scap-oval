using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#independent")]
    public enum FileBehaviorsRecurse {
        directories,
        symlinks,
        [XmlEnumAttribute("symlinks and directories")]
        symlinksanddirectories,
    }

}

