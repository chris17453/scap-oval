using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#macos")]
    [XmlRootAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#macos", IsNullable=false)]
    public class systemsetup_state : StateType {
        private EntityStateStringType timezoneField;
        private EntityStateBoolType usingnetworktimeField;
        private EntityStateStringType networktimeserverField;
        private EntityStateIntType computersleepField;
        private EntityStateIntType displaysleepField;
        private EntityStateIntType harddisksleepField;
        private EntityStateBoolType wakeonmodemField;
        private EntityStateBoolType wakeonnetworkaccessField;
        private EntityStateBoolType restartfreezeField;
        private EntityStateBoolType allowpowerbuttontosleepcomputerField;
        private EntityStateBoolType remoteloginField;
        private EntityStateBoolType remoteappleeventsField;
        private EntityStateStringType computernameField;
        private EntityStateStringType startupdiskField;
        private EntityStateIntType waitforstartupafterpowerfailureField;
        private EntityStateBoolType disablekeyboardwhenenclosurelockisengagedField;
        private EntityStateStringType kernelbootarchitecturesettingField;
        public EntityStateStringType timezone {
            get {
                return this.timezoneField;
            }
            set {
                this.timezoneField = value;
            }
        }
        public EntityStateBoolType usingnetworktime {
            get {
                return this.usingnetworktimeField;
            }
            set {
                this.usingnetworktimeField = value;
            }
        }
        public EntityStateStringType networktimeserver {
            get {
                return this.networktimeserverField;
            }
            set {
                this.networktimeserverField = value;
            }
        }
        public EntityStateIntType computersleep {
            get {
                return this.computersleepField;
            }
            set {
                this.computersleepField = value;
            }
        }
        public EntityStateIntType displaysleep {
            get {
                return this.displaysleepField;
            }
            set {
                this.displaysleepField = value;
            }
        }
        public EntityStateIntType harddisksleep {
            get {
                return this.harddisksleepField;
            }
            set {
                this.harddisksleepField = value;
            }
        }
        public EntityStateBoolType wakeonmodem {
            get {
                return this.wakeonmodemField;
            }
            set {
                this.wakeonmodemField = value;
            }
        }
        public EntityStateBoolType wakeonnetworkaccess {
            get {
                return this.wakeonnetworkaccessField;
            }
            set {
                this.wakeonnetworkaccessField = value;
            }
        }
        public EntityStateBoolType restartfreeze {
            get {
                return this.restartfreezeField;
            }
            set {
                this.restartfreezeField = value;
            }
        }
        public EntityStateBoolType allowpowerbuttontosleepcomputer {
            get {
                return this.allowpowerbuttontosleepcomputerField;
            }
            set {
                this.allowpowerbuttontosleepcomputerField = value;
            }
        }
        public EntityStateBoolType remotelogin {
            get {
                return this.remoteloginField;
            }
            set {
                this.remoteloginField = value;
            }
        }
        public EntityStateBoolType remoteappleevents {
            get {
                return this.remoteappleeventsField;
            }
            set {
                this.remoteappleeventsField = value;
            }
        }
        public EntityStateStringType computername {
            get {
                return this.computernameField;
            }
            set {
                this.computernameField = value;
            }
        }
        public EntityStateStringType startupdisk {
            get {
                return this.startupdiskField;
            }
            set {
                this.startupdiskField = value;
            }
        }
        public EntityStateIntType waitforstartupafterpowerfailure {
            get {
                return this.waitforstartupafterpowerfailureField;
            }
            set {
                this.waitforstartupafterpowerfailureField = value;
            }
        }
        public EntityStateBoolType disablekeyboardwhenenclosurelockisengaged {
            get {
                return this.disablekeyboardwhenenclosurelockisengagedField;
            }
            set {
                this.disablekeyboardwhenenclosurelockisengagedField = value;
            }
        }
        public EntityStateStringType kernelbootarchitecturesetting {
            get {
                return this.kernelbootarchitecturesettingField;
            }
            set {
                this.kernelbootarchitecturesettingField = value;
            }
        }
    }

}

