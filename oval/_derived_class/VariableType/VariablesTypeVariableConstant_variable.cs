using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5")]
    [XmlRootAttribute("constant_variable", Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5", IsNullable=false)]
    public class VariablesTypeVariableConstant_variable : VariableType {
        private ValueType[] valueField;
        [XmlElementAttribute("value")]
        public ValueType[] value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }

}

