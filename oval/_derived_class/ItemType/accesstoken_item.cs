using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#windows")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#windows", IsNullable=false)]
    public class accesstoken_item : ItemType {
        private EntityItemStringType security_principleField;
        private EntityItemBoolType seassignprimarytokenprivilegeField;
        private EntityItemBoolType seauditprivilegeField;
        private EntityItemBoolType sebackupprivilegeField;
        private EntityItemBoolType sechangenotifyprivilegeField;
        private EntityItemBoolType secreateglobalprivilegeField;
        private EntityItemBoolType secreatepagefileprivilegeField;
        private EntityItemBoolType secreatepermanentprivilegeField;
        private EntityItemBoolType secreatesymboliclinkprivilegeField;
        private EntityItemBoolType secreatetokenprivilegeField;
        private EntityItemBoolType sedebugprivilegeField;
        private EntityItemBoolType seenabledelegationprivilegeField;
        private EntityItemBoolType seimpersonateprivilegeField;
        private EntityItemBoolType seincreasebasepriorityprivilegeField;
        private EntityItemBoolType seincreasequotaprivilegeField;
        private EntityItemBoolType seincreaseworkingsetprivilegeField;
        private EntityItemBoolType seloaddriverprivilegeField;
        private EntityItemBoolType selockmemoryprivilegeField;
        private EntityItemBoolType semachineaccountprivilegeField;
        private EntityItemBoolType semanagevolumeprivilegeField;
        private EntityItemBoolType seprofilesingleprocessprivilegeField;
        private EntityItemBoolType serelabelprivilegeField;
        private EntityItemBoolType seremoteshutdownprivilegeField;
        private EntityItemBoolType serestoreprivilegeField;
        private EntityItemBoolType sesecurityprivilegeField;
        private EntityItemBoolType seshutdownprivilegeField;
        private EntityItemBoolType sesyncagentprivilegeField;
        private EntityItemBoolType sesystemenvironmentprivilegeField;
        private EntityItemBoolType sesystemprofileprivilegeField;
        private EntityItemBoolType sesystemtimeprivilegeField;
        private EntityItemBoolType setakeownershipprivilegeField;
        private EntityItemBoolType setcbprivilegeField;
        private EntityItemBoolType setimezoneprivilegeField;
        private EntityItemBoolType seundockprivilegeField;
        private EntityItemBoolType seunsolicitedinputprivilegeField;
        private EntityItemBoolType sebatchlogonrightField;
        private EntityItemBoolType seinteractivelogonrightField;
        private EntityItemBoolType senetworklogonrightField;
        private EntityItemBoolType seremoteinteractivelogonrightField;
        private EntityItemBoolType seservicelogonrightField;
        private EntityItemBoolType sedenybatchLogonrightField;
        private EntityItemBoolType sedenyinteractivelogonrightField;
        private EntityItemBoolType sedenynetworklogonrightField;
        private EntityItemBoolType sedenyremoteInteractivelogonrightField;
        private EntityItemBoolType sedenyservicelogonrightField;
        private EntityItemBoolType setrustedcredmanaccessnamerightField;
        public EntityItemStringType security_principle {
            get {
                return this.security_principleField;
            }
            set {
                this.security_principleField = value;
            }
        }
        public EntityItemBoolType seassignprimarytokenprivilege {
            get {
                return this.seassignprimarytokenprivilegeField;
            }
            set {
                this.seassignprimarytokenprivilegeField = value;
            }
        }
        public EntityItemBoolType seauditprivilege {
            get {
                return this.seauditprivilegeField;
            }
            set {
                this.seauditprivilegeField = value;
            }
        }
        public EntityItemBoolType sebackupprivilege {
            get {
                return this.sebackupprivilegeField;
            }
            set {
                this.sebackupprivilegeField = value;
            }
        }
        public EntityItemBoolType sechangenotifyprivilege {
            get {
                return this.sechangenotifyprivilegeField;
            }
            set {
                this.sechangenotifyprivilegeField = value;
            }
        }
        public EntityItemBoolType secreateglobalprivilege {
            get {
                return this.secreateglobalprivilegeField;
            }
            set {
                this.secreateglobalprivilegeField = value;
            }
        }
        public EntityItemBoolType secreatepagefileprivilege {
            get {
                return this.secreatepagefileprivilegeField;
            }
            set {
                this.secreatepagefileprivilegeField = value;
            }
        }
        public EntityItemBoolType secreatepermanentprivilege {
            get {
                return this.secreatepermanentprivilegeField;
            }
            set {
                this.secreatepermanentprivilegeField = value;
            }
        }
        public EntityItemBoolType secreatesymboliclinkprivilege {
            get {
                return this.secreatesymboliclinkprivilegeField;
            }
            set {
                this.secreatesymboliclinkprivilegeField = value;
            }
        }
        public EntityItemBoolType secreatetokenprivilege {
            get {
                return this.secreatetokenprivilegeField;
            }
            set {
                this.secreatetokenprivilegeField = value;
            }
        }
        public EntityItemBoolType sedebugprivilege {
            get {
                return this.sedebugprivilegeField;
            }
            set {
                this.sedebugprivilegeField = value;
            }
        }
        public EntityItemBoolType seenabledelegationprivilege {
            get {
                return this.seenabledelegationprivilegeField;
            }
            set {
                this.seenabledelegationprivilegeField = value;
            }
        }
        public EntityItemBoolType seimpersonateprivilege {
            get {
                return this.seimpersonateprivilegeField;
            }
            set {
                this.seimpersonateprivilegeField = value;
            }
        }
        public EntityItemBoolType seincreasebasepriorityprivilege {
            get {
                return this.seincreasebasepriorityprivilegeField;
            }
            set {
                this.seincreasebasepriorityprivilegeField = value;
            }
        }
        public EntityItemBoolType seincreasequotaprivilege {
            get {
                return this.seincreasequotaprivilegeField;
            }
            set {
                this.seincreasequotaprivilegeField = value;
            }
        }
        public EntityItemBoolType seincreaseworkingsetprivilege {
            get {
                return this.seincreaseworkingsetprivilegeField;
            }
            set {
                this.seincreaseworkingsetprivilegeField = value;
            }
        }
        public EntityItemBoolType seloaddriverprivilege {
            get {
                return this.seloaddriverprivilegeField;
            }
            set {
                this.seloaddriverprivilegeField = value;
            }
        }
        public EntityItemBoolType selockmemoryprivilege {
            get {
                return this.selockmemoryprivilegeField;
            }
            set {
                this.selockmemoryprivilegeField = value;
            }
        }
        public EntityItemBoolType semachineaccountprivilege {
            get {
                return this.semachineaccountprivilegeField;
            }
            set {
                this.semachineaccountprivilegeField = value;
            }
        }
        public EntityItemBoolType semanagevolumeprivilege {
            get {
                return this.semanagevolumeprivilegeField;
            }
            set {
                this.semanagevolumeprivilegeField = value;
            }
        }
        public EntityItemBoolType seprofilesingleprocessprivilege {
            get {
                return this.seprofilesingleprocessprivilegeField;
            }
            set {
                this.seprofilesingleprocessprivilegeField = value;
            }
        }
        public EntityItemBoolType serelabelprivilege {
            get {
                return this.serelabelprivilegeField;
            }
            set {
                this.serelabelprivilegeField = value;
            }
        }
        public EntityItemBoolType seremoteshutdownprivilege {
            get {
                return this.seremoteshutdownprivilegeField;
            }
            set {
                this.seremoteshutdownprivilegeField = value;
            }
        }
        public EntityItemBoolType serestoreprivilege {
            get {
                return this.serestoreprivilegeField;
            }
            set {
                this.serestoreprivilegeField = value;
            }
        }
        public EntityItemBoolType sesecurityprivilege {
            get {
                return this.sesecurityprivilegeField;
            }
            set {
                this.sesecurityprivilegeField = value;
            }
        }
        public EntityItemBoolType seshutdownprivilege {
            get {
                return this.seshutdownprivilegeField;
            }
            set {
                this.seshutdownprivilegeField = value;
            }
        }
        public EntityItemBoolType sesyncagentprivilege {
            get {
                return this.sesyncagentprivilegeField;
            }
            set {
                this.sesyncagentprivilegeField = value;
            }
        }
        public EntityItemBoolType sesystemenvironmentprivilege {
            get {
                return this.sesystemenvironmentprivilegeField;
            }
            set {
                this.sesystemenvironmentprivilegeField = value;
            }
        }
        public EntityItemBoolType sesystemprofileprivilege {
            get {
                return this.sesystemprofileprivilegeField;
            }
            set {
                this.sesystemprofileprivilegeField = value;
            }
        }
        public EntityItemBoolType sesystemtimeprivilege {
            get {
                return this.sesystemtimeprivilegeField;
            }
            set {
                this.sesystemtimeprivilegeField = value;
            }
        }
        public EntityItemBoolType setakeownershipprivilege {
            get {
                return this.setakeownershipprivilegeField;
            }
            set {
                this.setakeownershipprivilegeField = value;
            }
        }
        public EntityItemBoolType setcbprivilege {
            get {
                return this.setcbprivilegeField;
            }
            set {
                this.setcbprivilegeField = value;
            }
        }
        public EntityItemBoolType setimezoneprivilege {
            get {
                return this.setimezoneprivilegeField;
            }
            set {
                this.setimezoneprivilegeField = value;
            }
        }
        public EntityItemBoolType seundockprivilege {
            get {
                return this.seundockprivilegeField;
            }
            set {
                this.seundockprivilegeField = value;
            }
        }
        public EntityItemBoolType seunsolicitedinputprivilege {
            get {
                return this.seunsolicitedinputprivilegeField;
            }
            set {
                this.seunsolicitedinputprivilegeField = value;
            }
        }
        public EntityItemBoolType sebatchlogonright {
            get {
                return this.sebatchlogonrightField;
            }
            set {
                this.sebatchlogonrightField = value;
            }
        }
        public EntityItemBoolType seinteractivelogonright {
            get {
                return this.seinteractivelogonrightField;
            }
            set {
                this.seinteractivelogonrightField = value;
            }
        }
        public EntityItemBoolType senetworklogonright {
            get {
                return this.senetworklogonrightField;
            }
            set {
                this.senetworklogonrightField = value;
            }
        }
        public EntityItemBoolType seremoteinteractivelogonright {
            get {
                return this.seremoteinteractivelogonrightField;
            }
            set {
                this.seremoteinteractivelogonrightField = value;
            }
        }
        public EntityItemBoolType seservicelogonright {
            get {
                return this.seservicelogonrightField;
            }
            set {
                this.seservicelogonrightField = value;
            }
        }
        public EntityItemBoolType sedenybatchLogonright {
            get {
                return this.sedenybatchLogonrightField;
            }
            set {
                this.sedenybatchLogonrightField = value;
            }
        }
        public EntityItemBoolType sedenyinteractivelogonright {
            get {
                return this.sedenyinteractivelogonrightField;
            }
            set {
                this.sedenyinteractivelogonrightField = value;
            }
        }
        public EntityItemBoolType sedenynetworklogonright {
            get {
                return this.sedenynetworklogonrightField;
            }
            set {
                this.sedenynetworklogonrightField = value;
            }
        }
        public EntityItemBoolType sedenyremoteInteractivelogonright {
            get {
                return this.sedenyremoteInteractivelogonrightField;
            }
            set {
                this.sedenyremoteInteractivelogonrightField = value;
            }
        }
        public EntityItemBoolType sedenyservicelogonright {
            get {
                return this.sedenyservicelogonrightField;
            }
            set {
                this.sedenyservicelogonrightField = value;
            }
        }
        public EntityItemBoolType setrustedcredmanaccessnameright {
            get {
                return this.setrustedcredmanaccessnamerightField;
            }
            set {
                this.setrustedcredmanaccessnamerightField = value;
            }
        }
    }

}

