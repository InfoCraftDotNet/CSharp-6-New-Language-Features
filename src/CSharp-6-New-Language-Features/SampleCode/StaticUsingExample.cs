using System;
using System.Linq;
using static System.Math;
using static System.Linq.Enumerable;
using static System.IO.Directory;


namespace SampleCode
{
    public class StaticUsingExample
    {
        public void MathExample(double x, double y)
        {
            var pow1 = Math.Pow(x, y);

            // These both use the static
            // class "Math"
            var pow = Pow(x, y);
            var min = Min(x, y);

            // These specify the System.Linq.Enumerable 
            // Static Extensions.
            var range = Range(5, 50);
            var evens = range.Where(i => i%2 == 0);
        }

        /// <summary>
        /// Should test to see if a specific path exists
        /// </summary>
        /// <param name="filename"></param>
        private static void Encrypt(string filename)
        {


            if (!Exists(filename)) // LOGIC ERROR: Using Directory rather than File
            {
                throw new ArgumentException("The file does not exist.",
                  nameof(filename));
            }
            // ...
        }
    }
}