// Copyright (c) Marcos Jiménez, All rights reserved.
// Licensed under the MIT License
// Author:                  Marcos Jiménez
// Created:                 2017-03-13
// Last Modified:           2017-09-25

namespace DotNetFaker.Generators
{
    using System;
    using DotNetFaker.Core;

    /// <summary>
    /// Generates a random GUID
    /// </summary>
    public class GuidGenerator : BaseGenerator<string>
    {
        public override string GetRandomValue()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
