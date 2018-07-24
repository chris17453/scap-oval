using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#apache")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#apache", IsNullable=false)]
    public class httpd_state : StateType {
        private EntityStateStringType pathField;
        private EntityStateStringType binary_nameField;
        private EntityStateVersionType version1Field;
        public EntityStateStringType path {
            get {
                return this.pathField;
            }
            set {
                this.pathField = value;
            }
        }
        [XmlElementAttribute(IsNullable=true)]
        public EntityStateStringType binary_name {
            get {
                return this.binary_nameField;
            }
            set {
                this.binary_nameField = value;
            }
        }
        [XmlElementAttribute("version")]
        public EntityStateVersionType version1 {
            get {
                return this.version1Field;
            }
            set {
                this.version1Field = value;
            }
        }
    }

}

