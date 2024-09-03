using System;
using System.Reflection;
class Program
{
    static void Main()
    {
        Console.WriteLine("Bienvenido al juego de las adivinansas");
        bool reintentar=false;

        do
        {
            Random random = new Random();
            int nmr = random.Next(1,11);
            int contador=0;
            bool acierto =false;
        
            while (!acierto)
                {
                    Console.Write("Intenta adividar el numero secreto entre el 1 y el 10:");
                    int i = int.Parse(Console.ReadLine());

                    if (i == nmr)
                    {
                        Console.WriteLine("Felicidades has adivinado!");
                        Console.WriteLine($"Te tomo {contador} intentos");
                        acierto=true;
                    }
                    else
                    {
                            Console.WriteLine("Mala suerte, no has podido adivinar");
                            contador ++;
                    }
                }

            Console.WriteLine("¿Quieres jugar otra vez? (s/n): ");
            char jugarDeNuevo = Console.ReadKey().KeyChar;
            Console.WriteLine();
            switch (jugarDeNuevo)
            {
                case 's':
                case 'S':
                Console.WriteLine("Jugemos una vez mas");
                break;

                case 'n':
                case 'N':
                Console.WriteLine("Nos vemos pa prixima vez");
                reintentar=true;
                break;

                default:
                Console.WriteLine("Digitacion no valida. Cerrando programa");
                jugarDeNuevo = 'n';
                reintentar=true;
                break;
            }
        }
        while(reintentar==false);
    }
}