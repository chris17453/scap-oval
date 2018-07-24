using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#sharepoint")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#sharepoint", IsNullable=false)]
    public class spdiagnosticsservice_state : StateType {
        private EntityStateStringType farmnameField;
        private EntityStateStringType displaynameField;
        private EntityStateIntType logcutintervalField;
        private EntityStateStringType loglocationField;
        private EntityStateIntType logstokeepField;
        private EntityStateBoolType requiredField;
        private EntityStateStringType typenameField;
        public EntityStateStringType farmname {
            get {
                return this.farmnameField;
            }
            set {
                this.farmnameField = value;
            }
        }
        public EntityStateStringType displayname {
            get {
                return this.displaynameField;
            }
            set {
                this.displaynameField = value;
            }
        }
        public EntityStateIntType logcutinterval {
            get {
                return this.logcutintervalField;
            }
            set {
                this.logcutintervalField = value;
            }
        }
        public EntityStateStringType loglocation {
            get {
                return this.loglocationField;
            }
            set {
                this.loglocationField = value;
            }
        }
        public EntityStateIntType logstokeep {
            get {
                return this.logstokeepField;
            }
            set {
                this.logstokeepField = value;
            }
        }
        public EntityStateBoolType required {
            get {
                return this.requiredField;
            }
            set {
                this.requiredField = value;
            }
        }
        public EntityStateStringType typename {
            get {
                return this.typenameField;
            }
            set {
                this.typenameField = value;
            }
        }
    }

}

