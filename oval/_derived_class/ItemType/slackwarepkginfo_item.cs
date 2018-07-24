using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#linux")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#linux", IsNullable=false)]
    public class slackwarepkginfo_item : ItemType {
        private EntityItemStringType nameField;
        private slackwarepkginfo_itemVersion versionField;
        private EntityItemStringType architectureField;
        private EntityItemStringType revisionField;
        public EntityItemStringType name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        public slackwarepkginfo_itemVersion version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
        public EntityItemStringType architecture {
            get {
                return this.architectureField;
            }
            set {
                this.architectureField = value;
            }
        }
        public EntityItemStringType revision {
            get {
                return this.revisionField;
            }
            set {
                this.revisionField = value;
            }
        }
    }

}

