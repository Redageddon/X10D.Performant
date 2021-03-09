using System.IO;

namespace X10D.Generator
{
    public static partial class Program
    {
        public static void Main()
        {
            string andClass = GetClass("And", "&&", false, 15, AndDocumentation);
            string nandClass = GetClass("NAnd", "&&", true, 15, NAndDocumentation);
            string orClass = GetClass("Or", "||", false, 15, OrDocumentation);
            string norClass = GetClass("NOr", "||", true, 15, NOrDocumentation);
            string xorClass = GetClass("XOr", "^", false, 15, XOrDocumentation);
            string xnorClass = GetClass("XNOr", "^", true, 15, XNOrDocumentation);

            File.WriteAllText("../../../../X10D.Performant/src/Custom/IEquatableExtensions/AndEquals.cs", andClass);
            File.WriteAllText("../../../../X10D.Performant/src/Custom/IEquatableExtensions/NAndEquals.cs", nandClass);
            File.WriteAllText("../../../../X10D.Performant/src/Custom/IEquatableExtensions/OrEquals.cs", orClass);
            File.WriteAllText("../../../../X10D.Performant/src/Custom/IEquatableExtensions/NOrEquals.cs", norClass);
            File.WriteAllText("../../../../X10D.Performant/src/Custom/IEquatableExtensions/XOrEquals.cs", xorClass);
            File.WriteAllText("../../../../X10D.Performant/src/Custom/IEquatableExtensions/XNOrEquals.cs", xnorClass);
        }
    }
}