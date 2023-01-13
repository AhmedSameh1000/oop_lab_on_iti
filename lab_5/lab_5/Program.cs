using System;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction(1, 3);
        Fraction f2 = new Fraction(3, 9);
        Fraction f3 = new Fraction(5, 4);
        Fraction f4 = new Fraction(9, 1);
        Fraction f5 = new Fraction(7, 3);
        Fraction f6 = new Fraction(7, 3);
        //--------------Total fractions------------------------------------
        Fraction f_sum_fraction_with_Two_fraction = f1 + f2;
        Fraction f_sum_fraction_with_number = f3 + 7;
        Fraction f_sum_number_with_fraction = 9 + f4;
        Fraction f_pre_increment_operator = ++f5;
        Fraction f_Post_decrement_operator = f6++;
        //------------------------------------------------------------------
        Fraction[] All_Fractions = new Fraction[]
        {
          f_sum_fraction_with_Two_fraction,
          f_sum_fraction_with_number,
          f_sum_number_with_fraction,
          f_pre_increment_operator,
          f_Post_decrement_operator
        };
        //------------------------------------------------------------------
        for (int i = 0; i < All_Fractions.Length; i++)
        {
            //Console.WriteLine(All_Fractions[i].ToString());
             All_Fractions[i].print();
            Console.WriteLine("-----------------------------------------");
        }
        //------------------------------------------------------------------
        bool f_fractions_comparing = f1 == f2;
        Console.WriteLine(f_fractions_comparing);
        //-------------------------------------------------------------------

    }
}





























class Fraction
{
    public float numerator;
    public float denominotor;

    public Fraction(int numerator=0, int denominotor=0)
    {
        this.numerator = numerator;
        this.denominotor = denominotor;
    }

    public Fraction(Fraction fraction)
    {
        this.numerator = fraction.numerator;
        this.denominotor= fraction.denominotor;
    }
    //public Fraction(){ }

    public static Fraction operator +(Fraction f1, Fraction f2)
    {
        Fraction fre = new Fraction();

        if (f1.denominotor == f2.denominotor)
        {
            fre.numerator = f1.numerator + f2.numerator;
            fre.denominotor = f1.denominotor = f2.denominotor;
        }
        else
        {
            if (f2.denominotor != f1.denominotor && f2.denominotor > f1.denominotor && f2.denominotor % f1.denominotor == 0)
            {
                float result = f2.denominotor / f1.denominotor;
                f1.numerator = f1.numerator * result;
                f1.denominotor = f1.denominotor * result;

                fre.numerator = f1.numerator + f2.numerator;
                fre.denominotor = f1.denominotor = f2.denominotor;
            }
            else
            {
                f1.numerator = f1.numerator * f2.denominotor;
                f2.numerator = f2.numerator * f1.denominotor;

                fre.numerator = f1.numerator + f2.numerator;
                fre.denominotor = f1.denominotor * f2.denominotor;
            }

        }

        return fre;

    }

    public static Fraction operator +(Fraction f1,int number)
    {
        Fraction fre=new Fraction();
        fre.denominotor=f1.denominotor;
        fre.numerator = (f1.denominotor * number) + f1.numerator;
        return fre;
    }
    public static Fraction operator +(int number, Fraction f1)
    {
        Fraction fre = new Fraction();
        fre.denominotor = f1.denominotor;
        fre.numerator = (f1.denominotor * number) + f1.numerator;
        return fre;
    }


    public static Fraction operator++(Fraction f1)
    {
        Fraction fre = new Fraction();
        fre.denominotor = f1.denominotor;
        fre.numerator = (f1.denominotor * 1) + f1.numerator;
        return fre;
    }


    public static bool operator==(Fraction f1, Fraction f2)
    {
        if (f1.denominotor == f2.denominotor)
        {
            return f1.numerator == f2.numerator;
        }
        else
        {
            return (f1.numerator * f2.denominotor) == (f1.denominotor * f2.numerator);
        }

    }
    public static bool operator !=(Fraction f1, Fraction f2)
    {
        return !(f1 == f2);
    }
    public void print()
    {
        Console.WriteLine($"{numerator}/{denominotor}");
    }
    public override string ToString()
    {
        return $"{numerator}/{denominotor}"; ;
    }
}
