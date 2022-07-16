using System;

namespace T05Ejercicio21
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("¿Qué tamaño tendrá el array?: ");
            int longitud = Convert.ToInt32(Console.ReadLine());
            int[] arrayA = new int[longitud];
            ValoresRandom(arrayA);

            int[] ceroNueve = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            bool exit = false;
            int digito = 10;

            while (!exit)
            {
                try
                {
                    Console.WriteLine("¿Qué último dígito te interesa (0-9)?: ");
                    digito = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {                    
                }

                for (int i = 0; i < ceroNueve.Length; i++)
                {
                    if (ceroNueve[i] == digito)
                        exit = true;
                }
                if (!exit)
                {
                    Console.WriteLine("Error. No ha escrito un número entero entre 0 y 9");
                }
            }
            //No he sabido crear un array con extensión indeterminada que por un
            //lado me lo aceptara el método NuevoArray y que no me diera error en
            //NuevoArray al superar el tamaño del arrayB.
            int[] arrayB = new int[longitud];
            NuevoArray(arrayA, arrayB, digito);
            MostrarArray(arrayB);
        }

        static void MostrarArray(int[] arrayB)
        {
            Console.WriteLine();
            for(int i=0; i < arrayB.Length; i++)
            {
                if (arrayB[i] != 0)
                {
                    Console.WriteLine(arrayB[i]);
                }
            }
        }

        static void NuevoArray (int[] arrayA, int[] arrayB, int digito)
        {
            int x = 0;
            for (int i = 0; i < arrayA.Length; i++)
            {
                if (arrayA[i]%10 == digito)
                {
                    arrayB[x] = arrayA[i];
                    x++;
                }
            }
        }
      
        static void ValoresRandom(int[] arrayA)
        {
            for (int i = 0; i < arrayA.Length; i++)
            {
                arrayA[i] = GenerarRandom();
            }
        }

        private static int GenerarRandom()
        {
            Random rnd = new Random();
            int aleatorio = rnd.Next(1, 300);
            return aleatorio;
        }
    }
}

