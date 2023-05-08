using Microsoft.VisualBasic;
using System.Globalization;

namespace Basic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int row = 5; int col = 9; //가로세로 구성
            int mid = col / 2; //가운데 인덱스 설정

            for(int i = 0; i < row; i++)
            {
                for(int j = 0; j < col; j++)
                {
                    if (Math.Abs(j - mid) <= i)
                    {
                        Console.Write(i + 1 - Math.Abs(j - mid));
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            for (int i = row-2; i >= 0; i--)
            {
                for (int j = 0; j < col; j++)
                {
                    if (Math.Abs(j - mid) <= i)
                    {
                        Console.Write(i + 1 - Math.Abs(j - mid));
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            for(int i = 1; i < 6; i++)
            {
                for(int j = 1; j < i + 1; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }


            //int[] ints = { 4, 6, 1, 3, 5, 9, 2, 7, 8};
            //foreach (int i in ints)
            //{
            //    Console.Write(i);
            //}
            //Array.Sort(ints);
            //Console.WriteLine();
            //foreach (int i in ints) {
            //    Console.Write(i);
            //}

            //string[,] BooksArry = new string[3, 3];
            //BooksArry[0, 0] = "C#";
            //BooksArry[0, 1] = "Java";
            //BooksArry[0, 2] = "C++";
            //BooksArry[1, 0] = "Vb.net";
            //BooksArry[1, 1] = "C#.net";
            //BooksArry[1, 2] = "XML";
            //BooksArry[2, 0] = "HTML";
            //BooksArry[2, 1] = "Java";
            //BooksArry[2, 2] = "C++";

            //string[] books = {"C#","java","vb.net","c","c++"};
            //string[] booksArr = new string[5];
            //booksArr[0] = "C#";
            //booksArr[1] = "java";
            //booksArr[2] = "vb.net";
            //booksArr[3] = "C";
            //booksArr[4] = "C++";
            //Console.WriteLine(booksArr);

            //foreach (string book in booksArr)
            //{
            //    Console.WriteLine(book);
            //}
            //Console.Write(booksArr.ToString());


            //int a=0;
            //for (int i=1; i<=5;i++)
            //{
            //    for (int j = 5 - i + 1; j > 0; j--) Console.Write(" ");
            //    Console.Write(" ");
            //    for (int j = 1; j <= i; j++) {
            //        Console.Write(j);
            //        a = j;
            //    }
            //    for (int k = a-1; k >= 1; k--)
            //    {
            //        Console.Write(k);
            //    }
            //    Console.WriteLine("");
            //    a = 0;
            //}
            //for (int i = 4; i >= 1; i--)
            //{
            //    for (int j = 5 - i + 2; j > 0; j--) Console.Write(" ");
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(j);
            //        a = j; 
            //    }
            //    for (int k = a - 1; k >= 1; k--)
            //    {
            //        Console.Write(k);
            //    }
            //    Console.WriteLine("");
            //    a = 0;
            //}

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
