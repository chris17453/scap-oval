﻿using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#ios")]
    [XmlRootAttribute("interface_object", Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#ios", IsNullable=false)]
    public class interface_object2 : ObjectType1 {
        private object[] itemsField;
        [XmlElementAttribute("name", typeof(EntityObjectStringType))]
        [XmlElementAttribute("filter", typeof(filter), Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5")]
        [XmlElementAttribute("set", typeof(set), Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5")]
        public object[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
    }

}

