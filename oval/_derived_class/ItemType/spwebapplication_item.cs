using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#sharepoint")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#sharepoint", IsNullable=false)]
    public class spwebapplication_item : ItemType {
        private EntityItemStringType webapplicationurlField;
        private EntityItemBoolType allowparttopartcommunicationField;
        private EntityItemBoolType allowaccesstowebpartcatalogField;
        private EntityItemStringType[] blockedfileextentionField;
        private EntityItemStringType defaultquotatemplateField;
        private EntityItemBoolType externalworkflowparticipantsenabledField;
        private EntityItemBoolType recyclebinenabledField;
        private EntityItemBoolType automaticallydeleteunusedsitecollectionsField;
        private EntityItemBoolType selfservicesitecreationenabledField;
        private EntityItemIntType secondstagerecyclebinquotaField;
        private EntityItemIntType recyclebinretentionperiodField;
        private EntityItemStringType outboundmailserverinstanceField;
        private EntityItemStringType outboundmailsenderaddressField;
        private EntityItemStringType outboundmailreplytoaddressField;
        private EntityItemBoolType secvalexpiresField;
        private EntityItemIntType timeoutField;
        private EntityItemBoolType isadministrationwebapplicationField;
        private EntityItemStringType applicationpoolnameField;
        private EntityItemStringType applicationpoolusernameField;
        private EntityItemBoolType openitemsField;
        private EntityItemBoolType addlistitemsField;
        private EntityItemBoolType approveitemsField;
        private EntityItemBoolType deletelistitemsField;
        private EntityItemBoolType deleteversionsField;
        private EntityItemBoolType editlistitemsField;
        private EntityItemBoolType managelistsField;
        private EntityItemBoolType viewversionsField;
        private EntityItemBoolType viewlistitemsField;
        private EntityItemBoolType cancelcheckoutField;
        private EntityItemBoolType createalertsField;
        private EntityItemBoolType viewformpagesField;
        private EntityItemBoolType viewpagesField;
        private EntityItemBoolType addandcustomizepagesField;
        private EntityItemBoolType applystylesheetsField;
        private EntityItemBoolType applythemeandborderField;
        private EntityItemBoolType browsedirectoriesField;
        private EntityItemBoolType browseuserinfoField;
        private EntityItemBoolType creategroupsField;
        private EntityItemBoolType createsscsiteField;
        private EntityItemBoolType editmyuserinfoField;
        private EntityItemBoolType enumeratepermissionsField;
        private EntityItemBoolType managealertsField;
        private EntityItemBoolType managepermissionsField;
        private EntityItemBoolType managesubwebsField;
        private EntityItemBoolType managewebField;
        private EntityItemBoolType openField;
        private EntityItemBoolType useclientintegrationField;
        private EntityItemBoolType useremoteapisField;
        private EntityItemBoolType viewusagedataField;
        private EntityItemBoolType managepersonalviewsField;
        private EntityItemBoolType adddelprivatewebpartsField;
        private EntityItemBoolType updatepersonalwebpartsField;
        public EntityItemStringType webapplicationurl {
            get {
                return this.webapplicationurlField;
            }
            set {
                this.webapplicationurlField = value;
            }
        }
        public EntityItemBoolType allowparttopartcommunication {
            get {
                return this.allowparttopartcommunicationField;
            }
            set {
                this.allowparttopartcommunicationField = value;
            }
        }
        public EntityItemBoolType allowaccesstowebpartcatalog {
            get {
                return this.allowaccesstowebpartcatalogField;
            }
            set {
                this.allowaccesstowebpartcatalogField = value;
            }
        }
        [XmlElementAttribute("blockedfileextention")]
        public EntityItemStringType[] blockedfileextention {
            get {
                return this.blockedfileextentionField;
            }
            set {
                this.blockedfileextentionField = value;
            }
        }
        public EntityItemStringType defaultquotatemplate {
            get {
                return this.defaultquotatemplateField;
            }
            set {
                this.defaultquotatemplateField = value;
            }
        }
        public EntityItemBoolType externalworkflowparticipantsenabled {
            get {
                return this.externalworkflowparticipantsenabledField;
            }
            set {
                this.externalworkflowparticipantsenabledField = value;
            }
        }
        public EntityItemBoolType recyclebinenabled {
            get {
                return this.recyclebinenabledField;
            }
            set {
                this.recyclebinenabledField = value;
            }
        }
        public EntityItemBoolType automaticallydeleteunusedsitecollections {
            get {
                return this.automaticallydeleteunusedsitecollectionsField;
            }
            set {
                this.automaticallydeleteunusedsitecollectionsField = value;
            }
        }
        public EntityItemBoolType selfservicesitecreationenabled {
            get {
                return this.selfservicesitecreationenabledField;
            }
            set {
                this.selfservicesitecreationenabledField = value;
            }
        }
        public EntityItemIntType secondstagerecyclebinquota {
            get {
                return this.secondstagerecyclebinquotaField;
            }
            set {
                this.secondstagerecyclebinquotaField = value;
            }
        }
        public EntityItemIntType recyclebinretentionperiod {
            get {
                return this.recyclebinretentionperiodField;
            }
            set {
                this.recyclebinretentionperiodField = value;
            }
        }
        public EntityItemStringType outboundmailserverinstance {
            get {
                return this.outboundmailserverinstanceField;
            }
            set {
                this.outboundmailserverinstanceField = value;
            }
        }
        public EntityItemStringType outboundmailsenderaddress {
            get {
                return this.outboundmailsenderaddressField;
            }
            set {
                this.outboundmailsenderaddressField = value;
            }
        }
        public EntityItemStringType outboundmailreplytoaddress {
            get {
                return this.outboundmailreplytoaddressField;
            }
            set {
                this.outboundmailreplytoaddressField = value;
            }
        }
        public EntityItemBoolType secvalexpires {
            get {
                return this.secvalexpiresField;
            }
            set {
                this.secvalexpiresField = value;
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
        public EntityItemBoolType isadministrationwebapplication {
            get {
                return this.isadministrationwebapplicationField;
            }
            set {
                this.isadministrationwebapplicationField = value;
            }
        }
        public EntityItemStringType applicationpoolname {
            get {
                return this.applicationpoolnameField;
            }
            set {
                this.applicationpoolnameField = value;
            }
        }
        public EntityItemStringType applicationpoolusername {
            get {
                return this.applicationpoolusernameField;
            }
            set {
                this.applicationpoolusernameField = value;
            }
        }
        public EntityItemBoolType openitems {
            get {
                return this.openitemsField;
            }
            set {
                this.openitemsField = value;
            }
        }
        public EntityItemBoolType addlistitems {
            get {
                return this.addlistitemsField;
            }
            set {
                this.addlistitemsField = value;
            }
        }
        public EntityItemBoolType approveitems {
            get {
                return this.approveitemsField;
            }
            set {
                this.approveitemsField = value;
            }
        }
        public EntityItemBoolType deletelistitems {
            get {
                return this.deletelistitemsField;
            }
            set {
                this.deletelistitemsField = value;
            }
        }
        public EntityItemBoolType deleteversions {
            get {
                return this.deleteversionsField;
            }
            set {
                this.deleteversionsField = value;
            }
        }
        public EntityItemBoolType editlistitems {
            get {
                return this.editlistitemsField;
            }
            set {
                this.editlistitemsField = value;
            }
        }
        public EntityItemBoolType managelists {
            get {
                return this.managelistsField;
            }
            set {
                this.managelistsField = value;
            }
        }
        public EntityItemBoolType viewversions {
            get {
                return this.viewversionsField;
            }
            set {
                this.viewversionsField = value;
            }
        }
        public EntityItemBoolType viewlistitems {
            get {
                return this.viewlistitemsField;
            }
            set {
                this.viewlistitemsField = value;
            }
        }
        public EntityItemBoolType cancelcheckout {
            get {
                return this.cancelcheckoutField;
            }
            set {
                this.cancelcheckoutField = value;
            }
        }
        public EntityItemBoolType createalerts {
            get {
                return this.createalertsField;
            }
            set {
                this.createalertsField = value;
            }
        }
        public EntityItemBoolType viewformpages {
            get {
                return this.viewformpagesField;
            }
            set {
                this.viewformpagesField = value;
            }
        }
        public EntityItemBoolType viewpages {
            get {
                return this.viewpagesField;
            }
            set {
                this.viewpagesField = value;
            }
        }
        public EntityItemBoolType addandcustomizepages {
            get {
                return this.addandcustomizepagesField;
            }
            set {
                this.addandcustomizepagesField = value;
            }
        }
        public EntityItemBoolType applystylesheets {
            get {
                return this.applystylesheetsField;
            }
            set {
                this.applystylesheetsField = value;
            }
        }
        public EntityItemBoolType applythemeandborder {
            get {
                return this.applythemeandborderField;
            }
            set {
                this.applythemeandborderField = value;
            }
        }
        public EntityItemBoolType browsedirectories {
            get {
                return this.browsedirectoriesField;
            }
            set {
                this.browsedirectoriesField = value;
            }
        }
        public EntityItemBoolType browseuserinfo {
            get {
                return this.browseuserinfoField;
            }
            set {
                this.browseuserinfoField = value;
            }
        }
        public EntityItemBoolType creategroups {
            get {
                return this.creategroupsField;
            }
            set {
                this.creategroupsField = value;
            }
        }
        public EntityItemBoolType createsscsite {
            get {
                return this.createsscsiteField;
            }
            set {
                this.createsscsiteField = value;
            }
        }
        public EntityItemBoolType editmyuserinfo {
            get {
                return this.editmyuserinfoField;
            }
            set {
                this.editmyuserinfoField = value;
            }
        }
        public EntityItemBoolType enumeratepermissions {
            get {
                return this.enumeratepermissionsField;
            }
            set {
                this.enumeratepermissionsField = value;
            }
        }
        public EntityItemBoolType managealerts {
            get {
                return this.managealertsField;
            }
            set {
                this.managealertsField = value;
            }
        }
        public EntityItemBoolType managepermissions {
            get {
                return this.managepermissionsField;
            }
            set {
                this.managepermissionsField = value;
            }
        }
        public EntityItemBoolType managesubwebs {
            get {
                return this.managesubwebsField;
            }
            set {
                this.managesubwebsField = value;
            }
        }
        public EntityItemBoolType manageweb {
            get {
                return this.managewebField;
            }
            set {
                this.managewebField = value;
            }
        }
        public EntityItemBoolType open {
            get {
                return this.openField;
            }
            set {
                this.openField = value;
            }
        }
        public EntityItemBoolType useclientintegration {
            get {
                return this.useclientintegrationField;
            }
            set {
                this.useclientintegrationField = value;
            }
        }
        public EntityItemBoolType useremoteapis {
            get {
                return this.useremoteapisField;
            }
            set {
                this.useremoteapisField = value;
            }
        }
        public EntityItemBoolType viewusagedata {
            get {
                return this.viewusagedataField;
            }
            set {
                this.viewusagedataField = value;
            }
        }
        public EntityItemBoolType managepersonalviews {
            get {
                return this.managepersonalviewsField;
            }
            set {
                this.managepersonalviewsField = value;
            }
        }
        public EntityItemBoolType adddelprivatewebparts {
            get {
                return this.adddelprivatewebpartsField;
            }
            set {
                this.adddelprivatewebpartsField = value;
            }
        }
        public EntityItemBoolType updatepersonalwebparts {
            get {
                return this.updatepersonalwebpartsField;
            }
            set {
                this.updatepersonalwebpartsField = value;
            }
        }
    }

}

