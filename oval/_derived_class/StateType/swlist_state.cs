using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#hpux")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#hpux", IsNullable=false)]
    public class swlist_state : StateType {
        private EntityStateStringType swlistField;
        private EntityStateStringType bundleField;
        private EntityStateStringType filesetField;
        private swlist_stateVersion version1Field;
        private EntityStateStringType titleField;
        private EntityStateStringType vendorField;
        public EntityStateStringType swlist {
            get {
                return this.swlistField;
            }
            set {
                this.swlistField = value;
            }
        }
        public EntityStateStringType bundle {
            get {
                return this.bundleField;
            }
            set {
                this.bundleField = value;
            }
        }
        public EntityStateStringType fileset {
            get {
                return this.filesetField;
            }
            set {
                this.filesetField = value;
            }
        }
        [XmlElementAttribute("version")]
        public swlist_stateVersion version1 {
            get {
                return this.version1Field;
            }
            set {
                this.version1Field = value;
            }
        }
        public EntityStateStringType title {
            get {
                return this.titleField;
            }
            set {
                this.titleField = value;
            }
        }
        public EntityStateStringType vendor {
            get {
                return this.vendorField;
            }
            set {
                this.vendorField = value;
            }
        }
    }

}

