using System;


class Program
{
    static void Main()
    {
        int[] array = { 3, 2, 1, 6, 0, 5 };

        int raiz = array[0];
        int raizIndex = 0;

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > raiz)
            {
                raiz = array[i];
                raizIndex = i;
            }
        }

        
        Console.WriteLine("Raiz: " + raiz);

        Console.WriteLine("Galhos da esquerda");
        for (int i = raizIndex = 1; i >= 0; i--)
        {
            Console.WriteLine(array[i]);
        }
        Console.WriteLine("Galhos da direita");
        for (int i = raizIndex + 1;  i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
}
