namespace NewCSharpFeatures;

internal class DelegateExpressionImprovements
{
    public static bool IsACriminalEnterprise(bool coinFlip, string ouijaBoardMessage)
    {
        var rollingTotal = 0;
        foreach (var c in ouijaBoardMessage)
        {
            rollingTotal += c;
        }

        return (rollingTotal % 2 == 1) == coinFlip;
    }

    public void funcExample()
    {
        var func = (bool coinFlip, bool ouijaBoardMessage) => IsACriminalEnterprise;
    }

}
