using System;
using System.Collections.Generic;

namespace X10D.Performant.RandomExtensions
{
    /// <summary>
    ///     Extension methods for <see cref="Random"/>.
    /// </summary>
    public static partial class RandomExtensions
    {
        internal static Random Random { get; } = new();

        /// <include file='RandomExtensions.xml' path='members/member[@name="OneOf"]'/>
        public static T OneOf<T>(this Random random, params T[] values) => random.OneOf((IList<T>)values);

        /// <include file='RandomExtensions.xml' path='members/member[@name="OneOfIList"]'/>
        public static T OneOf<T>(this Random random, IList<T> values) => values[random.Next(values.Count)];
    }
}