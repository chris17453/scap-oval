using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5")]
    public class EntityObjectRecordType : EntityComplexBaseType {
        private EntityObjectFieldType[] fieldField;
        [XmlElementAttribute("field")]
        public EntityObjectFieldType[] field {
            get {
                return this.fieldField;
            }
            set {
                this.fieldField = value;
            }
        }
    }

}

