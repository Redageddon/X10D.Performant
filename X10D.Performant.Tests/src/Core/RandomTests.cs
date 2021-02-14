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
            Random random = new();
            IList<int> list = new List<int>
            {
                11,
                23,
                234,
                436,
                57,
                3246,
                547,
                235,
                7345,
                2467,
                135,
                2436234,
                624,
                6,
                246,
                2,
            };


            Assert.IsTrue(list.Contains(random.OneOf(2, 6, 11)));
        }       
        
        /// <summary>
        ///     Tests for <see cref="RandomExtensions.OneOf{T}(System.Random,IList{T})"/>
        /// </summary>
        [TestMethod]
        public void OneOf2()
        {
            Random random = new();
            IList<int> list = new List<int>
            {
                11,
                23,
                234,
                436,
                57,
                3246,
                547,
                235,
                7345,
                2467,
                135,
                2436234,
                624,
                6,
                246,
                2,
            };
            Assert.IsTrue(list.Contains(random.OneOf(list)));
        }
    }
}