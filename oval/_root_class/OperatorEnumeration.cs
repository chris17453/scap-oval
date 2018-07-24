using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-common-5")]
    public enum OperatorEnumeration {
        AND,
        ONE,
        OR,
        XOR,
    }

}

