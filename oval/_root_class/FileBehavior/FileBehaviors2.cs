using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(TypeName="FileBehaviors", Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#unix")]
    public class FileBehaviors2 {
        private string max_depthField;
        private FileBehaviorsRecurse2 recurseField;
        private FileBehaviorsRecurse_direction2 recurse_directionField;
        private FileBehaviorsRecurse_file_system2 recurse_file_systemField;
        public FileBehaviors2() {
            //this.max_depthField = "-1";
            //this.recurseField = FileBehaviorsRecurse2.symlinksanddirectories;
            //this.recurse_directionField = FileBehaviorsRecurse_direction2.none;
            //this.recurse_file_systemField = FileBehaviorsRecurse_file_system2.all;
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
        public FileBehaviorsRecurse2 recurse {
            get {
                return this.recurseField;
            }
            set {
                this.recurseField = value;
            }
        }
        [XmlAttribute]
        public FileBehaviorsRecurse_direction2 recurse_direction {
            get {
                return this.recurse_directionField;
            }
            set {
                this.recurse_directionField = value;
            }
        }
        [XmlAttribute]
        public FileBehaviorsRecurse_file_system2 recurse_file_system {
            get {
                return this.recurse_file_systemField;
            }
            set {
                this.recurse_file_systemField = value;
            }
        }
    }

}

