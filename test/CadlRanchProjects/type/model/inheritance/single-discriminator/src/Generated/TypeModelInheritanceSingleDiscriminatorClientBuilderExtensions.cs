// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core.Extensions;
using _Type.Model.Inheritance.SingleDiscriminator;

namespace Microsoft.Extensions.Azure
{
    /// <summary> Extension methods to add <see cref="SingleDiscriminatorClient"/> to client builder. </summary>
    public static partial class TypeModelInheritanceSingleDiscriminatorClientBuilderExtensions
    {
        /// <summary> Registers a <see cref="SingleDiscriminatorClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="endpoint"> TestServer endpoint. </param>
        public static IAzureClientBuilder<SingleDiscriminatorClient, SingleDiscriminatorClientOptions> AddSingleDiscriminatorClient<TBuilder>(this TBuilder builder, Uri endpoint)
        where TBuilder : IAzureClientFactoryBuilder
        {
            return builder.RegisterClientFactory<SingleDiscriminatorClient, SingleDiscriminatorClientOptions>((options) => new SingleDiscriminatorClient(endpoint, options));
        }

        /// <summary> Registers a <see cref="SingleDiscriminatorClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="configuration"> The configuration values. </param>
        public static IAzureClientBuilder<SingleDiscriminatorClient, SingleDiscriminatorClientOptions> AddSingleDiscriminatorClient<TBuilder, TConfiguration>(this TBuilder builder, TConfiguration configuration)
        where TBuilder : IAzureClientFactoryBuilderWithConfiguration<TConfiguration>
        {
            return builder.RegisterClientFactory<SingleDiscriminatorClient, SingleDiscriminatorClientOptions>(configuration);
        }
    }
}