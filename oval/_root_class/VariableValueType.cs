using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5")]
    public class VariableValueType {
        private string variable_idField;
        private string valueField;
        [XmlAttribute]
        public string variable_id {
            get {
                return this.variable_idField;
            }
            set {
                this.variable_idField = value;
            }
        }
        [XmlTextAttribute]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }

}

