using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#sharepoint")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#sharepoint", IsNullable=false)]
    public class spantivirussettings_item : ItemType {
        private EntityItemStringType spwebservicenameField;
        private EntityItemStringType spfarmnameField;
        private EntityItemBoolType allowdownloadField;
        private EntityItemBoolType cleaningenabledField;
        private EntityItemBoolType downloadscanenabledField;
        private EntityItemIntType numberofthreadsField;
        private EntityItemBoolType skipsearchcrawlField;
        private EntityItemIntType timeoutField;
        private EntityItemBoolType uploadscanenabledField;
        private EntityItemIntType vendorupdatecountField;
        public EntityItemStringType spwebservicename {
            get {
                return this.spwebservicenameField;
            }
            set {
                this.spwebservicenameField = value;
            }
        }
        public EntityItemStringType spfarmname {
            get {
                return this.spfarmnameField;
            }
            set {
                this.spfarmnameField = value;
            }
        }
        public EntityItemBoolType allowdownload {
            get {
                return this.allowdownloadField;
            }
            set {
                this.allowdownloadField = value;
            }
        }
        public EntityItemBoolType cleaningenabled {
            get {
                return this.cleaningenabledField;
            }
            set {
                this.cleaningenabledField = value;
            }
        }
        public EntityItemBoolType downloadscanenabled {
            get {
                return this.downloadscanenabledField;
            }
            set {
                this.downloadscanenabledField = value;
            }
        }
        public EntityItemIntType numberofthreads {
            get {
                return this.numberofthreadsField;
            }
            set {
                this.numberofthreadsField = value;
            }
        }
        public EntityItemBoolType skipsearchcrawl {
            get {
                return this.skipsearchcrawlField;
            }
            set {
                this.skipsearchcrawlField = value;
            }
        }
        public EntityItemIntType timeout {
            get {
                return this.timeoutField;
            }
            set {
                this.timeoutField = value;
            }
        }
        public EntityItemBoolType uploadscanenabled {
            get {
                return this.uploadscanenabledField;
            }
            set {
                this.uploadscanenabledField = value;
            }
        }
        public EntityItemIntType vendorupdatecount {
            get {
                return this.vendorupdatecountField;
            }
            set {
                this.vendorupdatecountField = value;
            }
        }
    }

}

