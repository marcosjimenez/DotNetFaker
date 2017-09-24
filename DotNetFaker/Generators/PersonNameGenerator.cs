namespace DotNetFaker.Generators
{
    using DotNetFaker.Common;

    /// <summary>
    /// Generates a random string from the Person name list
    /// </summary>
    public partial class PersonNameGenerator : ValueFromListGenerator<string>
    {
        public PersonNameGenerator() : base(Constants.PersonNames) {}
    }
}
