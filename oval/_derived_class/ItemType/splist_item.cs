using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#sharepoint")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#sharepoint", IsNullable=false)]
    public class splist_item : ItemType {
        private EntityItemStringType spsiteurlField;
        private EntityItemBoolType irmenabledField;
        private EntityItemBoolType enableversioningField;
        private EntityItemBoolType nocrawlField;
        public EntityItemStringType spsiteurl {
            get {
                return this.spsiteurlField;
            }
            set {
                this.spsiteurlField = value;
            }
        }
        public EntityItemBoolType irmenabled {
            get {
                return this.irmenabledField;
            }
            set {
                this.irmenabledField = value;
            }
        }
        public EntityItemBoolType enableversioning {
            get {
                return this.enableversioningField;
            }
            set {
                this.enableversioningField = value;
            }
        }
        public EntityItemBoolType nocrawl {
            get {
                return this.nocrawlField;
            }
            set {
                this.nocrawlField = value;
            }
        }
    }

}

