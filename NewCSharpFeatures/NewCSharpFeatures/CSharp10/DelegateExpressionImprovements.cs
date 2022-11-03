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
        var func = IsACriminalEnterprise;

        if (func != null) return;
        return;
    }

    public delegate void Action<in T1, in T2, in T3, in T4, in T5>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5);
    public delegate void Action<in T1, in T2, in T3, in T4, in T5, in T6>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6);
    public delegate void Action<in T1, in T2, in T3, in T4, in T5, in T6, in T7>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7);
    public delegate void Action<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8);
}
