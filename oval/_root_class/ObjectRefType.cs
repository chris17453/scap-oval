using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5")]
    public class ObjectRefType {
        private string object_refField;
        [XmlAttribute]
        public string object_ref {
            get {
                return this.object_refField;
            }
            set {
                this.object_refField = value;
            }
        }
    }

}

