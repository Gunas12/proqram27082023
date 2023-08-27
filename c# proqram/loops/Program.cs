namespace loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Verilmiş n tam ədədinin sadə və ya mürəkkəb ədəd olduğunu tapın
            //int n = 1000003;
            //if (n == 0 || n == 1)
            //{
            //    Console.WriteLine("eded ne sadedir ne murekkeb");
            //}
            //if (n == 2)
            //{
            //    Console.WriteLine("sadedir");
            //}
            //for (int i = 2; i*i <= n; i++)
            //{
            //    if (n % i == 0)
            //    {
            //        Console.WriteLine("eded murekkeb");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("eded sadedir");
            //        break;
            //    }
            //}




            //1-dən N-ə qədər 3 və 5-ə bölünən ədədləri ekrana yazdırin.
            //int n = 199;
            //for (int i = 1; i < n; i++)
            //{
            //    //if (i % 3==0 && i % 5 == 0)
            //    if (i % 15 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}



            //Verilmiş n tam ədədinin neçə mərtəbəli olduğunu tapın.
            int n = 17576;
            int d = 0;
            while (n > 0)
            {
                n = n / 10;
                d++;
            }
            Console.WriteLine(d);
        }
    }
    }
