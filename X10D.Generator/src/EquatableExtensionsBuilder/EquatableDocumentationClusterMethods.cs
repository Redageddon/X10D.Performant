using System.Text;

namespace X10D.Generator
{
    public partial class EquatableDocumentationBuilder
    {
        public static string BuildAndMethodCluster(int count)
        {
            StringBuilder clusterBuilder = new();

            for (int i = 1; i < count; i++)
            {
                clusterBuilder.AppendLine(BuildAndMethod(i));
            }

            return clusterBuilder.ToString();
        }

        public static string BuildNAndMethodCluster(int count)
        {
            StringBuilder clusterBuilder = new();

            for (int i = 1; i < count; i++)
            {
                clusterBuilder.AppendLine(BuildNAndMethod(i));
            }

            return clusterBuilder.ToString();
        }

        public static string BuildNOrMethodCluster(int count)
        {
            StringBuilder clusterBuilder = new();

            for (int i = 1; i < count; i++)
            {
                clusterBuilder.AppendLine(BuildNOrMethod(i));
            }

            return clusterBuilder.ToString();
        }

        public static string BuildOrMethodCluster(int count)
        {
            StringBuilder clusterBuilder = new();

            for (int i = 1; i < count; i++)
            {
                clusterBuilder.AppendLine(BuildOrMethod(i));
            }

            return clusterBuilder.ToString();
        }

        public static string BuildXNOrMethodCluster(int count)
        {
            StringBuilder clusterBuilder = new();

            for (int i = 1; i < count; i++)
            {
                clusterBuilder.AppendLine(BuildXNOrMethod(i));
            }

            return clusterBuilder.ToString();
        }

        public static string BuildXOrMethodCluster(int count)
        {
            StringBuilder clusterBuilder = new();

            for (int i = 1; i < count; i++)
            {
                clusterBuilder.AppendLine(BuildXOrMethod(i));
            }

            return clusterBuilder.ToString();
        }
    }
}