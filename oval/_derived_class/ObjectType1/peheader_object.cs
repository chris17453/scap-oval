﻿using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#windows")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#windows", IsNullable=false)]
    public class peheader_object : ObjectType1 {
        private object[] itemsField;
        private ItemsChoiceType21[] itemsElementNameField;
        [XmlElementAttribute("behaviors", typeof(FileBehaviors1))]
        [XmlElementAttribute("filename", typeof(EntityObjectStringType))]
        [XmlElementAttribute("filepath", typeof(EntityObjectStringType))]
        [XmlElementAttribute("path", typeof(EntityObjectStringType))]
        [XmlElementAttribute("filter", typeof(filter), Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5")]
        [XmlElementAttribute("set", typeof(set), Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5")]
        [XmlChoiceIdentifierAttribute("ItemsElementName")]
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
        public ItemsChoiceType21[] ItemsElementName {
            get {
                return this.itemsElementNameField;
            }
            set {
                this.itemsElementNameField = value;
            }
        }
    }

}

