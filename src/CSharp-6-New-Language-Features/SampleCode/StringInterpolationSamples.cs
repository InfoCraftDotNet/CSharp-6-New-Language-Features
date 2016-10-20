using System;

namespace SampleCode
{
    public class StringInterpolationSamples
    {
        public void StringFormatSample()
        {
            var person = new PersonWithAutoPropInitializer();

            person.FirstName = "Joe";
            person.LastName = "Reynolds";

            var line1 = string.Format("Person ID: {0}", person.PersonId.ToString());
            var line2 = string.Format("Name: {0} {1}", person.FirstName, person.LastName);

            Console.WriteLine(line1);
            Console.WriteLine(line2);
            Console.WriteLine("Did it work?");
        }

        public void StringConcatSample()
        {
            var person = new PersonWithAutoPropInitializer();
            person.FirstName = "Joe";
            person.LastName = "Reynolds";

            var outputStr = "Person ID: " + person.PersonId;
            outputStr += Environment.NewLine;
            outputStr += "Name: " + person.FirstName + " " + person.LastName;

            Console.WriteLine(outputStr);
        }

        public void StringInterpolationSample()
        {
            var person = new PersonWithAutoPropInitializer();
            decimal personId = 40m;
            person.FirstName = "Joe";
            person.LastName = "Reynolds";
            Console.WriteLine($"New Person ID: {personId:d4}");
            Console.WriteLine($"New Name: {person.WrongValue} {person.LastName}");
        }

        public string YuckyStuff()
        {
            return string.Format(@"<soap:Body>
                <GetCustomerLegalName xmlns=""http://www.infocraft.net"">
                  <custNo>{0}</custNo>
                </GetCustomerLegalName>
              </soap:Body>", 500);
        }
        public string BetterStuff()
        {
            return $"<soap:Body>\r\n" +
            $"<GetCustomerLegalName xmlns=\"http://www.infocraft.net\">\r\n" +
            $"<custNo>{500}</custNo>\r\n" +
            $"</GetCustomerLegalName>\r\n" +
            $"</soap:Body>";
        }
    }
}