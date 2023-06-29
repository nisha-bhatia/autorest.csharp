// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace ModelsTypeSpec.Models
{
    /// <summary> Derived model. </summary>
    public partial class RoundTripOnNoUse : NoUseBase
    {
        /// <summary> Initializes a new instance of RoundTripOnNoUse. </summary>
        /// <param name="baseModelProp"> base model property. </param>
        /// <param name="requiredCollection"> Required collection. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="baseModelProp"/> or <paramref name="requiredCollection"/> is null. </exception>
        public RoundTripOnNoUse(string baseModelProp, IEnumerable<CollectionItem> requiredCollection) : base(baseModelProp)
        {
            Argument.AssertNotNull(baseModelProp, nameof(baseModelProp));
            Argument.AssertNotNull(requiredCollection, nameof(requiredCollection));

            RequiredCollection = requiredCollection.ToList();
        }

        /// <summary> Initializes a new instance of RoundTripOnNoUse. </summary>
        /// <param name="baseModelProp"> base model property. </param>
        /// <param name="requiredCollection"> Required collection. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="baseModelProp"/> is null. </exception>
        internal RoundTripOnNoUse(string baseModelProp, IList<CollectionItem> requiredCollection) : base(baseModelProp)
        {
            Argument.AssertNotNull(baseModelProp, nameof(baseModelProp));

            RequiredCollection = requiredCollection;
        }

        /// <summary> Required collection. </summary>
        public IList<CollectionItem> RequiredCollection { get; }
    }
}