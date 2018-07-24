using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#linux")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#linux", IsNullable=false)]
    public class apparmorstatus_item : ItemType {
        private EntityItemIntType loaded_profiles_countField;
        private EntityItemIntType enforce_mode_profiles_countField;
        private EntityItemIntType complain_mode_profiles_countField;
        private EntityItemIntType processes_with_profiles_countField;
        private EntityItemIntType enforce_mode_processes_countField;
        private EntityItemIntType complain_mode_processes_countField;
        private EntityItemIntType unconfined_processes_with_profiles_countField;
        public EntityItemIntType loaded_profiles_count {
            get {
                return this.loaded_profiles_countField;
            }
            set {
                this.loaded_profiles_countField = value;
            }
        }
        public EntityItemIntType enforce_mode_profiles_count {
            get {
                return this.enforce_mode_profiles_countField;
            }
            set {
                this.enforce_mode_profiles_countField = value;
            }
        }
        public EntityItemIntType complain_mode_profiles_count {
            get {
                return this.complain_mode_profiles_countField;
            }
            set {
                this.complain_mode_profiles_countField = value;
            }
        }
        public EntityItemIntType processes_with_profiles_count {
            get {
                return this.processes_with_profiles_countField;
            }
            set {
                this.processes_with_profiles_countField = value;
            }
        }
        public EntityItemIntType enforce_mode_processes_count {
            get {
                return this.enforce_mode_processes_countField;
            }
            set {
                this.enforce_mode_processes_countField = value;
            }
        }
        public EntityItemIntType complain_mode_processes_count {
            get {
                return this.complain_mode_processes_countField;
            }
            set {
                this.complain_mode_processes_countField = value;
            }
        }
        public EntityItemIntType unconfined_processes_with_profiles_count {
            get {
                return this.unconfined_processes_with_profiles_countField;
            }
            set {
                this.unconfined_processes_with_profiles_countField = value;
            }
        }
    }

}

