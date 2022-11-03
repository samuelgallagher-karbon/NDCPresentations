namespace NewCSharpFeatures;

internal class ExtendedPropertyPatterns
{
    public class Kitchen
    {
        public Cutlery Cutlery;
    }

    public class Cutlery
    {
        public bool HasFork;
        public bool HasSpoon;
    }

    public static bool ExtendedPatterns()
    {

        Kitchen kitchen = new()
        {
            Cutlery = new()
            {
                HasFork = true,
                HasSpoon = false
            }
        };

        return kitchen is { Cutlery.HasFork: true };
    }
}
