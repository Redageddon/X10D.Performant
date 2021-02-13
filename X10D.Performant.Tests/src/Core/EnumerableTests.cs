using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace X10D.Performant.Tests.Core
{
    /// <summary>
    ///     Tests for <see cref="EnumerableExtensions"/>.
    /// </summary>
    [TestClass]
    public class EnumerableTests
    {
        /// <summary>
        ///     Tests for <see cref="EnumerableExtensions.LazyChunk{T}"/>.
        /// </summary>
        [TestMethod]
        public void LazyChunk()
        {
            byte[] foo = { 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08 };
            IEnumerable<IEnumerable<byte>> chunks = foo.LazyChunk(2).ToArray();

            Assert.AreEqual(4, chunks.Count());
            CollectionAssert.AreEqual(new byte[] { 0x01, 0x02 }, chunks.ElementAt(0).ToList());
            CollectionAssert.AreEqual(new byte[] { 0x03, 0x04 }, chunks.ElementAt(1).ToList());
            CollectionAssert.AreEqual(new byte[] { 0x05, 0x06 }, chunks.ElementAt(2).ToList());
            CollectionAssert.AreEqual(new byte[] { 0x07, 0x08 }, chunks.ElementAt(3).ToList());
        }

        /// <summary>
        ///     Tests for <see cref="EnumerableExtensions.LazyRandom{T}"/>
        /// </summary>
        [TestMethod]
        public void LazyRandom()
        {
            int[] array = { 1,1,1,2,2,2,3,3,3 }; 
            int[] collection = array.LazyRandom(10).ToArray();
            
            Assert.AreEqual(10, collection.Length);
            CollectionAssert.AreNotEqual(array, collection);
        }      
        
        /// <summary>
        ///     Tests for <see cref="EnumerableExtensions.Shuffled{T}"/>
        /// </summary>
        [TestMethod]
        public void Shuffled()
        {
            int[] array = { 1,1,1,2,2,2,3,3,3 }; 
            int[] collection = array.Shuffled().ToArray();
            
            Assert.AreEqual(array.Length, collection.Length);
            CollectionAssert.AreNotEqual(array, collection);
        }
    }
}
