using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#sharepoint")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#sharepoint", IsNullable=false)]
    public class spcrawlrule_item : ItemType {
        private EntityItemStringType spsiteurlField;
        private EntityItemBoolType crawlashttpField;
        private EntityItemBoolType enabledField;
        private EntityItemBoolType followcomplexurlsField;
        private EntityItemStringType pathField;
        private EntityItemIntType priorityField;
        private EntityItemBoolType suppressindexingField;
        private EntityItemStringType accountnameField;
        public EntityItemStringType spsiteurl {
            get {
                return this.spsiteurlField;
            }
            set {
                this.spsiteurlField = value;
            }
        }
        public EntityItemBoolType crawlashttp {
            get {
                return this.crawlashttpField;
            }
            set {
                this.crawlashttpField = value;
            }
        }
        public EntityItemBoolType enabled {
            get {
                return this.enabledField;
            }
            set {
                this.enabledField = value;
            }
        }
        public EntityItemBoolType followcomplexurls {
            get {
                return this.followcomplexurlsField;
            }
            set {
                this.followcomplexurlsField = value;
            }
        }
        public EntityItemStringType path {
            get {
                return this.pathField;
            }
            set {
                this.pathField = value;
            }
        }
        public EntityItemIntType priority {
            get {
                return this.priorityField;
            }
            set {
                this.priorityField = value;
            }
        }
        public EntityItemBoolType suppressindexing {
            get {
                return this.suppressindexingField;
            }
            set {
                this.suppressindexingField = value;
            }
        }
        public EntityItemStringType accountname {
            get {
                return this.accountnameField;
            }
            set {
                this.accountnameField = value;
            }
        }
    }

}

