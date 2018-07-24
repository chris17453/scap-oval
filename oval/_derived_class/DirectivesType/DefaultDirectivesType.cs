using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-results-5")]
    public class DefaultDirectivesType : DirectivesType {
    [XmlIgnore]
    public bool? include_source_definitionsField       { get; set; }
    public bool include_source_definitionsSpecified=>include_source_definitionsField.HasValue;
        public DefaultDirectivesType() {
            //this.include_source_definitionsField = true;
        }
        [XmlAttribute]
        public bool include_source_definitions {
            get {
                return this.include_source_definitionsField.Value;
            }
            set {
                this.include_source_definitionsField = value;
            }
        }
    }

}

