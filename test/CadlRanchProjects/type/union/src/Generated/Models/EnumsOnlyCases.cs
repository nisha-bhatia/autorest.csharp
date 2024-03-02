// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace _Type.Union.Models
{
    /// <summary> The EnumsOnlyCases. </summary>
    public partial class EnumsOnlyCases
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

        /// <summary> Initializes a new instance of <see cref="EnumsOnlyCases"/>. </summary>
        /// <param name="lr"> This should be receive/send the left variant. </param>
        /// <param name="ud"> This should be receive/send the up variant. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="lr"/> or <paramref name="ud"/> is null. </exception>
        public EnumsOnlyCases(BinaryData lr, BinaryData ud)
        {
            if (lr == null)
            {
                throw new ArgumentNullException(nameof(lr));
            }
            if (ud == null)
            {
                throw new ArgumentNullException(nameof(ud));
            }

            Lr = lr;
            Ud = ud;
        }

        /// <summary> Initializes a new instance of <see cref="EnumsOnlyCases"/>. </summary>
        /// <param name="lr"> This should be receive/send the left variant. </param>
        /// <param name="ud"> This should be receive/send the up variant. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal EnumsOnlyCases(BinaryData lr, BinaryData ud, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Lr = lr;
            Ud = ud;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="EnumsOnlyCases"/> for deserialization. </summary>
        internal EnumsOnlyCases()
        {
        }

        /// <summary>
        /// This should be receive/send the left variant
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// <remarks>
        /// Supported types:
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="LR"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="UD"/></description>
        /// </item>
        /// </list>
        /// </remarks>
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
        public BinaryData Lr { get; set; }
        /// <summary>
        /// This should be receive/send the up variant
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// <remarks>
        /// Supported types:
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="UD"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="UD"/></description>
        /// </item>
        /// </list>
        /// </remarks>
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
        public BinaryData Ud { get; set; }
    }
}