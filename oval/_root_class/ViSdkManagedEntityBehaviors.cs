using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#esx")]
    public class ViSdkManagedEntityBehaviors {
        private ViSdkManagedEntityBehaviorsManaged_entity_type managed_entity_typeField;
        public ViSdkManagedEntityBehaviors() {
           // this.managed_entity_typeField = ViSdkManagedEntityBehaviorsManaged_entity_type.VirtualMachine;
        }
        [XmlAttribute]
        public ViSdkManagedEntityBehaviorsManaged_entity_type managed_entity_type {
            get {
                return this.managed_entity_typeField;
            }
            set {
                this.managed_entity_typeField = value;
            }
        }
    }

}

