namespace NewCSharpFeatures;

internal class FileScopedNamespaces
{
    public int x;

    static void Example()
    {
        using var stream = new MemoryStream();


        using (var stream2 = new MemoryStream())
        {
            // does something...
        };
    }
}
