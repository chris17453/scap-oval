using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [XmlIncludeAttribute(typeof(ClassDirectivesType))]
    [XmlIncludeAttribute(typeof(DefaultDirectivesType))]
    [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-results-5")]
    public class DirectivesType {
        private DirectiveType definition_trueField;
        private DirectiveType definition_falseField;
        private DirectiveType definition_unknownField;
        private DirectiveType definition_errorField;
        private DirectiveType definition_not_evaluatedField;
        private DirectiveType definition_not_applicableField;
        public DirectiveType definition_true {
            get {
                return this.definition_trueField;
            }
            set {
                this.definition_trueField = value;
            }
        }
        public DirectiveType definition_false {
            get {
                return this.definition_falseField;
            }
            set {
                this.definition_falseField = value;
            }
        }
        public DirectiveType definition_unknown {
            get {
                return this.definition_unknownField;
            }
            set {
                this.definition_unknownField = value;
            }
        }
        public DirectiveType definition_error {
            get {
                return this.definition_errorField;
            }
            set {
                this.definition_errorField = value;
            }
        }
        public DirectiveType definition_not_evaluated {
            get {
                return this.definition_not_evaluatedField;
            }
            set {
                this.definition_not_evaluatedField = value;
            }
        }
        public DirectiveType definition_not_applicable {
            get {
                return this.definition_not_applicableField;
            }
            set {
                this.definition_not_applicableField = value;
            }
        }
    }

}

