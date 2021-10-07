namespace DecoratorIcecream
{
    public class HoneyIceCream : IceCreamDecorator
    {
        public HoneyIceCream(IceCream icecream) : base(icecream)
        {
        }

        public override string MakeIceCream() => $"{_icecream.MakeIceCream()} with Honey";
    }
}

