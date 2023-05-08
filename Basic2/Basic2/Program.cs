using System.Globalization;

namespace Basic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a=0;
            for (int i=1; i<=5;i++)
            {
                for (int j = 5 - i + 1; j > 0; j--) Console.Write(" ");
                Console.Write(" ");
                for (int j = 1; j <= i; j++) {
                    Console.Write(j);
                    a = j;
                }
                for (int k = a-1; k >= 1; k--)
                {
                    Console.Write(k);
                }
                Console.WriteLine("");
                a = 0;
            }
            for (int i = 4; i >= 1; i--)
            {
                for (int j = 5 - i + 2; j > 0; j--) Console.Write(" ");
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                    a = j; 
                }
                for (int k = a - 1; k >= 1; k--)
                {
                    Console.Write(k);
                }
                Console.WriteLine("");
                a = 0;
            }



            //Console.Write("숫자 입력 : ");
            //int i = int.Parse(Console.ReadLine()?? "0");

            //int j = 0;
            //do
            //{
            //    j++;
            //    Console.WriteLine(j);
            //} while (j < i) ;

            //for(int j=0; j < i; j++) { 
            //Console.WriteLine(j);}

            //if(i%2 == 0)
            //{
            //    Console.WriteLine("짝수");
            //}
            //else Console.WriteLine("홀수");


            //double tax = 0;
            //switch(i)
            //{
            //    case <= 10000:
            //        tax = i * 0.05;
            //        break;
            //    case <= 100000:
            //        tax = i * 0.08;
            //        break;
            //    case > 100000:
            //        tax = i * 0.1;
            //        break;
            //    default:
            //        tax = i * 0.05;
            //        break;
            //}
            //Console.WriteLine($"{i}의 세금은 {tax}입니다");
        }
    }
}
