using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-common-5")]
    public enum OperationEnumeration {
        equals,
        [XmlEnumAttribute("not equal")]
        notequal,
        [XmlEnumAttribute("case insensitive equals")]
        caseinsensitiveequals,
        [XmlEnumAttribute("case insensitive not equal")]
        caseinsensitivenotequal,
        [XmlEnumAttribute("greater than")]
        greaterthan,
        [XmlEnumAttribute("less than")]
        lessthan,
        [XmlEnumAttribute("greater than or equal")]
        greaterthanorequal,
        [XmlEnumAttribute("less than or equal")]
        lessthanorequal,
        [XmlEnumAttribute("bitwise and")]
        bitwiseand,
        [XmlEnumAttribute("bitwise or")]
        bitwiseor,
        [XmlEnumAttribute("pattern match")]
        patternmatch,
        [XmlEnumAttribute("subset of")]
        subsetof,
        [XmlEnumAttribute("superset of")]
        supersetof,
    }

}

