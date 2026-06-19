using System;

class Program
{
    static void Main()
    {
        Random r = new Random();
        int secret = r.Next(1, 100);

        while (true)
        {
            Console.Write("Guess: ");
            int g = int.Parse(Console.ReadLine());

            if (g == secret)
            {
                Console.WriteLine("Win!");
                break;
            }
            else if (g > secret)
                Console.WriteLine("Down");
            else
                Console.WriteLine("Up");
        }
    }
}
