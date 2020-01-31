namespace ConsoleApp2
{
    public interface IMinimumDiscount
    {
        public double ProductPrice { get; }

        double GetDiscount()
            {
            return this.ProductPrice * 0.9;
        }
    }
}