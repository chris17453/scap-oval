using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#sharepoint")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#sharepoint", IsNullable=false)]
    public class splist_state : StateType {
        private EntityStateStringType spsiteurlField;
        private EntityStateBoolType irmenabledField;
        private EntityStateBoolType enableversioningField;
        private EntityStateBoolType nocrawlField;
        public EntityStateStringType spsiteurl {
            get {
                return this.spsiteurlField;
            }
            set {
                this.spsiteurlField = value;
            }
        }
        public EntityStateBoolType irmenabled {
            get {
                return this.irmenabledField;
            }
            set {
                this.irmenabledField = value;
            }
        }
        public EntityStateBoolType enableversioning {
            get {
                return this.enableversioningField;
            }
            set {
                this.enableversioningField = value;
            }
        }
        public EntityStateBoolType nocrawl {
            get {
                return this.nocrawlField;
            }
            set {
                this.nocrawlField = value;
            }
        }
    }

}

