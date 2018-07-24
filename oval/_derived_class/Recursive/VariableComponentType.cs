using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5")]
    [XmlRoot ("variable_component")]
    public class VariableComponentType   {
    [XmlIgnore]
    public bool? glob_noescapeField       { get; set; }
    public bool glob_noescapeSpecified=>glob_noescapeField.HasValue;
        private string var_refField;
        [XmlAttribute]
        public string var_ref {
            get {
                return this.var_refField;
            }
            set {
                this.var_refField = value;
            }
        }
    }

}

