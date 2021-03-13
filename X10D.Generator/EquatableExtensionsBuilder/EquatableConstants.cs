namespace X10D.Generator.EquatableExtensionsBuilder
{
    public partial class EquatableBuilder
    {
        private const string StartingChunk = @"using System;
using System.Runtime.CompilerServices;

namespace X10D.Performant
{
    public static partial class EquatableExtensions
    {
";

        private const string EndingChunk = @"    }
}";

        private const string AndDocumentation = @"        /// <summary>
        ///     Checks if this element is AND equaled to all of the parameters.
        /// </summary>
        /// <param name=""value"">The value being checked into.</param>
        /// <param name=""comparisons"">All values being checked against.</param>
        /// <typeparam name=""T"">The type being tested against.</typeparam>
        /// <returns>
        ///     <see langword=""true""/> if value is AND equaled to all of the parameters.
        ///     EX: a == b and a == c and a == d.
        /// </returns>";

        private const string NAndDocumentation = @"        /// <summary>
        ///     Checks if this element is NAND equaled to all of the parameters.
        /// </summary>
        /// <param name=""value"">The value being checked into.</param>
        /// <param name=""comparisons"">All values being checked against.</param>
        /// <typeparam name=""T"">The type being tested against.</typeparam>
        /// <returns>
        ///     <see langword=""true""/> if value is NAND equaled to all of the parameters.
        ///     EX: !(!(a == b and a == c) and a == d).
        /// </returns>";

        private const string NOrDocumentation = @"        /// <summary>
        ///     Checks if this element is NOR equaled to all of the parameters.
        /// </summary>
        /// <param name=""value"">The value being checked into.</param>
        /// <param name=""comparisons"">All values being checked against.</param>
        /// <typeparam name=""T"">The type being tested against.</typeparam>
        /// <returns>
        ///     <see langword=""true""/> if value is NOR equaled to all of the parameters.
        ///     EX: !(!(a == b or a == c) or a == d).
        /// </returns>";

        private const string OrDocumentation = @"        /// <summary>
        ///     Checks if this element is OR equaled to all of the parameters.
        /// </summary>
        /// <param name=""value"">The value being checked into.</param>
        /// <param name=""comparisons"">All values being checked against.</param>
        /// <typeparam name=""T"">The type being tested against.</typeparam>
        /// <returns>
        ///     <see langword=""true""/> if value is OR equaled to any of the parameters.
        ///     EX: a == b or a == c or a == d.
        /// </returns>";

        private const string XNOrDocumentation = @"        /// <summary>
        ///     Checks if this element is XNOR equaled to all of the parameters.
        /// </summary>
        /// <param name=""value"">The value being checked into.</param>
        /// <param name=""comparisons"">All values being checked against.</param>
        /// <typeparam name=""T"">The type being tested against.</typeparam>
        /// <returns>
        ///     <see langword=""true""/> if value is XNOR equaled to any of the parameters.
        ///     EX: !(!(a == b ^ a == c) ^ a == d).
        /// </returns>";

        private const string XOrDocumentation = @"        /// <summary>
        ///     Checks if this element is XOR equaled to all of the parameters.
        /// </summary>
        /// <param name=""value"">The value being checked into.</param>
        /// <param name=""comparisons"">All values being checked against.</param>
        /// <typeparam name=""T"">The type being tested against.</typeparam>
        /// <returns>
        ///     <see langword=""true""/> if value is XOR equaled to all of the parameters.
        ///     EX: a == b ^ a == c ^ a == d.
        /// </returns>";
    }
}