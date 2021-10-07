namespace DecoratorIcecream
{
    public abstract class IceCreamDecorator : IceCream
    {
        protected IceCream _icecream;

        public IceCreamDecorator(IceCream icecream) => _icecream = icecream;

        public override string MakeIceCream() => _icecream.MakeIceCream();
    }
}
