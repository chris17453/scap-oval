using System;
using System.Xml; 
using System.Xml.Serialization; 
 namespace oval{       [SerializableAttribute]
    [XmlTypeAttribute(AnonymousType=true, Namespace="http://oval.mitre.org/XMLSchema/oval-definitions-5#esx")]
    public enum ViSdkManagedEntityBehaviorsManaged_entity_type {
        ClusterComputerResource,
        ComputeResource,
        Datacenter,
        Datastore,
        DistributedVirtualPortgroup,
        DistributedVirtualSwitch,
        Folder,
        HostSystem,
        Network,
        ResourcePool,
        VirtualApp,
        VirtualMachine,
    }

}

