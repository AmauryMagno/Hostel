using Hotel.Models;

namespace Hotel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            List<Person> guests = new List<Person>();

            // Create instances of Persons
            Person p1 = new Person
            {
                Name = "João",
                Sobrenome = "Silva"
            };

            Person p2 = new Person
            {
                Name = "Maria",
                Sobrenome = "Oliveira"
            };

            // Add guests to the list
            guests.Add(p1);
            guests.Add(p2);

            //Create a suite instance
            Suite suite = new Suite
            {
                SuiteType = "Luxo",
                Capacity = 2,
                DailyValue = 30.00m
            };

            //Create a Booker instance and register the suite and guests
            Booker booker = new Booker(daysBooked: 10);
            booker.RegisterGuests(guests);
            booker.RegisterSuite(suite);
            

            //Show the booking details
            Console.WriteLine($"Hospedes: {booker.GetTotalGuests()}");
            Console.WriteLine($"Valor da reserva de {booker.DaysBooked} dias: {booker.GetValueBooking():C2}");
        }
    }
}
