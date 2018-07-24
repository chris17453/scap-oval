using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [XmlIncludeAttribute(typeof(RegkeyEffectiveRightsBehaviors))]
    [XmlIncludeAttribute(typeof(RegkeyEffectiveRights53Behaviors))]
    [XmlIncludeAttribute(typeof(RegkeyAuditPermissionsBehaviors))]
    [XmlIncludeAttribute(typeof(RegkeyAuditPermissions53Behaviors))]
    [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#windows")]
    public class RegistryBehaviors {
        private string max_depthField;
        private RegistryBehaviorsRecurse_direction recurse_directionField;
        private RegistryBehaviorsWindows_view windows_viewField;
        public RegistryBehaviors() {
            //this.max_depthField = "-1";
            //this.recurse_directionField = RegistryBehaviorsRecurse_direction.none;
            //this.windows_viewField = RegistryBehaviorsWindows_view.Item64_bit;
        }
        [XmlAttribute(DataType="integer")]
        public string max_depth {
            get {
                return this.max_depthField;
            }
            set {
                this.max_depthField = value;
            }
        }
        [XmlAttribute]
        public RegistryBehaviorsRecurse_direction recurse_direction {
            get {
                return this.recurse_directionField;
            }
            set {
                this.recurse_directionField = value;
            }
        }
        [XmlAttribute]
        public RegistryBehaviorsWindows_view windows_view {
            get {
                return this.windows_viewField;
            }
            set {
                this.windows_viewField = value;
            }
        }
    }

}

