// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Accessibility_LowLevel_TokenAuth;
using Azure.Core;
using Azure.Core.TestFramework;

namespace Accessibility_LowLevel_TokenAuth.Tests
{
    public partial class Accessibility_LowLevel_TokenAuthTestBase : RecordedTestBase<Accessibility_LowLevel_TokenAuthTestEnvironment>
    {
        public Accessibility_LowLevel_TokenAuthTestBase(bool isAsync) : base(isAsync)
        {
        }

        protected AccessibilityClient CreateAccessibilityClient(Uri endpoint, TokenCredential credential)
        {
            AccessibilityClientOptions options = InstrumentClientOptions(new AccessibilityClientOptions());
            AccessibilityClient client = new AccessibilityClient(endpoint, credential, options);
            return InstrumentClient(client);
        }
    }
}