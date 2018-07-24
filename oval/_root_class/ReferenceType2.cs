using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(TypeName="ReferenceType", Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5")]
    public class ReferenceType2 {
        private string item_refField;
        [XmlAttribute(DataType="integer")]
        public string item_ref {
            get {
                return this.item_refField;
            }
            set {
                this.item_refField = value;
            }
        }
    }

}

