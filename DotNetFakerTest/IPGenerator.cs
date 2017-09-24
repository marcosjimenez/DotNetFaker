namespace DotNetFakerTest
{
    using DotNetFaker.Core;

    public class IPGenerator : BaseGenerator<string>
    {
        public override string GetRandomValue()
        {
            return string.Format("{0}.{1}.{2}.{3}",
                base.Random.Next(0, 255),
                base.Random.Next(0, 255),
                base.Random.Next(0, 255),
                base.Random.Next(0, 255));
        }
    }
}
