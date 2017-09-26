// Copyright (c) Marcos Jiménez, All rights reserved.
// Licensed under the MIT License
// Author:                  Marcos Jiménez
// Created:                 2017-03-13
// Last Modified:           2017-09-25

namespace DotNetFaker.Core
{
    using System;

    /// <summary>
    /// Interface for Base Generators
    /// </summary>
    public interface IFakeGenerator
    {
        Random Random { get; set; }
        object Maximum { get; set; }
        object Minimum { get; set; }
        object GetRandomValue();
    }
}
