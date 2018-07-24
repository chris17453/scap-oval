using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#solaris")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#solaris", IsNullable=false)]
    public class smf_state : StateType {
        private EntityStateStringType fmriField;
        private EntityStateStringType service_nameField;
        private EntityStateSmfServiceStateType service_stateField;
        private EntityStateStringType protocolField;
        private EntityStateStringType server_executableField;
        private EntityStateStringType server_arguementsField;
        private EntityStateStringType exec_as_userField;
        public EntityStateStringType fmri {
            get {
                return this.fmriField;
            }
            set {
                this.fmriField = value;
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
        public EntityStateSmfServiceStateType service_state {
            get {
                return this.service_stateField;
            }
            set {
                this.service_stateField = value;
            }
        }
        public EntityStateStringType protocol {
            get {
                return this.protocolField;
            }
            set {
                this.protocolField = value;
            }
        }
        public EntityStateStringType server_executable {
            get {
                return this.server_executableField;
            }
            set {
                this.server_executableField = value;
            }
        }
        public EntityStateStringType server_arguements {
            get {
                return this.server_arguementsField;
            }
            set {
                this.server_arguementsField = value;
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
    }

}

