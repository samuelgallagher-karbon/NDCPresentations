namespace NewCSharpFeatures;

internal class AssignmentAndDeclaration
{
    static void Example()
    {
        // old style
        // initialisation
        var point = new Point(2, 4);

        // assignment
        (int x, int y) = point;

        // new style
        int a;
        (a, int b) = point;

        var z = a + b + x + y;
    }
}
