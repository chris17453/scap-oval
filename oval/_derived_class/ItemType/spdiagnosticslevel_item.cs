using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#sharepoint")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#sharepoint", IsNullable=false)]
    public class spdiagnosticslevel_item : ItemType {
        private EntityItemStringType farmnameField;
        private EntityItemEventSeverityType eventseverityField;
        private EntityItemBoolType hiddenField;
        private EntityItemStringType levelidField;
        private EntityItemStringType levelnameField;
        private EntityItemTraceSeverityType traceseverityField;
        public EntityItemStringType farmname {
            get {
                return this.farmnameField;
            }
            set {
                this.farmnameField = value;
            }
        }
        public EntityItemEventSeverityType eventseverity {
            get {
                return this.eventseverityField;
            }
            set {
                this.eventseverityField = value;
            }
        }
        public EntityItemBoolType hidden {
            get {
                return this.hiddenField;
            }
            set {
                this.hiddenField = value;
            }
        }
        public EntityItemStringType levelid {
            get {
                return this.levelidField;
            }
            set {
                this.levelidField = value;
            }
        }
        public EntityItemStringType levelname {
            get {
                return this.levelnameField;
            }
            set {
                this.levelnameField = value;
            }
        }
        public EntityItemTraceSeverityType traceseverity {
            get {
                return this.traceseverityField;
            }
            set {
                this.traceseverityField = value;
            }
        }
    }

}

