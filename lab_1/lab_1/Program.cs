using System;

namespace lab_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Example_1
            //Console.WriteLine("Hello world");
            #endregion
            #region example_2
            //Console.WriteLine("insert your number");
            //if (int.TryParse(Console.ReadLine(), out var num))
            //{
            //    Console.WriteLine($"{3.14 * num * num}cm²");
            //}
            //else
            //{
            //    Console.WriteLine("invalid value");
            //}

            #endregion
            #region Example_3
            //Console.WriteLine("insert your first number");
            //float.TryParse(Console.ReadLine(), out float number_1);
            //Console.WriteLine("insert your second number");
            //float.TryParse(Console.ReadLine(), out float number_2);

            //Console.WriteLine($"{number_1} + {number_2} = ({number_1 + number_2})");
            //Console.WriteLine($"{number_1} - {number_2} = ({number_1 - number_2})");
            //Console.WriteLine($"{number_1} * {number_2} = ({number_1 * number_2})");
            //if (number_2 != 0)
            //{
            //    Console.WriteLine($"{number_1} / {number_2} = ({number_1 / number_2})");
            //}
            //else
            //{
            //    Console.WriteLine($"{number_1} / {number_2} =>> can't divide by zero");
            //}
            #endregion
            #region EXample_4
            //Console.WriteLine("insert a character ");
            //if (char.TryParse(Console.ReadLine(), out char Character))
            //{
            //    int asci_code=Character;
            //    Console.WriteLine(asci_code);
            //}
            //else
            //{
            //    Console.WriteLine("invalid value");
            //}
            #endregion
            #region Example_5    
            //Console.WriteLine("insert your number");          
            //int.TryParse(Console.ReadLine(), out int num);
            //if (num % 2 == 0 && num != 0)
            //{
            //    Console.WriteLine("Even Number");
            //}
            //else if (num % 2 != 0)
            //{
            //    Console.WriteLine("Odd Number");
            //}
            //else
            //{
            //    Console.WriteLine("Zero");
            //}
            #endregion
            #region Example_6
            //Console.WriteLine("insert the student grad");
            //if (float.TryParse(Console.ReadLine(), out float grad))
            //{
            //    if (grad < 60)
            //    {
            //        Console.WriteLine("F");
            //    }
            //    else if (grad >= 60 && grad < 70)
            //    {
            //        Console.WriteLine("D");
            //    }
            //    else if (grad >= 70 && grad < 80)
            //    {
            //        Console.WriteLine("C");
            //    }
            //    else if (grad >= 80 && grad < 90)
            //    {
            //        Console.WriteLine("B");
            //    }
            //    else
            //    {
            //        Console.WriteLine("A");
            //    }

            //}
            //else
            //{
            //    Console.WriteLine("invalid value");
            //}
            #endregion
            #region Example_7
            //Console.WriteLine("insert your number to show menu");
            //if (int.TryParse(Console.ReadLine(), out int num))
            //{
            //    switch (num)
            //    {
            //        case 1:
            //            Console.WriteLine("Add");
            //            break;
            //        case 2:
            //            Console.WriteLine("Edit");
            //            break;
            //        case 3:
            //            Console.WriteLine("Display");
            //            break;
            //        case 4:
            //            Console.WriteLine("Exit");
            //            break;
            //        default:
            //            Console.WriteLine("invalid value");
            //            break;
            //    }
            //}
            #endregion
            #region Example_8   
            Console.WriteLine("Enter first number");
            float.TryParse(Console.ReadLine(), out float number_1);
            Console.WriteLine("Enter Operator");
            char.TryParse(Console.ReadLine(), out char operate);
            Console.WriteLine("Enter Second number");
            float.TryParse(Console.ReadLine(), out float number_2);

            if (operate == '+')
            {
                Console.WriteLine($"{number_1} + {number_2} = ({number_1 + number_2})");
            }
            else if (operate == '-')
            {
                Console.WriteLine($"{number_1} - {number_2} = ({number_1 - number_2})");
            }
            else if (operate == '*')
            {
                Console.WriteLine($"{number_1} * {number_2} = ({number_1 * number_2})");
            }
            else if (operate == '/')
            {
                if (number_2 == 0)
                {
                    Console.WriteLine("cannot divide by zero");
                }

                else
                {
                    Console.WriteLine($"{number_1} / {number_2} = ({number_1 / number_2})");

                }
            }
            else
            {
                Console.WriteLine("invalid operation");
            }
            #endregion




        }
        
    }
}