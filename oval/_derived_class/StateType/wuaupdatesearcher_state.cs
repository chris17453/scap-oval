using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#windows")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#windows", IsNullable=false)]
    public class wuaupdatesearcher_state : StateType {
        private EntityStateStringType search_criteriaField;
        private EntityStateStringType update_idField;
        public EntityStateStringType search_criteria {
            get {
                return this.search_criteriaField;
            }
            set {
                this.search_criteriaField = value;
            }
        }
        public EntityStateStringType update_id {
            get {
                return this.update_idField;
            }
            set {
                this.update_idField = value;
            }
        }
    }

}

