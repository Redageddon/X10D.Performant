using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

namespace X10D.Performant.Tests.Core
{
    /// <summary>
    ///     Tests for <see cref="KeyValuePairExtensions"/>.
    /// </summary>
    public class DictionaryTests
    {
        /// <summary>
        ///     Tests for <see cref="KeyValuePairExtensions.FlipKeyValues{TKey,TValue}(IEnumerable{KeyValuePair{TKey, TValue}})"/>
        /// </summary>
        [Test]
        public void FlipKeyValues()
        {
            Dictionary<string, int> dictionary = new()
            {
                {"4", 4},
                {"3", 3},
                {"2", 2},
                {"1", 1},
            };
            
            Dictionary<int, string> dictionary2 = new()
            {
                {4, "4"},
                {3, "3"},
                {2, "2"},
                {1, "1"},
            };

            CollectionAssert.AreEqual(dictionary2, dictionary.FlipKeyValues());
        }

        /// <summary>
        ///     Tests for
        ///     <see
        ///         cref="KeyValuePairExtensions.ToConnectionString{T1,T2}(System.Collections.Generic.IEnumerable{System.Collections.Generic.KeyValuePair{T1,T2}})"/>
        ///     .
        /// </summary>
        [Test]
        public void ToConnectionString()
        {
            Dictionary<string, object> dictionary = new()
            {
                { "username", "Foo" },
                { "password", "Foo Bar" },
                { "port", 3306 },
            };

            string connectionString = dictionary.ToConnectionString();
            Assert.AreEqual("username=Foo;password=\"Foo Bar\";port=3306", connectionString);
        }

        /// <summary>
        ///     Tests for
        ///     <see cref="KeyValuePairExtensions.ToGetParameters{T1,T2}(System.Collections.Generic.IEnumerable{System.Collections.Generic.KeyValuePair{T1,T2}})"/>
        ///     .
        /// </summary>
        [Test]
        public void ToGetParameters()
        {
            Dictionary<string, object> dictionary = new()
            {
                { "username", "Foo" },
                { "password", "Foo Bar" },
                { "port", 3306 },
            };

            string getParameterString = dictionary.ToGetParameters();
            Assert.AreEqual("username=Foo&password=Foo+Bar&port=3306", getParameterString);
        }

        /// <summary>
        ///     Tests for
        ///     <see cref="KeyValuePairExtensions.ToGetParameters{T1,T2}(System.Collections.Generic.IEnumerable{System.Collections.Generic.KeyValuePair{T1,T2}})"/>
        ///     .
        /// </summary>
        [Test]
        public void ToGetParametersSeparators()
        {
            Dictionary<string, IEnumerable> dictionary = new()
            {
                { "username", "Foo" },
                { "password", "Foo Bar" },
                { "port", new[] { 3, 3, 0, 6 } },
            };

            string getParameterString = dictionary.ToGetParameters(",", "-", ".");
            Assert.AreEqual("username=F%2co%2co&password=F-o-o-+-B-a-r&port=3.3.0.6", getParameterString);

            getParameterString = dictionary.ToGetParameters(",", "-");
            Assert.AreEqual("username=F%2co%2co&password=F-o-o-+-B-a-r&port=3-3-0-6", getParameterString);

            getParameterString = dictionary.ToGetParameters(",");
            Assert.AreEqual("username=F%2co%2co&password=F%2co%2co%2c+%2cB%2ca%2cr&port=3%2c3%2c0%2c6", getParameterString);
        }
    }
}