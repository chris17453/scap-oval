using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#windows")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#windows", IsNullable=false)]
    public class uac_item : ItemType {
        private EntityItemBoolType admin_approval_modeField;
        private EntityItemStringType elevation_prompt_adminField;
        private EntityItemStringType elevation_prompt_standardField;
        private EntityItemBoolType detect_installationsField;
        private EntityItemBoolType elevate_signed_executablesField;
        private EntityItemBoolType elevate_uiaccessField;
        private EntityItemBoolType run_admins_aamField;
        private EntityItemBoolType secure_desktopField;
        private EntityItemBoolType virtualize_write_failuresField;
        public EntityItemBoolType admin_approval_mode {
            get {
                return this.admin_approval_modeField;
            }
            set {
                this.admin_approval_modeField = value;
            }
        }
        public EntityItemStringType elevation_prompt_admin {
            get {
                return this.elevation_prompt_adminField;
            }
            set {
                this.elevation_prompt_adminField = value;
            }
        }
        public EntityItemStringType elevation_prompt_standard {
            get {
                return this.elevation_prompt_standardField;
            }
            set {
                this.elevation_prompt_standardField = value;
            }
        }
        public EntityItemBoolType detect_installations {
            get {
                return this.detect_installationsField;
            }
            set {
                this.detect_installationsField = value;
            }
        }
        public EntityItemBoolType elevate_signed_executables {
            get {
                return this.elevate_signed_executablesField;
            }
            set {
                this.elevate_signed_executablesField = value;
            }
        }
        public EntityItemBoolType elevate_uiaccess {
            get {
                return this.elevate_uiaccessField;
            }
            set {
                this.elevate_uiaccessField = value;
            }
        }
        public EntityItemBoolType run_admins_aam {
            get {
                return this.run_admins_aamField;
            }
            set {
                this.run_admins_aamField = value;
            }
        }
        public EntityItemBoolType secure_desktop {
            get {
                return this.secure_desktopField;
            }
            set {
                this.secure_desktopField = value;
            }
        }
        public EntityItemBoolType virtualize_write_failures {
            get {
                return this.virtualize_write_failuresField;
            }
            set {
                this.virtualize_write_failuresField = value;
            }
        }
    }

}

