using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#macos")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5#macos", IsNullable=false)]
    public class systemsetup_item : ItemType {
        private EntityItemStringType timezoneField;
        private EntityItemBoolType usingnetworktimeField;
        private EntityItemStringType networktimeserverField;
        private EntityItemIntType computersleepField;
        private EntityItemIntType displaysleepField;
        private EntityItemIntType harddisksleepField;
        private EntityItemBoolType wakeonmodemField;
        private EntityItemBoolType wakeonnetworkaccessField;
        private EntityItemBoolType restartfreezeField;
        private EntityItemBoolType restartpowerfailureField;
        private EntityItemBoolType allowpowerbuttontosleepcomputerField;
        private EntityItemBoolType remoteloginField;
        private EntityItemBoolType remoteappleeventsField;
        private EntityItemStringType computernameField;
        private EntityItemStringType localsubnetnameField;
        private EntityItemStringType startupdiskField;
        private EntityItemIntType waitforstartupafterpowerfailureField;
        private EntityItemBoolType disablekeyboardwhenenclosurelockisengagedField;
        private EntityItemStringType kernelbootarchitecturesettingField;
        public EntityItemStringType timezone {
            get {
                return this.timezoneField;
            }
            set {
                this.timezoneField = value;
            }
        }
        public EntityItemBoolType usingnetworktime {
            get {
                return this.usingnetworktimeField;
            }
            set {
                this.usingnetworktimeField = value;
            }
        }
        public EntityItemStringType networktimeserver {
            get {
                return this.networktimeserverField;
            }
            set {
                this.networktimeserverField = value;
            }
        }
        public EntityItemIntType computersleep {
            get {
                return this.computersleepField;
            }
            set {
                this.computersleepField = value;
            }
        }
        public EntityItemIntType displaysleep {
            get {
                return this.displaysleepField;
            }
            set {
                this.displaysleepField = value;
            }
        }
        public EntityItemIntType harddisksleep {
            get {
                return this.harddisksleepField;
            }
            set {
                this.harddisksleepField = value;
            }
        }
        public EntityItemBoolType wakeonmodem {
            get {
                return this.wakeonmodemField;
            }
            set {
                this.wakeonmodemField = value;
            }
        }
        public EntityItemBoolType wakeonnetworkaccess {
            get {
                return this.wakeonnetworkaccessField;
            }
            set {
                this.wakeonnetworkaccessField = value;
            }
        }
        public EntityItemBoolType restartfreeze {
            get {
                return this.restartfreezeField;
            }
            set {
                this.restartfreezeField = value;
            }
        }
        public EntityItemBoolType restartpowerfailure {
            get {
                return this.restartpowerfailureField;
            }
            set {
                this.restartpowerfailureField = value;
            }
        }
        public EntityItemBoolType allowpowerbuttontosleepcomputer {
            get {
                return this.allowpowerbuttontosleepcomputerField;
            }
            set {
                this.allowpowerbuttontosleepcomputerField = value;
            }
        }
        public EntityItemBoolType remotelogin {
            get {
                return this.remoteloginField;
            }
            set {
                this.remoteloginField = value;
            }
        }
        public EntityItemBoolType remoteappleevents {
            get {
                return this.remoteappleeventsField;
            }
            set {
                this.remoteappleeventsField = value;
            }
        }
        public EntityItemStringType computername {
            get {
                return this.computernameField;
            }
            set {
                this.computernameField = value;
            }
        }
        public EntityItemStringType localsubnetname {
            get {
                return this.localsubnetnameField;
            }
            set {
                this.localsubnetnameField = value;
            }
        }
        public EntityItemStringType startupdisk {
            get {
                return this.startupdiskField;
            }
            set {
                this.startupdiskField = value;
            }
        }
        public EntityItemIntType waitforstartupafterpowerfailure {
            get {
                return this.waitforstartupafterpowerfailureField;
            }
            set {
                this.waitforstartupafterpowerfailureField = value;
            }
        }
        public EntityItemBoolType disablekeyboardwhenenclosurelockisengaged {
            get {
                return this.disablekeyboardwhenenclosurelockisengagedField;
            }
            set {
                this.disablekeyboardwhenenclosurelockisengagedField = value;
            }
        }
        public EntityItemStringType kernelbootarchitecturesetting {
            get {
                return this.kernelbootarchitecturesettingField;
            }
            set {
                this.kernelbootarchitecturesettingField = value;
            }
        }
    }

}

