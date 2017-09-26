// Copyright (c) Marcos Jiménez, All rights reserved.
// Licensed under the MIT License
// Author:                  Marcos Jiménez
// Created:                 2017-03-13
// Last Modified:           2017-09-25

namespace DotNetFaker.Core
{
    using System;
    using DotNetFaker.Core.Common;

    /// <summary>
    /// Defines a custom generator type
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class CustomFakeAttribute : FakeAttribute
    {
        public CustomFakeAttribute(string pName, object pMinimum = null, object pMaximum = null)
            : base(GeneratorType.Custom, pMinimum, pMaximum)
        {
            this.Name = pName;
        }
    }
}
