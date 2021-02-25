using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace X10D.Performant
{
    /// <summary>
    ///     The class responsible for generic value comparisons
    /// </summary>
    public static partial class EquatableExtensions
    {
        private static bool AdvancedComparison<T, TOperation>(T value, params T[] comparisons)
            where T : IEquatable<T>
            where TOperation : struct, IOperable
        {
            bool temp = value.Equals(comparisons[0]);

            for (int index = 1; index < comparisons.Length; index++)
            {
                temp = default(TOperation).Execute(temp, value.Equals(comparisons[index]));
            }

            return temp;
        }

        private interface IOperable
        {
            public bool Execute(bool left, bool right);
        }

        private struct And : IOperable
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public bool Execute(bool left, bool right) => left && right;
        }

        private struct NAnd : IOperable
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public bool Execute(bool left, bool right) => !(left && right);
        }

        private struct Or : IOperable
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public bool Execute(bool left, bool right) => left || right;
        }

        private struct NOr : IOperable
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public bool Execute(bool left, bool right) => !(left || right);
        }

        private struct XOr : IOperable
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public bool Execute(bool left, bool right) => left ^ right;
        }

        [SuppressMessage("ReSharper", "InconsistentNaming")]
        private struct XNOr : IOperable
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public bool Execute(bool left, bool right) => !(left ^ right);
        }
    }
}