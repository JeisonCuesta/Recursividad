using System;

namespace TorresC
{
    class Program
    {
        static void Main(string[] args){
         hanoi ha = new hanoi();

            byte discos = 0;
            Console.WriteLine("INGRESE EL NUMERO DE DISCOS DE LAS TORRES HANOI...");
            discos = Convert.ToByte(Console.ReadLine());
            ha.mover(discos, 1, 2, 3);
            Console.WriteLine("\n FIN DEL JUEGO");

        }
    }

    class hanoi
    {
        public void mover(int num, int inicio, int temporal, int fin)
        {
            if (num == 1)
            {
                Console.WriteLine("Se mueve el disco de la torre (" + inicio + ") a la torre (" + fin + ")");
            }
            else
            {
                mover(num - 1, inicio, fin, temporal);
                Console.WriteLine("Se mueve el disco de la torre (" + inicio + ") a la torre (" + fin + ")");
                mover(num - 1, temporal, inicio, fin);
            }
        }
    }
}

