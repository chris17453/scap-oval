using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#windows")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#windows", IsNullable=false)]
    public class group_sid_state : StateType {
        private EntityStateStringType group_sidField;
        private EntityStateStringType user_sidField;
        private EntityStateStringType subgroup_sidField;
        public EntityStateStringType group_sid {
            get {
                return this.group_sidField;
            }
            set {
                this.group_sidField = value;
            }
        }
        public EntityStateStringType user_sid {
            get {
                return this.user_sidField;
            }
            set {
                this.user_sidField = value;
            }
        }
        public EntityStateStringType subgroup_sid {
            get {
                return this.subgroup_sidField;
            }
            set {
                this.subgroup_sidField = value;
            }
        }
    }

}

