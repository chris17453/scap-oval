using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#windows")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#windows", IsNullable=false)]
    public class auditeventpolicy_item : ItemType {
        private EntityItemAuditType account_logonField;
        private EntityItemAuditType account_managementField;
        private EntityItemAuditType detailed_trackingField;
        private EntityItemAuditType directory_service_accessField;
        private EntityItemAuditType logonField;
        private EntityItemAuditType object_accessField;
        private EntityItemAuditType policy_changeField;
        private EntityItemAuditType privilege_useField;
        private EntityItemAuditType systemField;
        public EntityItemAuditType account_logon {
            get {
                return this.account_logonField;
            }
            set {
                this.account_logonField = value;
            }
        }
        public EntityItemAuditType account_management {
            get {
                return this.account_managementField;
            }
            set {
                this.account_managementField = value;
            }
        }
        public EntityItemAuditType detailed_tracking {
            get {
                return this.detailed_trackingField;
            }
            set {
                this.detailed_trackingField = value;
            }
        }
        public EntityItemAuditType directory_service_access {
            get {
                return this.directory_service_accessField;
            }
            set {
                this.directory_service_accessField = value;
            }
        }
        public EntityItemAuditType logon {
            get {
                return this.logonField;
            }
            set {
                this.logonField = value;
            }
        }
        public EntityItemAuditType object_access {
            get {
                return this.object_accessField;
            }
            set {
                this.object_accessField = value;
            }
        }
        public EntityItemAuditType policy_change {
            get {
                return this.policy_changeField;
            }
            set {
                this.policy_changeField = value;
            }
        }
        public EntityItemAuditType privilege_use {
            get {
                return this.privilege_useField;
            }
            set {
                this.privilege_useField = value;
            }
        }
        public EntityItemAuditType system {
            get {
                return this.systemField;
            }
            set {
                this.systemField = value;
            }
        }
    }

}

