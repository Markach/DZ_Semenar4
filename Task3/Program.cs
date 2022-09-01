// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
Random rd = new Random();
int[] array = new int[8];
 Console.Write("[");
 void PrintArray(int[] arr)
 {
  
    for (int i = 0; i < 8; i++)
    {
        array[i] = rd.Next(1,100);
    
        if(i!=7) Console.Write( array[i]+ ", " );
        else Console.Write(  array[i]  );
    }
    Console.Write("]");
  }
 PrintArray(array);




