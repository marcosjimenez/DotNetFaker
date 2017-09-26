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
    /// Generates a new incremental integer value
    /// </summary>
    public class IntAutoIncrementGenerator : BaseGenerator<int>
    {
        private int _increment = 0;
        public int Value
        {
            get { return _increment; }
            set { _increment = value; }
        }

        public override int GetRandomValue()
        {
            _increment++;
            return _increment;
        }
    }
}
