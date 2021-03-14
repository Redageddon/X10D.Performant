using System;
using System.IO;

namespace X10D.Generator.FileRegenerator
{
    public class Regenerator
    {
        public Regenerator()
        {
            RegenerateSingleExtensions();
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

        private static void Regenerate(string startingPath, string endingPath, string[] selectedWords, string[] replacedWords)
        {
            if (selectedWords.Length != replacedWords.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(selectedWords) + " and " + nameof(replacedWords), "replacements should have the same amount of elements.");
            }

            string contents = File.ReadAllText(startingPath);

            for (int i = 0; i < selectedWords.Length; i++)
            {
                contents = contents.Replace(selectedWords[i], replacedWords[i]);
            }

            File.WriteAllText(endingPath, contents);
        }
    }
}