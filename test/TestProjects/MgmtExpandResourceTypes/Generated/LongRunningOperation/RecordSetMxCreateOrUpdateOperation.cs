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
using MgmtExpandResourceTypes;

namespace MgmtExpandResourceTypes.Models
{
    /// <summary> Creates or updates a record set within a DNS zone. </summary>
    public partial class RecordSetMxCreateOrUpdateOperation : Operation<RecordSetMx>
    {
        private readonly OperationOrResponseInternals<RecordSetMx> _operation;

        /// <summary> Initializes a new instance of RecordSetMxCreateOrUpdateOperation for mocking. </summary>
        protected RecordSetMxCreateOrUpdateOperation()
        {
        }

        internal RecordSetMxCreateOrUpdateOperation(ArmClient armClient, Response<RecordSetData> response)
        {
            _operation = new OperationOrResponseInternals<RecordSetMx>(Response.FromValue(new RecordSetMx(armClient, response.Value), response.GetRawResponse()));
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override RecordSetMx Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<RecordSetMx>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<RecordSetMx>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);
    }
}