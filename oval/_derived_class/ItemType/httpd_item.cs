using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#apache")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#apache", IsNullable=false)]
    public class httpd_item : ItemType {
        private EntityItemStringType pathField;
        private EntityItemStringType binary_nameField;
        private EntityItemVersionType versionField;
        public EntityItemStringType path {
            get {
                return this.pathField;
            }
            set {
                this.pathField = value;
            }
        }
        public EntityItemStringType binary_name {
            get {
                return this.binary_nameField;
            }
            set {
                this.binary_nameField = value;
            }
        }
        public EntityItemVersionType version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
    }

}

