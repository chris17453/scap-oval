using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#hpux")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#hpux", IsNullable=false)]
    public class getconf_item : ItemType {
        private EntityItemStringType parameter_nameField;
        private EntityItemStringType pathnameField;
        private EntityItemAnySimpleType outputField;
        public EntityItemStringType parameter_name {
            get {
                return this.parameter_nameField;
            }
            set {
                this.parameter_nameField = value;
            }
        }
        [XmlElementAttribute(IsNullable=true)]
        public EntityItemStringType pathname {
            get {
                return this.pathnameField;
            }
            set {
                this.pathnameField = value;
            }
        }
        public EntityItemAnySimpleType output {
            get {
                return this.outputField;
            }
            set {
                this.outputField = value;
            }
        }
    }

}

