using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5", IsNullable=false)]
    public class set {
        private object[] itemsField;
    [XmlIgnore]
    public SetOperatorEnumeration? set_operatorField       { get; set; }
    public bool set_operatorSpecified=>set_operatorField.HasValue;
        public set() {
            //this.set_operatorField = SetOperatorEnumeration.UNION;
        }
        [XmlElementAttribute("filter", typeof(filter))]
        [XmlElementAttribute("object_reference", typeof(string))]
        [XmlElementAttribute("set", typeof(set))]
        public object[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
        [XmlAttribute]
        public SetOperatorEnumeration set_operator {
            get {
                return this.set_operatorField.Value;
            }
            set {
                this.set_operatorField = value;
            }
        }
    }

}

