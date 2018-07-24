using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#aix")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#aix", IsNullable=false)]
    public class fileset_state : StateType {
        private EntityStateStringType flstinstField;
        private EntityStateVersionType levelField;
        private EntityStateFilesetStateType stateField;
        private EntityStateStringType descriptionField;
        public EntityStateStringType flstinst {
            get {
                return this.flstinstField;
            }
            set {
                this.flstinstField = value;
            }
        }
        public EntityStateVersionType level {
            get {
                return this.levelField;
            }
            set {
                this.levelField = value;
            }
        }
        public EntityStateFilesetStateType state {
            get {
                return this.stateField;
            }
            set {
                this.stateField = value;
            }
        }
        public EntityStateStringType description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
    }

}

