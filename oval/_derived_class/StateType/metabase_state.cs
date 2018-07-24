using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#windows")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#windows", IsNullable=false)]
    public class metabase_state : StateType {
        private EntityStateStringType keyField;
        private EntityStateIntType id1Field;
        private EntityStateStringType nameField;
        private EntityStateStringType user_typeField;
        private EntityStateStringType data_typeField;
        private EntityStateAnySimpleType dataField;
        public EntityStateStringType key {
            get {
                return this.keyField;
            }
            set {
                this.keyField = value;
            }
        }
        [XmlElementAttribute("id")]
        public EntityStateIntType id1 {
            get {
                return this.id1Field;
            }
            set {
                this.id1Field = value;
            }
        }
        public EntityStateStringType name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        public EntityStateStringType user_type {
            get {
                return this.user_typeField;
            }
            set {
                this.user_typeField = value;
            }
        }
        public EntityStateStringType data_type {
            get {
                return this.data_typeField;
            }
            set {
                this.data_typeField = value;
            }
        }
        public EntityStateAnySimpleType data {
            get {
                return this.dataField;
            }
            set {
                this.dataField = value;
            }
        }
    }

}

