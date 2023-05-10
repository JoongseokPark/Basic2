using Basic3;

namespace Basic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("학생 이름 입력");
            string name = Console.ReadLine() ?? string.Empty;
            Student student = new Student(name);

            student.Display_Name();
            student.Name = "JS";
            Console.WriteLine(student.Name);
            //Console.WriteLine("학생 나이 입력");
            //int age = int.Parse(Console.ReadLine() ?? string.Empty);
            //student.Student_Name(name);
            //student.Student_Age(age);

            //int x = 10;
            //int y = 45;
            ////Program pg = new(); //Program 클래스 pg 생성
            ////int result = pg.Add(x, y);
            //int result = Add(x, y);
            //Console.WriteLine(result);
            //result = Sub(x, y);
            //Console.WriteLine(result);
            //result = Mul(x, y);
            //Console.WriteLine(result);
            //result = Div(x, y);
            //Console.WriteLine(result);
        }
        //private static int Add(int a, int b)
        //{
        //    return a + b;
        //}
        //private static int Sub(int a, int b)
        //{
        //    return a - b;
        //}
        //private static int Mul(int a, int b)
        //{
        //    return a * b;
        //}
        //private static int Div(int a, int b)
        //{
        //    return a / b;
        //}
    }
    
}