using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-common-5")]
    public enum FamilyEnumeration {
        android,
        asa,
        apple_ios,
        catos,
        ios,
        iosxe,
        junos,
        macos,
        pixos,
        undefined,
        unix,
        vmware_infrastructure,
        windows,
    }

}

