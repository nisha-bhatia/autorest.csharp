// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources.Models;

namespace MgmtListMethods
{
    /// <summary> A class representing the SubParentWithNonResCh data model. </summary>
    public partial class SubParentWithNonResChData : TrackedResource
    {
        /// <summary> Initializes a new instance of SubParentWithNonResChData. </summary>
        /// <param name="location"> The location. </param>
        public SubParentWithNonResChData(Location location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of SubParentWithNonResChData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="location"> The location. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="bar"> specifies the bar. </param>
        internal SubParentWithNonResChData(ResourceIdentifier id, string name, ResourceType type, Location location, IDictionary<string, string> tags, string bar) : base(id, name, type, location, tags)
        {
            Bar = bar;
        }

        /// <summary> specifies the bar. </summary>
        public string Bar { get; set; }
    }
}