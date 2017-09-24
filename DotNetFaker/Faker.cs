namespace DotNetFaker
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using DotNetFaker.Core;
    using DotNetFaker.Generators;
    using DotNetFaker.Common;
    using DotNetFaker.Core.Common;

    /// <summary>
    /// Generates fake data
    /// </summary>
    public class Faker
    {

        #region Private declarations
        private Dictionary<string, IFakeGenerator> generators;
        private Random random;
        #endregion

        #region Constructors
        public Faker()
        {
            random = new Random((int)DateTime.Now.Ticks);
            generators = new Dictionary<string, IFakeGenerator>();
        }
        #endregion

        #region Generation

        /// <summary>
        /// Adds a custom fake data generator 
        /// </summary>
        /// <param name="customType">Custom generator instance</param>
        /// <param name="name">Unique name</param>
        /// <returns></returns>
        public IFakeGenerator AddGenerator(IFakeGenerator customType, string name)
        {
            if (generators.ContainsKey(name))
                throw new DotNetFakerException(string.Format("Duplicate generator named {0}", name));

            customType.Random = random;
            generators.Add(name, customType);
            return generators[name];
        }

        /// <summary>
        /// Generates a fake list of <typeparamref name="T"/>
        /// </summary>
        /// <typeparam name="T">Type to generate</typeparam>
        /// <param name="count">Number of instances</param>
        public List<T> GetFake<T>(int count)
        {
            List<T> retVal = new List<T>();

            for (int i = 0; i < count; i++)
                retVal.Add(GetFake<T>());

            return retVal;
        }

        /// <summary>
        /// Generates a fake instance of <typeparamref name="T"/>
        /// </summary>
        /// <typeparam name="T">Type to generate</typeparam>
        /// <returns></returns>
        public T GetFake<T>()
        {
            Type type = typeof(T);
            return FillProperties<T>((T)Activator.CreateInstance(type));
        }

        private T FillProperties<T>(T instance)
        {
            PropertyInfo[] props = instance.GetType().GetProperties();

            foreach (PropertyInfo prop in props)
            {
                Attribute[] attributes = Attribute.GetCustomAttributes(prop);
                FakeAttribute fakeAttribute = (FakeAttribute)attributes.Where(
                    x => x.GetType().Equals(typeof(FakeAttribute)) ||
                         x.GetType().Equals(typeof(CustomFakeAttribute))
                    ).FirstOrDefault();

                if (fakeAttribute != null)
                    AddFakeValue(instance, fakeAttribute, prop, fakeAttribute.Minimum, fakeAttribute.Maximum);

            }
            return instance;
        }

        private IFakeGenerator getGenerator(string type)
        {
            if (!generators.ContainsKey(type))
                throw new DotNetFakerException(string.Format("Cannot find generator {0}", type));

            return generators[type];
        }

        private IFakeGenerator getGenerator(GeneratorType type)
        {
            string typeString = type.ToString();

            if (generators.ContainsKey(typeString))
                return generators[typeString];

            Type systemType = Type.GetType(String.Format("{0}.{1}{2}", "DotNetFaker.Generators", typeString, "Generator"));

            IFakeGenerator generator = (IFakeGenerator)Activator.CreateInstance(systemType);

            generator.Random = random;
            generators.Add(typeString, generator);

            return generators[typeString];
        }

        private void AddFakeValue(object instance, IFakeAttribute fakeAttribute, PropertyInfo property, object minimum = null, object maximum = null)
        {
            IFakeGenerator generator;
            if (fakeAttribute is CustomFakeAttribute)
                generator = getGenerator(fakeAttribute.Name);
            else
                generator = getGenerator(fakeAttribute.Type);

            generator.Maximum = maximum;
            generator.Minimum = minimum;
            property.SetValue(instance, generator.GetRandomValue());
        }

        #endregion

        #region String list updates

        /// <summary>
        /// Adds a range of values to the internal list of the specified generator
        /// </summary>
        /// <typeparam name="T">Type of values of the list</typeparam>
        /// <param name="list">Values to add</param>
        /// <param name="listType">The generator to update</param>
        public void AddList<T>(IList<T> list, StringLists listType)
        {
            GeneratorType generatorType = GeneratorType.PersonName;
            switch (listType)
            {
                case StringLists.Address:
                    generatorType = GeneratorType.Address;
                    break;
                case StringLists.CompanyName:
                    generatorType = GeneratorType.CompanyName;
                    break;
                case StringLists.PersonName:
                    generatorType = GeneratorType.PersonName;
                    break;
            }

            ValueFromListGenerator<T> generator = (ValueFromListGenerator<T>)getGenerator(generatorType);
            generator.AddRange(list);

        }

        #endregion

    }
}
