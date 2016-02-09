using System;

namespace SampleCode
{
    public class AutoPropertySamples
    {
        public Person GetPersonWithEmptyId()
        {
            var person = new Person
            {
                FirstName = "Joe",
                LastName = "Reynolds"
            };
            if (person.PersonId == Guid.Empty)
                throw new ArgumentException($"{nameof(person.PersonId)} was empty");
            return person;
        }
        public Person GetPersonWithRuntimeInit()
        {
            var person = new Person
            {
                FirstName = "Joe",
                LastName = "Reynolds",
                PersonId = Guid.NewGuid()
            };
            if (person.PersonId == Guid.Empty)
                throw new ArgumentException($"{nameof(person.PersonId)} was empty");
            return person;
        }
        public PersonWithPersonIdFromConstructor GetPersonWithPersonIdFromConstructor()
        {
            var person = new PersonWithPersonIdFromConstructor
            {
                FirstName = "Joe",
                LastName = "Reynolds"
            };
            if (person.PersonId == Guid.Empty)
                throw new ArgumentException($"{nameof(person.PersonId)} was empty");
            return person;
        }
        public PersonWithAutoPropInitializer GetPersonWithAutoPropInitializer()
        {
            var person = new PersonWithAutoPropInitializer
            {
                FirstName = "Joe",
                LastName = "Reynolds"
            };
            if (person.PersonId == Guid.Empty)
                throw new ArgumentException($"{nameof(person.PersonId)} was empty");
            return person;
        }
    }
    public class Person
    {
        public Guid PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    public class PersonWithPersonIdFromConstructor
    {
        public PersonWithPersonIdFromConstructor()
        {
            PersonId = Guid.NewGuid();
        }
        public Guid PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    public class PersonWithAutoPropInitializer
    {
        public Guid PersonId { get; } = Guid.NewGuid();
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class CustomerImmutabilitySample
    {
        public string Name { get; }

        public CustomerImmutabilitySample(string first, string last)
        {
            Name = first + " " + last;
        }
    }
}