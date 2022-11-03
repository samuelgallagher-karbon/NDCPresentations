namespace NewCSharpFeatures
{
    internal class IndicesAndRanges
    {
        private void LastIndex()
        {
            var array = new string[]
            {
                "Richard",
                "of",
                "York",
                "Gave",
                "Battle",
                "in",
                "Mexico"
            };

            var last = array[^1];
            var alsoLast = array[array.Length - 1];
        }

        private void ArraySlicing()
        {
            var array = new string[]
            {
                "Richard",
                "of",
                "York",
                "Gave",
                "Battle",
                "in",
                "Mexico"
            };

            // inclusive start, exclusive end
            var allExceptLast = array[0..^1]; // Richard, of, York, Gave, Battle, in
        }

    }
}
