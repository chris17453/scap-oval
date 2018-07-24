using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#sharepoint")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#sharepoint", IsNullable=false)]
    public class spwebapplication_state : StateType {
        private EntityStateStringType webapplicationurlField;
        private EntityStateBoolType allowparttopartcommunicationField;
        private EntityStateBoolType allowaccesstowebpartcatalogField;
        private EntityStateStringType blockedfileextentionField;
        private EntityStateStringType defaultquotatemplateField;
        private EntityStateBoolType externalworkflowparticipantsenabledField;
        private EntityStateBoolType recyclebinenabledField;
        private EntityStateBoolType automaticallydeleteunusedsitecollectionsField;
        private EntityStateBoolType selfservicesitecreationenabledField;
        private EntityStateIntType secondstagerecyclebinquotaField;
        private EntityStateIntType recyclebinretentionperiodField;
        private EntityStateStringType outboundmailserverinstanceField;
        private EntityStateStringType outboundmailsenderaddressField;
        private EntityStateStringType outboundmailreplytoaddressField;
        private EntityStateBoolType secvalexpiresField;
        private EntityStateIntType timeoutField;
        private EntityStateBoolType isadministrationwebapplicationField;
        private EntityStateStringType applicationpoolnameField;
        private EntityStateStringType applicationpoolusernameField;
        private EntityStateBoolType openitemsField;
        private EntityStateBoolType addlistitemsField;
        private EntityStateBoolType approveitemsField;
        private EntityStateBoolType deletelistitemsField;
        private EntityStateBoolType deleteversionsField;
        private EntityStateBoolType editlistitemsField;
        private EntityStateBoolType managelistsField;
        private EntityStateBoolType viewversionsField;
        private EntityStateBoolType viewlistitemsField;
        private EntityStateBoolType cancelcheckoutField;
        private EntityStateBoolType createalertsField;
        private EntityStateBoolType viewformpagesField;
        private EntityStateBoolType viewpagesField;
        private EntityStateBoolType addandcustomizepagesField;
        private EntityStateBoolType applystylesheetsField;
        private EntityStateBoolType applythemeandborderField;
        private EntityStateBoolType browsedirectoriesField;
        private EntityStateBoolType browseuserinfoField;
        private EntityStateBoolType creategroupsField;
        private EntityStateBoolType createsscsiteField;
        private EntityStateBoolType editmyuserinfoField;
        private EntityStateBoolType enumeratepermissionsField;
        private EntityStateBoolType managealertsField;
        private EntityStateBoolType managepermissionsField;
        private EntityStateBoolType managesubwebsField;
        private EntityStateBoolType managewebField;
        private EntityStateBoolType openField;
        private EntityStateBoolType useclientintegrationField;
        private EntityStateBoolType useremoteapisField;
        private EntityStateBoolType viewusagedataField;
        private EntityStateBoolType managepersonalviewsField;
        private EntityStateBoolType adddelprivatewebpartsField;
        private EntityStateBoolType updatepersonalwebpartsField;
        public EntityStateStringType webapplicationurl {
            get {
                return this.webapplicationurlField;
            }
            set {
                this.webapplicationurlField = value;
            }
        }
        public EntityStateBoolType allowparttopartcommunication {
            get {
                return this.allowparttopartcommunicationField;
            }
            set {
                this.allowparttopartcommunicationField = value;
            }
        }
        public EntityStateBoolType allowaccesstowebpartcatalog {
            get {
                return this.allowaccesstowebpartcatalogField;
            }
            set {
                this.allowaccesstowebpartcatalogField = value;
            }
        }
        public EntityStateStringType blockedfileextention {
            get {
                return this.blockedfileextentionField;
            }
            set {
                this.blockedfileextentionField = value;
            }
        }
        public EntityStateStringType defaultquotatemplate {
            get {
                return this.defaultquotatemplateField;
            }
            set {
                this.defaultquotatemplateField = value;
            }
        }
        public EntityStateBoolType externalworkflowparticipantsenabled {
            get {
                return this.externalworkflowparticipantsenabledField;
            }
            set {
                this.externalworkflowparticipantsenabledField = value;
            }
        }
        public EntityStateBoolType recyclebinenabled {
            get {
                return this.recyclebinenabledField;
            }
            set {
                this.recyclebinenabledField = value;
            }
        }
        public EntityStateBoolType automaticallydeleteunusedsitecollections {
            get {
                return this.automaticallydeleteunusedsitecollectionsField;
            }
            set {
                this.automaticallydeleteunusedsitecollectionsField = value;
            }
        }
        public EntityStateBoolType selfservicesitecreationenabled {
            get {
                return this.selfservicesitecreationenabledField;
            }
            set {
                this.selfservicesitecreationenabledField = value;
            }
        }
        public EntityStateIntType secondstagerecyclebinquota {
            get {
                return this.secondstagerecyclebinquotaField;
            }
            set {
                this.secondstagerecyclebinquotaField = value;
            }
        }
        public EntityStateIntType recyclebinretentionperiod {
            get {
                return this.recyclebinretentionperiodField;
            }
            set {
                this.recyclebinretentionperiodField = value;
            }
        }
        public EntityStateStringType outboundmailserverinstance {
            get {
                return this.outboundmailserverinstanceField;
            }
            set {
                this.outboundmailserverinstanceField = value;
            }
        }
        public EntityStateStringType outboundmailsenderaddress {
            get {
                return this.outboundmailsenderaddressField;
            }
            set {
                this.outboundmailsenderaddressField = value;
            }
        }
        public EntityStateStringType outboundmailreplytoaddress {
            get {
                return this.outboundmailreplytoaddressField;
            }
            set {
                this.outboundmailreplytoaddressField = value;
            }
        }
        public EntityStateBoolType secvalexpires {
            get {
                return this.secvalexpiresField;
            }
            set {
                this.secvalexpiresField = value;
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
        public EntityStateBoolType isadministrationwebapplication {
            get {
                return this.isadministrationwebapplicationField;
            }
            set {
                this.isadministrationwebapplicationField = value;
            }
        }
        public EntityStateStringType applicationpoolname {
            get {
                return this.applicationpoolnameField;
            }
            set {
                this.applicationpoolnameField = value;
            }
        }
        public EntityStateStringType applicationpoolusername {
            get {
                return this.applicationpoolusernameField;
            }
            set {
                this.applicationpoolusernameField = value;
            }
        }
        public EntityStateBoolType openitems {
            get {
                return this.openitemsField;
            }
            set {
                this.openitemsField = value;
            }
        }
        public EntityStateBoolType addlistitems {
            get {
                return this.addlistitemsField;
            }
            set {
                this.addlistitemsField = value;
            }
        }
        public EntityStateBoolType approveitems {
            get {
                return this.approveitemsField;
            }
            set {
                this.approveitemsField = value;
            }
        }
        public EntityStateBoolType deletelistitems {
            get {
                return this.deletelistitemsField;
            }
            set {
                this.deletelistitemsField = value;
            }
        }
        public EntityStateBoolType deleteversions {
            get {
                return this.deleteversionsField;
            }
            set {
                this.deleteversionsField = value;
            }
        }
        public EntityStateBoolType editlistitems {
            get {
                return this.editlistitemsField;
            }
            set {
                this.editlistitemsField = value;
            }
        }
        public EntityStateBoolType managelists {
            get {
                return this.managelistsField;
            }
            set {
                this.managelistsField = value;
            }
        }
        public EntityStateBoolType viewversions {
            get {
                return this.viewversionsField;
            }
            set {
                this.viewversionsField = value;
            }
        }
        public EntityStateBoolType viewlistitems {
            get {
                return this.viewlistitemsField;
            }
            set {
                this.viewlistitemsField = value;
            }
        }
        public EntityStateBoolType cancelcheckout {
            get {
                return this.cancelcheckoutField;
            }
            set {
                this.cancelcheckoutField = value;
            }
        }
        public EntityStateBoolType createalerts {
            get {
                return this.createalertsField;
            }
            set {
                this.createalertsField = value;
            }
        }
        public EntityStateBoolType viewformpages {
            get {
                return this.viewformpagesField;
            }
            set {
                this.viewformpagesField = value;
            }
        }
        public EntityStateBoolType viewpages {
            get {
                return this.viewpagesField;
            }
            set {
                this.viewpagesField = value;
            }
        }
        public EntityStateBoolType addandcustomizepages {
            get {
                return this.addandcustomizepagesField;
            }
            set {
                this.addandcustomizepagesField = value;
            }
        }
        public EntityStateBoolType applystylesheets {
            get {
                return this.applystylesheetsField;
            }
            set {
                this.applystylesheetsField = value;
            }
        }
        public EntityStateBoolType applythemeandborder {
            get {
                return this.applythemeandborderField;
            }
            set {
                this.applythemeandborderField = value;
            }
        }
        public EntityStateBoolType browsedirectories {
            get {
                return this.browsedirectoriesField;
            }
            set {
                this.browsedirectoriesField = value;
            }
        }
        public EntityStateBoolType browseuserinfo {
            get {
                return this.browseuserinfoField;
            }
            set {
                this.browseuserinfoField = value;
            }
        }
        public EntityStateBoolType creategroups {
            get {
                return this.creategroupsField;
            }
            set {
                this.creategroupsField = value;
            }
        }
        public EntityStateBoolType createsscsite {
            get {
                return this.createsscsiteField;
            }
            set {
                this.createsscsiteField = value;
            }
        }
        public EntityStateBoolType editmyuserinfo {
            get {
                return this.editmyuserinfoField;
            }
            set {
                this.editmyuserinfoField = value;
            }
        }
        public EntityStateBoolType enumeratepermissions {
            get {
                return this.enumeratepermissionsField;
            }
            set {
                this.enumeratepermissionsField = value;
            }
        }
        public EntityStateBoolType managealerts {
            get {
                return this.managealertsField;
            }
            set {
                this.managealertsField = value;
            }
        }
        public EntityStateBoolType managepermissions {
            get {
                return this.managepermissionsField;
            }
            set {
                this.managepermissionsField = value;
            }
        }
        public EntityStateBoolType managesubwebs {
            get {
                return this.managesubwebsField;
            }
            set {
                this.managesubwebsField = value;
            }
        }
        public EntityStateBoolType manageweb {
            get {
                return this.managewebField;
            }
            set {
                this.managewebField = value;
            }
        }
        public EntityStateBoolType open {
            get {
                return this.openField;
            }
            set {
                this.openField = value;
            }
        }
        public EntityStateBoolType useclientintegration {
            get {
                return this.useclientintegrationField;
            }
            set {
                this.useclientintegrationField = value;
            }
        }
        public EntityStateBoolType useremoteapis {
            get {
                return this.useremoteapisField;
            }
            set {
                this.useremoteapisField = value;
            }
        }
        public EntityStateBoolType viewusagedata {
            get {
                return this.viewusagedataField;
            }
            set {
                this.viewusagedataField = value;
            }
        }
        public EntityStateBoolType managepersonalviews {
            get {
                return this.managepersonalviewsField;
            }
            set {
                this.managepersonalviewsField = value;
            }
        }
        public EntityStateBoolType adddelprivatewebparts {
            get {
                return this.adddelprivatewebpartsField;
            }
            set {
                this.adddelprivatewebpartsField = value;
            }
        }
        public EntityStateBoolType updatepersonalwebparts {
            get {
                return this.updatepersonalwebpartsField;
            }
            set {
                this.updatepersonalwebpartsField = value;
            }
        }
    }

}

