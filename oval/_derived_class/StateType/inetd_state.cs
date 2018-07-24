using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#unix")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#unix", IsNullable=false)]
    public class inetd_state : StateType {
        private EntityStateStringType protocolField;
        private EntityStateStringType service_nameField;
        private EntityStateStringType server_programField;
        private EntityStateStringType server_argumentsField;
        private EntityStateEndpointType endpoint_typeField;
        private EntityStateStringType exec_as_userField;
        private EntityStateWaitStatusType wait_statusField;
        public EntityStateStringType protocol {
            get {
                return this.protocolField;
            }
            set {
                this.protocolField = value;
            }
        }
        public EntityStateStringType service_name {
            get {
                return this.service_nameField;
            }
            set {
                this.service_nameField = value;
            }
        }
        public EntityStateStringType server_program {
            get {
                return this.server_programField;
            }
            set {
                this.server_programField = value;
            }
        }
        public EntityStateStringType server_arguments {
            get {
                return this.server_argumentsField;
            }
            set {
                this.server_argumentsField = value;
            }
        }
        public EntityStateEndpointType endpoint_type {
            get {
                return this.endpoint_typeField;
            }
            set {
                this.endpoint_typeField = value;
            }
        }
        public EntityStateStringType exec_as_user {
            get {
                return this.exec_as_userField;
            }
            set {
                this.exec_as_userField = value;
            }
        }
        public EntityStateWaitStatusType wait_status {
            get {
                return this.wait_statusField;
            }
            set {
                this.wait_statusField = value;
            }
        }
    }

}

