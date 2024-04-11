// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace FirstTestTypeSpec
{
    // Data plane generated sub-client.
    /// <summary> Hello world service. </summary>
    public partial class HelloDemo
    {
        private const string AuthorizationHeader = "x-ms-api-key";
        private readonly AzureKeyCredential _credential;
        private static readonly string[] AuthorizationScopes = new string[] { "https://api.example.com/.default" };
        private readonly TokenCredential _tokenCredential;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of HelloDemo for mocking. </summary>
        protected HelloDemo()
        {
        }

        /// <summary> Initializes a new instance of HelloDemo. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="credential"> The key credential to copy. </param>
        /// <param name="tokenCredential"> The token credential to copy. </param>
        /// <param name="endpoint"> The <see cref="Uri"/> to use. </param>
        internal HelloDemo(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, AzureKeyCredential credential, TokenCredential tokenCredential, Uri endpoint)
        {
            ClientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            _credential = credential;
            _tokenCredential = tokenCredential;
            _endpoint = endpoint;
        }

        /// <summary>
        /// [Protocol Method] Return hi
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="headParameter"> The <see cref="string"/> to use. </param>
        /// <param name="queryParameter"> The <see cref="string"/> to use. </param>
        /// <param name="optionalQuery"> The <see cref="string"/> to use. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="headParameter"/> or <paramref name="queryParameter"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/HelloDemo.xml" path="doc/members/member[@name='SayHiAsync(string,string,string,RequestContext)']/*" />
        public virtual async Task<Response> SayHiAsync(string headParameter, string queryParameter, string optionalQuery, RequestContext context)
        {
            Argument.AssertNotNull(headParameter, nameof(headParameter));
            Argument.AssertNotNull(queryParameter, nameof(queryParameter));

            using var scope = ClientDiagnostics.CreateScope("HelloDemo.SayHi");
            scope.Start();
            try
            {
                using HttpMessage message = CreateSayHiRequest(headParameter, queryParameter, optionalQuery, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Return hi
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="headParameter"> The <see cref="string"/> to use. </param>
        /// <param name="queryParameter"> The <see cref="string"/> to use. </param>
        /// <param name="optionalQuery"> The <see cref="string"/> to use. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="headParameter"/> or <paramref name="queryParameter"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/HelloDemo.xml" path="doc/members/member[@name='SayHi(string,string,string,RequestContext)']/*" />
        public virtual Response SayHi(string headParameter, string queryParameter, string optionalQuery, RequestContext context)
        {
            Argument.AssertNotNull(headParameter, nameof(headParameter));
            Argument.AssertNotNull(queryParameter, nameof(queryParameter));

            using var scope = ClientDiagnostics.CreateScope("HelloDemo.SayHi");
            scope.Start();
            try
            {
                using HttpMessage message = CreateSayHiRequest(headParameter, queryParameter, optionalQuery, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateSayHiRequest(string headParameter, string queryParameter, string optionalQuery, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/hello", false);
            uri.AppendQuery("queryParameter", queryParameter, true);
            if (optionalQuery != null)
            {
                uri.AppendQuery("optionalQuery", optionalQuery, true);
            }
            request.Uri = uri;
            request.Headers.Add("head-parameter", headParameter);
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        private static ResponseClassifier _responseClassifier200;
        private static ResponseClassifier ResponseClassifier200 => _responseClassifier200 ??= new StatusCodeClassifier(stackalloc ushort[] { 200 });
    }
}
