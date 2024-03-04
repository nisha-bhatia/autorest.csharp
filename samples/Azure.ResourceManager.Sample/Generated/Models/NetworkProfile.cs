// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Sample;

namespace Azure.ResourceManager.Sample.Models
{
    /// <summary>
    /// Specifies the network interfaces of the virtual machine.
    /// Serialized Name: NetworkProfile
    /// </summary>
    internal partial class NetworkProfile
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="NetworkProfile"/>. </summary>
        public NetworkProfile()
        {
            NetworkInterfaces = new ChangeTrackingList<NetworkInterfaceReference>();
        }

        /// <summary> Initializes a new instance of <see cref="NetworkProfile"/>. </summary>
        /// <param name="networkInterfaces">
        /// Specifies the list of resource Ids for the network interfaces associated with the virtual machine.
        /// Serialized Name: NetworkProfile.networkInterfaces
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NetworkProfile(IList<NetworkInterfaceReference> networkInterfaces, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            NetworkInterfaces = networkInterfaces;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// Specifies the list of resource Ids for the network interfaces associated with the virtual machine.
        /// Serialized Name: NetworkProfile.networkInterfaces
        /// </summary>
        [WirePath("networkInterfaces")]
        public IList<NetworkInterfaceReference> NetworkInterfaces { get; }
    }
}
