using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace X10D.Performant.Tests.Core
{
    /// <summary>
    ///     Tests for <see cref="KeyValuePairExtensions"/>.
    /// </summary>
    [TestClass]
    public class DictionaryTests
    {
        /// <summary>
        ///     Tests for
        ///     <see
        ///         cref="KeyValuePairExtensions.ToConnectionString{T1,T2}(System.Collections.Generic.IEnumerable{System.Collections.Generic.KeyValuePair{T1,T2}})"/>
        ///     .
        /// </summary>
        [TestMethod]
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
        [TestMethod]
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
        [TestMethod]
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