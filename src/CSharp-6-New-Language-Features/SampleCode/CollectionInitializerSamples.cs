using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    public class CollectionInitializerSamples
    {
        /// <summary>
        /// Uses the new collection initializer format
        /// </summary>
        /// <returns></returns>
        public Dictionary<int, string> GetNewSampleInputDictionary()
        {
            var sampleFileInput =
                new Dictionary<int, string>
                {
                    [1] = "String 1",
                    [2] = "String A", 
                    [3] = "String Foo"
                };
            return sampleFileInput;
        }

        /// <summary>
        /// Uses the old collection initializer format.
        /// </summary>
        /// <returns></returns>
        public Dictionary<int, string> GetOldSampleInputDictionary()
        {
            var sampleFileInput =
                new Dictionary<int, string>
                {
                    {1, "String 1"},
                    {2, "String A"},
                    {3, "String Foo"}
                };
            return sampleFileInput;
        }

        /// <summary>
        /// Uses the old initializer, but accidently assigns two things to one key.
        /// This will break if it assigns two things to the same key.
        /// Maybe this is ok... Maybe not.
        /// </summary>
        /// <returns></returns>
        public Dictionary<int, string> BadOldSampleInputDictionary()
        {
            var sampleFileInput =
                new Dictionary<int, string>
                {
                    {1, "String 1"},
                    {1, "String A"},
                    {3, "String Foo"}
                };
            return sampleFileInput;
        }

        /// <summary>
        /// Uses the new initializer
        /// This won't break if it assigns two things to the same key.
        /// This may be good... Or not.
        /// </summary>
        /// <returns></returns>
        public Dictionary<int, string> BadNewSampleInputDictionary()
        {
            var sampleFileInput =
                new Dictionary<int, string>
                {
                    [1] = "String 1",
                    [1] = "String A",
                    [3] = "String Foo"
                };
            return sampleFileInput;
        }
    }
}
