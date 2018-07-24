using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#unix")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#unix", IsNullable=false)]
    public class uname_item : ItemType {
        private EntityItemStringType machine_classField;
        private EntityItemStringType node_nameField;
        private EntityItemStringType os_nameField;
        private EntityItemStringType os_releaseField;
        private EntityItemStringType os_versionField;
        private EntityItemStringType processor_typeField;
        public EntityItemStringType machine_class {
            get {
                return this.machine_classField;
            }
            set {
                this.machine_classField = value;
            }
        }
        public EntityItemStringType node_name {
            get {
                return this.node_nameField;
            }
            set {
                this.node_nameField = value;
            }
        }
        public EntityItemStringType os_name {
            get {
                return this.os_nameField;
            }
            set {
                this.os_nameField = value;
            }
        }
        public EntityItemStringType os_release {
            get {
                return this.os_releaseField;
            }
            set {
                this.os_releaseField = value;
            }
        }
        public EntityItemStringType os_version {
            get {
                return this.os_versionField;
            }
            set {
                this.os_versionField = value;
            }
        }
        public EntityItemStringType processor_type {
            get {
                return this.processor_typeField;
            }
            set {
                this.processor_typeField = value;
            }
        }
    }

}

