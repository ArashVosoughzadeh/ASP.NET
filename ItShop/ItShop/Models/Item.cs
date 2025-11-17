namespace ItShop.Models
{
    public class Item
    {
        public int Id { get; set; }
        public decimal price { get; set; }
        public int QuantityInStook { get; set; }

        public Product product { get; set; }

        internal object SingleOrDefault(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }
    }
}
