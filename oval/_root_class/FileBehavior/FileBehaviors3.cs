using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(TypeName="FileBehaviors", Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#linux")]
    public class FileBehaviors3 {
        private string max_depthField;
        private FileBehaviorsRecurse3 recurseField;
        private FileBehaviorsRecurse_direction3 recurse_directionField;
        private FileBehaviorsRecurse_file_system3 recurse_file_systemField;
        public FileBehaviors3() {
            //this.max_depthField = "-1";
            //this.recurseField = FileBehaviorsRecurse3.symlinksanddirectories;
            //this.recurse_directionField = FileBehaviorsRecurse_direction3.none;
            //this.recurse_file_systemField = FileBehaviorsRecurse_file_system3.all;
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
        public FileBehaviorsRecurse3 recurse {
            get {
                return this.recurseField;
            }
            set {
                this.recurseField = value;
            }
        }
        [XmlAttribute]
        public FileBehaviorsRecurse_direction3 recurse_direction {
            get {
                return this.recurse_directionField;
            }
            set {
                this.recurse_directionField = value;
            }
        }
        [XmlAttribute]
        public FileBehaviorsRecurse_file_system3 recurse_file_system {
            get {
                return this.recurse_file_systemField;
            }
            set {
                this.recurse_file_systemField = value;
            }
        }
    }

}

