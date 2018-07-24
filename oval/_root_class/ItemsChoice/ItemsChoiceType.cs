using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#", IncludeInSchema=false)]
    public enum ItemsChoiceType {
        [XmlEnumAttribute("##any:")]
        Item,
        X509CRL,
        X509Certificate,
        X509IssuerSerial,
        X509SKI,
        X509SubjectName,
    }

}

