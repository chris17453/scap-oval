using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#ios")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#ios", IsNullable=false)]
    public class section_state : StateType {
        private EntityStateStringType section_commandField;
        private EntityStateStringType section_config_linesField;
        private EntityStateStringType config_lineField;
        public EntityStateStringType section_command {
            get {
                return this.section_commandField;
            }
            set {
                this.section_commandField = value;
            }
        }
        public EntityStateStringType section_config_lines {
            get {
                return this.section_config_linesField;
            }
            set {
                this.section_config_linesField = value;
            }
        }
        public EntityStateStringType config_line {
            get {
                return this.config_lineField;
            }
            set {
                this.config_lineField = value;
            }
        }
    }

}

