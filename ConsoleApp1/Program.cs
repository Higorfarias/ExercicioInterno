using System;

class ArrayTest
{
    static void Main()
    {
        //  CENÁRIO 1 
        int[] array1 = { 3, 2, 1, 6, 0, 5 };
        Console.WriteLine("CENÁRIO 1:");
        ProcessarArray(array1);

        //  CENÁRIO 2 
        int[] array2 = { 7, 5, 13, 9, 1, 6, 4 };
        Console.WriteLine("\nCENÁRIO 2:");
        ProcessarArray(array2);
    }

    static void ProcessarArray(int[] array)
    {
        int raiz = array[0];
        int raizIndex = 0;

        // pega a raiz de maior valor
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > raiz)
            {
                raiz = array[i];
                raizIndex = i;
            }
        }

        Console.WriteLine("Raiz: " + raiz);

       
        int[] esquerda = new int[raizIndex];
        Array.Copy(array, 0, esquerda, 0, raizIndex);
        Array.Sort(esquerda);
        Array.Reverse(esquerda);

        Console.WriteLine("Galhos da Esquerda:");
        foreach (int num in esquerda)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        int[] direita = new int[array.Length - raizIndex - 1];
        Array.Copy(array, raizIndex + 1, direita, 0, direita.Length);
        Array.Sort(direita);
        Array.Reverse(direita);

        Console.WriteLine("Galhos da Direita:");
        foreach (int num in direita)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
