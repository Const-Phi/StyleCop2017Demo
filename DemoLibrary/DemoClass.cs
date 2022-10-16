namespace DemoLibrary
{
    public sealed class DemoClass
    {
        public int Value { get; set; }

        public override string ToString() => $"Value is {this.Value}";
    }
}
