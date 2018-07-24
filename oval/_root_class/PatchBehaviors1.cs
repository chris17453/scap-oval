using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(TypeName="PatchBehaviors", Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#esx")]
    public class PatchBehaviors1 {
    [XmlIgnore]
    public bool? supersedenceField       { get; set; }
    public bool supersedenceSpecified=>supersedenceField.HasValue;
        public PatchBehaviors1() {
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

