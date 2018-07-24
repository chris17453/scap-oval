using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#linux")]
    public class RpmInfoBehaviors {
    [XmlIgnore]
    public bool? filepathsField       { get; set; }
    public bool filepathsSpecified=>filepathsField.HasValue;
        public RpmInfoBehaviors() {
           // this.filepathsField = false;
        }
        [XmlAttribute]
        public bool filepaths {
            get {
                return this.filepathsField.Value;
            }
            set {
                this.filepathsField = value;
            }
        }
    }

}

