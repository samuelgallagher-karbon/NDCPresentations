namespace NewCSharpFeatures
{
    internal class ProductStats
    {
        public DateTimeOffset ReleaseDate { get; init; }
        public int Sales { get; init; }
    }

    public class SalesTool
    {
        public static void Tool()
        {
            var product = new ProductStats
            {
                ReleaseDate = DateTimeOffset.UtcNow,
                Sales = 250
            };
        }
    }
}
