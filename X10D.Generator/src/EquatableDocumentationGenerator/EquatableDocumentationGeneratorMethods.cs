using System.Text;

namespace X10D.Generator;

public partial class EquatableDocumentationGenerator
{
    private static string BuildArgsDocs(int count)
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

    private static string BuildAndMethod(int count) =>
        $@"    <member name=""AndEquals{count}"">
        <summary>
            Checks if this element is AND equaled to all of the parameters.
        </summary>
        <param name=""value"">The value being checked into.</param>
{BuildArgsDocs(count)}        <typeparam name=""T"">The type being tested against.</typeparam>
        <returns>
            <see langword=""true""/> if value is AND equaled to all of the parameters.
            EX: a == b and a == c and a == d.
        </returns>
    </member>";

    private static string BuildNAndMethod(int count) =>
        $@"    <member name=""NAndEquals{count}"">
        <summary>
            Checks if this element is NAND equaled to all of the parameters.
        </summary>
        <param name=""value"">The value being checked into.</param>
{BuildArgsDocs(count)}        <typeparam name=""T"">The type being tested against.</typeparam>
        <returns>
            <see langword=""true""/> if value is NAND equaled to all of the parameters.
            EX: !(!(a == b and a == c) and a == d).
        </returns>
    </member>";

    private static string BuildNOrMethod(int count) =>
        $@"    <member name=""NOrEquals{count}"">
        <summary>
            Checks if this element is NOR equaled to all of the parameters.
        </summary>
        <param name=""value"">The value being checked into.</param>
{BuildArgsDocs(count)}        <typeparam name=""T"">The type being tested against.</typeparam>
        <returns>
            <see langword=""true""/> if value is NOR equaled to all of the parameters.
            EX: !(!(a == b or a == c) or a == d).
        </returns>
    </member>";

    private static string BuildOrMethod(int count) =>
        $@"    <member name=""OrEquals{count}"">
        <summary>
            Checks if this element is OR equaled to all of the parameters.
        </summary>
        <param name=""value"">The value being checked into.</param>
{BuildArgsDocs(count)}        <typeparam name=""T"">The type being tested against.</typeparam>
        <returns>
            <see langword=""true""/> if value is OR equaled to all of the parameters.
            EX: a == b or a == c or a == d.
        </returns>
    </member>";

    private static string BuildXNOrMethod(int count) =>
        $@"    <member name=""XNOrEquals{count}"">
        <summary>
            Checks if this element is XNOR equaled to all of the parameters.
        </summary>
        <param name=""value"">The value being checked into.</param>
{BuildArgsDocs(count)}        <typeparam name=""T"">The type being tested against.</typeparam>
        <returns>
            <see langword=""true""/> if value is XNOR equaled to all of the parameters.
            EX: !(!(a == b ^ a == c) ^ a == d).
        </returns>
    </member>";

    private static string BuildXOrMethod(int count) =>
        $@"    <member name=""XOrEquals{count}"">
        <summary>
            Checks if this element is XOR equaled to all of the parameters.
        </summary>
        <param name=""value"">The value being checked into.</param>
{BuildArgsDocs(count)}        <typeparam name=""T"">The type being tested against.</typeparam>
        <returns>
            <see langword=""true""/> if value is XOR equaled to all of the parameters.
            EX: a == b ^ a == c ^ a == d.
        </returns>
    </member>";

    private static string BuildMethodCluster(int count, Func<int, string> buildMethod)
    {
        StringBuilder clusterBuilder = new();

        for (int i = 1; i < count; i++)
        {
            clusterBuilder.AppendLine(buildMethod(i));
        }

        return clusterBuilder.ToString();
    }
}