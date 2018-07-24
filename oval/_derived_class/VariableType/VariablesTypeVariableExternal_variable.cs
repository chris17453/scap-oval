using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5")]
    [XmlRootAttribute("external_variable", Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5", IsNullable=false)]
    public class VariablesTypeVariableExternal_variable : VariableType {
        private object[] itemsField;
        [XmlElementAttribute("possible_restriction", typeof(PossibleRestrictionType))]
        [XmlElementAttribute("possible_value", typeof(PossibleValueType))]
        public object[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
    }

}

