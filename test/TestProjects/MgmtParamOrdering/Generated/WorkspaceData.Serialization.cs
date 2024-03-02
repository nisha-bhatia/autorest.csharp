// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using MgmtParamOrdering.Models;

namespace MgmtParamOrdering
{
    public partial class WorkspaceData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (!(Tags is ChangeTrackingDictionary<string, string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Description != null)
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (FriendlyName != null)
            {
                writer.WritePropertyName("friendlyName"u8);
                writer.WriteStringValue(FriendlyName);
            }
            if (KeyVault != null)
            {
                writer.WritePropertyName("keyVault"u8);
                writer.WriteStringValue(KeyVault);
            }
            if (ApplicationInsights != null)
            {
                writer.WritePropertyName("applicationInsights"u8);
                writer.WriteStringValue(ApplicationInsights);
            }
            if (ContainerRegistry != null)
            {
                if (ContainerRegistry != null)
                {
                    writer.WritePropertyName("containerRegistry"u8);
                    writer.WriteStringValue(ContainerRegistry);
                }
                else
                {
                    writer.WriteNull("containerRegistry");
                }
            }
            if (StorageAccount != null)
            {
                writer.WritePropertyName("storageAccount"u8);
                writer.WriteStringValue(StorageAccount);
            }
            if (DiscoveryUri != null)
            {
                writer.WritePropertyName("discoveryUrl"u8);
                writer.WriteStringValue(DiscoveryUri.AbsoluteUri);
            }
            if (HbiWorkspace.HasValue)
            {
                writer.WritePropertyName("hbiWorkspace"u8);
                writer.WriteBooleanValue(HbiWorkspace.Value);
            }
            if (ImageBuildCompute != null)
            {
                writer.WritePropertyName("imageBuildCompute"u8);
                writer.WriteStringValue(ImageBuildCompute);
            }
            if (AllowPublicAccessWhenBehindVnet.HasValue)
            {
                writer.WritePropertyName("allowPublicAccessWhenBehindVnet"u8);
                writer.WriteBooleanValue(AllowPublicAccessWhenBehindVnet.Value);
            }
            if (PrimaryUserAssignedIdentity != null)
            {
                writer.WritePropertyName("primaryUserAssignedIdentity"u8);
                writer.WriteStringValue(PrimaryUserAssignedIdentity);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static WorkspaceData DeserializeWorkspaceData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string workspaceId = default;
            string description = default;
            string friendlyName = default;
            string keyVault = default;
            string applicationInsights = default;
            string containerRegistry = default;
            string storageAccount = default;
            Uri discoveryUrl = default;
            ProvisioningState? provisioningState = default;
            bool? hbiWorkspace = default;
            string serviceProvisionedResourceGroup = default;
            int? privateLinkCount = default;
            string imageBuildCompute = default;
            bool? allowPublicAccessWhenBehindVnet = default;
            string primaryUserAssignedIdentity = default;
            Guid? tenantId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("workspaceId"u8))
                        {
                            workspaceId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("friendlyName"u8))
                        {
                            friendlyName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("keyVault"u8))
                        {
                            keyVault = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("applicationInsights"u8))
                        {
                            applicationInsights = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("containerRegistry"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                containerRegistry = null;
                                continue;
                            }
                            containerRegistry = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("storageAccount"u8))
                        {
                            storageAccount = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("discoveryUrl"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            discoveryUrl = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("hbiWorkspace"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hbiWorkspace = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("serviceProvisionedResourceGroup"u8))
                        {
                            serviceProvisionedResourceGroup = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("privateLinkCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            privateLinkCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("imageBuildCompute"u8))
                        {
                            imageBuildCompute = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("allowPublicAccessWhenBehindVnet"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            allowPublicAccessWhenBehindVnet = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("primaryUserAssignedIdentity"u8))
                        {
                            primaryUserAssignedIdentity = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("tenantId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            tenantId = property0.Value.GetGuid();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new WorkspaceData(
                id,
                name,
                type,
                systemData,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                location,
                workspaceId,
                description,
                friendlyName,
                keyVault,
                applicationInsights,
                containerRegistry,
                storageAccount,
                discoveryUrl,
                provisioningState,
                hbiWorkspace,
                serviceProvisionedResourceGroup,
                privateLinkCount,
                imageBuildCompute,
                allowPublicAccessWhenBehindVnet,
                primaryUserAssignedIdentity,
                tenantId);
        }
    }
}