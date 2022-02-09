// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;
using MgmtPropertyChooser.Models;

namespace MgmtPropertyChooser
{
    /// <summary> A class representing the VirtualMachine data model. </summary>
    public partial class VirtualMachineData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of VirtualMachineData. </summary>
        /// <param name="location"> The location. </param>
        public VirtualMachineData(AzureLocation location) : base(location)
        {
            Resources = new ChangeTrackingList<VirtualMachineExtension>();
            Zones = new ChangeTrackingList<string>();
            FakeResources = new ChangeTrackingList<Models.Resource>();
        }

        /// <summary> Initializes a new instance of VirtualMachineData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="plan"> Specifies information about the marketplace image used to create the virtual machine. This element is only used for marketplace images. Before you can use a marketplace image from an API, you must enable the image for programmatic use.  In the Azure portal, find the marketplace image that you want to use and then click **Want to deploy programmatically, Get Started -&gt;**. Enter any required information and then click **Save**. </param>
        /// <param name="resources"> The virtual machine child extension resources. </param>
        /// <param name="identity"> The identity of the virtual machine, if configured. </param>
        /// <param name="identityWithRenamedProperty"> The identity of the virtual machine, if configured. </param>
        /// <param name="identityWithDifferentPropertyType"> The identity of the virtual machine, if configured. </param>
        /// <param name="identityWithNoUserIdentity"> The identity of the virtual machine, if configured. </param>
        /// <param name="identityWithNoSystemIdentity"> The identity of the virtual machine, if configured. </param>
        /// <param name="zones"> The virtual machine zones. </param>
        /// <param name="fakeResources"> The fake resources for the virtual machine. </param>
        /// <param name="fakeSubResource"> The fake subresource. </param>
        /// <param name="fakeWritableSubResource"> The fake writable subresource. </param>
        /// <param name="provisioningState"> The provisioning state, which only appears in the response. </param>
        /// <param name="licenseType"> Specifies that the image or disk that is being used was licensed on-premises. This element is only used for images that contain the Windows Server operating system. &lt;br&gt;&lt;br&gt; Possible values are: &lt;br&gt;&lt;br&gt; Windows_Client &lt;br&gt;&lt;br&gt; Windows_Server &lt;br&gt;&lt;br&gt; If this element is included in a request for an update, the value must match the initial value. This value cannot be updated. &lt;br&gt;&lt;br&gt; For more information, see [Azure Hybrid Use Benefit for Windows Server](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-hybrid-use-benefit-licensing?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json) &lt;br&gt;&lt;br&gt; Minimum api-version: 2015-06-15. </param>
        /// <param name="vmId"> Specifies the VM unique ID which is a 128-bits identifier that is encoded and stored in all Azure IaaS VMs SMBIOS and can be read using platform BIOS commands. </param>
        /// <param name="extensionsTimeBudget"> Specifies the time alloted for all extensions to start. The time duration should be between 15 minutes and 120 minutes (inclusive) and should be specified in ISO 8601 format. The default value is 90 minutes (PT1H30M). &lt;br&gt;&lt;br&gt; Minimum api-version: 2020-06-01. </param>
        internal VirtualMachineData(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, Models.Plan plan, IReadOnlyList<VirtualMachineExtension> resources, ManagedServiceIdentity identity, IdentityWithRenamedProperty identityWithRenamedProperty, IdentityWithDifferentPropertyType identityWithDifferentPropertyType, IdentityWithNoUserIdentity identityWithNoUserIdentity, IdentityWithNoSystemIdentity identityWithNoSystemIdentity, IList<string> zones, IReadOnlyList<Models.Resource> fakeResources, SubResource fakeSubResource, WritableSubResource fakeWritableSubResource, string provisioningState, string licenseType, string vmId, string extensionsTimeBudget) : base(id, name, type, systemData, tags, location)
        {
            Plan = plan;
            Resources = resources;
            Identity = identity;
            IdentityWithRenamedProperty = identityWithRenamedProperty;
            IdentityWithDifferentPropertyType = identityWithDifferentPropertyType;
            IdentityWithNoUserIdentity = identityWithNoUserIdentity;
            IdentityWithNoSystemIdentity = identityWithNoSystemIdentity;
            Zones = zones;
            FakeResources = fakeResources;
            FakeSubResource = fakeSubResource;
            FakeWritableSubResource = fakeWritableSubResource;
            ProvisioningState = provisioningState;
            LicenseType = licenseType;
            VmId = vmId;
            ExtensionsTimeBudget = extensionsTimeBudget;
        }

        /// <summary> Specifies information about the marketplace image used to create the virtual machine. This element is only used for marketplace images. Before you can use a marketplace image from an API, you must enable the image for programmatic use.  In the Azure portal, find the marketplace image that you want to use and then click **Want to deploy programmatically, Get Started -&gt;**. Enter any required information and then click **Save**. </summary>
        public Models.Plan Plan { get; set; }
        /// <summary> The virtual machine child extension resources. </summary>
        public IReadOnlyList<VirtualMachineExtension> Resources { get; }
        /// <summary> The identity of the virtual machine, if configured. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> The identity of the virtual machine, if configured. </summary>
        public IdentityWithRenamedProperty IdentityWithRenamedProperty { get; set; }
        /// <summary> The identity of the virtual machine, if configured. </summary>
        public IdentityWithDifferentPropertyType IdentityWithDifferentPropertyType { get; set; }
        /// <summary> The identity of the virtual machine, if configured. </summary>
        public IdentityWithNoUserIdentity IdentityWithNoUserIdentity { get; set; }
        /// <summary> The identity of the virtual machine, if configured. </summary>
        public IdentityWithNoSystemIdentity IdentityWithNoSystemIdentity { get; set; }
        /// <summary> The virtual machine zones. </summary>
        public IList<string> Zones { get; }
        /// <summary> The fake resources for the virtual machine. </summary>
        public IReadOnlyList<Models.Resource> FakeResources { get; }
        /// <summary> The fake subresource. </summary>
        public SubResource FakeSubResource { get; set; }
        /// <summary> The fake writable subresource. </summary>
        public WritableSubResource FakeWritableSubResource { get; set; }
        /// <summary> The provisioning state, which only appears in the response. </summary>
        public string ProvisioningState { get; }
        /// <summary> Specifies that the image or disk that is being used was licensed on-premises. This element is only used for images that contain the Windows Server operating system. &lt;br&gt;&lt;br&gt; Possible values are: &lt;br&gt;&lt;br&gt; Windows_Client &lt;br&gt;&lt;br&gt; Windows_Server &lt;br&gt;&lt;br&gt; If this element is included in a request for an update, the value must match the initial value. This value cannot be updated. &lt;br&gt;&lt;br&gt; For more information, see [Azure Hybrid Use Benefit for Windows Server](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-hybrid-use-benefit-licensing?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json) &lt;br&gt;&lt;br&gt; Minimum api-version: 2015-06-15. </summary>
        public string LicenseType { get; set; }
        /// <summary> Specifies the VM unique ID which is a 128-bits identifier that is encoded and stored in all Azure IaaS VMs SMBIOS and can be read using platform BIOS commands. </summary>
        public string VmId { get; }
        /// <summary> Specifies the time alloted for all extensions to start. The time duration should be between 15 minutes and 120 minutes (inclusive) and should be specified in ISO 8601 format. The default value is 90 minutes (PT1H30M). &lt;br&gt;&lt;br&gt; Minimum api-version: 2020-06-01. </summary>
        public string ExtensionsTimeBudget { get; set; }
    }
}
