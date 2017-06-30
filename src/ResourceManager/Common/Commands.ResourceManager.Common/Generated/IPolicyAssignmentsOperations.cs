// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Internal.Resources
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure.OData;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// PolicyAssignmentsOperations operations.
    /// </summary>
    public partial interface IPolicyAssignmentsOperations
    {
        /// <summary>
        /// Deletes a policy assignment.
        /// </summary>
        /// <param name='scope'>
        /// The scope of the policy assignment.
        /// </param>
        /// <param name='policyAssignmentName'>
        /// The name of the policy assignment to delete.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<PolicyAssignment>> DeleteWithHttpMessagesAsync(string scope, string policyAssignmentName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates a policy assignment.
        /// </summary>
        /// Policy assignments are inherited by child resources. For example,
        /// when you apply a policy to a resource group that policy is
        /// assigned to all resources in the group.
        /// <param name='scope'>
        /// The scope of the policy assignment.
        /// </param>
        /// <param name='policyAssignmentName'>
        /// The name of the policy assignment.
        /// </param>
        /// <param name='parameters'>
        /// Parameters for the policy assignment.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<PolicyAssignment>> CreateWithHttpMessagesAsync(string scope, string policyAssignmentName, PolicyAssignment parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets a policy assignment.
        /// </summary>
        /// <param name='scope'>
        /// The scope of the policy assignment.
        /// </param>
        /// <param name='policyAssignmentName'>
        /// The name of the policy assignment to get.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<PolicyAssignment>> GetWithHttpMessagesAsync(string scope, string policyAssignmentName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets policy assignments for the resource group.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains policy assignments.
        /// </param>
        /// <param name='filter'>
        /// The filter to apply on the operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<PolicyAssignment>>> ListForResourceGroupWithHttpMessagesAsync(string resourceGroupName, string filter = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets policy assignments for a resource.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group containing the resource. The name
        /// is case insensitive.
        /// </param>
        /// <param name='resourceProviderNamespace'>
        /// The namespace of the resource provider.
        /// </param>
        /// <param name='parentResourcePath'>
        /// The parent resource path.
        /// </param>
        /// <param name='resourceType'>
        /// The resource type.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the resource with policy assignments.
        /// </param>
        /// <param name='odataQuery'>
        /// OData parameters to apply to the operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<PolicyAssignment>>> ListForResourceWithHttpMessagesAsync(string resourceGroupName, string resourceProviderNamespace, string parentResourcePath, string resourceType, string resourceName, ODataQuery<PolicyAssignment> odataQuery = default(ODataQuery<PolicyAssignment>), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets all the policy assignments for a subscription.
        /// </summary>
        /// <param name='odataQuery'>
        /// OData parameters to apply to the operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<PolicyAssignment>>> ListWithHttpMessagesAsync(ODataQuery<PolicyAssignment> odataQuery = default(ODataQuery<PolicyAssignment>), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes a policy assignment by ID.
        /// </summary>
        /// When providing a scope for the assigment, use
        /// '/subscriptions/{subscription-id}/' for subscriptions,
        /// '/subscriptions/{subscription-id}/resourceGroups/{resource-group-name}'
        /// for resource groups, and
        /// '/subscriptions/{subscription-id}/resourceGroups/{resource-group-name}/providers/{resource-provider-namespace}/{resource-type}/{resource-name}'
        /// for resources.
        /// <param name='policyAssignmentId'>
        /// The ID of the policy assignment to delete. Use the format
        /// '/{scope}/providers/Microsoft.Authorization/policyAssignments/{policy-assignment-name}'.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<PolicyAssignment>> DeleteByIdWithHttpMessagesAsync(string policyAssignmentId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates a policy assignment by ID.
        /// </summary>
        /// Policy assignments are inherited by child resources. For example,
        /// when you apply a policy to a resource group that policy is
        /// assigned to all resources in the group. When providing a scope
        /// for the assigment, use '/subscriptions/{subscription-id}/' for
        /// subscriptions,
        /// '/subscriptions/{subscription-id}/resourceGroups/{resource-group-name}'
        /// for resource groups, and
        /// '/subscriptions/{subscription-id}/resourceGroups/{resource-group-name}/providers/{resource-provider-namespace}/{resource-type}/{resource-name}'
        /// for resources.
        /// <param name='policyAssignmentId'>
        /// The ID of the policy assignment to create. Use the format
        /// '/{scope}/providers/Microsoft.Authorization/policyAssignments/{policy-assignment-name}'.
        /// </param>
        /// <param name='parameters'>
        /// Parameters for policy assignment.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<PolicyAssignment>> CreateByIdWithHttpMessagesAsync(string policyAssignmentId, PolicyAssignment parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets a policy assignment by ID.
        /// </summary>
        /// When providing a scope for the assigment, use
        /// '/subscriptions/{subscription-id}/' for subscriptions,
        /// '/subscriptions/{subscription-id}/resourceGroups/{resource-group-name}'
        /// for resource groups, and
        /// '/subscriptions/{subscription-id}/resourceGroups/{resource-group-name}/providers/{resource-provider-namespace}/{resource-type}/{resource-name}'
        /// for resources.
        /// <param name='policyAssignmentId'>
        /// The ID of the policy assignment to get. Use the format
        /// '/{scope}/providers/Microsoft.Authorization/policyAssignments/{policy-assignment-name}'.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<PolicyAssignment>> GetByIdWithHttpMessagesAsync(string policyAssignmentId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets policy assignments for the resource group.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<PolicyAssignment>>> ListForResourceGroupNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets policy assignments for a resource.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<PolicyAssignment>>> ListForResourceNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets all the policy assignments for a subscription.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<PolicyAssignment>>> ListNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}