using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("FOUNDATION 4");
        Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - ");
        Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - ");

        Lecture lectureEvent = new Lecture(
            "John Doe",
            100, 
            "Interestellar Book",
            "Experience an exhilarating journey through the cosmos with 'Interstellar.' This captivating read propels readers beyond our solar system, where science and imagination intertwine amidst cosmic challenges. Explore unknown worlds, confront existential dilemmas, and unravel the mysteries of the universe. Each page promises a thrilling revelation, leaving readers yearning to uncover the secrets hidden among the stars.",
            new DateTime(2024, 2, 25), 
            90,
            new Address("123 Lecture St", "Salt Lake", "Utah", "USA") // Address
        );

        // Crear objeto Reception
        Reception receptionEvent = new Reception(
            "fernandogonzalezevents@example.com",
            "Networking Reception",
            "Experience an evening of networking excellence at our Networking Reception. Join professionals from various industries under the same celestial roof, fostering connections and collaborations in an atmosphere of conviviality and purpose. Engage in meaningful conversations, exchange ideas, and expand your professional orbit while enjoying delightful refreshments and ambiance. Whether you're seeking new opportunities, partnerships, or simply expanding your network, our Networking Reception promises to be a stellar event", 
            new DateTime(2024, 3, 15),
            120,      
            new Address("456 Reception Ave", "Santiago", "RM", "Chile") 
        );

        // Crear objeto Outdoor
        Outdoor outdoorEvent = new Outdoor(
            "Sunny",              // Weather
            "Picnic in the Park", // Title
            "Description of the outdoor event", // Description
            new DateTime(2024, 4, 20), // Date
            180,                       // Time (in minutes)
            new Address("789 Park Blvd", "City", "Country", "13579") // Address
        );

        // Imprimir la información completa de cada evento
        lectureEvent.GetFullInformation();
        Console.WriteLine();
        receptionEvent.GetFullInformation();
        Console.WriteLine();
        outdoorEvent.GetFullInformation();






    }
}