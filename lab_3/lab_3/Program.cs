using System;
using System.Data.Common;
using System.Drawing;

class Ahmed
{
    static void Main()
    {
        #region Example_one

        //Console.WriteLine("enter row size :");
        //int.TryParse(Console.ReadLine(), out int row);
        //Console.WriteLine("enter column size :");
        //int.TryParse(Console.ReadLine(), out int column);
        //int[,] arr = new int[row, column];
        //fill(arr);
        //Console.WriteLine("__________________________________");
        //print(arr);

        #endregion
        #region EXample_two
        //int[] arr = new int[] { 1, 2, 6, 8, 4 };
        //int sum = PrintSum(arr);
        //Console.WriteLine(sum);
        #endregion
        #region Example_three
        //int[,] array2D = new int[5, 3]
        //{
        //    { 1, 2, 5},
        //    { 3, 4, 9},
        //    { 5, 6, 2},
        //    { 7, 8, 5},
        //    {10, 6, 9}
        //};

        //int[] arr = get_arr(array2D);
        //for (int i = 0; i < arr.Length; i++)
        //{
        //    Console.WriteLine(arr[i]);
        //}
        #endregion
        #region matrix
        // int[,] array2D = new int[3, 2];
         int[,] array2D = new int[4, 4]
         {
               { 105, 7 ,9 , 0},
               { 3, 4 ,6 , 0},
               { 5, 6 ,3 , 0},
               { 2, 8 ,2 , 0}
         };


        my_matrix(array2D);

        #endregion

    }

    static void fill( int[,] arr)
    {
        for (int c = 0; c < arr.GetLength(1); c++)
        {
            for (int r = 0; r < arr.GetLength(0); r++)
            {
                Console.WriteLine($"inter the student number : {c} with his grads :{r}");
                int.TryParse(Console.ReadLine(), out arr[r,c]);      
            }
        }
    }
    static void print( int[,]arr)
    {
        for (int c = 0; c < arr.GetLength(1); c++)
        {
            for (int r = 0; r < arr.GetLength(0); r++)
            {
                Console.WriteLine($"details about student grads number : {r}");
                Console.WriteLine(arr[r,c]);
            }
        }
    }




    static int PrintSum(int[] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum+= arr[i];
        }
        return sum;
    }
    static int[] get_arr(int[,] arr)
    {
        int[] result = new int[3] ;
        for (int c = 0; c < arr.GetLength(1); c++)
        {
            for (int r = 0; r < arr.GetLength(0); r++)
            {
                result[c] += arr[r, c]; 
            }
        }
        return result;
    }


    static void my_matrix(int[,] array2D)
    {
    start:
        Console.WriteLine(
            "number (1) to add\n" +
            "number (2) to Edit\n" +
            "number (3) to delete \n" +
            "number (4) to print all data\n" +
            "number (5) to Exit");

        if (int.TryParse(Console.ReadLine(), out int number))
        {
            switch (number)
            {
                case 1:
                    Console.WriteLine("insert specific row To Add");
                    int.TryParse(Console.ReadLine(), out int row);
                    Console.WriteLine("insert specific column To Add");
                    int.TryParse(Console.ReadLine(), out int column);
                    Console.WriteLine("inter your grad : ");
                    int.TryParse(Console.ReadLine(), out int grad);
                    Add(array2D, row, column, grad);
                    break;
                case 2:
                    Console.WriteLine("insert specific row to Edit");
                    int.TryParse(Console.ReadLine(), out int rowToEdit);
                    Console.WriteLine("insert specific column to Edit");
                    int.TryParse(Console.ReadLine(), out int columnToEdit);
                    Console.WriteLine("update your grad : ");
                    int.TryParse(Console.ReadLine(), out int new_grad);
                    Edit(array2D, rowToEdit, columnToEdit, new_grad);
                    break;
                case 3:
                    Console.WriteLine("insert specific row to delete");
                    int.TryParse(Console.ReadLine(), out int rowToDelete);
                    Console.WriteLine("insert specific column to delete");
                    int.TryParse(Console.ReadLine(), out int columnToDelete);
                    delete(array2D, rowToDelete, columnToDelete);
                    break;
                case 4:
                    Display(array2D);
                    break;
                case 5:
                    Console.WriteLine("thanks for you");
                    return;
            }
        }
        else
        {
            Console.WriteLine("invalid value");
            return;
        }
        goto start;
    }





    private static void Display(int[,] arr)
    {
        for (int c = 0; c < arr.GetLength(1); c++)
        {
            for (int r = 0; r < arr.GetLength(0); r++)
            {
                if (arr[r, c] == -1) continue;
                Console.WriteLine($"row ({r}) and column ({c}) =>>>{arr[r, c]}");   
            }
        }
    }
    private static void delete(int[,]arr,int row,int column)
    {
        arr[row,column] = -1;
    }
    private static void Edit(int[,]arr,int row,int column,int new_grad)
    {
        for (int c = 0; c < arr.GetLength(1); c++)
        {
            for (int r = 0; r < arr.GetLength(1); r++)
            {
                arr[row, column] = new_grad;
               
            }
        }
    }
    private static void Add(int[,]arr,int row,int column,int current_grad)
    {
        for (int c = 0; c < arr.GetLength(1); c++)
        {
            for (int r = 0; r < arr.GetLength(1); r++)
            {               
                   arr[row, column] = current_grad;
            }
        }
    }

}
