using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#unix")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#unix", IsNullable=false)]
    public class inetd_item : ItemType {
        private EntityItemStringType protocolField;
        private EntityItemStringType service_nameField;
        private EntityItemStringType server_programField;
        private EntityItemStringType server_argumentsField;
        private EntityItemEndpointType endpoint_typeField;
        private EntityItemStringType exec_as_userField;
        private EntityItemWaitStatusType wait_statusField;
        public EntityItemStringType protocol {
            get {
                return this.protocolField;
            }
            set {
                this.protocolField = value;
            }
        }
        public EntityItemStringType service_name {
            get {
                return this.service_nameField;
            }
            set {
                this.service_nameField = value;
            }
        }
        public EntityItemStringType server_program {
            get {
                return this.server_programField;
            }
            set {
                this.server_programField = value;
            }
        }
        public EntityItemStringType server_arguments {
            get {
                return this.server_argumentsField;
            }
            set {
                this.server_argumentsField = value;
            }
        }
        public EntityItemEndpointType endpoint_type {
            get {
                return this.endpoint_typeField;
            }
            set {
                this.endpoint_typeField = value;
            }
        }
        public EntityItemStringType exec_as_user {
            get {
                return this.exec_as_userField;
            }
            set {
                this.exec_as_userField = value;
            }
        }
        public EntityItemWaitStatusType wait_status {
            get {
                return this.wait_statusField;
            }
            set {
                this.wait_statusField = value;
            }
        }
    }

}

