using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleCode;

namespace ConsoleHarness
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 0;
            //Console.WriteLine($"See Something called {nameof(i)} {i++}");
            //Console.WriteLine($"See Something called {nameof(i)} {i++}");
            //Console.ReadKey();

            PrintCollections();
            //var foo = new NullConditionalSamples();
            //// Console.WriteLine(foo.UsingNullConditionals(null));

        }

        /// <summary>
        /// Demo the Collection Initializer Examples.
        /// </summary>
        static void PrintCollections()
        {
            try
            {
                var samples = new CollectionInitializerSamples();

                Console.WriteLine("New Way --- ");
                var newSamples = samples.GetNewSampleInputDictionary();
                foreach (var sample in newSamples)
                {
                    Console.WriteLine(sample.Key + ": " + sample.Value);
                }
                Console.ReadKey();

                Console.WriteLine("Old Way --- ");
                var oldSamples = samples.GetOldSampleInputDictionary();
                foreach (var sample in oldSamples)
                {
                    Console.WriteLine(sample.Key + ": " + sample.Value);
                }
                Console.ReadKey();

                Console.WriteLine("Bad New Way --- ");
                var badNewSamples = samples.BadNewSampleInputDictionary();
                foreach (var sample in badNewSamples)
                {
                    Console.WriteLine(sample.Key + ": " + sample.Value);
                }
                Console.ReadKey();

                Console.WriteLine("Bad Old Way --- ");
                var badOldSamples = samples.BadOldSampleInputDictionary();
                foreach (var sample in badOldSamples)
                {
                    Console.WriteLine(sample.Key + ": " + sample.Value);
                }
                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine("Something Broke...");
                Console.ReadKey();
            }
        }

        static void PrintPeope()
        {
            var samples = new AutoPropertySamples();
            try
            {
                var person1 = samples.GetPersonWithEmptyId();
                Console.WriteLine($"New Person ID: {person1.PersonId}");
                Console.WriteLine($"New Name: {person1.FirstName} {person1.LastName}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            try
            {
                var person2 = samples.GetPersonWithRuntimeInit();
                Console.WriteLine($"New Person ID: {person2.PersonId}");
                Console.WriteLine($"New Name: {person2.FirstName} {person2.LastName}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            try
            {
                var person3 = samples.GetPersonWithPersonIdFromConstructor();
                Console.WriteLine($"New Person ID: {person3.PersonId}");
                Console.WriteLine($"New Name: {person3.FirstName} {person3.LastName}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            try
            {
                var person4 = samples.GetPersonWithAutoPropInitializer();
                Console.WriteLine($"New Person ID: {person4.PersonId}");
                Console.WriteLine($"New Name: {person4.FirstName} {person4.LastName}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.ReadKey();
        }

    }
}
