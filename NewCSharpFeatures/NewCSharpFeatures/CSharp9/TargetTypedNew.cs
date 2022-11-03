namespace NewCSharpFeatures
{
    public class Layer1
    {
        public Layer2 layer { get; set; }

        public Layer1(Layer2 layer)
        {
            this.layer = layer;
        }
    }

    public class Layer2
    {
        public Layer3 layer { get; set; }
        public Layer2(Layer3 layer)
        {
            this.layer = layer;
        }
    }

    public class Layer3
    {
        public string Name { get; set; }
    }

    internal class TargetTypedNew
    {
        List<string> strings = new();

        Layer1 layers = new(new(new()));
    }
}
