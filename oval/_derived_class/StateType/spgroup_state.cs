using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#sharepoint")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#sharepoint", IsNullable=false)]
    public class spgroup_state : StateType {
        private EntityStateStringType sitecollectionurlField;
        private EntityStateStringType gnameField;
        private EntityStateBoolType autoacceptrequesttojoinleaveField;
        private EntityStateBoolType allowmemberseditmembershipField;
        private EntityStateBoolType onlyallowmembersviewmembershipField;
        public EntityStateStringType sitecollectionurl {
            get {
                return this.sitecollectionurlField;
            }
            set {
                this.sitecollectionurlField = value;
            }
        }
        public EntityStateStringType gname {
            get {
                return this.gnameField;
            }
            set {
                this.gnameField = value;
            }
        }
        public EntityStateBoolType autoacceptrequesttojoinleave {
            get {
                return this.autoacceptrequesttojoinleaveField;
            }
            set {
                this.autoacceptrequesttojoinleaveField = value;
            }
        }
        public EntityStateBoolType allowmemberseditmembership {
            get {
                return this.allowmemberseditmembershipField;
            }
            set {
                this.allowmemberseditmembershipField = value;
            }
        }
        public EntityStateBoolType onlyallowmembersviewmembership {
            get {
                return this.onlyallowmembersviewmembershipField;
            }
            set {
                this.onlyallowmembersviewmembershipField = value;
            }
        }
    }

}

