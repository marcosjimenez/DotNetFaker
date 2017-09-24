namespace DotNetFaker.Generators
{
    using System;
    using System.Linq;
    using DotNetFaker.Core;
    using DotNetFaker.Common;

    /// <summary>
    /// Generates a random string 
    /// </summary>
    public class StringGenerator : BaseGenerator<string>
    {

        private const string randomChars = "0123456789!\"·$%&/()=?¿@#¬€`+´,.-;:_¨^*¡'ºª\\abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ ";

        public override string GetRandomValue()
        {

            if (Maximum == null)
                throw new DotNetFakerException("StringGenerator.GetRandomValue: Maximum cannot be null");

            return new String(Enumerable.Repeat(randomChars, (int)Maximum).Select(x => x[base.Random.Next(x.Length)]).ToArray());
        }
    }
}
