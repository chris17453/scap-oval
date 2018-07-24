using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#windows")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#windows", IsNullable=false)]
    public class auditeventpolicy_state : StateType {
        private EntityStateAuditType account_logonField;
        private EntityStateAuditType account_managementField;
        private EntityStateAuditType detailed_trackingField;
        private EntityStateAuditType directory_service_accessField;
        private EntityStateAuditType logonField;
        private EntityStateAuditType object_accessField;
        private EntityStateAuditType policy_changeField;
        private EntityStateAuditType privilege_useField;
        private EntityStateAuditType systemField;
        public EntityStateAuditType account_logon {
            get {
                return this.account_logonField;
            }
            set {
                this.account_logonField = value;
            }
        }
        public EntityStateAuditType account_management {
            get {
                return this.account_managementField;
            }
            set {
                this.account_managementField = value;
            }
        }
        public EntityStateAuditType detailed_tracking {
            get {
                return this.detailed_trackingField;
            }
            set {
                this.detailed_trackingField = value;
            }
        }
        public EntityStateAuditType directory_service_access {
            get {
                return this.directory_service_accessField;
            }
            set {
                this.directory_service_accessField = value;
            }
        }
        public EntityStateAuditType logon {
            get {
                return this.logonField;
            }
            set {
                this.logonField = value;
            }
        }
        public EntityStateAuditType object_access {
            get {
                return this.object_accessField;
            }
            set {
                this.object_accessField = value;
            }
        }
        public EntityStateAuditType policy_change {
            get {
                return this.policy_changeField;
            }
            set {
                this.policy_changeField = value;
            }
        }
        public EntityStateAuditType privilege_use {
            get {
                return this.privilege_useField;
            }
            set {
                this.privilege_useField = value;
            }
        }
        public EntityStateAuditType system {
            get {
                return this.systemField;
            }
            set {
                this.systemField = value;
            }
        }
    }

}

