// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace ProtocolMethodsInRestClient.Models
{
    /// <summary> . </summary>
    public partial class Resource
    {
        /// <summary> Initializes a new instance of Resource. </summary>
        public Resource()
        {
        }

        /// <summary> Initializes a new instance of Resource. </summary>
        /// <param name="name"></param>
        /// <param name="id"></param>
        internal Resource(string name, string id)
        {
            Name = name;
            Id = id;
        }

        /// <summary> Gets or sets the name. </summary>
        public string Name { get; set; }
        /// <summary> Gets or sets the id. </summary>
        public string Id { get; set; }
    }
}