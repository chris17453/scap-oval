using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#solaris")]
    public class PatchBehaviors {
    [XmlIgnore]
    public bool? supersedenceField       { get; set; }
    public bool supersedenceSpecified=>supersedenceField.HasValue;
        public PatchBehaviors() {
            //this.supersedenceField = false;
        }
        [XmlAttribute]
        public bool supersedence {
            get {
                return this.supersedenceField.Value;
            }
            set {
                this.supersedenceField = value;
            }
        }
    }

}

