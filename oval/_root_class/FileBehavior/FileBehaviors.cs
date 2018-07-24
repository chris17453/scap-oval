using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [XmlIncludeAttribute(typeof(Textfilecontent54Behaviors))]
    [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#independent")]
    public class FileBehaviors {
        private string max_depthField;
        private FileBehaviorsRecurse recurseField;
        private FileBehaviorsRecurse_direction recurse_directionField;
        private FileBehaviorsRecurse_file_system recurse_file_systemField;
        private FileBehaviorsWindows_view windows_viewField;
        public FileBehaviors() {
            //this.max_depthField = "-1";
            //this.recurseField = FileBehaviorsRecurse.symlinksanddirectories;
            //this.recurse_directionField = FileBehaviorsRecurse_direction.none;
            //this.recurse_file_systemField = FileBehaviorsRecurse_file_system.all;
            //this.windows_viewField = FileBehaviorsWindows_view.Item64_bit;
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
        public FileBehaviorsRecurse recurse {
            get {
                return this.recurseField;
            }
            set {
                this.recurseField = value;
            }
        }
        [XmlAttribute]
        public FileBehaviorsRecurse_direction recurse_direction {
            get {
                return this.recurse_directionField;
            }
            set {
                this.recurse_directionField = value;
            }
        }
        [XmlAttribute]
        public FileBehaviorsRecurse_file_system recurse_file_system {
            get {
                return this.recurse_file_systemField;
            }
            set {
                this.recurse_file_systemField = value;
            }
        }
        [XmlAttribute]
        public FileBehaviorsWindows_view windows_view {
            get {
                return this.windows_viewField;
            }
            set {
                this.windows_viewField = value;
            }
        }
    }

}

