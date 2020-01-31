namespace ConsoleApp2
{
    public interface IMaximumDiscount
    {
        public double ProductPrice { get; }

        double GetDiscount()
        {
            return this.ProductPrice * 0.4;
        }
    }
}