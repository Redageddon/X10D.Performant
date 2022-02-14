namespace X10D.Generator;

public partial class EquatableBuilder
{
    private const string StartingChunk = @"using System;
using System.Runtime.CompilerServices;

namespace X10D.Performant.IEquatableExtensions
{
    public static partial class EquatableExtensions
    {
";

    private const string EndingChunk = @"    }
}";
}