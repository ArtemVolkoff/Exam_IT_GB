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
	    
	  
	    static void ChangeArray(string[] matr)
	    {
	      for (int i = 0; i < matr.Length; i++)
	        {
	          if (matr[i].Length > 3)
            {
               matr[i] = matr[i].Substring(0, 3);
            }
	        }
	    }
	  
	    static void Main(string[] args)
	    {
	        Console.Write("Введите размерность массива: ");
	        int m = Convert.ToInt32(Console.ReadLine());
	        string [] array = new string[m];
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
          ChangeArray(array);
        	Console.WriteLine("Итоговый массив: ");
	        PrintArray(array);
	    }
	  
	}
