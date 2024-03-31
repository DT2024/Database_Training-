using Week11.EF.Models.Entities;

public class Try
{
    static void Main(string[] args)
    {
        var dbContext = new MMABooksContext();

        var customers = dbContext.Customers;

        foreach (var customer in customers)

        {

            Console.WriteLine("The name is : " + customer.Name);

        }
    }
}