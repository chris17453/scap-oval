using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#iosxe")]
    [XmlRootAttribute("section_item", Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#iosxe", IsNullable=false)]
    public class section_item1 : ItemType {
        private EntityItemStringType section_commandField;
        private EntityItemStringType section_config_linesField;
        private EntityItemStringType[] config_lineField;
        public EntityItemStringType section_command {
            get {
                return this.section_commandField;
            }
            set {
                this.section_commandField = value;
            }
        }
        public EntityItemStringType section_config_lines {
            get {
                return this.section_config_linesField;
            }
            set {
                this.section_config_linesField = value;
            }
        }
        [XmlElementAttribute("config_line")]
        public EntityItemStringType[] config_line {
            get {
                return this.config_lineField;
            }
            set {
                this.config_lineField = value;
            }
        }
    }

}

