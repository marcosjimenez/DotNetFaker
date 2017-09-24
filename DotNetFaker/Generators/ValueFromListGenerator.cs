namespace DotNetFaker.Generators
{
    using System.Linq;
    using System.Collections.Generic;
    using DotNetFaker.Core;

    /// <summary>
    /// Generates a random string from a list
    /// </summary>
    public class ValueFromListGenerator<T> : BaseGenerator<T>
    {

        public List<T> Values { get; private set; }

        public ValueFromListGenerator(T[] list)
        {
            Values = list.ToList();
        }

        public override T GetRandomValue()
        {
            return Values[base.Random.Next(Values.Count - 1)];
        }

        public void AddRange(IList<T> list)
        {
            Values.AddRange(list);
        }

        public void AddValue(T value)
        {
            Values.Add(value);
        }

    }
}
