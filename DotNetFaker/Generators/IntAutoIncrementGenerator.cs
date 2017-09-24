namespace DotNetFaker.Generators
{
    using DotNetFaker.Core;

    /// <summary>
    /// Generates a new incremental integer value
    /// </summary>
    public class IntAutoIncrementGenerator : BaseGenerator<int>
    {
        private int _increment = 0;

        public int Value
        {
            get { return _increment; }
            set { _increment = value; }
        }

        public override int GetRandomValue()
        {
            _increment++;
            return _increment;
        }
    }
}
