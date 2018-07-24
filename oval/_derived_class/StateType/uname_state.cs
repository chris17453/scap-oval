using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#unix")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#unix", IsNullable=false)]
    public class uname_state : StateType {
        private EntityStateStringType machine_classField;
        private EntityStateStringType node_nameField;
        private EntityStateStringType os_nameField;
        private EntityStateStringType os_releaseField;
        private EntityStateStringType os_versionField;
        private EntityStateStringType processor_typeField;
        public EntityStateStringType machine_class {
            get {
                return this.machine_classField;
            }
            set {
                this.machine_classField = value;
            }
        }
        public EntityStateStringType node_name {
            get {
                return this.node_nameField;
            }
            set {
                this.node_nameField = value;
            }
        }
        public EntityStateStringType os_name {
            get {
                return this.os_nameField;
            }
            set {
                this.os_nameField = value;
            }
        }
        public EntityStateStringType os_release {
            get {
                return this.os_releaseField;
            }
            set {
                this.os_releaseField = value;
            }
        }
        public EntityStateStringType os_version {
            get {
                return this.os_versionField;
            }
            set {
                this.os_versionField = value;
            }
        }
        public EntityStateStringType processor_type {
            get {
                return this.processor_typeField;
            }
            set {
                this.processor_typeField = value;
            }
        }
    }

}

