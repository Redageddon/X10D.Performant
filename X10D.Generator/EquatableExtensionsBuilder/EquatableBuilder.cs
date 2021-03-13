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

            File.WriteAllText("../../../../X10D.Performant/src/Custom/IEquatableExtensions/AndEquals.g.cs", andClass);
            File.WriteAllText("../../../../X10D.Performant/src/Custom/IEquatableExtensions/NAndEquals.g.cs", nandClass);
            File.WriteAllText("../../../../X10D.Performant/src/Custom/IEquatableExtensions/OrEquals.g.cs", orClass);
            File.WriteAllText("../../../../X10D.Performant/src/Custom/IEquatableExtensions/NOrEquals.g.cs", norClass);
            File.WriteAllText("../../../../X10D.Performant/src/Custom/IEquatableExtensions/XOrEquals.g.cs", xorClass);
            File.WriteAllText("../../../../X10D.Performant/src/Custom/IEquatableExtensions/XNOrEquals.g.cs", xnorClass);
        }
    }
}