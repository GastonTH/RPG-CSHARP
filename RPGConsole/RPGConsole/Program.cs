using System;

namespace RPGConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            bool condicionWin = true;
            bool whoWin = true; //true = heroe - false = villano
            int turno = 0;

            int vidaHeroe = 1000;
            int vidaVillano = 1000;
            int ataqueHeroe = 233;
            int ataqueVillano = 121;

            void esperarRespuesta()
            {
                Console.WriteLine("Esperando respuesta...");
                Console.ReadLine();
            }

            //pequeño pvp

            while (condicionWin)
            {
                //sistema de turnos

                Console.WriteLine("Turno: " + turno);
                Console.WriteLine("Turno del heroe");
                Console.WriteLine("");

                Console.WriteLine("El Heroe ataca al Villano y le quita " + ataqueHeroe);

                vidaVillano -= ataqueHeroe;

                Console.WriteLine("");

                if (vidaVillano <= 0)
                {
                    condicionWin = false;
                    whoWin = true;
                    break;
                }

                Console.WriteLine("Vida del Villano: " + );
                Console.WriteLine("El Villano ataca al Heroe y le quita " + ataqueVillano);

                vidaHeroe -= ataqueVillano;

                if (vidaHeroe <= 0)
                {
                    condicionWin = false;
                    whoWin = false;
                    break;
                }


                //-----------------
                turno++;

            }

            if (whoWin)
            {
                Console.WriteLine("¡Ha ganado el Heroe!");
            }
            else
            {
                Console.WriteLine("Ha ganado el villano...");
            }

            esperarRespuesta();
        }
    }
}
