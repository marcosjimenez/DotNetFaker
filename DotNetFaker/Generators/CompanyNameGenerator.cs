namespace DotNetFaker.Generators
{
    using DotNetFaker.Common;

    /// <summary>
    /// Generates a random string from the Company list
    /// </summary>
    public class CompanyNameGenerator : ValueFromListGenerator<string>
    {
        public CompanyNameGenerator() : base(Constants.Companies)
        {
        }
    }
}
