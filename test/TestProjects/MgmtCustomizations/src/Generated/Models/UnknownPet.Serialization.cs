// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using MgmtCustomizations;

namespace MgmtCustomizations.Models
{
    internal partial class UnknownPet : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToSerialString());
            writer.WritePropertyName("size"u8);
            SerializeSizeProperty(writer);
            if (Optional.IsDefined(DateOfBirth))
            {
                writer.WritePropertyName("dateOfBirth"u8);
                SerializeDateOfBirthProperty(writer);
            }
            writer.WriteEndObject();
        }

        internal static UnknownPet DeserializeUnknownPet(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            PetKind kind = default;
            string name = default;
            int size = default;
            DateTimeOffset? dateOfBirth = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString().ToPetKind();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("size"u8))
                {
                    DeserializeSizeProperty(property, ref size);
                    continue;
                }
                if (property.NameEquals("dateOfBirth"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dateOfBirth = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new UnknownPet(kind, name, size, dateOfBirth);
        }
    }
}