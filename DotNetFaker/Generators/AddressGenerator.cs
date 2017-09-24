namespace DotNetFaker.Generators
{
    using DotNetFaker.Common;

    /// <summary>
    /// Generates a random string from the Address list
    /// </summary>
    public class AddressGenerator : ValueFromListGenerator<string>
    {
        public AddressGenerator() : base(Constants.Addresses)
        {
        }
    }
}
