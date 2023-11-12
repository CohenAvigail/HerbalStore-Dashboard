namespace MyProject.Entites
{
    public class Order
    {
        int id;
        Customer customer;
        Product [] products;

        public int Id { get => id; set => id = value; }
        public Customer Customer { get => customer; set => customer = value; }
        public Product[] Products { get => products; set => products = value; }
    }
}
