using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#macos")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#macos", IsNullable=false)]
    public class launchd_item : ItemType {
        private EntityItemStringType labelField;
        private EntityItemIntType pidField;
        private EntityItemIntType status1Field;
        public EntityItemStringType label {
            get {
                return this.labelField;
            }
            set {
                this.labelField = value;
            }
        }
        public EntityItemIntType pid {
            get {
                return this.pidField;
            }
            set {
                this.pidField = value;
            }
        }
        [XmlElementAttribute("status")]
        public EntityItemIntType status1 {
            get {
                return this.status1Field;
            }
            set {
                this.status1Field = value;
            }
        }
    }

}

