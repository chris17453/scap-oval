using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#windows")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#windows", IsNullable=false)]
    public class accesstoken_state : StateType {
        private EntityStateStringType security_principleField;
        private EntityStateBoolType seassignprimarytokenprivilegeField;
        private EntityStateBoolType seauditprivilegeField;
        private EntityStateBoolType sebackupprivilegeField;
        private EntityStateBoolType sechangenotifyprivilegeField;
        private EntityStateBoolType secreateglobalprivilegeField;
        private EntityStateBoolType secreatepagefileprivilegeField;
        private EntityStateBoolType secreatepermanentprivilegeField;
        private EntityStateBoolType secreatesymboliclinkprivilegeField;
        private EntityStateBoolType secreatetokenprivilegeField;
        private EntityStateBoolType sedebugprivilegeField;
        private EntityStateBoolType seenabledelegationprivilegeField;
        private EntityStateBoolType seimpersonateprivilegeField;
        private EntityStateBoolType seincreasebasepriorityprivilegeField;
        private EntityStateBoolType seincreasequotaprivilegeField;
        private EntityStateBoolType seincreaseworkingsetprivilegeField;
        private EntityStateBoolType seloaddriverprivilegeField;
        private EntityStateBoolType selockmemoryprivilegeField;
        private EntityStateBoolType semachineaccountprivilegeField;
        private EntityStateBoolType semanagevolumeprivilegeField;
        private EntityStateBoolType seprofilesingleprocessprivilegeField;
        private EntityStateBoolType serelabelprivilegeField;
        private EntityStateBoolType seremoteshutdownprivilegeField;
        private EntityStateBoolType serestoreprivilegeField;
        private EntityStateBoolType sesecurityprivilegeField;
        private EntityStateBoolType seshutdownprivilegeField;
        private EntityStateBoolType sesyncagentprivilegeField;
        private EntityStateBoolType sesystemenvironmentprivilegeField;
        private EntityStateBoolType sesystemprofileprivilegeField;
        private EntityStateBoolType sesystemtimeprivilegeField;
        private EntityStateBoolType setakeownershipprivilegeField;
        private EntityStateBoolType setcbprivilegeField;
        private EntityStateBoolType setimezoneprivilegeField;
        private EntityStateBoolType seundockprivilegeField;
        private EntityStateBoolType seunsolicitedinputprivilegeField;
        private EntityStateBoolType sebatchlogonrightField;
        private EntityStateBoolType seinteractivelogonrightField;
        private EntityStateBoolType senetworklogonrightField;
        private EntityStateBoolType seremoteinteractivelogonrightField;
        private EntityStateBoolType seservicelogonrightField;
        private EntityStateBoolType sedenybatchLogonrightField;
        private EntityStateBoolType sedenyinteractivelogonrightField;
        private EntityStateBoolType sedenynetworklogonrightField;
        private EntityStateBoolType sedenyremoteInteractivelogonrightField;
        private EntityStateBoolType sedenyservicelogonrightField;
        private EntityStateBoolType setrustedcredmanaccessnamerightField;
        public EntityStateStringType security_principle {
            get {
                return this.security_principleField;
            }
            set {
                this.security_principleField = value;
            }
        }
        public EntityStateBoolType seassignprimarytokenprivilege {
            get {
                return this.seassignprimarytokenprivilegeField;
            }
            set {
                this.seassignprimarytokenprivilegeField = value;
            }
        }
        public EntityStateBoolType seauditprivilege {
            get {
                return this.seauditprivilegeField;
            }
            set {
                this.seauditprivilegeField = value;
            }
        }
        public EntityStateBoolType sebackupprivilege {
            get {
                return this.sebackupprivilegeField;
            }
            set {
                this.sebackupprivilegeField = value;
            }
        }
        public EntityStateBoolType sechangenotifyprivilege {
            get {
                return this.sechangenotifyprivilegeField;
            }
            set {
                this.sechangenotifyprivilegeField = value;
            }
        }
        public EntityStateBoolType secreateglobalprivilege {
            get {
                return this.secreateglobalprivilegeField;
            }
            set {
                this.secreateglobalprivilegeField = value;
            }
        }
        public EntityStateBoolType secreatepagefileprivilege {
            get {
                return this.secreatepagefileprivilegeField;
            }
            set {
                this.secreatepagefileprivilegeField = value;
            }
        }
        public EntityStateBoolType secreatepermanentprivilege {
            get {
                return this.secreatepermanentprivilegeField;
            }
            set {
                this.secreatepermanentprivilegeField = value;
            }
        }
        public EntityStateBoolType secreatesymboliclinkprivilege {
            get {
                return this.secreatesymboliclinkprivilegeField;
            }
            set {
                this.secreatesymboliclinkprivilegeField = value;
            }
        }
        public EntityStateBoolType secreatetokenprivilege {
            get {
                return this.secreatetokenprivilegeField;
            }
            set {
                this.secreatetokenprivilegeField = value;
            }
        }
        public EntityStateBoolType sedebugprivilege {
            get {
                return this.sedebugprivilegeField;
            }
            set {
                this.sedebugprivilegeField = value;
            }
        }
        public EntityStateBoolType seenabledelegationprivilege {
            get {
                return this.seenabledelegationprivilegeField;
            }
            set {
                this.seenabledelegationprivilegeField = value;
            }
        }
        public EntityStateBoolType seimpersonateprivilege {
            get {
                return this.seimpersonateprivilegeField;
            }
            set {
                this.seimpersonateprivilegeField = value;
            }
        }
        public EntityStateBoolType seincreasebasepriorityprivilege {
            get {
                return this.seincreasebasepriorityprivilegeField;
            }
            set {
                this.seincreasebasepriorityprivilegeField = value;
            }
        }
        public EntityStateBoolType seincreasequotaprivilege {
            get {
                return this.seincreasequotaprivilegeField;
            }
            set {
                this.seincreasequotaprivilegeField = value;
            }
        }
        public EntityStateBoolType seincreaseworkingsetprivilege {
            get {
                return this.seincreaseworkingsetprivilegeField;
            }
            set {
                this.seincreaseworkingsetprivilegeField = value;
            }
        }
        public EntityStateBoolType seloaddriverprivilege {
            get {
                return this.seloaddriverprivilegeField;
            }
            set {
                this.seloaddriverprivilegeField = value;
            }
        }
        public EntityStateBoolType selockmemoryprivilege {
            get {
                return this.selockmemoryprivilegeField;
            }
            set {
                this.selockmemoryprivilegeField = value;
            }
        }
        public EntityStateBoolType semachineaccountprivilege {
            get {
                return this.semachineaccountprivilegeField;
            }
            set {
                this.semachineaccountprivilegeField = value;
            }
        }
        public EntityStateBoolType semanagevolumeprivilege {
            get {
                return this.semanagevolumeprivilegeField;
            }
            set {
                this.semanagevolumeprivilegeField = value;
            }
        }
        public EntityStateBoolType seprofilesingleprocessprivilege {
            get {
                return this.seprofilesingleprocessprivilegeField;
            }
            set {
                this.seprofilesingleprocessprivilegeField = value;
            }
        }
        public EntityStateBoolType serelabelprivilege {
            get {
                return this.serelabelprivilegeField;
            }
            set {
                this.serelabelprivilegeField = value;
            }
        }
        public EntityStateBoolType seremoteshutdownprivilege {
            get {
                return this.seremoteshutdownprivilegeField;
            }
            set {
                this.seremoteshutdownprivilegeField = value;
            }
        }
        public EntityStateBoolType serestoreprivilege {
            get {
                return this.serestoreprivilegeField;
            }
            set {
                this.serestoreprivilegeField = value;
            }
        }
        public EntityStateBoolType sesecurityprivilege {
            get {
                return this.sesecurityprivilegeField;
            }
            set {
                this.sesecurityprivilegeField = value;
            }
        }
        public EntityStateBoolType seshutdownprivilege {
            get {
                return this.seshutdownprivilegeField;
            }
            set {
                this.seshutdownprivilegeField = value;
            }
        }
        public EntityStateBoolType sesyncagentprivilege {
            get {
                return this.sesyncagentprivilegeField;
            }
            set {
                this.sesyncagentprivilegeField = value;
            }
        }
        public EntityStateBoolType sesystemenvironmentprivilege {
            get {
                return this.sesystemenvironmentprivilegeField;
            }
            set {
                this.sesystemenvironmentprivilegeField = value;
            }
        }
        public EntityStateBoolType sesystemprofileprivilege {
            get {
                return this.sesystemprofileprivilegeField;
            }
            set {
                this.sesystemprofileprivilegeField = value;
            }
        }
        public EntityStateBoolType sesystemtimeprivilege {
            get {
                return this.sesystemtimeprivilegeField;
            }
            set {
                this.sesystemtimeprivilegeField = value;
            }
        }
        public EntityStateBoolType setakeownershipprivilege {
            get {
                return this.setakeownershipprivilegeField;
            }
            set {
                this.setakeownershipprivilegeField = value;
            }
        }
        public EntityStateBoolType setcbprivilege {
            get {
                return this.setcbprivilegeField;
            }
            set {
                this.setcbprivilegeField = value;
            }
        }
        public EntityStateBoolType setimezoneprivilege {
            get {
                return this.setimezoneprivilegeField;
            }
            set {
                this.setimezoneprivilegeField = value;
            }
        }
        public EntityStateBoolType seundockprivilege {
            get {
                return this.seundockprivilegeField;
            }
            set {
                this.seundockprivilegeField = value;
            }
        }
        public EntityStateBoolType seunsolicitedinputprivilege {
            get {
                return this.seunsolicitedinputprivilegeField;
            }
            set {
                this.seunsolicitedinputprivilegeField = value;
            }
        }
        public EntityStateBoolType sebatchlogonright {
            get {
                return this.sebatchlogonrightField;
            }
            set {
                this.sebatchlogonrightField = value;
            }
        }
        public EntityStateBoolType seinteractivelogonright {
            get {
                return this.seinteractivelogonrightField;
            }
            set {
                this.seinteractivelogonrightField = value;
            }
        }
        public EntityStateBoolType senetworklogonright {
            get {
                return this.senetworklogonrightField;
            }
            set {
                this.senetworklogonrightField = value;
            }
        }
        public EntityStateBoolType seremoteinteractivelogonright {
            get {
                return this.seremoteinteractivelogonrightField;
            }
            set {
                this.seremoteinteractivelogonrightField = value;
            }
        }
        public EntityStateBoolType seservicelogonright {
            get {
                return this.seservicelogonrightField;
            }
            set {
                this.seservicelogonrightField = value;
            }
        }
        public EntityStateBoolType sedenybatchLogonright {
            get {
                return this.sedenybatchLogonrightField;
            }
            set {
                this.sedenybatchLogonrightField = value;
            }
        }
        public EntityStateBoolType sedenyinteractivelogonright {
            get {
                return this.sedenyinteractivelogonrightField;
            }
            set {
                this.sedenyinteractivelogonrightField = value;
            }
        }
        public EntityStateBoolType sedenynetworklogonright {
            get {
                return this.sedenynetworklogonrightField;
            }
            set {
                this.sedenynetworklogonrightField = value;
            }
        }
        public EntityStateBoolType sedenyremoteInteractivelogonright {
            get {
                return this.sedenyremoteInteractivelogonrightField;
            }
            set {
                this.sedenyremoteInteractivelogonrightField = value;
            }
        }
        public EntityStateBoolType sedenyservicelogonright {
            get {
                return this.sedenyservicelogonrightField;
            }
            set {
                this.sedenyservicelogonrightField = value;
            }
        }
        public EntityStateBoolType setrustedcredmanaccessnameright {
            get {
                return this.setrustedcredmanaccessnamerightField;
            }
            set {
                this.setrustedcredmanaccessnamerightField = value;
            }
        }
    }

}

