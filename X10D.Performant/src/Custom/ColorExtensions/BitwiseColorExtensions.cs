using System.Drawing;

namespace X10D.Performant.ColorExtensions
{
    public static partial class ColorExtensions
    {
        /// <include file='ColorExtensions.xml' path='members/member[@name="And"]'/>
        public static Color And(this Color color, Color other) => Color.FromArgb(color.ToArgb() & other.ToArgb());

        /// <include file='ColorExtensions.xml' path='members/member[@name="Or"]'/>
        public static Color Or(this Color color, Color other) => Color.FromArgb(color.ToArgb() | other.ToArgb());

        /// <include file='ColorExtensions.xml' path='members/member[@name="XOr"]'/>
        public static Color XOr(this Color color, Color other) => Color.FromArgb(color.ToArgb() ^ other.ToArgb());
    }
}