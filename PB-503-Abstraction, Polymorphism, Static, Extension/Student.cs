using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PB_503_Abstraction__Polymorphism__Static__Extension
{
    public class Student
    {
         double _point;
        public string Fullname { get; set; }
        public readonly int Id;
        public double Point { get => _point; set { if (value >= 0) _point = value; } }
        //
        //Summary:You must fill the Fullname and Point
        //
        public Student(string Fullname,double point)
        {
            this.Fullname = Fullname;
            Point = point;
            Id++;
        }
        public void StudentInfo()
        {
            Console.WriteLine($"STUDENT INFO:\nFullname:{Fullname} \nId:{Id} \nPoint:{Fullname}");
        }
    }
}
