using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-results-5")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-results-5", IsNullable=false)]
    public class oval_results {
        private GeneratorType generatorField;
        private DefaultDirectivesType directivesField;
        private ClassDirectivesType[] class_directivesField;
        private oval_definitions oval_definitionsField;
        private SystemType[] resultsField;
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
        [XmlElementAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5")]
        public oval_definitions oval_definitions {
            get {
                return this.oval_definitionsField;
            }
            set {
                this.oval_definitionsField = value;
            }
        }
        [XmlArrayItemAttribute("system", IsNullable=false)]
        public SystemType[] results {
            get {
                return this.resultsField;
            }
            set {
                this.resultsField = value;
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

