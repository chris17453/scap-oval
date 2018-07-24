using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#sharepoint")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#sharepoint", IsNullable=false)]
    public class spgroup_item : ItemType {
        private EntityItemStringType sitecollectionurlField;
        private EntityItemStringType gnameField;
        private EntityItemBoolType autoacceptrequesttojoinleaveField;
        private EntityItemBoolType allowmemberseditmembershipField;
        private EntityItemBoolType onlyallowmembersviewmembershipField;
        public EntityItemStringType sitecollectionurl {
            get {
                return this.sitecollectionurlField;
            }
            set {
                this.sitecollectionurlField = value;
            }
        }
        public EntityItemStringType gname {
            get {
                return this.gnameField;
            }
            set {
                this.gnameField = value;
            }
        }
        public EntityItemBoolType autoacceptrequesttojoinleave {
            get {
                return this.autoacceptrequesttojoinleaveField;
            }
            set {
                this.autoacceptrequesttojoinleaveField = value;
            }
        }
        public EntityItemBoolType allowmemberseditmembership {
            get {
                return this.allowmemberseditmembershipField;
            }
            set {
                this.allowmemberseditmembershipField = value;
            }
        }
        public EntityItemBoolType onlyallowmembersviewmembership {
            get {
                return this.onlyallowmembersviewmembershipField;
            }
            set {
                this.onlyallowmembersviewmembershipField = value;
            }
        }
    }

}

