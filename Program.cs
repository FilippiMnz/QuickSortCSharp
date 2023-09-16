using System;

namespace Quick
{
    class Program
    {
        public static int[] QuickSort(int[] lista)
        {
            QuickSort(lista, 0, lista.Length - 1);
            return lista;
        }

        private static void QuickSort(int[] lista, int inicio, int fim)
        {
            if (inicio < fim)
            {
                int indicePivo = Particao(lista, inicio, fim);

                QuickSort(lista, inicio, indicePivo - 1);
                QuickSort(lista, indicePivo + 1, fim);
            }
        }

        private static int Particao(int[] lista, int inicio, int fim)
        {
            Random random = new Random();
            int randomIndex = random.Next(inicio, fim + 1);
            int pivot = lista[randomIndex];

            Swap(lista, randomIndex, fim);

            int i = inicio;

            for (int j = inicio; j < fim; j++)
            {
                if (lista[j] <= pivot)
                {
                    Swap(lista, i, j);
                    i++;
                }
            }

            Swap(lista, i, fim);

            return i;
        }

        private static void Swap(int[] lista, int i, int j)
        {
            int temp = lista[i];
            lista[i] = lista[j];
            lista[j] = temp;
        }

        static void Main(string[] args)
        {
            int[] array = { 3, 6, 1, 8, 4, 2, 9, 7, 5 };
            Console.WriteLine("Lista antes do QuickSort:");
            Console.WriteLine(string.Join(", ", array));

            QuickSort(array);

            Console.WriteLine("Lista após o QuickSort:");
            Console.WriteLine(string.Join(", ", array));
        }
    }
}