using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5")]
    public class EntityItemRecordType : EntityItemComplexBaseType {
        private EntityItemFieldType[] fieldField;
        [XmlElementAttribute("field")]
        public EntityItemFieldType[] field {
            get {
                return this.fieldField;
            }
            set {
                this.fieldField = value;
            }
        }
    }

}

