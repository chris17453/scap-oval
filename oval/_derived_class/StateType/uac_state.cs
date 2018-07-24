using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#windows")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#windows", IsNullable=false)]
    public class uac_state : StateType {
        private EntityStateBoolType admin_approval_modeField;
        private EntityStateStringType elevation_prompt_adminField;
        private EntityStateStringType elevation_prompt_standardField;
        private EntityStateBoolType detect_installationsField;
        private EntityStateBoolType elevate_signed_executablesField;
        private EntityStateBoolType elevate_uiaccessField;
        private EntityStateBoolType run_admins_aamField;
        private EntityStateBoolType secure_desktopField;
        private EntityStateBoolType virtualize_write_failuresField;
        public EntityStateBoolType admin_approval_mode {
            get {
                return this.admin_approval_modeField;
            }
            set {
                this.admin_approval_modeField = value;
            }
        }
        public EntityStateStringType elevation_prompt_admin {
            get {
                return this.elevation_prompt_adminField;
            }
            set {
                this.elevation_prompt_adminField = value;
            }
        }
        public EntityStateStringType elevation_prompt_standard {
            get {
                return this.elevation_prompt_standardField;
            }
            set {
                this.elevation_prompt_standardField = value;
            }
        }
        public EntityStateBoolType detect_installations {
            get {
                return this.detect_installationsField;
            }
            set {
                this.detect_installationsField = value;
            }
        }
        public EntityStateBoolType elevate_signed_executables {
            get {
                return this.elevate_signed_executablesField;
            }
            set {
                this.elevate_signed_executablesField = value;
            }
        }
        public EntityStateBoolType elevate_uiaccess {
            get {
                return this.elevate_uiaccessField;
            }
            set {
                this.elevate_uiaccessField = value;
            }
        }
        public EntityStateBoolType run_admins_aam {
            get {
                return this.run_admins_aamField;
            }
            set {
                this.run_admins_aamField = value;
            }
        }
        public EntityStateBoolType secure_desktop {
            get {
                return this.secure_desktopField;
            }
            set {
                this.secure_desktopField = value;
            }
        }
        public EntityStateBoolType virtualize_write_failures {
            get {
                return this.virtualize_write_failuresField;
            }
            set {
                this.virtualize_write_failuresField = value;
            }
        }
    }

}

