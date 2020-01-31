namespace ConsoleApp2
{
    public class Product : IMaximumDiscount, IMinimumDiscount
    {
        public Product(double productPrice)
        {
            ProductPrice = productPrice;
        }

        public double ProductPrice { get; }

    }
}