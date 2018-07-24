using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#windows")]
    public class NTUserBehaviors {
    [XmlIgnore]
    public bool? include_defaultField       { get; set; }
    public bool include_defaultSpecified=>include_defaultField.HasValue;
        private string max_depthField;
        private NTUserBehaviorsRecurse_direction recurse_directionField;
        private NTUserBehaviorsWindows_view windows_viewField;
        public NTUserBehaviors() {
            //this.include_defaultField = false;
            //this.max_depthField = "-1";
            //this.recurse_directionField = NTUserBehaviorsRecurse_direction.none;
            //this.windows_viewField = NTUserBehaviorsWindows_view.Item64_bit;
        }
        [XmlAttribute]
        public bool include_default {
            get {
                return this.include_defaultField.Value;
            }
            set {
                this.include_defaultField = value;
            }
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
        public NTUserBehaviorsRecurse_direction recurse_direction {
            get {
                return this.recurse_directionField;
            }
            set {
                this.recurse_directionField = value;
            }
        }
        [XmlAttribute]
        public NTUserBehaviorsWindows_view windows_view {
            get {
                return this.windows_viewField;
            }
            set {
                this.windows_viewField = value;
            }
        }
    }

}

