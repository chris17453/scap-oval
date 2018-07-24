using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5")]
    public class StateRefType {
        private string state_refField;
        [XmlAttribute]
        public string state_ref {
            get {
                return this.state_refField;
            }
            set {
                this.state_refField = value;
            }
        }
    }

}

