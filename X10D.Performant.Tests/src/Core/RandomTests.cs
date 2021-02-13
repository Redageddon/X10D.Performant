using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace X10D.Performant.Tests.Core
{
    /// <summary>
    ///     Tests for <see cref="RandomExtensions"/>.
    /// </summary>
    [TestClass]
    public class RandomTests
    {
        /// <summary>
        ///     Tests for <see cref="RandomExtensions.NextBool"/>.
        /// </summary>
        [TestMethod]
        public void CoinToss()
        {
            Random random = new();

            bool[] tosses =
            {
                random.NextBool(), random.NextBool(), random.NextBool(), random.NextBool(), random.NextBool(), random.NextBool(),
                random.NextBool(), random.NextBool(), random.NextBool(), random.NextBool(), random.NextBool(), random.NextBool(),
                random.NextBool(), random.NextBool(), random.NextBool(), random.NextBool(), random.NextBool(), random.NextBool(),
                random.NextBool(), random.NextBool(),
            };

            CollectionAssert.AreNotEqual(
                new[] { true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true },
                tosses);

            CollectionAssert.AreNotEqual(
                new[]
                {
                    false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false,
                    false, false,
                },
                tosses);
        }
        
        /// <summary>
        ///     Tests for <see cref="RandomExtensions.OneOf{T}(System.Random,T[])"/>
        /// </summary>
        [TestMethod]
        public void OneOf()
        {
            // Todo: implement this test
        }       
        
        /// <summary>
        ///     Tests for <see cref="RandomExtensions.OneOf{T}(System.Random,IList{T})"/>
        /// </summary>
        [TestMethod]
        public void OneOf2()
        {
            // Todo: implement this test
        }
    }
}