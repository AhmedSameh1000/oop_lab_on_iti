using System;
class Ahmed
{
    static void Main()
    {
        #region Example_1
        //if (int.TryParse(Console.ReadLine(), out int num))
        //{
        //    for (int i = 0; i <= 100; i++)
        //    {
        //        Console.WriteLine(num * (i + 2));
        //    }
        //}
        //else
        //{
        //    Console.WriteLine("invalid value");
        //}
        #endregion

        #region Example_2
        //int sum = 1;
        //int flag = 0;
        //for (int i = 0; i < 10; i++)
        //{
        //    if (int.TryParse(Console.ReadLine(), out int num_1))
        //    {
        //        sum *= num_1;
        //    }
        //    else
        //    {

        //        flag = 1;
        //        break;
        //    }
        //}
        //if (flag is 1)
        //{
        //    Console.WriteLine("invalid value");
        //}
        //else
        //{
        //    Console.WriteLine(sum);
        //}


        #endregion

        #region Example_3
        //for (int i = 0; i <= 255; i++)
        //{
        //    Console.WriteLine($"{(char)i} {i}");
        //}
        #endregion
        #region Example_4
        //int sum = 0;
        //int flag = 0;
        //for (int i = 0; i <= 100; i++)
        //{
        //    if (int.TryParse(Console.ReadLine(), out int num))
        //    {
        //        sum += num;
        //        if (sum > 100)
        //        {
        //            Console.WriteLine(sum);
        //            break;
        //        }
        //    }
        //    else
        //    {
        //        flag = 1;
        //        break;
        //    }
        //}
        //if (flag == 1)
        //{
        //    Console.WriteLine("invalid value");
        //}

        #endregion

        #region Example_5
        //char a = ' ';
        //while (a != 'x')
        //{
        //    char.TryParse(Console.ReadLine(), out a);
        //    Console.WriteLine((int)a);
        //}
        #endregion
        #region Example_6
        //int num = 0;
        //do
        //{
        //    Console.WriteLine("insert your number to show menu");
        //    if (int.TryParse(Console.ReadLine(), out num))
        //    {
        //        switch (num)
        //        {
        //            case 1:
        //                Console.WriteLine("Add");
        //                break;
        //            case 2:
        //                Console.WriteLine("Edit");
        //                break;
        //            case 3:
        //                Console.WriteLine("Display");
        //                break;
        //            case 4:
        //                Console.WriteLine("Exit");
        //                return;
        //        }
        //    }
        //}
        //while (true);
        #endregion
        #region Example_7
        //int[] grads = new int[4];
        //int count = 0;
        //float avg = 0;
        //int greater = 0;
        //int is_passed = 50;
        //for (int i = 0; i < grads.Length; i++)
        //{
        //    Console.WriteLine($"inter your grad of subject : {i + 1}");
        //    int.TryParse(Console.ReadLine(), out grads[i]);
        //    if (greater < grads[i])
        //    {
        //        greater = grads[i];
        //    }
        //    count += grads[i];
        //}
        //avg = count / grads.Length;

        //Console.WriteLine($"greater grad of subjects is {greater}");
        //Console.WriteLine($"the average is {avg}");
        //if (count > is_passed)
        //{
        //    Console.WriteLine("the student is Success ");
        //}
        //else
        //{
        //    Console.WriteLine("the student is Failed");
        //}
        #endregion
        #region Example_8
        #region sol_1
        //int[] oldArray = new int[] { 6, 1, 2, 3, 4, 5 };
      
        //int element = oldArray[0];

        //for (int i = 0; i < oldArray.Length - 1; i++)
        //{
        //    oldArray[i] = oldArray[i + 1];
        //}
        //oldArray[oldArray.Length - 1] = element;
        //for (int j = 0; j < oldArray.Length; j++)
        //{
        //    Console.WriteLine($"index {j}>> {oldArray[j]}");
        //}

        #region MyRegion
        //int[] oldArray = new int[] { 6, 1, 2, 3, 4, 5 };
        //int.TryParse(Console.ReadLine(), out int i);
        //int element = oldArray[i];

        //for (; i < oldArray.Length - 1; i++)
        //{
        //    oldArray[i] = oldArray[i + 1];
        //}
        //Console.WriteLine("___________________");
        //if (i == oldArray.Length - 1)
        //{
        //    oldArray[oldArray.Length - 1] = element;
        //}
        //for (int j = 0; j < oldArray.Length; j++)
        //{
        //    Console.WriteLine($"index {j}>> {oldArray[j]}");
        //}

        #endregion
        #endregion
        #region Another_solution
        //int[] oldArray = new int[] { 6, 1, 2, 3, 4, 5 };
        //int[] newArray = new int[oldArray.Length];
        //int ele = oldArray[0];
        //for (int i = 0; i < oldArray.Length; i++)
        //{
        //    Console.WriteLine($"index {i}>> {oldArray[i]}");

        //}
        //Console.WriteLine("___________________");
        ////  newArray[newArray.Length - 1] = ele;

        //Array.Copy(oldArray, 1, newArray, 0, oldArray.Length - 1);
        //for (int i = 0; i < newArray.Length; i++)
        //{
        //    Console.WriteLine($"index {i}>> {newArray[i]}");

        //}
        #endregion

        #region MyRegion
        //int[] oldArray = new int[] { 6, 20, 5, 9, 10, 44 };
        //int[] newArray = new int[oldArray.Length];

        //int.TryParse(Console.ReadLine(), out int i);
        //int element = 0;

        //if (i >= 0 && i < oldArray.Length - 1)
        //{
        //    element = oldArray[i];
        //    for (; i < newArray.Length - 1; i++)
        //    {

        //        oldArray[i] = oldArray[i + 1];
        //    }
        //    if (i == oldArray.Length - 1)
        //    {
        //        oldArray[oldArray.Length - 1] = element;
        //    }
        //}


        //Console.WriteLine("___________________");

        //newArray[oldArray.Length - 1] = element;
        //for (int j = 0; j < oldArray.Length; j++)
        //{
        //    Console.WriteLine($"index {i}>> {oldArray[j]}");
        //}
        #endregion

        #endregion
    
        int[] oldArray = new int[] { 6, 1, 2, 3, 4, 5 };
        delete(oldArray, 0);
        for (int i = 0; i < oldArray.Length; i++)
        {
            Console.WriteLine(oldArray[i]);
        }
    }
   
    static void delete(int[] arr, int index)
    {
         for (; index < arr.Length - 1; index++)
         {
             arr[index] = arr[index + 1];
         }
        arr[arr.Length - 1] = 0;
    }
}