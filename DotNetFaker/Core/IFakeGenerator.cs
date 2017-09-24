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
