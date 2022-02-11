using System;

namespace EsercizioStringhe1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sommac = -1;
            int sommav = 0;
            char iniziale ;  
            Console.Write("Scrivi una parola, se vuoi smettere di scrivere parole scrivi fine, ti scrivo quante: ");
            string parola="";
            
            while (parola != "fine")
            {
                parola = Console.ReadLine();
                iniziale = parola[0];
                if (iniziale == 'a')
                {
                    sommav = sommav + 1;
                }
                else if (iniziale == 'e')
                {
                    sommav = sommav + 1;
                }
                else if (iniziale == 'i')
                {
                    sommav = sommav + 1;
                }
                else if (iniziale == 'o')
                {
                    sommav = sommav + 1;
                }
                else if (iniziale == 'u')
                {
                    sommav = sommav + 1;
                }
                else 
                {
                    sommac = sommac + 1;
                }
            }
            Console.WriteLine($"Sono presenti {sommav} parole che iniziano per vocale e sono presente {sommac} parole che iniziano per consonante.");
        }
    }
}
