using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#sharepoint")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#sharepoint", IsNullable=false)]
    public class spdiagnosticsservice_item : ItemType {
        private EntityItemStringType farmnameField;
        private EntityItemStringType displaynameField;
        private EntityItemIntType logcutintervalField;
        private EntityItemStringType loglocationField;
        private EntityItemIntType logstokeepField;
        private EntityItemBoolType requiredField;
        private EntityItemStringType typenameField;
        public EntityItemStringType farmname {
            get {
                return this.farmnameField;
            }
            set {
                this.farmnameField = value;
            }
        }
        public EntityItemStringType displayname {
            get {
                return this.displaynameField;
            }
            set {
                this.displaynameField = value;
            }
        }
        public EntityItemIntType logcutinterval {
            get {
                return this.logcutintervalField;
            }
            set {
                this.logcutintervalField = value;
            }
        }
        public EntityItemStringType loglocation {
            get {
                return this.loglocationField;
            }
            set {
                this.loglocationField = value;
            }
        }
        public EntityItemIntType logstokeep {
            get {
                return this.logstokeepField;
            }
            set {
                this.logstokeepField = value;
            }
        }
        public EntityItemBoolType required {
            get {
                return this.requiredField;
            }
            set {
                this.requiredField = value;
            }
        }
        public EntityItemStringType typename {
            get {
                return this.typenameField;
            }
            set {
                this.typenameField = value;
            }
        }
    }

}

