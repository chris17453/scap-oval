using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#independent")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#independent", IsNullable=false)]
    public class textfilecontent54_object : ObjectType1 {
        private object[] itemsField;
        private ItemsChoiceType9[] itemsElementNameField;
        [XmlElement(ElementName="behaviors",Type = typeof(Textfilecontent54Behaviors))]
        [XmlElement(ElementName="filename" ,Type = typeof(EntityObjectStringType))]
        [XmlElement(ElementName="filepath" ,Type = typeof(EntityObjectStringType))]
        [XmlElement(ElementName="instance" ,Type = typeof(EntityObjectIntType)   )]
        [XmlElement(ElementName="path"     ,Type = typeof(EntityObjectStringType))]
        [XmlElement(ElementName="pattern"  ,Type = typeof(EntityObjectStringType))]
        [XmlElement(ElementName="filter"   ,Type = typeof(filter)                ,Namespace ="http://oval.mitre.org/XMLSchema/oval-definitions-5")]
        [XmlElement(ElementName="set"      ,Type = typeof(set)                   ,Namespace ="http://oval.mitre.org/XMLSchema/oval-definitions-5")]
        [XmlChoiceIdentifier("ItemsElementName")]
        public object[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
        [XmlElementAttribute("ItemsElementName")]
        [XmlIgnoreAttribute]
        public ItemsChoiceType9[] ItemsElementName {
            get {
                return this.itemsElementNameField;
            }
            set {
                this.itemsElementNameField = value;
            }
        }
    }

}

