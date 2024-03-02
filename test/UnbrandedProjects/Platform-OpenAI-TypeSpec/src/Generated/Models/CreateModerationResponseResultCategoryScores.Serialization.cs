// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Internal;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace OpenAI.Models
{
    public partial class CreateModerationResponseResultCategoryScores : IUtf8JsonWriteable, IJsonModel<CreateModerationResponseResultCategoryScores>
    {
        void IUtf8JsonWriteable.Write(Utf8JsonWriter writer) => ((IJsonModel<CreateModerationResponseResultCategoryScores>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CreateModerationResponseResultCategoryScores>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CreateModerationResponseResultCategoryScores>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CreateModerationResponseResultCategoryScores)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("hate"u8);
            writer.WriteNumberValue(Hate);
            writer.WritePropertyName("hate/threatening"u8);
            writer.WriteNumberValue(HateThreatening);
            writer.WritePropertyName("harassment"u8);
            writer.WriteNumberValue(Harassment);
            writer.WritePropertyName("harassment/threatening"u8);
            writer.WriteNumberValue(HarassmentThreatening);
            writer.WritePropertyName("self-harm"u8);
            writer.WriteNumberValue(SelfHarm);
            writer.WritePropertyName("self-harm/intent"u8);
            writer.WriteNumberValue(SelfHarmIntent);
            writer.WritePropertyName("self-harm/instructive"u8);
            writer.WriteNumberValue(SelfHarmInstructive);
            writer.WritePropertyName("sexual"u8);
            writer.WriteNumberValue(Sexual);
            writer.WritePropertyName("sexual/minors"u8);
            writer.WriteNumberValue(SexualMinors);
            writer.WritePropertyName("violence"u8);
            writer.WriteNumberValue(Violence);
            writer.WritePropertyName("violence/graphic"u8);
            writer.WriteNumberValue(ViolenceGraphic);
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

        CreateModerationResponseResultCategoryScores IJsonModel<CreateModerationResponseResultCategoryScores>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CreateModerationResponseResultCategoryScores>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CreateModerationResponseResultCategoryScores)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCreateModerationResponseResultCategoryScores(document.RootElement, options);
        }

        internal static CreateModerationResponseResultCategoryScores DeserializeCreateModerationResponseResultCategoryScores(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            double hate = default;
            double hateThreatening = default;
            double harassment = default;
            double harassmentThreatening = default;
            double selfHarm = default;
            double selfHarmIntent = default;
            double selfHarmInstructive = default;
            double sexual = default;
            double sexualMinors = default;
            double violence = default;
            double violenceGraphic = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("hate"u8))
                {
                    hate = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("hate/threatening"u8))
                {
                    hateThreatening = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("harassment"u8))
                {
                    harassment = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("harassment/threatening"u8))
                {
                    harassmentThreatening = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("self-harm"u8))
                {
                    selfHarm = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("self-harm/intent"u8))
                {
                    selfHarmIntent = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("self-harm/instructive"u8))
                {
                    selfHarmInstructive = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("sexual"u8))
                {
                    sexual = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("sexual/minors"u8))
                {
                    sexualMinors = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("violence"u8))
                {
                    violence = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("violence/graphic"u8))
                {
                    violenceGraphic = property.Value.GetDouble();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CreateModerationResponseResultCategoryScores(
                hate,
                hateThreatening,
                harassment,
                harassmentThreatening,
                selfHarm,
                selfHarmIntent,
                selfHarmInstructive,
                sexual,
                sexualMinors,
                violence,
                violenceGraphic,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CreateModerationResponseResultCategoryScores>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CreateModerationResponseResultCategoryScores>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CreateModerationResponseResultCategoryScores)} does not support '{options.Format}' format.");
            }
        }

        CreateModerationResponseResultCategoryScores IPersistableModel<CreateModerationResponseResultCategoryScores>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CreateModerationResponseResultCategoryScores>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCreateModerationResponseResultCategoryScores(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CreateModerationResponseResultCategoryScores)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CreateModerationResponseResultCategoryScores>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The result to deserialize the model from. </param>
        internal static CreateModerationResponseResultCategoryScores FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeCreateModerationResponseResultCategoryScores(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestBody. </summary>
        internal virtual RequestBody ToRequestBody()
        {
            var content = new Utf8JsonRequestBody();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}