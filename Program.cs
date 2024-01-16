for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Ange ett tal");
    string input = Console.ReadLine();

    // konvertera det som skrivs in till ett heltal
    if (int.TryParse(input, out int tal))
    {
        if (tal > 5)
        {
            Console.WriteLine("Högre än 5");
        }
    }
    else
    {
        Console.WriteLine("Ogiltigt tal. Försök igen.");
       
    }
}
