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
    /// Describes a virtual machine scale set OS profile.
    /// Serialized Name: VirtualMachineScaleSetUpdateOSProfile
    /// </summary>
    public partial class VirtualMachineScaleSetUpdateOSProfile
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

        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetUpdateOSProfile"/>. </summary>
        public VirtualMachineScaleSetUpdateOSProfile()
        {
            Secrets = new ChangeTrackingList<VaultSecretGroup>();
        }

        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetUpdateOSProfile"/>. </summary>
        /// <param name="customData">
        /// A base-64 encoded string of custom data.
        /// Serialized Name: VirtualMachineScaleSetUpdateOSProfile.customData
        /// </param>
        /// <param name="windowsConfiguration">
        /// The Windows Configuration of the OS profile.
        /// Serialized Name: VirtualMachineScaleSetUpdateOSProfile.windowsConfiguration
        /// </param>
        /// <param name="linuxConfiguration">
        /// The Linux Configuration of the OS profile.
        /// Serialized Name: VirtualMachineScaleSetUpdateOSProfile.linuxConfiguration
        /// </param>
        /// <param name="secrets">
        /// The List of certificates for addition to the VM.
        /// Serialized Name: VirtualMachineScaleSetUpdateOSProfile.secrets
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal VirtualMachineScaleSetUpdateOSProfile(string customData, WindowsConfiguration windowsConfiguration, LinuxConfiguration linuxConfiguration, IList<VaultSecretGroup> secrets, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            CustomData = customData;
            WindowsConfiguration = windowsConfiguration;
            LinuxConfiguration = linuxConfiguration;
            Secrets = secrets;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// A base-64 encoded string of custom data.
        /// Serialized Name: VirtualMachineScaleSetUpdateOSProfile.customData
        /// </summary>
        [WirePath("customData")]
        public string CustomData { get; set; }
        /// <summary>
        /// The Windows Configuration of the OS profile.
        /// Serialized Name: VirtualMachineScaleSetUpdateOSProfile.windowsConfiguration
        /// </summary>
        [WirePath("windowsConfiguration")]
        public WindowsConfiguration WindowsConfiguration { get; set; }
        /// <summary>
        /// The Linux Configuration of the OS profile.
        /// Serialized Name: VirtualMachineScaleSetUpdateOSProfile.linuxConfiguration
        /// </summary>
        [WirePath("linuxConfiguration")]
        public LinuxConfiguration LinuxConfiguration { get; set; }
        /// <summary>
        /// The List of certificates for addition to the VM.
        /// Serialized Name: VirtualMachineScaleSetUpdateOSProfile.secrets
        /// </summary>
        [WirePath("secrets")]
        public IList<VaultSecretGroup> Secrets { get; }
    }
}
