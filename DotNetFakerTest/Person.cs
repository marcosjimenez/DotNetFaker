namespace DotNetFakerTest
{
    using System;
    using DotNetFaker.Core;
    using DotNetFaker.Core.Common;

    public class Person
    {
        [Fake(GeneratorType.Guid)]
        public string ID { get; set; }

        [Fake(GeneratorType.PersonName)]
        public string Name { get; set; }

        [Fake(GeneratorType.Address)]
        public string Address { get; set; }

        [Fake(GeneratorType.CompanyName)]
        public string Company { get; set; }

        [Fake(GeneratorType.DateTime)]
        public DateTime BornDate { get; set; }

        [CustomFake("IPGenerator")]
        public string IP { get; set; }

        [Fake(GeneratorType.String, 1, 255)]
        public string RandomString { get; set; }

    }
}
