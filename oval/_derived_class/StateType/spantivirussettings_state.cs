using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#sharepoint")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#sharepoint", IsNullable=false)]
    public class spantivirussettings_state : StateType {
        private EntityStateStringType spwebservicenameField;
        private EntityStateStringType spfarmnameField;
        private EntityStateBoolType allowdownloadField;
        private EntityStateBoolType cleaningenabledField;
        private EntityStateBoolType downloadscanenabledField;
        private EntityStateIntType numberofthreadsField;
        private EntityStateBoolType skipsearchcrawlField;
        private EntityStateIntType timeoutField;
        private EntityStateBoolType uploadscanenabledField;
        private EntityStateIntType vendorupdatecountField;
        public EntityStateStringType spwebservicename {
            get {
                return this.spwebservicenameField;
            }
            set {
                this.spwebservicenameField = value;
            }
        }
        public EntityStateStringType spfarmname {
            get {
                return this.spfarmnameField;
            }
            set {
                this.spfarmnameField = value;
            }
        }
        public EntityStateBoolType allowdownload {
            get {
                return this.allowdownloadField;
            }
            set {
                this.allowdownloadField = value;
            }
        }
        public EntityStateBoolType cleaningenabled {
            get {
                return this.cleaningenabledField;
            }
            set {
                this.cleaningenabledField = value;
            }
        }
        public EntityStateBoolType downloadscanenabled {
            get {
                return this.downloadscanenabledField;
            }
            set {
                this.downloadscanenabledField = value;
            }
        }
        public EntityStateIntType numberofthreads {
            get {
                return this.numberofthreadsField;
            }
            set {
                this.numberofthreadsField = value;
            }
        }
        public EntityStateBoolType skipsearchcrawl {
            get {
                return this.skipsearchcrawlField;
            }
            set {
                this.skipsearchcrawlField = value;
            }
        }
        public EntityStateIntType timeout {
            get {
                return this.timeoutField;
            }
            set {
                this.timeoutField = value;
            }
        }
        public EntityStateBoolType uploadscanenabled {
            get {
                return this.uploadscanenabledField;
            }
            set {
                this.uploadscanenabledField = value;
            }
        }
        public EntityStateIntType vendorupdatecount {
            get {
                return this.vendorupdatecountField;
            }
            set {
                this.vendorupdatecountField = value;
            }
        }
    }

}

