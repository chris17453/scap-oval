using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-results-5")]
    public class ClassDirectivesType : DirectivesType {
    [XmlIgnore]
    public ClassEnumeration? classField       { get; set; }
    public bool classSpecified=>classField.HasValue;
        [XmlAttribute]
        public ClassEnumeration @class {
            get {
                return this.classField.Value;
            }
            set {
                this.classField = value;
            }
        }
    }

}

