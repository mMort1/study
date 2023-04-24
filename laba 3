using System; 

 

class Program 

{ 

    static void Main(string[] args) 

    { 

        // масив 

        int[] array = new int[] { 6, 1, 2, 5, 9 }; 

 

        // знаходимо індекси 

        int minIndex = 0; 

        int maxIndex = 0; 

        for (int i = 1; i < array.Length; i++) 

        { 

            if (array[i] < array[minIndex]) 

            { 

                minIndex = i; 

            } 

            if (array[i] > array[maxIndex]) 

            { 

                maxIndex = i; 

            } 

        } 



        // міняємо місцями 

        int temp = array[minIndex]; 

        array[minIndex] = array[maxIndex]; 

        array[maxIndex] = temp; 

 

        //виводимо масив 

        Console.WriteLine(string.Join(" ", array)); 

    } 
