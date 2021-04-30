using System.IO;
using System.Text;

namespace X10D.Generator
{
    public partial class EquatableDocumentationBuilder
    {
        public EquatableDocumentationBuilder()
        {
            StringBuilder xmlBuilder = new();
            xmlBuilder.AppendLine(@"<members>");
            xmlBuilder.Append(BuildAndMethodCluster(16));
            xmlBuilder.Append(BuildNAndMethodCluster(16));
            xmlBuilder.Append(BuildNOrMethodCluster(16));
            xmlBuilder.Append(BuildOrMethodCluster(16));
            xmlBuilder.Append(BuildXNOrMethodCluster(16));
            xmlBuilder.Append(BuildXOrMethodCluster(16));
            xmlBuilder.AppendLine(@"</members>");
            File.WriteAllText(Path.Combine(Program.CustomPath, "IEquatableExtensions/EquatableExtensions.g.xml"), xmlBuilder.ToString());
        }

        public static string BuildArgsDocs(int count)
        {
            StringBuilder argBuilder = new(78 * (count - 1));

            if (count == 1)
            {
                argBuilder.AppendLine(@"        <param name=""comparisons"">All values being checked against.</param>");
            }
            else
            {
                for (int i = 0; i < count; i++)
                {
                    argBuilder.AppendLine($@"        <param name=""arg{i + 1}"">A <typeparamref name=""T""/> being checked.</param>");
                }
            }

            return argBuilder.ToString();
        }
    }
}