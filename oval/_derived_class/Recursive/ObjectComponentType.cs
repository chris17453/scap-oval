using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5")]
    [XmlRoot ("object_component")]
    public class ObjectComponentType   {
        private ObjectComponentType object_componentField;
        private VariableComponentType variable_componentField;
        private LiteralComponentType literal_componentField;
        public ObjectComponentType object_component {
            get {
                return this.object_componentField;
            }
            set {
                this.object_componentField = value;
            }
        }
        public VariableComponentType variable_component {
            get {
                return this.variable_componentField;
            }
            set {
                this.variable_componentField = value;
            }
        }
        public LiteralComponentType literal_component {
            get {
                return this.literal_componentField;
            }
            set {
                this.literal_componentField = value;
            }
        }
    [XmlIgnore]
    public bool? glob_noescapeField       { get; set; }
    public bool glob_noescapeSpecified=>glob_noescapeField.HasValue;
        private string object_refField;
        private string item_fieldField;
        private string record_fieldField;
        [XmlAttribute]
        public string object_ref {
            get {
                return this.object_refField;
            }
            set {
                this.object_refField = value;
            }
        }
        [XmlAttribute]
        public string item_field {
            get {
                return this.item_fieldField;
            }
            set {
                this.item_fieldField = value;
            }
        }
        [XmlAttribute]
        public string record_field {
            get {
                return this.record_fieldField;
            }
            set {
                this.record_fieldField = value;
            }
        }
    }

}

