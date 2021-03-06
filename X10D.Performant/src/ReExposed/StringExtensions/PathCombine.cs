using System.IO;

namespace X10D.Performant.ReExposed
{
    public static partial class StringExtensions
    {
        /// <inheritdoc cref="Path.Combine(string,string)"/>
        public static string PathCombine(this string path1, string path2) => Path.Combine(path1, path2);

        /// <inheritdoc cref="Path.Combine(string,string,string)"/>
        public static string PathCombine(this string path1, string path2, string path3) => Path.Combine(path1, path2, path3);

        /// <inheritdoc cref="Path.Combine(string,string,string,string)"/>
        public static string PathCombine(this string path1, string path2, string path3, string path4) => Path.Combine(path1, path2, path3, path4);
    }
}