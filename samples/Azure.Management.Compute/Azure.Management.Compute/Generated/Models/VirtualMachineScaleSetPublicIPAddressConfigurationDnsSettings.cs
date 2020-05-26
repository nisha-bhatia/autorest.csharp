// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Management.Compute.Models
{
    /// <summary> Describes a virtual machines scale sets network configuration&apos;s DNS settings. </summary>
    public partial class VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings
    {
        /// <summary> Initializes a new instance of VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings. </summary>
        /// <param name="domainNameLabel"> The Domain name label.The concatenation of the domain name label and vm index will be the domain name labels of the PublicIPAddress resources that will be created. </param>
        public VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings(string domainNameLabel)
        {
            if (domainNameLabel == null)
            {
                throw new ArgumentNullException(nameof(domainNameLabel));
            }

            DomainNameLabel = domainNameLabel;
        }

        /// <summary> The Domain name label.The concatenation of the domain name label and vm index will be the domain name labels of the PublicIPAddress resources that will be created. </summary>
        public string DomainNameLabel { get; set; }
    }
}
