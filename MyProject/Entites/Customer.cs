namespace MyProject.Entites
{
    public class Customer
    {
        //static int num = 0;
        int id;
        string name;
        string address;
        string phoneNumber;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
    }
}
