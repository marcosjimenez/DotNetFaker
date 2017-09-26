// Copyright (c) Marcos Jiménez, All rights reserved.
// Licensed under the MIT License
// Author:                  Marcos Jiménez
// Created:                 2017-03-13
// Last Modified:           2017-09-25

namespace DotNetFaker.Core
{
    using DotNetFaker.Core.Common;
    using System;

    /// <summary>
    /// Defines a fake value generation for properties
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class FakeAttribute : Attribute, IFakeAttribute
    {
        public GeneratorType Type { get; set; }

        public string Name { get; set; }

        public object Maximum { get; set; }
        public object Minimum { get; set; }

        public FakeAttribute(GeneratorType pType, object pMinimum = null, object pMaximum = null)
        {
            Type = pType;
            Minimum = pMinimum;
            Maximum = pMaximum;
        }
    }
}
