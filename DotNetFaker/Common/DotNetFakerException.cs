// Copyright (c) Marcos Jiménez, All rights reserved.
// Licensed under the MIT License
// Author:                  Marcos Jiménez
// Created:                 2017-03-13
// Last Modified:           2017-09-25

namespace DotNetFaker.Common
{
    using System;

    public class DotNetFakerException : Exception
    {
        public DotNetFakerException(string message) : base(message)
        {
        }
    }
}
