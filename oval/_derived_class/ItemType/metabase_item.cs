using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#windows")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#windows", IsNullable=false)]
    public class metabase_item : ItemType {
        private EntityItemStringType keyField;
        private EntityItemIntType id1Field;
        private EntityItemStringType nameField;
        private EntityItemStringType user_typeField;
        private EntityItemStringType data_typeField;
        private EntityItemAnySimpleType[] dataField;
        public EntityItemStringType key {
            get {
                return this.keyField;
            }
            set {
                this.keyField = value;
            }
        }
        [XmlElementAttribute("id", IsNullable=true)]
        public EntityItemIntType id1 {
            get {
                return this.id1Field;
            }
            set {
                this.id1Field = value;
            }
        }
        public EntityItemStringType name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        public EntityItemStringType user_type {
            get {
                return this.user_typeField;
            }
            set {
                this.user_typeField = value;
            }
        }
        public EntityItemStringType data_type {
            get {
                return this.data_typeField;
            }
            set {
                this.data_typeField = value;
            }
        }
        [XmlElementAttribute("data")]
        public EntityItemAnySimpleType[] data {
            get {
                return this.dataField;
            }
            set {
                this.dataField = value;
            }
        }
    }

}

