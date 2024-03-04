// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;
using MgmtExpandResourceTypes;

namespace MgmtExpandResourceTypes.Models
{
    /// <summary> Represents a single Azure resource and its referencing DNS records. </summary>
    public partial class DnsResourceReference
    {
        /// <summary> Initializes a new instance of <see cref="DnsResourceReference"/>. </summary>
        internal DnsResourceReference()
        {
            DnsResources = new ChangeTrackingList<WritableSubResource>();
        }

        /// <summary> Initializes a new instance of <see cref="DnsResourceReference"/>. </summary>
        /// <param name="dnsResources"> A list of dns Records. </param>
        /// <param name="targetResource"> A reference to an azure resource from where the dns resource value is taken. </param>
        internal DnsResourceReference(IReadOnlyList<WritableSubResource> dnsResources, WritableSubResource targetResource)
        {
            DnsResources = dnsResources;
            TargetResource = targetResource;
        }

        /// <summary> A list of dns Records. </summary>
        public IReadOnlyList<WritableSubResource> DnsResources { get; }
        /// <summary> A reference to an azure resource from where the dns resource value is taken. </summary>
        internal WritableSubResource TargetResource { get; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier TargetResourceId
        {
            get => TargetResource?.Id;
        }
    }
}
