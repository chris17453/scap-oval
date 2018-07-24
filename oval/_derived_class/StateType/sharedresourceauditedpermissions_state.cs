using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#windows")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#windows", IsNullable=false)]
    public class sharedresourceauditedpermissions_state : StateType {
        private EntityStateStringType netnameField;
        private EntityStateStringType trustee_sidField;
        private EntityStateAuditType standard_deleteField;
        private EntityStateAuditType standard_read_controlField;
        private EntityStateAuditType standard_write_dacField;
        private EntityStateAuditType standard_write_ownerField;
        private EntityStateAuditType standard_synchronizeField;
        private EntityStateAuditType access_system_securityField;
        private EntityStateAuditType generic_readField;
        private EntityStateAuditType generic_writeField;
        private EntityStateAuditType generic_executeField;
        private EntityStateAuditType generic_allField;
        public EntityStateStringType netname {
            get {
                return this.netnameField;
            }
            set {
                this.netnameField = value;
            }
        }
        public EntityStateStringType trustee_sid {
            get {
                return this.trustee_sidField;
            }
            set {
                this.trustee_sidField = value;
            }
        }
        public EntityStateAuditType standard_delete {
            get {
                return this.standard_deleteField;
            }
            set {
                this.standard_deleteField = value;
            }
        }
        public EntityStateAuditType standard_read_control {
            get {
                return this.standard_read_controlField;
            }
            set {
                this.standard_read_controlField = value;
            }
        }
        public EntityStateAuditType standard_write_dac {
            get {
                return this.standard_write_dacField;
            }
            set {
                this.standard_write_dacField = value;
            }
        }
        public EntityStateAuditType standard_write_owner {
            get {
                return this.standard_write_ownerField;
            }
            set {
                this.standard_write_ownerField = value;
            }
        }
        public EntityStateAuditType standard_synchronize {
            get {
                return this.standard_synchronizeField;
            }
            set {
                this.standard_synchronizeField = value;
            }
        }
        public EntityStateAuditType access_system_security {
            get {
                return this.access_system_securityField;
            }
            set {
                this.access_system_securityField = value;
            }
        }
        public EntityStateAuditType generic_read {
            get {
                return this.generic_readField;
            }
            set {
                this.generic_readField = value;
            }
        }
        public EntityStateAuditType generic_write {
            get {
                return this.generic_writeField;
            }
            set {
                this.generic_writeField = value;
            }
        }
        public EntityStateAuditType generic_execute {
            get {
                return this.generic_executeField;
            }
            set {
                this.generic_executeField = value;
            }
        }
        public EntityStateAuditType generic_all {
            get {
                return this.generic_allField;
            }
            set {
                this.generic_allField = value;
            }
        }
    }

}

