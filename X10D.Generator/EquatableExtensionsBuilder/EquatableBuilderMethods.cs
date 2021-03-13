﻿using System;
using System.Collections.Generic;
using System.Text;

namespace X10D.Generator.EquatableExtensionsBuilder
{
    public partial class EquatableBuilder
    {
        private static string GetClass(string type, string binarySeparationType, bool isReversedType, int argsCount, string documentation)
        {
            StringBuilder classBuilder = new();
            classBuilder.Append(Program.AutoGeneratedString);
            classBuilder.Append(StartingChunk);
            classBuilder.Append(GetParamsMethod(type, documentation));

            List<string> strings = new();

            for (int i = 2; i < argsCount + 1; i++)
            {
                strings.Add(GetOverloadsMethod(type, binarySeparationType, isReversedType, i));
            }

            classBuilder.AppendJoin(Environment.NewLine, strings);

            classBuilder.Append(EndingChunk);

            return classBuilder.ToString();
        }

        private static string GetParamsMethod(string type, string documentation) =>
            documentation +
            @$"
        public static bool {type}Equals<T>(this T value, params T[] comparisons)
            where T : IEquatable<T> =>
            AdvancedComparison<T, {type}>(value, comparisons);

";

        private static string GetOverloadsMethod(string type, string binarySeparationType, bool isReversedType, int argsCount)
        {
            StringBuilder argsStringBuilder = new();
            StringBuilder returnsStringBuilder = new();

            #region argsBuild

            List<string> strings = new();

            for (int i = 0; i < argsCount; i++)
            {
                strings.Add("T arg" + (i + 1));
            }

            argsStringBuilder.Append(string.Join(", ", strings));

            #endregion

            if (isReversedType)
            {
                returnsStringBuilder.Append("!(");
            }

            if (argsCount == 2)
            {
                returnsStringBuilder.Append("value.Equals(arg1) ");
                returnsStringBuilder.Append(binarySeparationType);
                returnsStringBuilder.Append(" value.Equals(arg2)");
            }
            else
            {
                returnsStringBuilder.Append("value.");
                returnsStringBuilder.Append(type);
                returnsStringBuilder.Append("Equals(");

                strings.Clear();

                for (int i = 0; i < argsCount - 1; i++)
                {
                    strings.Add("arg" + (i + 1));
                }

                returnsStringBuilder.Append(string.Join(", ", strings));

                returnsStringBuilder.Append(") ");
                returnsStringBuilder.Append(binarySeparationType);
                returnsStringBuilder.Append(" value.Equals(arg");
                returnsStringBuilder.Append(argsCount);
                returnsStringBuilder.Append(')');
            }

            if (isReversedType)
            {
                returnsStringBuilder.Append(')');
            }

            return @$"        /// <inheritdoc cref=""{type}Equals{{T}}(T,T[])""/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool {type}Equals<T>(this T value, {argsStringBuilder})
            where T : IEquatable<T> =>
            {returnsStringBuilder};
";
        }
    }
}