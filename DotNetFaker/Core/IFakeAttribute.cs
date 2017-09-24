﻿namespace DotNetFaker.Core
{
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