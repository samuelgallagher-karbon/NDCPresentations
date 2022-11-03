namespace NewCSharpFeatures
{
    public enum Quadrant
    {
        Origin,
        One,
        Two,
        Three,
        Four,
        OnAxes,
        Unknown
    }

    public class Point
    {
        public int X { get; }
        public int Y { get; }

        public Point(int x, int y) => (X, Y) = (x, y);

        public void Deconstruct(out int x, out int y) =>
            (x, y) = (X, Y);

        public (int, int) Deconstructing()
        {
            var point = new Point(3, 5);

            var (x, y) = point;

            return (x, y);
        }

        static Quadrant GetPoint(Point point) => point switch
        {
            (0, 0)                              => Quadrant.Origin,
            var (x, y) when x > 0 && y > 0      => Quadrant.One,
            var (x, y) when x > 0 && y < 0      => Quadrant.Two,
            var (x, y) when x < 0 && y < 0      => Quadrant.Three,
            var (x, y) when x < 0 && y > 0      => Quadrant.Four,
            var (_, _)                          => Quadrant.OnAxes,
            _                                   => Quadrant.Unknown
        };
    }

}
