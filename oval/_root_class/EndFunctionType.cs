using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5")]
   // [XmlRoot ("end")]
    public class EndFunctionType: recursive_base {
        private string characterField;
        [XmlAttribute]
        public string character {
            get {
                return this.characterField;
            }
            set {
                this.characterField = value;
            }
        }
    }

}

