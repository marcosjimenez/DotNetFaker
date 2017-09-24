namespace DotNetFaker.Generators
{
    using System;
    using DotNetFaker.Core;

    /// <summary>
    /// Generates a random GUID
    /// </summary>
    public class GuidGenerator : BaseGenerator<string>
    {
        public override string GetRandomValue()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
