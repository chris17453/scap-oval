using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#sharepoint")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#sharepoint", IsNullable=false)]
    public class spdiagnosticslevel_state : StateType {
        private EntityStateStringType farmnameField;
        private EntityStateEventSeverityType eventseverityField;
        private EntityStateBoolType hiddenField;
        private EntityStateStringType levelidField;
        private EntityStateStringType levelnameField;
        private EntityStateTraceSeverityType traceseverityField;
        public EntityStateStringType farmname {
            get {
                return this.farmnameField;
            }
            set {
                this.farmnameField = value;
            }
        }
        public EntityStateEventSeverityType eventseverity {
            get {
                return this.eventseverityField;
            }
            set {
                this.eventseverityField = value;
            }
        }
        public EntityStateBoolType hidden {
            get {
                return this.hiddenField;
            }
            set {
                this.hiddenField = value;
            }
        }
        public EntityStateStringType levelid {
            get {
                return this.levelidField;
            }
            set {
                this.levelidField = value;
            }
        }
        public EntityStateStringType levelname {
            get {
                return this.levelnameField;
            }
            set {
                this.levelnameField = value;
            }
        }
        public EntityStateTraceSeverityType traceseverity {
            get {
                return this.traceseverityField;
            }
            set {
                this.traceseverityField = value;
            }
        }
    }

}

