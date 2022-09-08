using System;
	

	class Program
	{
	    static void PrintArray(string[] matr)
	    {
	      for (int i = 0; i < matr.Length; i++)
	        {
	            Console.Write($"{matr[i]} ");
	        }
	        Console.WriteLine();
	    }
	    
	  
	    static void ChangeArray(string[] matr, string[] matr2)
	    {
        int j=0;
	      for (int i = 0; i < matr.Length; i++)
	        {
            if (matr[i].Length < 4)
            {
               matr2[j] = matr[i];
              j++;
            }
	        }
	    }
	  
	    static void Main(string[] args)
	    {
	        Console.Write("Введите размерность массива: ");
	        int m = Convert.ToInt32(Console.ReadLine());
          int n = m;
	        string [] array = new string[m];
          string [] array2 = new string[n];
          for (int i = 0; i < m; i++)
	        {
	            Console.Write($"Введите {i} строку массива:");
              array[i]=Convert.ToString(Console.ReadLine());
	        }
	        Console.WriteLine();
	        Console.WriteLine("");
	        Console.WriteLine("Заданный массив: ");
	        PrintArray(array);
        	Console.WriteLine();
	        Console.WriteLine("");
          ChangeArray(array,array2);
        	Console.WriteLine("Итоговый массив: ");
	        PrintArray(array2);
	    }
	  
	}
