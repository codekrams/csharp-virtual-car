using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoKeineKlasse
{
    class Auto
    {

        static void Main(string[] args)
        {
            string farbe;
            int max_geschw;
            int akt_geschw = 0;
            int eingabe = 0;
            string auswahl;
            int beschleunigung;
            int bremsen;

            Console.WriteLine("Welche Farbe hat das Auto?");
            farbe = Console.ReadLine();

            Console.WriteLine("Wie schnell kann das Auto fahren?");
            max_geschw = Convert.ToInt32(Console.ReadLine());

            do
            {
                Console.WriteLine("Bremsen oder Beschleunigen?");
                auswahl = Console.ReadLine();

                if (auswahl == "Beschleunigen")
                {
                    Console.WriteLine("Um wie viel soll beschleunigt werden?");
                    beschleunigung = Convert.ToInt32(Console.ReadLine());
                    akt_geschw += beschleunigung;

                    if (akt_geschw > max_geschw)
                    {
                        akt_geschw = max_geschw;
                    }
                    Console.WriteLine("Aktuelle Geschwindigkeit: " + akt_geschw.ToString());
                }

                else if (auswahl == "Bremsen")
                {
                    Console.WriteLine("Wie stark soll gebremst werden??");
                    bremsen = Convert.ToInt32(Console.ReadLine());
                    akt_geschw -= bremsen;

                    if (akt_geschw < 0)
                    {
                        akt_geschw = 0;
                    }
                    Console.WriteLine("Aktuelle Geschwindigkeit: " + akt_geschw.ToString());
                }
                else {
                    Console.WriteLine("Ungültige Eingabe");
                }

                
                
            

                Console.WriteLine("Drücken Sie 1 zum Weiterfahren und 0 zum Parken");
                eingabe = Convert.ToInt32(Console.ReadLine());

            } while (eingabe != 0);



            Console.ReadKey();
        }



    }
}
