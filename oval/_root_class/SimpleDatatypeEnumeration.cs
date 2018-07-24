using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-common-5")]
    public enum SimpleDatatypeEnumeration {
        binary,
        boolean,
        evr_string,
        debian_evr_string,
        fileset_revision,
        @float,
        ios_version,
        @int,
        ipv4_address,
        ipv6_address,
        @string,
        version,
    }

}

