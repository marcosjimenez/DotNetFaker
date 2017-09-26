// Copyright (c) Marcos Jiménez, All rights reserved.
// Licensed under the MIT License
// Author:                  Marcos Jiménez
// Created:                 2017-03-13
// Last Modified:           2017-09-25

namespace DotNetFaker.Generators
{
    using DotNetFaker.Common;

    /// <summary>
    /// Generates a random string from the Address list
    /// </summary>
    public class AddressGenerator : ValueFromListGenerator<string>
    {
        public AddressGenerator() : base(Constants.Addresses)
        {
        }
    }
}
