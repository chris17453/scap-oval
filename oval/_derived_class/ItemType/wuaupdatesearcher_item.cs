using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#windows")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#windows", IsNullable=false)]
    public class wuaupdatesearcher_item : ItemType {
        private EntityItemStringType search_criteriaField;
        private EntityItemStringType[] update_idField;
        public EntityItemStringType search_criteria {
            get {
                return this.search_criteriaField;
            }
            set {
                this.search_criteriaField = value;
            }
        }
        [XmlElementAttribute("update_id")]
        public EntityItemStringType[] update_id {
            get {
                return this.update_idField;
            }
            set {
                this.update_idField = value;
            }
        }
    }

}

