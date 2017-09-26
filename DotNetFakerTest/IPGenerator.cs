// Copyright (c) Marcos Jiménez, All rights reserved.
// Licensed under the MIT License
// Author:                  Marcos Jiménez
// Created:                 2017-03-13
// Last Modified:           2017-09-25

namespace DotNetFakerTest
{
    using DotNetFaker.Core;

    public class IPGenerator : BaseGenerator<string>
    {
        public override string GetRandomValue()
        {
            return string.Format("{0}.{1}.{2}.{3}",
                base.Random.Next(0, 255),
                base.Random.Next(0, 255),
                base.Random.Next(0, 255),
                base.Random.Next(0, 255));
        }
    }
}
