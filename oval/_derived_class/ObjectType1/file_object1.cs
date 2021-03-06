﻿using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#unix")]
    [XmlRootAttribute("file_object", Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#unix", IsNullable=false)]
    public class file_object1 : ObjectType1 {
        private object[] itemsField;
        private ItemsChoiceType46[] itemsElementNameField;
        [XmlElementAttribute("behaviors", typeof(FileBehaviors2))]
        [XmlElementAttribute("filename", typeof(EntityObjectStringType), IsNullable=true)]
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
        public ItemsChoiceType46[] ItemsElementName {
            get {
                return this.itemsElementNameField;
            }
            set {
                this.itemsElementNameField = value;
            }
        }
    }

}

