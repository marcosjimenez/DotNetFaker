# DotNetFaker [![Version-shield]](https://raw.githubusercontent.com/marcosjimenez/DotNetFaker/master/CHANGELOG.md)
DotNetFaker helps on creating fake values for your c# classes.

It is based on attributes, decorate your class with the attributes and launch the generator.

## Usage

### Models

Your models must contains the **Fake** and/or **CustomFake** attributes. Generators will use this information to generate fake data.

```c#
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
```

### Generating data

To make a fake data generator for this model class, create a **Faker** instance. Initially, the faker will obtain the generation rules from the class attributes.

```c#
Faker personFaker = new Faker();
```

If you need a custom data for any property, the **CustomFake** attribute must be used:

```c#
personFaker.AddGenerator(new IPGenerator(), "IPGenerator");
```

### Extending data generation

Some fake data types can be extended, like **PersonName**, **CompanyName**, etc. You can add data to the base arrays with the **AddList** method.

```c#
List<string> names = new List<string>();
names.Add("Pepito Perez");
names.Add("Fulanito Antunez");
names.Add("Sutanito Gutierrez");
names.Add("Shurmano Gomez");
names.Add("Suprimo de los Vientos");

personFaker.AddList<string>(names, DotNetFaker.Core.StringLists.PersonName);
```

For complex types, you can inherit from **BaseGenerator**:

```c#
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
```

### Generating data

Use ```GetFake<T>``` for a single instance, and ```GetFake<T>(int count)``` for a ```List<T>```

```c#
Person person = personFaker.GetFake<Person>();
	
List<Person> persons = personFaker.GetFake<Person>(10);
```

