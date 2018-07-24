using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-common-5")]
    public enum ExistenceEnumeration {
        all_exist,
        any_exist,
        at_least_one_exists,
        none_exist,
        only_one_exists,
    }

}

