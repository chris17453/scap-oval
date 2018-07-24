using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-directives-5")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-directives-5", IsNullable=false)]
    public class oval_directives {
        private GeneratorType generatorField;
        private DefaultDirectivesType directivesField;
        private ClassDirectivesType[] class_directivesField;
        private SignatureType signatureField;
        public GeneratorType generator {
            get {
                return this.generatorField;
            }
            set {
                this.generatorField = value;
            }
        }
        public DefaultDirectivesType directives {
            get {
                return this.directivesField;
            }
            set {
                this.directivesField = value;
            }
        }
        [XmlElementAttribute("class_directives")]
        public ClassDirectivesType[] class_directives {
            get {
                return this.class_directivesField;
            }
            set {
                this.class_directivesField = value;
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

