using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#esx")]
    public class Patch56Behaviors {
    [XmlIgnore]
    public bool? supersedenceField       { get; set; }
    public bool supersedenceSpecified=>supersedenceField.HasValue;
        public Patch56Behaviors() {
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

