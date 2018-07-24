using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(TypeName="TestType", Namespace="http://oval.mitre.org/XMLSchema/oval-results-5")]
    public class TestType1 {
        private MessageType[] messageField;
        private TestedItemType[] tested_itemField;
        private TestedVariableType[] tested_variableField;
        private string test_idField;
        private string versionField;
        private string variable_instanceField;
    [XmlIgnore]
    public ExistenceEnumeration? check_existenceField       { get; set; }
    public bool check_existenceSpecified=>check_existenceField.HasValue;
    [XmlIgnore]
    public CheckEnumeration? checkField       { get; set; }
    public bool checkSpecified=>checkField.HasValue;
    [XmlIgnore]
    public OperatorEnumeration? state_operatorField       { get; set; }
    public bool state_operatorSpecified=>state_operatorField.HasValue;
    [XmlIgnore]
    public ResultEnumeration? resultField       { get; set; }
    public bool resultSpecified=>resultField.HasValue;
        public TestType1() {
            /*this.variable_instanceField = "1";
            this.check_existenceField = ExistenceEnumeration.at_least_one_exists;
            this.state_operatorField = OperatorEnumeration.AND;*/
        }
        [XmlElementAttribute("message")]
        public MessageType[] message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
            }
        }
        [XmlElementAttribute("tested_item")]
        public TestedItemType[] tested_item {
            get {
                return this.tested_itemField;
            }
            set {
                this.tested_itemField = value;
            }
        }
        [XmlElementAttribute("tested_variable")]
        public TestedVariableType[] tested_variable {
            get {
                return this.tested_variableField;
            }
            set {
                this.tested_variableField = value;
            }
        }
        [XmlAttribute]
        public string test_id {
            get {
                return this.test_idField;
            }
            set {
                this.test_idField = value;
            }
        }
        [XmlAttribute(DataType="nonNegativeInteger")]
        public string version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
        [XmlAttribute(DataType="nonNegativeInteger")]
        public string variable_instance {
            get {
                return this.variable_instanceField;
            }
            set {
                this.variable_instanceField = value;
            }
        }
        [XmlAttribute]
        public ExistenceEnumeration check_existence {
            get {
                return this.check_existenceField.Value;
            }
            set {
                this.check_existenceField = value;
            }
        }
        [XmlAttribute]
        public CheckEnumeration check {
            get {
                return this.checkField.Value;
            }
            set {
                this.checkField = value;
            }
        }
        [XmlAttribute]
        public OperatorEnumeration state_operator {
            get {
                return this.state_operatorField.Value;
            }
            set {
                this.state_operatorField = value;
            }
        }
        [XmlAttribute]
        public ResultEnumeration result {
            get {
                return this.resultField.Value;
            }
            set {
                this.resultField = value;
            }
        }
    }

}

