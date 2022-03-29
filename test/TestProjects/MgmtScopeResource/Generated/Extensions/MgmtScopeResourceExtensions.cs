// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.ManagementGroups;
using Azure.ResourceManager.Resources;
using MgmtScopeResource.Models;

namespace MgmtScopeResource
{
    /// <summary> A class to add extension methods to MgmtScopeResource. </summary>
    public static partial class MgmtScopeResourceExtensions
    {
        private static TenantResourceExtensionClient GetExtensionClient(TenantResource tenantResource)
        {
            return tenantResource.GetCachedClient((client) =>
            {
                return new TenantResourceExtensionClient(client, tenantResource.Id);
            }
            );
        }

        /// <summary> Gets a collection of DeploymentExtendedResources in the TenantResource. </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of DeploymentExtendedResources and their operations over a DeploymentExtendedResource. </returns>
        public static DeploymentExtendedCollection GetDeploymentExtendeds(this TenantResource tenantResource)
        {
            return GetExtensionClient(tenantResource).GetDeploymentExtendeds();
        }

        /// <summary>
        /// Gets a deployment.
        /// Request Path: /{scope}/providers/Microsoft.Resources/deployments/{deploymentName}
        /// Operation Id: Deployments_GetAtScope
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="deploymentName"> The name of the deployment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deploymentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deploymentName"/> is null. </exception>
        public static async Task<Response<DeploymentExtendedResource>> GetDeploymentExtendedAsync(this TenantResource tenantResource, string deploymentName, CancellationToken cancellationToken = default)
        {
            return await tenantResource.GetDeploymentExtendeds().GetAsync(deploymentName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a deployment.
        /// Request Path: /{scope}/providers/Microsoft.Resources/deployments/{deploymentName}
        /// Operation Id: Deployments_GetAtScope
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="deploymentName"> The name of the deployment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deploymentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deploymentName"/> is null. </exception>
        public static Response<DeploymentExtendedResource> GetDeploymentExtended(this TenantResource tenantResource, string deploymentName, CancellationToken cancellationToken = default)
        {
            return tenantResource.GetDeploymentExtendeds().Get(deploymentName, cancellationToken);
        }

        /// <summary> Gets a collection of ResourceLinkResources in the TenantResource. </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="scope"> The fully qualified ID of the scope for getting the resource links. For example, to list resource links at and under a resource group, set the scope to /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myGroup. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/> is null. </exception>
        /// <returns> An object representing collection of ResourceLinkResources and their operations over a ResourceLinkResource. </returns>
        public static ResourceLinkCollection GetResourceLinks(this TenantResource tenantResource, string scope)
        {
            Argument.AssertNotNull(scope, nameof(scope));

            return GetExtensionClient(tenantResource).GetResourceLinks(scope);
        }

        /// <summary>
        /// Gets a resource link with the specified ID.
        /// Request Path: /{linkId}
        /// Operation Id: ResourceLinks_Get
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="scope"> The fully qualified ID of the scope for getting the resource links. For example, to list resource links at and under a resource group, set the scope to /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myGroup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/> is null. </exception>
        public static async Task<Response<ResourceLinkResource>> GetResourceLinkAsync(this TenantResource tenantResource, string scope, CancellationToken cancellationToken = default)
        {
            return await GetResourceLinks(tenantResource, scope).GetAsync(cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a resource link with the specified ID.
        /// Request Path: /{linkId}
        /// Operation Id: ResourceLinks_Get
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="scope"> The fully qualified ID of the scope for getting the resource links. For example, to list resource links at and under a resource group, set the scope to /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myGroup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/> is null. </exception>
        public static Response<ResourceLinkResource> GetResourceLink(this TenantResource tenantResource, string scope, CancellationToken cancellationToken = default)
        {
            return GetResourceLinks(tenantResource, scope).Get(cancellationToken);
        }

        /// <summary>
        /// Calculate the hash of the given template.
        /// Request Path: /providers/Microsoft.Resources/calculateTemplateHash
        /// Operation Id: Deployments_CalculateTemplateHash
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="template"> The template provided to calculate hash. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="template"/> is null. </exception>
        public static async Task<Response<TemplateHashResult>> CalculateTemplateHashDeploymentAsync(this TenantResource tenantResource, BinaryData template, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(template, nameof(template));

            return await GetExtensionClient(tenantResource).CalculateTemplateHashDeploymentAsync(template, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Calculate the hash of the given template.
        /// Request Path: /providers/Microsoft.Resources/calculateTemplateHash
        /// Operation Id: Deployments_CalculateTemplateHash
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="template"> The template provided to calculate hash. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="template"/> is null. </exception>
        public static Response<TemplateHashResult> CalculateTemplateHashDeployment(this TenantResource tenantResource, BinaryData template, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(template, nameof(template));

            return GetExtensionClient(tenantResource).CalculateTemplateHashDeployment(template, cancellationToken);
        }

        private static SubscriptionResourceExtensionClient GetExtensionClient(SubscriptionResource subscriptionResource)
        {
            return subscriptionResource.GetCachedClient((client) =>
            {
                return new SubscriptionResourceExtensionClient(client, subscriptionResource.Id);
            }
            );
        }

        /// <summary> Gets a collection of DeploymentExtendedResources in the SubscriptionResource. </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of DeploymentExtendedResources and their operations over a DeploymentExtendedResource. </returns>
        public static DeploymentExtendedCollection GetDeploymentExtendeds(this SubscriptionResource subscriptionResource)
        {
            return GetExtensionClient(subscriptionResource).GetDeploymentExtendeds();
        }

        /// <summary>
        /// Gets a deployment.
        /// Request Path: /{scope}/providers/Microsoft.Resources/deployments/{deploymentName}
        /// Operation Id: Deployments_GetAtScope
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="deploymentName"> The name of the deployment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deploymentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deploymentName"/> is null. </exception>
        public static async Task<Response<DeploymentExtendedResource>> GetDeploymentExtendedAsync(this SubscriptionResource subscriptionResource, string deploymentName, CancellationToken cancellationToken = default)
        {
            return await subscriptionResource.GetDeploymentExtendeds().GetAsync(deploymentName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a deployment.
        /// Request Path: /{scope}/providers/Microsoft.Resources/deployments/{deploymentName}
        /// Operation Id: Deployments_GetAtScope
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="deploymentName"> The name of the deployment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deploymentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deploymentName"/> is null. </exception>
        public static Response<DeploymentExtendedResource> GetDeploymentExtended(this SubscriptionResource subscriptionResource, string deploymentName, CancellationToken cancellationToken = default)
        {
            return subscriptionResource.GetDeploymentExtendeds().Get(deploymentName, cancellationToken);
        }

        /// <summary>
        /// Gets all the linked resources for the subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Resources/links
        /// Operation Id: ResourceLinks_ListAtSubscription
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="filter"> The filter to apply on the list resource links operation. The supported filter for list resource links is targetId. For example, $filter=targetId eq {value}. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ResourceLinkResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<ResourceLinkResource> GetResourceLinksAsync(this SubscriptionResource subscriptionResource, string filter = null, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetResourceLinksAsync(filter, cancellationToken);
        }

        /// <summary>
        /// Gets all the linked resources for the subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Resources/links
        /// Operation Id: ResourceLinks_ListAtSubscription
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="filter"> The filter to apply on the list resource links operation. The supported filter for list resource links is targetId. For example, $filter=targetId eq {value}. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ResourceLinkResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<ResourceLinkResource> GetResourceLinks(this SubscriptionResource subscriptionResource, string filter = null, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetResourceLinks(filter, cancellationToken);
        }

        private static ResourceGroupResourceExtensionClient GetExtensionClient(ResourceGroupResource resourceGroupResource)
        {
            return resourceGroupResource.GetCachedClient((client) =>
            {
                return new ResourceGroupResourceExtensionClient(client, resourceGroupResource.Id);
            }
            );
        }

        /// <summary> Gets a collection of DeploymentExtendedResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of DeploymentExtendedResources and their operations over a DeploymentExtendedResource. </returns>
        public static DeploymentExtendedCollection GetDeploymentExtendeds(this ResourceGroupResource resourceGroupResource)
        {
            return GetExtensionClient(resourceGroupResource).GetDeploymentExtendeds();
        }

        /// <summary>
        /// Gets a deployment.
        /// Request Path: /{scope}/providers/Microsoft.Resources/deployments/{deploymentName}
        /// Operation Id: Deployments_GetAtScope
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="deploymentName"> The name of the deployment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deploymentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deploymentName"/> is null. </exception>
        public static async Task<Response<DeploymentExtendedResource>> GetDeploymentExtendedAsync(this ResourceGroupResource resourceGroupResource, string deploymentName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetDeploymentExtendeds().GetAsync(deploymentName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a deployment.
        /// Request Path: /{scope}/providers/Microsoft.Resources/deployments/{deploymentName}
        /// Operation Id: Deployments_GetAtScope
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="deploymentName"> The name of the deployment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deploymentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deploymentName"/> is null. </exception>
        public static Response<DeploymentExtendedResource> GetDeploymentExtended(this ResourceGroupResource resourceGroupResource, string deploymentName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetDeploymentExtendeds().Get(deploymentName, cancellationToken);
        }

        private static ManagementGroupResourceExtensionClient GetExtensionClient(ManagementGroupResource managementGroupResource)
        {
            return managementGroupResource.GetCachedClient((client) =>
            {
                return new ManagementGroupResourceExtensionClient(client, managementGroupResource.Id);
            }
            );
        }

        /// <summary> Gets a collection of DeploymentExtendedResources in the ManagementGroupResource. </summary>
        /// <param name="managementGroupResource"> The <see cref="ManagementGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of DeploymentExtendedResources and their operations over a DeploymentExtendedResource. </returns>
        public static DeploymentExtendedCollection GetDeploymentExtendeds(this ManagementGroupResource managementGroupResource)
        {
            return GetExtensionClient(managementGroupResource).GetDeploymentExtendeds();
        }

        /// <summary>
        /// Gets a deployment.
        /// Request Path: /{scope}/providers/Microsoft.Resources/deployments/{deploymentName}
        /// Operation Id: Deployments_GetAtScope
        /// </summary>
        /// <param name="managementGroupResource"> The <see cref="ManagementGroupResource" /> instance the method will execute against. </param>
        /// <param name="deploymentName"> The name of the deployment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deploymentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deploymentName"/> is null. </exception>
        public static async Task<Response<DeploymentExtendedResource>> GetDeploymentExtendedAsync(this ManagementGroupResource managementGroupResource, string deploymentName, CancellationToken cancellationToken = default)
        {
            return await managementGroupResource.GetDeploymentExtendeds().GetAsync(deploymentName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a deployment.
        /// Request Path: /{scope}/providers/Microsoft.Resources/deployments/{deploymentName}
        /// Operation Id: Deployments_GetAtScope
        /// </summary>
        /// <param name="managementGroupResource"> The <see cref="ManagementGroupResource" /> instance the method will execute against. </param>
        /// <param name="deploymentName"> The name of the deployment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deploymentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deploymentName"/> is null. </exception>
        public static Response<DeploymentExtendedResource> GetDeploymentExtended(this ManagementGroupResource managementGroupResource, string deploymentName, CancellationToken cancellationToken = default)
        {
            return managementGroupResource.GetDeploymentExtendeds().Get(deploymentName, cancellationToken);
        }

        private static ArmResourceExtensionClient GetExtensionClient(ArmResource armResource)
        {
            return armResource.GetCachedClient((client) =>
            {
                return new ArmResourceExtensionClient(client, armResource.Id);
            }
            );
        }

        /// <summary> Gets a collection of FakePolicyAssignmentResources in the ArmResource. </summary>
        /// <param name="armResource"> The <see cref="ArmResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of FakePolicyAssignmentResources and their operations over a FakePolicyAssignmentResource. </returns>
        public static FakePolicyAssignmentCollection GetFakePolicyAssignments(this ArmResource armResource)
        {
            return GetExtensionClient(armResource).GetFakePolicyAssignments();
        }

        /// <summary>
        /// This operation retrieves a single policy assignment, given its name and the scope it was created at.
        /// Request Path: /{scope}/providers/Microsoft.Authorization/policyAssignments/{policyAssignmentName}
        /// Operation Id: FakePolicyAssignments_Get
        /// </summary>
        /// <param name="armResource"> The <see cref="ArmResource" /> instance the method will execute against. </param>
        /// <param name="policyAssignmentName"> The name of the policy assignment to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyAssignmentName"/> is null. </exception>
        public static async Task<Response<FakePolicyAssignmentResource>> GetFakePolicyAssignmentAsync(this ArmResource armResource, string policyAssignmentName, CancellationToken cancellationToken = default)
        {
            return await armResource.GetFakePolicyAssignments().GetAsync(policyAssignmentName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// This operation retrieves a single policy assignment, given its name and the scope it was created at.
        /// Request Path: /{scope}/providers/Microsoft.Authorization/policyAssignments/{policyAssignmentName}
        /// Operation Id: FakePolicyAssignments_Get
        /// </summary>
        /// <param name="armResource"> The <see cref="ArmResource" /> instance the method will execute against. </param>
        /// <param name="policyAssignmentName"> The name of the policy assignment to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyAssignmentName"/> is null. </exception>
        public static Response<FakePolicyAssignmentResource> GetFakePolicyAssignment(this ArmResource armResource, string policyAssignmentName, CancellationToken cancellationToken = default)
        {
            return armResource.GetFakePolicyAssignments().Get(policyAssignmentName, cancellationToken);
        }

        #region FakePolicyAssignmentResource
        /// <summary>
        /// Gets an object representing a <see cref="FakePolicyAssignmentResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="FakePolicyAssignmentResource.CreateResourceIdentifier" /> to create a <see cref="FakePolicyAssignmentResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="FakePolicyAssignmentResource" /> object. </returns>
        public static FakePolicyAssignmentResource GetFakePolicyAssignmentResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                FakePolicyAssignmentResource.ValidateResourceId(id);
                return new FakePolicyAssignmentResource(client, id);
            }
            );
        }
        #endregion

        #region DeploymentExtendedResource
        /// <summary>
        /// Gets an object representing a <see cref="DeploymentExtendedResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DeploymentExtendedResource.CreateResourceIdentifier" /> to create a <see cref="DeploymentExtendedResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DeploymentExtendedResource" /> object. </returns>
        public static DeploymentExtendedResource GetDeploymentExtendedResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                DeploymentExtendedResource.ValidateResourceId(id);
                return new DeploymentExtendedResource(client, id);
            }
            );
        }
        #endregion

        #region ResourceLinkResource
        /// <summary>
        /// Gets an object representing a <see cref="ResourceLinkResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ResourceLinkResource.CreateResourceIdentifier" /> to create a <see cref="ResourceLinkResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ResourceLinkResource" /> object. </returns>
        public static ResourceLinkResource GetResourceLinkResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                ResourceLinkResource.ValidateResourceId(id);
                return new ResourceLinkResource(client, id);
            }
            );
        }
        #endregion
    }
}
