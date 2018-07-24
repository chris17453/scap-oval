using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-results-5")]
    public class SystemType {
        private DefinitionType1[] definitionsField;
        private TestType1[] testsField;
        private oval_system_characteristics oval_system_characteristicsField;
        [XmlArrayItemAttribute("definition", IsNullable=false)]
        public DefinitionType1[] definitions {
            get {
                return this.definitionsField;
            }
            set {
                this.definitionsField = value;
            }
        }
        [XmlArrayItemAttribute("test", IsNullable=false)]
        public TestType1[] tests {
            get {
                return this.testsField;
            }
            set {
                this.testsField = value;
            }
        }
        [XmlElementAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5")]
        public oval_system_characteristics oval_system_characteristics {
            get {
                return this.oval_system_characteristicsField;
            }
            set {
                this.oval_system_characteristicsField = value;
            }
        }
    }

}

