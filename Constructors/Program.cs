class Program
{
    private static void Main(string[] args)
    {
        Customer customer1 = new Customer { Id = 1, FirstName = "Engin", LastName = "Demiroğ", City = "Ankara" };

        Customer customer2 = new Customer(2, "Derin", "Demiroğ", "Ankara");

        Console.WriteLine(customer2.FirstName);


        Customer customer3 = new Customer();
        customer3.Id = 3;
    }
}
class Customer

{
    public Customer() //parametresiz çalıştırmak için
    {

    }

    public Customer(int id, string firstName, string lastName, string city) // parametreli çalıştırmak için

    {   // aşağıdakileri yazmazsak "costumer3.FirstName" gibi ifadeleri çağıramayız.
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        City = city;
    }
    public int Id { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string City { get; set; }
}