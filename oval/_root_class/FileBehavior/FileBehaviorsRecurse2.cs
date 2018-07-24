using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#unix")]
    public enum FileBehaviorsRecurse2 {
        none,
        files,
        directories,
        [XmlEnumAttribute("files and directories")]
        filesanddirectories,
        symlinks,
        [XmlEnumAttribute("symlinks and directories")]
        symlinksanddirectories,
    }

}

