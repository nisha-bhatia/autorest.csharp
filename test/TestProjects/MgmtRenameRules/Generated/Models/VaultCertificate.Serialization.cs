// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace MgmtRenameRules.Models
{
    public partial class VaultCertificate : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(CertificateUri))
            {
                writer.WritePropertyName("certificateUrl");
                writer.WriteStringValue(CertificateUri.AbsoluteUri);
            }
            if (Optional.IsDefined(CertificateStore))
            {
                writer.WritePropertyName("certificateStore");
                writer.WriteStringValue(CertificateStore);
            }
            writer.WriteEndObject();
        }

        internal static VaultCertificate DeserializeVaultCertificate(JsonElement element)
        {
            Optional<Uri> certificateUrl = default;
            Optional<string> certificateStore = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("certificateUrl"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        certificateUrl = null;
                        continue;
                    }
                    certificateUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("certificateStore"))
                {
                    certificateStore = property.Value.GetString();
                    continue;
                }
            }
            return new VaultCertificate(certificateUrl.Value, certificateStore.Value);
        }
    }
}