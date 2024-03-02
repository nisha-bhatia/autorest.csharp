// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace FirstTestTypeSpec.Models
{
    public partial class ThereLevelElement : IUtf8JsonSerializable, IJsonModel<ThereLevelElement>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ThereLevelElement>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ThereLevelElement>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ThereLevelElement>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ThereLevelElement)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(Extension is ChangeTrackingList<ThereLevelExtension> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("extension"u8);
                writer.WriteStartArray();
                foreach (var item in Extension)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        ThereLevelElement IJsonModel<ThereLevelElement>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ThereLevelElement>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ThereLevelElement)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeThereLevelElement(document.RootElement, options);
        }

        internal static ThereLevelElement DeserializeThereLevelElement(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<ThereLevelExtension> extension = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("extension"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ThereLevelExtension> array = new List<ThereLevelExtension>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ThereLevelExtension.DeserializeThereLevelExtension(item, options));
                    }
                    extension = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ThereLevelElement(extension ?? new ChangeTrackingList<ThereLevelExtension>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ThereLevelElement>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ThereLevelElement>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ThereLevelElement)} does not support '{options.Format}' format.");
            }
        }

        ThereLevelElement IPersistableModel<ThereLevelElement>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ThereLevelElement>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeThereLevelElement(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ThereLevelElement)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ThereLevelElement>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ThereLevelElement FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeThereLevelElement(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}