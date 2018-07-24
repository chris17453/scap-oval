using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#aix")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#aix", IsNullable=false)]
    public class fileset_item : ItemType {
        private EntityItemStringType flstinstField;
        private EntityItemVersionType levelField;
        private EntityItemFilesetStateType stateField;
        private EntityItemStringType descriptionField;
        public EntityItemStringType flstinst {
            get {
                return this.flstinstField;
            }
            set {
                this.flstinstField = value;
            }
        }
        public EntityItemVersionType level {
            get {
                return this.levelField;
            }
            set {
                this.levelField = value;
            }
        }
        public EntityItemFilesetStateType state {
            get {
                return this.stateField;
            }
            set {
                this.stateField = value;
            }
        }
        public EntityItemStringType description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
    }

}

