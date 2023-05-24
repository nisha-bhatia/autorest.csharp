// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace MgmtCustomizations.Models
{
    /// <summary> A cat. </summary>
    public partial class Cat : Pet
    {
        /// <summary> Initializes a new instance of Cat. </summary>
        public Cat()
        {
            Kind = PetKind.Cat;
        }

        /// <summary> Initializes a new instance of Cat. </summary>
        /// <param name="kind"> The kind of the pet. </param>
        /// <param name="name"> The name of the pet. </param>
        /// <param name="meow"> A cat can meow. </param>
        internal Cat(PetKind kind, string name, string meow) : base(kind, name)
        {
            Meow = meow;
            Kind = kind;
        }
    }
}