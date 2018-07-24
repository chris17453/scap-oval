using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#solaris")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#solaris", IsNullable=false)]
    public class smf_item : ItemType {
        private EntityItemStringType fmriField;
        private EntityItemStringType service_nameField;
        private EntityItemSmfServiceStateType service_stateField;
        private EntityItemStringType[] protocolField;
        private EntityItemStringType server_executableField;
        private EntityItemStringType server_arguementsField;
        private EntityItemStringType exec_as_userField;
        public EntityItemStringType fmri {
            get {
                return this.fmriField;
            }
            set {
                this.fmriField = value;
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
        public EntityItemSmfServiceStateType service_state {
            get {
                return this.service_stateField;
            }
            set {
                this.service_stateField = value;
            }
        }
        [XmlElementAttribute("protocol")]
        public EntityItemStringType[] protocol {
            get {
                return this.protocolField;
            }
            set {
                this.protocolField = value;
            }
        }
        public EntityItemStringType server_executable {
            get {
                return this.server_executableField;
            }
            set {
                this.server_executableField = value;
            }
        }
        public EntityItemStringType server_arguements {
            get {
                return this.server_arguementsField;
            }
            set {
                this.server_arguementsField = value;
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
    }

}

