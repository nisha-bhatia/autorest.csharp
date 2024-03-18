// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace MgmtCollectionParent.Models
{
    /// <summary> Resource stage details. </summary>
    public partial class StageDetails
    {
        /// <summary> Initializes a new instance of <see cref="StageDetails"/>. </summary>
        internal StageDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="StageDetails"/>. </summary>
        /// <param name="stageStatus"> Stage status. </param>
        /// <param name="stageName"> Stage name. </param>
        /// <param name="displayName"> Display name of the resource stage. </param>
        /// <param name="startOn"> Stage start time. </param>
        internal StageDetails(StageStatus? stageStatus, StageName? stageName, string displayName, DateTimeOffset? startOn)
        {
            StageStatus = stageStatus;
            StageName = stageName;
            DisplayName = displayName;
            StartOn = startOn;
        }

        /// <summary> Stage status. </summary>
        public StageStatus? StageStatus { get; }
        /// <summary> Stage name. </summary>
        public StageName? StageName { get; }
        /// <summary> Display name of the resource stage. </summary>
        public string DisplayName { get; }
        /// <summary> Stage start time. </summary>
        public DateTimeOffset? StartOn { get; }
    }
}