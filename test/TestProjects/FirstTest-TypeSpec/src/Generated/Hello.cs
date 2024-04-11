// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace FirstTestTypeSpec
{
    // Data plane generated sub-client.
    /// <summary> The Hello sub-client. </summary>
    public partial class Hello
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

        /// <summary> Initializes a new instance of Hello for mocking. </summary>
        protected Hello()
        {
        }

        /// <summary> Initializes a new instance of Hello. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="credential"> The key credential to copy. </param>
        /// <param name="tokenCredential"> The token credential to copy. </param>
        /// <param name="endpoint"> The <see cref="Uri"/> to use. </param>
        internal Hello(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, AzureKeyCredential credential, TokenCredential tokenCredential, Uri endpoint)
        {
            ClientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            _credential = credential;
            _tokenCredential = tokenCredential;
            _endpoint = endpoint;
        }

        private HelloDemo _cachedHelloDemo;
        private HelloDemo2 _cachedHelloDemo2;

        /// <summary> Initializes a new instance of HelloDemo. </summary>
        public virtual HelloDemo GetHelloDemoClient()
        {
            return Volatile.Read(ref _cachedHelloDemo) ?? Interlocked.CompareExchange(ref _cachedHelloDemo, new HelloDemo(ClientDiagnostics, _pipeline, _credential, _tokenCredential, _endpoint), null) ?? _cachedHelloDemo;
        }

        /// <summary> Initializes a new instance of HelloDemo2. </summary>
        public virtual HelloDemo2 GetHelloDemo2Client()
        {
            return Volatile.Read(ref _cachedHelloDemo2) ?? Interlocked.CompareExchange(ref _cachedHelloDemo2, new HelloDemo2(ClientDiagnostics, _pipeline, _credential, _tokenCredential, _endpoint), null) ?? _cachedHelloDemo2;
        }
    }
}
