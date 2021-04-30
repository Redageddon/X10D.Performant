using System.IO;

namespace X10D.Generator
{
    public partial class EquatableBuilder
    {
        public EquatableBuilder()
        {
            string andClass = GetClass("And", "&&", false, 15);
            string nandClass = GetClass("NAnd", "&&", true, 15);
            string orClass = GetClass("Or", "||", false, 15);
            string norClass = GetClass("NOr", "||", true, 15);
            string xorClass = GetClass("XOr", "^", false, 15);
            string xnorClass = GetClass("XNOr", "^", true, 15);

            Directory.CreateDirectory(Path.Combine(Program.CustomPath, "IEquatableExtensions"));

            File.Copy("RawCopy/AdvancedComparisonInlining.cs.copy",
                      Path.Combine(Program.CustomPath, "IEquatableExtensions/AdvancedComparisonInlining.copy.cs"),
                      true);

            File.WriteAllText(Path.Combine(Program.CustomPath, "IEquatableExtensions/AndEquals.g.cs"), andClass);
            File.WriteAllText(Path.Combine(Program.CustomPath, "IEquatableExtensions/NAndEquals.g.cs"), nandClass);
            File.WriteAllText(Path.Combine(Program.CustomPath, "IEquatableExtensions/OrEquals.g.cs"), orClass);
            File.WriteAllText(Path.Combine(Program.CustomPath, "IEquatableExtensions/NOrEquals.g.cs"), norClass);
            File.WriteAllText(Path.Combine(Program.CustomPath, "IEquatableExtensions/XOrEquals.g.cs"), xorClass);
            File.WriteAllText(Path.Combine(Program.CustomPath, "IEquatableExtensions/XNOrEquals.g.cs"), xnorClass);
        }
    }
}