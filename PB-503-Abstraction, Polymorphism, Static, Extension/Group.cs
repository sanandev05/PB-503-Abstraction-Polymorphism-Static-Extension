using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PB_503_Abstraction__Polymorphism__Static__Extension
{
    public class Group
    {
         int _studentLimit;
        public string GroupNo { get; set; }
        public int StudentLimit
        { 
            get => _studentLimit;
            set
            {
                if (value > 4 && value < 19)
                {
                    _studentLimit = value;
                }
                
            } 
        }
        private Student[] Students = new Student[0];
        public bool CheckGroupNo(string groupNo)
        {
            if (groupNo.Length <= 5)
            {
                if (char.IsLetter(groupNo[0]) && char.IsLetter(groupNo[1])&& char.IsDigit(groupNo[2]) && char.IsDigit(groupNo[3])&& char.IsDigit(groupNo[4]))
                {
                    return true;
                }else return false;
            } else return false;
        }
        public Group(string groupNo,int limit)
        {
            GroupNo = groupNo;
            StudentLimit = limit;
        }
        public void AddStudent(Student student)
        {
               Array.Resize(ref Students, Students.Length + 1);
           
                if (Students.Length <= StudentLimit)
                {
                    Students[Students.Length - 1] = student;
                }
                else Console.WriteLine("Stundent length was reached the limit");
            
        }
        public Student GetStudent(int? id)
        {
            Student getStudent=null;
            if (id.HasValue)
            {
                foreach (Student student in Students)
                {
                    if (id == student.Id)
                    {
                        getStudent = student;
                    }
                }      
            }
            else { Console.WriteLine("Dont write null variable"); }
            return getStudent;
        }
        public Student[] GetAllStudents()
        {
            return Students;
        }
    }
}
