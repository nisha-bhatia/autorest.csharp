// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace MgmtListMethods
{
    /// <summary> A class representing the ResGrpParentWithAncestorWithLoc data model. </summary>
    public partial class ResGrpParentWithAncestorWithLocData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of ResGrpParentWithAncestorWithLocData. </summary>
        /// <param name="location"> The location. </param>
        public ResGrpParentWithAncestorWithLocData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of ResGrpParentWithAncestorWithLocData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="bar"> specifies the bar. </param>
        internal ResGrpParentWithAncestorWithLocData(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string bar) : base(id, name, type, systemData, tags, location)
        {
            Bar = bar;
        }

        /// <summary> specifies the bar. </summary>
        public string Bar { get; set; }
    }
}
