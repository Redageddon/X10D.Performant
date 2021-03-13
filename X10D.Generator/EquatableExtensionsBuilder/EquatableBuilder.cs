using System.IO;

namespace X10D.Generator.EquatableExtensionsBuilder
{
    public partial class EquatableBuilder
    {
        public EquatableBuilder()
        {
            string andClass = GetClass("And", "&&", false, 15, AndDocumentation);
            string nandClass = GetClass("NAnd", "&&", true, 15, NAndDocumentation);
            string orClass = GetClass("Or", "||", false, 15, OrDocumentation);
            string norClass = GetClass("NOr", "||", true, 15, NOrDocumentation);
            string xorClass = GetClass("XOr", "^", false, 15, XOrDocumentation);
            string xnorClass = GetClass("XNOr", "^", true, 15, XNOrDocumentation);

            File.WriteAllText(Path.Combine(Program.CustomPath, "IEquatableExtensions/AndEquals.g.cs"), andClass);
            File.WriteAllText(Path.Combine(Program.CustomPath, "IEquatableExtensions/NAndEquals.g.cs"), nandClass);
            File.WriteAllText(Path.Combine(Program.CustomPath, "IEquatableExtensions/OrEquals.g.cs"), orClass);
            File.WriteAllText(Path.Combine(Program.CustomPath, "IEquatableExtensions/NOrEquals.g.cs"), norClass);
            File.WriteAllText(Path.Combine(Program.CustomPath, "IEquatableExtensions/XOrEquals.g.cs"), xorClass);
            File.WriteAllText(Path.Combine(Program.CustomPath, "IEquatableExtensions/XNOrEquals.g.cs"), xnorClass);
        }
    }
}