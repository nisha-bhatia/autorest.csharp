// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Management.Storage.Models
{
    /// <summary> Blob range. </summary>
    public partial class BlobRestoreRange
    {
        /// <summary> Initializes a new instance of BlobRestoreRange. </summary>
        /// <param name="startRange"> Blob start range. This is inclusive. Empty means account start. </param>
        /// <param name="endRange"> Blob end range. This is exclusive. Empty means account end. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="startRange"/> or <paramref name="endRange"/> is null. </exception>
        public BlobRestoreRange(string startRange, string endRange)
        {
            if (startRange == null)
            {
                throw new ArgumentNullException(nameof(startRange));
            }
            if (endRange == null)
            {
                throw new ArgumentNullException(nameof(endRange));
            }

            StartRange = startRange;
            EndRange = endRange;
        }

        /// <summary> Blob start range. This is inclusive. Empty means account start. </summary>
        public string StartRange { get; set; }
        /// <summary> Blob end range. This is exclusive. Empty means account end. </summary>
        public string EndRange { get; set; }
    }
}