namespace DotNetFaker.Core
{
    using System;

    /// <summary>
    /// Base class to implement generators
    /// </summary>
    /// <typeparam name="T">Class to generate</typeparam>
    public abstract class BaseGenerator<T> : IFakeGenerator
    {
        /// <summary>
        /// Instance of random class, used to generate data
        /// </summary>
        public Random Random { get; set; }

        /// <summary>
        /// Generates a new random <typeparamref name="T"/> value
        /// </summary>
        /// <typeparam name="T">The element type to generate</typeparam>
        /// <returns>A random <typeparamref name="T"/> value</returns>
        public abstract T GetRandomValue();

        /// <summary>
        /// Defines a Maximum value for the generated data
        /// </summary>
        public object Maximum { get; set; }

        /// <summary>
        /// Defines a Minimum value for the generated data
        /// </summary>
        public object Minimum { get; set; }

        object IFakeGenerator.GetRandomValue()
        {
            return this.GetRandomValue();
        }
    }
}
