using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [XmlIncludeAttribute(typeof(EntityItemDebianEVRStringType))]
    [XmlIncludeAttribute(typeof(EntityItemEVRStringType))]
    [XmlIncludeAttribute(typeof(EntityItemIOSVersionType))]
    [XmlIncludeAttribute(typeof(EntityItemFilesetRevisionType))]
    [XmlIncludeAttribute(typeof(EntityItemVersionType))]
    [XmlIncludeAttribute(typeof(EntityItemStringType))]
    [XmlIncludeAttribute(typeof(EntityItemInterimFixStateType))]
    [XmlIncludeAttribute(typeof(EntityItemFixInstallationStatusType))]
    [XmlIncludeAttribute(typeof(EntityItemFilesetStateType))]
    [XmlIncludeAttribute(typeof(EntityItemWifiProtocolType))]
    [XmlIncludeAttribute(typeof(EntityItemWifiPairwiseCipherType))]
    [XmlIncludeAttribute(typeof(EntityItemWifiKeyMgmtType))]
    [XmlIncludeAttribute(typeof(EntityItemWifiGroupCipherType))]
    [XmlIncludeAttribute(typeof(EntityItemWifiCurrentStatusType))]
    [XmlIncludeAttribute(typeof(EntityItemWifiAuthAlgorithmType))]
    [XmlIncludeAttribute(typeof(EntityItemPasswordQualityType))]
    [XmlIncludeAttribute(typeof(EntityItemNetworkType))]
    [XmlIncludeAttribute(typeof(EntityItemKeyguardDisabledFeaturesType))]
    [XmlIncludeAttribute(typeof(EntityItemEncryptionStatusType))]
    [XmlIncludeAttribute(typeof(EntityItemSNMPPrivStringType2))]
    [XmlIncludeAttribute(typeof(EntityItemSNMPAuthStringType2))]
    [XmlIncludeAttribute(typeof(EntityItemSNMPSecLevelStringType2))]
    [XmlIncludeAttribute(typeof(EntityItemSNMPVersionStringType2))]
    [XmlIncludeAttribute(typeof(EntityItemMatchType))]
    [XmlIncludeAttribute(typeof(EntityItemApplyServicePolicyType))]
    [XmlIncludeAttribute(typeof(EntityItemInspectionType))]
    [XmlIncludeAttribute(typeof(EntityItemClassMapType))]
    [XmlIncludeAttribute(typeof(EntityItemAccessListInterfaceDirectionType2))]
    [XmlIncludeAttribute(typeof(EntityItemAccessListUseType2))]
    [XmlIncludeAttribute(typeof(EntityItemAccessListIPVersionType2))]
    [XmlIncludeAttribute(typeof(EntityItemSupportLevelType))]
    [XmlIncludeAttribute(typeof(EntityItemClassificationType))]
    [XmlIncludeAttribute(typeof(EntityItemAccessListInterfaceDirectionType1))]
    [XmlIncludeAttribute(typeof(EntityItemAccessListUseType1))]
    [XmlIncludeAttribute(typeof(EntityItemAccessListIPVersionType1))]
    [XmlIncludeAttribute(typeof(EntityItemSNMPPrivStringType1))]
    [XmlIncludeAttribute(typeof(EntityItemSNMPAuthStringType1))]
    [XmlIncludeAttribute(typeof(EntityItemSNMPModeStringType1))]
    [XmlIncludeAttribute(typeof(EntityItemSNMPSecLevelStringType1))]
    [XmlIncludeAttribute(typeof(EntityItemSNMPVersionStringType1))]
    [XmlIncludeAttribute(typeof(EntityItemRoutingAuthTypeStringType1))]
    [XmlIncludeAttribute(typeof(EntityItemRoutingProtocolType1))]
    [XmlIncludeAttribute(typeof(EntityItemSwitchportModeType1))]
    [XmlIncludeAttribute(typeof(EntityItemTrunkEncapType1))]
    [XmlIncludeAttribute(typeof(EntityItemTrunkEncapType))]
    [XmlIncludeAttribute(typeof(EntityItemSwitchportModeType))]
    [XmlIncludeAttribute(typeof(EntityItemSNMPPrivStringType))]
    [XmlIncludeAttribute(typeof(EntityItemSNMPAuthStringType))]
    [XmlIncludeAttribute(typeof(EntityItemSNMPModeStringType))]
    [XmlIncludeAttribute(typeof(EntityItemSNMPSecLevelStringType))]
    [XmlIncludeAttribute(typeof(EntityItemSNMPVersionStringType))]
    [XmlIncludeAttribute(typeof(EntityItemRoutingProtocolType))]
    [XmlIncludeAttribute(typeof(EntityItemRoutingAuthTypeStringType))]
    [XmlIncludeAttribute(typeof(EntityItemAccessListUseType))]
    [XmlIncludeAttribute(typeof(EntityItemAccessListIPVersionType))]
    [XmlIncludeAttribute(typeof(EntityItemAccessListInterfaceDirectionType))]
    [XmlIncludeAttribute(typeof(EntityItemProtocolType1))]
    [XmlIncludeAttribute(typeof(EntityItemRpmVerifyResultType))]
    [XmlIncludeAttribute(typeof(EntityItemJunosReleaseTypeType))]
    [XmlIncludeAttribute(typeof(EntityItemPlistTypeType))]
    [XmlIncludeAttribute(typeof(EntityItemPermissionCompareType1))]
    [XmlIncludeAttribute(typeof(EntityItemDataTypeType))]
    [XmlIncludeAttribute(typeof(EntityItemInterfaceType))]
    [XmlIncludeAttribute(typeof(EntityItemEncryptMethodType))]
    [XmlIncludeAttribute(typeof(EntityItemWaitStatusType))]
    [XmlIncludeAttribute(typeof(EntityItemXinetdTypeStatusType))]
    [XmlIncludeAttribute(typeof(EntityItemRoutingTableFlagsType))]
    [XmlIncludeAttribute(typeof(EntityItemGconfTypeType))]
    [XmlIncludeAttribute(typeof(EntityItemEndpointType))]
    [XmlIncludeAttribute(typeof(EntityItemCapabilityType))]
    [XmlIncludeAttribute(typeof(EntityItemPolicyRoleType))]
    [XmlIncludeAttribute(typeof(EntityItemPolicyFeatureStateType))]
    [XmlIncludeAttribute(typeof(EntityItemTraceSeverityType))]
    [XmlIncludeAttribute(typeof(EntityItemEventSeverityType))]
    [XmlIncludeAttribute(typeof(EntityItemUrlZoneType))]
    [XmlIncludeAttribute(typeof(EntityItemLDOMRoleType))]
    [XmlIncludeAttribute(typeof(EntityItemV12NEnvType))]
    [XmlIncludeAttribute(typeof(EntityItemSmfServiceStateType))]
    [XmlIncludeAttribute(typeof(EntityItemPublisherTypeType))]
    [XmlIncludeAttribute(typeof(EntityItemPermissionCompareType))]
    [XmlIncludeAttribute(typeof(EntityItemClientUUIDType))]
    [XmlIncludeAttribute(typeof(EntityItemUserRightType))]
    [XmlIncludeAttribute(typeof(EntityItemWindowsViewType1))]
    [XmlIncludeAttribute(typeof(EntityItemCmdletVerbType))]
    [XmlIncludeAttribute(typeof(EntityItemGUIDType))]
    [XmlIncludeAttribute(typeof(EntityItemSystemMetricIndexType))]
    [XmlIncludeAttribute(typeof(EntityItemSharedResourceTypeType))]
    [XmlIncludeAttribute(typeof(EntityItemServiceTypeType))]
    [XmlIncludeAttribute(typeof(EntityItemServiceStartTypeType))]
    [XmlIncludeAttribute(typeof(EntityItemServiceCurrentStateType))]
    [XmlIncludeAttribute(typeof(EntityItemServiceControlsAcceptedType))]
    [XmlIncludeAttribute(typeof(EntityItemRegistryTypeType))]
    [XmlIncludeAttribute(typeof(EntityItemRegistryHiveType))]
    [XmlIncludeAttribute(typeof(EntityItemProtocolType))]
    [XmlIncludeAttribute(typeof(EntityItemPeSubsystemType))]
    [XmlIncludeAttribute(typeof(EntityItemPeTargetMachineType))]
    [XmlIncludeAttribute(typeof(EntityItemNTUserAccountTypeType))]
    [XmlIncludeAttribute(typeof(EntityItemNamingContextType))]
    [XmlIncludeAttribute(typeof(EntityItemInterfaceTypeType))]
    [XmlIncludeAttribute(typeof(EntityItemFileAttributeType))]
    [XmlIncludeAttribute(typeof(EntityItemFileTypeType))]
    [XmlIncludeAttribute(typeof(EntityItemDriveTypeType))]
    [XmlIncludeAttribute(typeof(EntityItemAuditType))]
    [XmlIncludeAttribute(typeof(EntityItemAdstypeType))]
    [XmlIncludeAttribute(typeof(EntityItemAddrTypeType))]
    [XmlIncludeAttribute(typeof(EntityItemWindowsViewType))]
    [XmlIncludeAttribute(typeof(EntityItemLdaptypeType))]
    [XmlIncludeAttribute(typeof(EntityItemVariableRefType))]
    [XmlIncludeAttribute(typeof(EntityItemHashTypeType))]
    [XmlIncludeAttribute(typeof(EntityItemFamilyType))]
    [XmlIncludeAttribute(typeof(EntityItemEngineType))]
    [XmlIncludeAttribute(typeof(EntityItemIntType))]
    [XmlIncludeAttribute(typeof(EntityItemFloatType))]
    [XmlIncludeAttribute(typeof(EntityItemBoolType))]
    [XmlIncludeAttribute(typeof(EntityItemBinaryType))]
    [XmlIncludeAttribute(typeof(EntityItemAnySimpleType))]
    [XmlIncludeAttribute(typeof(EntityItemIPAddressStringType))]
    [XmlIncludeAttribute(typeof(EntityItemIPAddressType))]
    [SerializableAttribute]
    [XmlTypeAttribute(Namespace="http://oval.mitre.org/XMLSchema/oval-system-characteristics-5")]
    public abstract class EntityItemSimpleBaseType {
        private string datatypeField;
    [XmlIgnore]
    public bool? maskField       { get; set; }
    public bool maskSpecified=>maskField.HasValue;
    [XmlIgnore]
    public StatusEnumeration? statusField       { get; set; }
    public bool statusSpecified=>statusField.HasValue;
        private string valueField;
        public EntityItemSimpleBaseType() {
            //this.datatypeField = "string";
            //this.maskField = false;
            //this.statusField = StatusEnumeration.exists;
        }
        [XmlAttribute]
        public string datatype {
            get {
                return this.datatypeField;
            }
            set {
                this.datatypeField = value;
            }
        }
        [XmlAttribute]
        public bool mask {
            get {
                return this.maskField.Value;
            }
            set {
                this.maskField = value;
            }
        }
        [XmlAttribute]
        public StatusEnumeration status {
            get {
                return this.statusField.Value;
            }
            set {
                this.statusField = value;
            }
        }
        [XmlTextAttribute]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }

}

