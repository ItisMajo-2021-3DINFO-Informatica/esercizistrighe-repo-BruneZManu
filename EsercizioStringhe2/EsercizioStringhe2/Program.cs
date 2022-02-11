using System;

namespace EsercizioStringhe2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Scrivi una serie di parole, scrivi fine quando desideri concludere;" +
                " ti dico quante parole hanno meno di otto caratteri e quante più: ");
            string parola="";
            int menott = 0;
            int piùott = 0;
            
            double nparole = 0;
            double somma = 0;
            while (parola != "fine")
            {
                parola = Console.ReadLine();
                int lungh = parola.Length;
                if (lungh >= 8)
                {
                    piùott = piùott + 1;
                    nparole = nparole + 1;
                    somma = somma + lungh;

                }
                else if(lungh < 8)
                {
                    menott = menott + 1;
                    nparole = nparole + 1;
                    somma = somma + lungh;
                }
            }
            double media = somma / nparole;
            Console.WriteLine($"Ci sono {piùott} parole con almeno otto caratteri e {menott} " +
                $"parole con meno di otto e la media dei caratteri è {media}.");
        }
    }
}
