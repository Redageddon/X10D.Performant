using System.Buffers;

namespace X10D.Performant.IntExtensions
{
    public static partial class IntExtensions
    {
        /// <inheritdoc cref="string.Create{T}(int,T,SpanAction{char,T})"/>
        public static string CreateString<TState>(this int length, TState state, SpanAction<char, TState> action) => string.Create(length, state, action);
    }
}