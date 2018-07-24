using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#sharepoint")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#sharepoint", IsNullable=false)]
    public class spcrawlrule_state : StateType {
        private EntityStateStringType spsiteurlField;
        private EntityStateBoolType crawlashttpField;
        private EntityStateBoolType enabledField;
        private EntityStateBoolType followcomplexurlsField;
        private EntityStateStringType pathField;
        private EntityStateIntType priorityField;
        private EntityStateBoolType suppressindexingField;
        private EntityStateStringType accountnameField;
        public EntityStateStringType spsiteurl {
            get {
                return this.spsiteurlField;
            }
            set {
                this.spsiteurlField = value;
            }
        }
        public EntityStateBoolType crawlashttp {
            get {
                return this.crawlashttpField;
            }
            set {
                this.crawlashttpField = value;
            }
        }
        public EntityStateBoolType enabled {
            get {
                return this.enabledField;
            }
            set {
                this.enabledField = value;
            }
        }
        public EntityStateBoolType followcomplexurls {
            get {
                return this.followcomplexurlsField;
            }
            set {
                this.followcomplexurlsField = value;
            }
        }
        public EntityStateStringType path {
            get {
                return this.pathField;
            }
            set {
                this.pathField = value;
            }
        }
        public EntityStateIntType priority {
            get {
                return this.priorityField;
            }
            set {
                this.priorityField = value;
            }
        }
        public EntityStateBoolType suppressindexing {
            get {
                return this.suppressindexingField;
            }
            set {
                this.suppressindexingField = value;
            }
        }
        public EntityStateStringType accountname {
            get {
                return this.accountnameField;
            }
            set {
                this.accountnameField = value;
            }
        }
    }

}

