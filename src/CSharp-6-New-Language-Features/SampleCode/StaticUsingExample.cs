using System;
using System.Linq;
using static System.Math;
using static System.Linq.Enumerable;


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
    }
}