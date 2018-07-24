using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [XmlIncludeAttribute(typeof(EntityStateRecordType))]
    [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5")]
    public abstract class EntityStateComplexBaseType : EntityComplexBaseType {
    [XmlIgnore]
    public CheckEnumeration? entity_checkField       { get; set; }
    public bool entity_checkSpecified=>entity_checkField.HasValue;
    [XmlIgnore]
    public ExistenceEnumeration? check_existenceField       { get; set; }
    public bool check_existenceSpecified=>check_existenceField.HasValue;
        public EntityStateComplexBaseType() {
            /*this.entity_checkField = CheckEnumeration.all;
            this.check_existenceField = ExistenceEnumeration.at_least_one_exists;*/
        }
        [XmlAttribute]
        public CheckEnumeration entity_check {
            get {
                return this.entity_checkField.Value;
            }
            set {
                this.entity_checkField = value;
            }
        }
        [XmlAttribute]
        public ExistenceEnumeration check_existence {
            get {
                return this.check_existenceField.Value;
            }
            set {
                this.check_existenceField = value;
            }
        }
    }

}

