namespace MyProject.Entites
{
    public class Product
    {
        
        int id;
        string name;
        double price;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }
    }
}
