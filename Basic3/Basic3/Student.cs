using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic3
{
    internal class Student //internal은 같은 namespace에서 public
    {

        string _name;

        public string Name { get; set; } //자동생성
        //public string Name //properties 수동생성
        //{
        //    get
        //    {
        //        return _name;
        //    }
        //    set
        //    {
        //        _name = value;
        //    }
        //}
        public Student(string name) {
            _name = name;   
        }

        //public void SetName(string name) { _name = name; } //게터와 세터
        //public string GetName() { return _name; }
        public void Display_Name()
        {
            Console.WriteLine($"학생의 이름 : {_name}");
        }
        public void Student_Age(int age)
        {
            Console.WriteLine($"학생의 이름 : {age}");
        }
    }
}
