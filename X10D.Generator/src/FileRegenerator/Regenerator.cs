using System;
using System.IO;

namespace X10D.Generator.FileRegenerator
{
    public class Regenerator
    {
        public Regenerator()
        {
            RegenerateSingleExtensions();
            RegenerateIntegerExtensions();
        }

        private static void Regenerate(string startingPath, string endingPath, string[] selectedWords, string[] replacedWords)
        {
            if (selectedWords.Length != replacedWords.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(selectedWords) + " and " + nameof(replacedWords),
                                                      "replacements should have the same amount of elements.");
            }

            string contents = File.ReadAllText(startingPath);

            for (int i = 0; i < selectedWords.Length; i++)
            {
                contents = contents.Replace(selectedWords[i], replacedWords[i]);
            }

            File.WriteAllText(endingPath, contents);
        }

        private static void RegenerateIntegerExtensions()
        {
            string ulongPath = Path.Combine(Program.CustomPath, "IntegerExtensions/UInt64Extensions/");
            string uintPath = Path.Combine(Program.CustomPath, "IntegerExtensions/UInt32Extensions/");
            string ushortPath = Path.Combine(Program.CustomPath, "IntegerExtensions/UInt16Extensions/");
            string sbytePath = Path.Combine(Program.CustomPath, "IntegerExtensions/SByteExtensions/");
            string longPath = Path.Combine(Program.CustomPath, "IntegerExtensions/Int64Extensions/");
            string intPath = Path.Combine(Program.CustomPath, "IntegerExtensions/Int32Extensions/");
            string shortPath = Path.Combine(Program.CustomPath, "IntegerExtensions/Int16Extensions/");
            string bytePath = Path.Combine(Program.CustomPath, "IntegerExtensions/ByteExtensions/");

            #region BooleanConversions

            Regenerate(Path.Combine(ulongPath, "BooleanConversions.cs"),
                       Path.Combine(uintPath, "BooleanConversions.copy.cs"),
                       new[] { "ulong", "UInt64", ".xml" },
                       new[] { "uint", "UInt32", ".copy.xml" });

            Regenerate(Path.Combine(ulongPath, "BooleanConversions.cs"),
                       Path.Combine(ushortPath, "BooleanConversions.copy.cs"),
                       new[] { "ulong", "UInt64", ".xml" },
                       new[] { "ushort", "UInt16", ".copy.xml" });

            Regenerate(Path.Combine(ulongPath, "BooleanConversions.cs"),
                       Path.Combine(sbytePath, "BooleanConversions.copy.cs"),
                       new[] { "ulong", "UInt64", ".xml" },
                       new[] { "sbyte", "SByte", ".copy.xml" });

            Regenerate(Path.Combine(ulongPath, "BooleanConversions.cs"),
                       Path.Combine(longPath, "BooleanConversions.copy.cs"),
                       new[] { "ulong", "UInt64", ".xml" },
                       new[] { "long", "Int64", ".copy.xml" });

            Regenerate(Path.Combine(ulongPath, "BooleanConversions.cs"),
                       Path.Combine(intPath, "BooleanConversions.copy.cs"),
                       new[] { "ulong", "UInt64", ".xml" },
                       new[] { "int", "Int32", ".copy.xml" });

            Regenerate(Path.Combine(ulongPath, "BooleanConversions.cs"),
                       Path.Combine(shortPath, "BooleanConversions.copy.cs"),
                       new[] { "ulong", "UInt64", ".xml" },
                       new[] { "short", "Int16", ".copy.xml" });

            Regenerate(Path.Combine(ulongPath, "BooleanConversions.cs"),
                       Path.Combine(bytePath, "BooleanConversions.copy.cs"),
                       new[] { "ulong", "UInt64", ".xml" },
                       new[] { "byte", "Byte", ".copy.xml" });

            #endregion

            #region XmlCopy

            Regenerate(Path.Combine(ulongPath, "UInt64Extensions.xml"),
                       Path.Combine(uintPath, "UInt32Extensions.copy.xml"),
                       new[] { "ulong" },
                       new[] { "uint" });

            Regenerate(Path.Combine(ulongPath, "UInt64Extensions.xml"),
                       Path.Combine(ushortPath, "UInt16Extensions.copy.xml"),
                       new[] { "ulong" },
                       new[] { "ushort" });

            Regenerate(Path.Combine(ulongPath, "UInt64Extensions.xml"),
                       Path.Combine(sbytePath, "SByteExtensions.copy.xml"),
                       new[]
                       {
                           "ulong", @"
        <param name=""useCache"">Gives the user the ability to use a cache of type <see cref=""System.Collections.Generic.HashSet{T}""/>.</param>",
                       },
                       new[] { "sbyte", "" });

            Regenerate(Path.Combine(ulongPath, "UInt64Extensions.xml"),
                       Path.Combine(longPath, "Int64Extensions.copy.xml"),
                       new[] { "ulong" },
                       new[] { "long" });

            Regenerate(Path.Combine(ulongPath, "UInt64Extensions.xml"),
                       Path.Combine(intPath, "Int32Extensions.copy.xml"),
                       new[] { "ulong" },
                       new[] { "int" });

            Regenerate(Path.Combine(ulongPath, "UInt64Extensions.xml"),
                       Path.Combine(shortPath, "Int16Extensions.copy.xml"),
                       new[] { "ulong" },
                       new[] { "short" });

            Regenerate(Path.Combine(ulongPath, "UInt64Extensions.xml"),
                       Path.Combine(bytePath, "ByteExtensions.copy.xml"),
                       new[]
                       {
                           "ulong", @"
        <param name=""useCache"">Gives the user the ability to use a cache of type <see cref=""System.Collections.Generic.HashSet{T}""/>.</param>",
                       },
                       new[] { "byte", "" });

            #endregion
        }

        private static void RegenerateSingleExtensions()
        {
            string doublePath = Path.Combine(Program.CustomPath, "DecimalExtensions/DoubleExtensions/");
            string singlePath = Path.Combine(Program.CustomPath, "DecimalExtensions/SingleExtensions/");

            Directory.CreateDirectory(singlePath);
            Directory.CreateDirectory(Path.Combine(singlePath, "UnitConversions"));

            string[] selectedWords = { "double", "Double", "Math", "D ", "D;", "D)", ".xml" };
            string[] replacedWords = { "float", "Single", "MathF", "F ", "F;", "F)", ".copy.xml" };

            Regenerate(Path.Combine(doublePath, "DoubleExtensions.cs"),
                       Path.Combine(singlePath, "SingleExtensions.copy.cs"),
                       selectedWords,
                       replacedWords);

            Regenerate(Path.Combine(doublePath, "Lerp.cs"),
                       Path.Combine(singlePath, "Lerp.copy.cs"),
                       selectedWords,
                       replacedWords);

            Regenerate(Path.Combine(doublePath, "UnitConversions", "Angle.cs"),
                       Path.Combine(singlePath, "UnitConversions", "Angle.copy.cs"),
                       selectedWords,
                       replacedWords);

            Regenerate(Path.Combine(doublePath, "UnitConversions", "Temperature.cs"),
                       Path.Combine(singlePath, "UnitConversions", "Temperature.copy.cs"),
                       selectedWords,
                       replacedWords);

            Regenerate(Path.Combine(doublePath, "DoubleExtensions.xml"),
                       Path.Combine(singlePath, "SingleExtensions.copy.xml"),
                       new[] { "double", "Double" },
                       new[] { "float", "Single" });
        }
    }
}