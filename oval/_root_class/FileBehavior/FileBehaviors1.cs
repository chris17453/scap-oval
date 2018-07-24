using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [XmlIncludeAttribute(typeof(FileEffectiveRightsBehaviors))]
    [XmlIncludeAttribute(typeof(FileEffectiveRights53Behaviors))]
    [XmlIncludeAttribute(typeof(FileAuditPermissionsBehaviors))]
    [XmlIncludeAttribute(typeof(FileAuditPermissions53Behaviors))]
    [SerializableAttribute]
    [XmlTypeAttribute(TypeName="FileBehaviors", Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#windows")]
    public class FileBehaviors1 {
        private string max_depthField;
        private FileBehaviorsRecurse1 recurseField;
        private FileBehaviorsRecurse_direction1 recurse_directionField;
        private FileBehaviorsRecurse_file_system1 recurse_file_systemField;
        private FileBehaviorsWindows_view1 windows_viewField;
        public FileBehaviors1() {
            //this.max_depthField = "-1";
            //this.recurseField = FileBehaviorsRecurse1.directories;
            //this.recurse_directionField = FileBehaviorsRecurse_direction1.none;
            //this.recurse_file_systemField = FileBehaviorsRecurse_file_system1.all;
            //this.windows_viewField = FileBehaviorsWindows_view1.Item64_bit;
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
        public FileBehaviorsRecurse1 recurse {
            get {
                return this.recurseField;
            }
            set {
                this.recurseField = value;
            }
        }
        [XmlAttribute]
        public FileBehaviorsRecurse_direction1 recurse_direction {
            get {
                return this.recurse_directionField;
            }
            set {
                this.recurse_directionField = value;
            }
        }
        [XmlAttribute]
        public FileBehaviorsRecurse_file_system1 recurse_file_system {
            get {
                return this.recurse_file_systemField;
            }
            set {
                this.recurse_file_systemField = value;
            }
        }
        [XmlAttribute]
        public FileBehaviorsWindows_view1 windows_view {
            get {
                return this.windows_viewField;
            }
            set {
                this.windows_viewField = value;
            }
        }
    }

}

