using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5")]
    //[XmlRoot ("regex_capture")]
    public class RegexCaptureFunctionType : recursive_base  {
            private string patternField;
        [XmlAttribute]
        public string pattern {
            get {
                return this.patternField;
            }
            set {
                this.patternField = value;
            }
        }
    }

}

