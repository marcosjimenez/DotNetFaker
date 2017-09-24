namespace DotNetFaker.Core
{
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
