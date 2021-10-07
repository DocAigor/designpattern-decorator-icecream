namespace DecoratorIcecream
{
    public class NutsIceCream : IceCreamDecorator
    {
        public NutsIceCream(IceCream icecream) : base(icecream)
        {
        }

        public override string MakeIceCream() => $"{_icecream.MakeIceCream()} with nuts";
    }
}

