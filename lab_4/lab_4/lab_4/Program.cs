using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
class Program
{
    static void Main()
    {
        Student student = new Student
        {
            Name = "ahmed",
            Age = 22,
            Adress = "alexandria",
            array_of_grade = new int[] { 4, 58, 9, 8, 7, 4, 8, 636, 3, 21, 8 },
            pasword = "Ahmeds14@1000"
        };
        try
        {
            student.Forget_password("ahmed22");
            Console.WriteLine("________________________________________");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        Console.WriteLine("______________________________________________");


        for (int i = 0; i < student.array_of_grade.Length; i++)
        {
            Console.WriteLine($"your grad number {i + 1} = ({student.array_of_grade[i]})");
        }
        Console.WriteLine("_______________________________________________");
        Console.WriteLine($"your new password is {student.pasword}");

    }
}
class Student
{

    private Regex regular = new Regex("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[@$!%*#?&])[A-Za-z\\d@$!%*#?&]{8,}$");

    private string _name = "";
    private string _password;
    private int _age = 0;
    private string UserName
    {
        get 
        {
            return $"{_name}{_age}";
        }
    }




    public string Name
    {
        set
        {
            if (value.Length >= 5)
            {
                _name = value;
            }
        }
        get { return _name; }
    }

    public int Age
    {
        get { return _age; }
        set
        {
            if (value > 20)
            {
                _age = value;
            }
        }
    }

    public string Adress { get; set; } = "";

    public int[] array_of_grade { get; set; }

    public string pasword
    {
        init
        {
            if (regular.IsMatch(value) == true && value.Length > 8)
            {
                _password = value;
            }
        }
        get { return _password; }
    }


    public void Forget_password(string user_naem)
    {
        if (user_naem == UserName)
        {
            Console.WriteLine("insert your new password");
            string new_password = Console.ReadLine()!;
            if (regular.IsMatch(new_password)==true && new_password.Length > 8)
            {
                _password= new_password;
                Console.WriteLine("your password has been successfully changed");
            }
            else
            {
                Console.WriteLine("the password you try to insert it not valid");
            }
        }
        else
        {
            throw new Exception("invalid User Name please try again later");
        }
    }
   
}