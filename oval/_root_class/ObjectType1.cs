using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(TypeName="ObjectType", Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5")]
    [XmlRootAttribute("object", Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5", IsNullable=true)]
    public class ObjectType1 {
        public ObjectType1() {
            //this.deprecatedField = false;
        }
        [XmlElement(Namespace="http://www.w3.org/2000/09/xmldsig#")]
        public SignatureType Signature { get { return this.signatureField; } set { this.signatureField = value; } }
        [XmlIgnore]
        public SignatureType signatureField;
        public bool   SignatureSpecified { get { if(signatureField==null) return false; return true; } }

        [XmlArray(Namespace="http://oval.mitre.org/XMLSchema/oval-common-5")]
        [XmlArrayItem("note", IsNullable=false)] 
        public string[] notes { get { return this.notesField; } set { this.notesField = value; } }
        [XmlIgnore]
        public string[] notesField;
        public bool   notesSpecified { get { if(notesField==null) return false; return true; } }

        [XmlAttribute]
        public string id { get { return this.idField; } set {  this.idField = value; } }
        [XmlIgnore]
        public string idField;
        public bool   idSpecified { get { if(idField==null) return false; return true; } }

        [XmlAttribute(DataType="nonNegativeInteger")]
        public string version { get { return this.versionField; } set { this.versionField = value; } }
        [XmlIgnore]
        public string versionField;
        public bool   versionSpecified { get { if(versionField==null) return false; return true; } }

        [XmlAttribute]
        public string comment { get { return this.commentField; } set { this.commentField = value; } }
        [XmlIgnore]
        public string commentField;
        public bool   commentSpecified { get { if(commentField==null) return false; return true; } }

        [XmlAttribute]
        public bool deprecated { get { return this.deprecatedField.Value; } set { this.deprecatedField = value; } }
        [XmlIgnore]
        public bool? deprecatedField       { get; set; }
        public bool deprecatedSpecified=>deprecatedField.HasValue;
        
    }

}

