// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using ProjectedName.Models;

namespace ProjectedName
{
    // Data plane generated client.
    /// <summary> Projection. </summary>
    public partial class ProjectedNameClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of ProjectedNameClient. </summary>
        public ProjectedNameClient() : this(new Uri("http://localhost:3000"), new ProjectedNameClientOptions())
        {
        }

        /// <summary> Initializes a new instance of ProjectedNameClient. </summary>
        /// <param name="endpoint"> TestServer endpoint. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> is null. </exception>
        public ProjectedNameClient(Uri endpoint, ProjectedNameClientOptions options)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            options ??= new ProjectedNameClientOptions();

            ClientDiagnostics = new ClientDiagnostics(options, true);
            _pipeline = HttpPipelineBuilder.Build(options, Array.Empty<HttpPipelinePolicy>(), Array.Empty<HttpPipelinePolicy>(), new ResponseClassifier());
            _endpoint = endpoint;
            _apiVersion = options.Version;
        }

        /// <param name="project"> The Project to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="project"/> is null. </exception>
        public virtual async Task<Response> JsonProjectionAsync(Project project, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(project, nameof(project));

            RequestContext context = FromCancellationToken(cancellationToken);
            Response response = await JsonProjectionAsync(project.ToRequestContent(), context).ConfigureAwait(false);
            return response;
        }

        /// <param name="project"> The Project to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="project"/> is null. </exception>
        public virtual Response JsonProjection(Project project, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(project, nameof(project));

            RequestContext context = FromCancellationToken(cancellationToken);
            Response response = JsonProjection(project.ToRequestContent(), context);
            return response;
        }

        /// <param name="content"> The content to send as the body of the request. Details of the request body schema are in the Remarks section below. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/ProjectedNameClient.xml" path="doc/members/member[@name='JsonProjectionAsync(RequestContent,RequestContext)']/*" />
        public virtual async Task<Response> JsonProjectionAsync(RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("ProjectedNameClient.JsonProjection");
            scope.Start();
            try
            {
                using HttpMessage message = CreateJsonProjectionRequest(content, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="content"> The content to send as the body of the request. Details of the request body schema are in the Remarks section below. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/ProjectedNameClient.xml" path="doc/members/member[@name='JsonProjection(RequestContent,RequestContext)']/*" />
        public virtual Response JsonProjection(RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("ProjectedNameClient.JsonProjection");
            scope.Start();
            try
            {
                using HttpMessage message = CreateJsonProjectionRequest(content, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="project"> The Project to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="project"/> is null. </exception>
        public virtual async Task<Response> ClientProjectionAsync(Project project, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(project, nameof(project));

            RequestContext context = FromCancellationToken(cancellationToken);
            Response response = await ClientProjectionAsync(project.ToRequestContent(), context).ConfigureAwait(false);
            return response;
        }

        /// <param name="project"> The Project to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="project"/> is null. </exception>
        public virtual Response ClientProjection(Project project, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(project, nameof(project));

            RequestContext context = FromCancellationToken(cancellationToken);
            Response response = ClientProjection(project.ToRequestContent(), context);
            return response;
        }

        /// <param name="content"> The content to send as the body of the request. Details of the request body schema are in the Remarks section below. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/ProjectedNameClient.xml" path="doc/members/member[@name='ClientProjectionAsync(RequestContent,RequestContext)']/*" />
        public virtual async Task<Response> ClientProjectionAsync(RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("ProjectedNameClient.ClientProjection");
            scope.Start();
            try
            {
                using HttpMessage message = CreateClientProjectionRequest(content, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="content"> The content to send as the body of the request. Details of the request body schema are in the Remarks section below. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/ProjectedNameClient.xml" path="doc/members/member[@name='ClientProjection(RequestContent,RequestContext)']/*" />
        public virtual Response ClientProjection(RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("ProjectedNameClient.ClientProjection");
            scope.Start();
            try
            {
                using HttpMessage message = CreateClientProjectionRequest(content, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="project"> The Project to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="project"/> is null. </exception>
        public virtual async Task<Response> LanguageProjectionAsync(Project project, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(project, nameof(project));

            RequestContext context = FromCancellationToken(cancellationToken);
            Response response = await LanguageProjectionAsync(project.ToRequestContent(), context).ConfigureAwait(false);
            return response;
        }

        /// <param name="project"> The Project to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="project"/> is null. </exception>
        public virtual Response LanguageProjection(Project project, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(project, nameof(project));

            RequestContext context = FromCancellationToken(cancellationToken);
            Response response = LanguageProjection(project.ToRequestContent(), context);
            return response;
        }

        /// <param name="content"> The content to send as the body of the request. Details of the request body schema are in the Remarks section below. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/ProjectedNameClient.xml" path="doc/members/member[@name='LanguageProjectionAsync(RequestContent,RequestContext)']/*" />
        public virtual async Task<Response> LanguageProjectionAsync(RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("ProjectedNameClient.LanguageProjection");
            scope.Start();
            try
            {
                using HttpMessage message = CreateLanguageProjectionRequest(content, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="content"> The content to send as the body of the request. Details of the request body schema are in the Remarks section below. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/ProjectedNameClient.xml" path="doc/members/member[@name='LanguageProjection(RequestContent,RequestContext)']/*" />
        public virtual Response LanguageProjection(RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("ProjectedNameClient.LanguageProjection");
            scope.Start();
            try
            {
                using HttpMessage message = CreateLanguageProjectionRequest(content, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateJsonProjectionRequest(RequestContent content, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier204);
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/projection/json", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            return message;
        }

        internal HttpMessage CreateClientProjectionRequest(RequestContent content, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier204);
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/projection/client", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            return message;
        }

        internal HttpMessage CreateLanguageProjectionRequest(RequestContent content, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier204);
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/projection/language", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            return message;
        }

        private static RequestContext DefaultRequestContext = new RequestContext();
        internal static RequestContext FromCancellationToken(CancellationToken cancellationToken = default)
        {
            if (!cancellationToken.CanBeCanceled)
            {
                return DefaultRequestContext;
            }

            return new RequestContext() { CancellationToken = cancellationToken };
        }

        private static ResponseClassifier _responseClassifier204;
        private static ResponseClassifier ResponseClassifier204 => _responseClassifier204 ??= new StatusCodeClassifier(stackalloc ushort[] { 204 });
    }
}