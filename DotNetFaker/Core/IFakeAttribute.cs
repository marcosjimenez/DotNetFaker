// Copyright (c) Marcos Jiménez, All rights reserved.
// Licensed under the MIT License
// Author:                  Marcos Jiménez
// Created:                 2017-03-13
// Last Modified:           2017-09-25

namespace DotNetFaker.Core
{
    using DotNetFaker.Core.Common;

    /// <summary>
    /// Defines a Fake attribute
    /// </summary>
    public interface IFakeAttribute
    {
        GeneratorType Type { get; set; }
        string Name { get; set; }
        object Maximum { get; set; }
        object Minimum { get; set; }
    }
}
