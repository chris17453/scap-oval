using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#independent", IncludeInSchema=false)]
    public enum environmentvariable58_object_choice {
        name,
        pid,
        [XmlEnumAttribute("http://oval.mitre.org/XMLSchema/oval-definitions-5:filter")]
        filter,
        [XmlEnumAttribute("http://oval.mitre.org/XMLSchema/oval-definitions-5:set")]
        set
    }



    [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#independent")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#independent", IsNullable=false)]

    public class environmentvariable58_object : ObjectType1 {
        private object[] itemsField;
        [XmlElement("name"  , typeof(EntityObjectStringType))]
        [XmlElement("pid"   , typeof(EntityObjectIntType)   ,IsNullable=true)]
        [XmlElement("filter", typeof(filter)                , Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5")]
        [XmlElement("set"   , typeof(set)                   , Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5")]
        [XmlChoiceIdentifier("ItemsElementName")]
        public object[] Items { get {  return this.itemsField; } set { this.itemsField = value; } }
        [XmlIgnore]
        public  environmentvariable58_object_choice[] ItemsElementName { get; set; }
    }

}

