namespace DotNetFaker.Generators
{
    using System;
    using DotNetFaker.Core;

    /// <summary>
    /// Generates a random DateTime value
    /// </summary>
    public class DateTimeGenerator : BaseGenerator<DateTime>
    {
        public override DateTime GetRandomValue()
        {
            DateTime randomDate = new DateTime(2010, 1, 1);
            int range = (DateTime.Today - randomDate).Days;
            return randomDate.AddDays(base.Random.Next(range));
        }
    }
}
