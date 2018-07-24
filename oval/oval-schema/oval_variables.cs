using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-variables-5")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-variables-5", IsNullable=false)]
    public class oval_variables {
        private GeneratorType generatorField;
        private VariableType1[] variablesField;
        private SignatureType signatureField;
        public GeneratorType generator {
            get {
                return this.generatorField;
            }
            set {
                this.generatorField = value;
            }
        }
        [XmlArrayItemAttribute("variable", IsNullable=false)]
        public VariableType1[] variables {
            get {
                return this.variablesField;
            }
            set {
                this.variablesField = value;
            }
        }
        [XmlElementAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
        public SignatureType Signature {
            get {
                return this.signatureField;
            }
            set {
                this.signatureField = value;
            }
        }
    }

}

