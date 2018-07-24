using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#windows")]
    public class WuaUpdateSearcherBehaviors {
    [XmlIgnore]
    public bool? include_superseded_updatesField       { get; set; }
    public bool include_superseded_updatesSpecified=>include_superseded_updatesField.HasValue;
        public WuaUpdateSearcherBehaviors() {
            //this.include_superseded_updatesField = true;
        }
        [XmlAttribute]
        public bool include_superseded_updates {
            get {
                return this.include_superseded_updatesField.Value;
            }
            set {
                this.include_superseded_updatesField = value;
            }
        }
    }

}

