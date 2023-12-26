// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace _Type.Model.Inheritance.Recursive.Models
{
    /// <summary> extension. </summary>
    public partial class Extension : Element
    {
        /// <summary> Initializes a new instance of <see cref="Extension"/>. </summary>
        /// <param name="level"></param>
        public Extension(int level)
        {
            Level = level;
        }

        /// <summary> Initializes a new instance of <see cref="Extension"/>. </summary>
        /// <param name="extension"></param>
        /// <param name="level"></param>
        internal Extension(IReadOnlyList<Extension> extension, int level) : base(extension)
        {
            Level = level;
        }

        /// <summary> Gets or sets the level. </summary>
        public int Level { get; set; }
    }
}