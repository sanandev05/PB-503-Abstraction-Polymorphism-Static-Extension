using System.Text.RegularExpressions;

namespace PB_503_Abstraction__Polymorphism__Static__Extension
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Fullname, Email, Password="Fs1233456";
            
            Console.Write("Please enter your new Fullname ,Email,Password. \nFullname:");
            Fullname = Console.ReadLine();

            Console.Write("\nEmail:");
            Email = Console.ReadLine();
            Console.Write("\nWrite  Password:");
            Password = Console.ReadLine();
            User user = new User(Email, Password);      
            while (!user.PasswordChecker(Password))
            {
                Console.Write("\nWrite Valid Password:");
                Password = Console.ReadLine();
            }
            user.Password = Password;
            user.Fullname = Fullname;
            Console.WriteLine("New User created successfully!\n1.Show info\n2.Create new group");

            int input=-1;
            string GroupNo = "";
            int StudentLimit = 0;
            while (input != 0)
            {
                
                Console.WriteLine("1.Show info\n2.Create new group");
               input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        user.ShowInfo();
                        break;
                    case 2:
                        Console.Write("\nStudent Limit:");
                        StudentLimit = int.Parse(Console.ReadLine());

                        Console.Write("\nWrite  GroupNo:");
                        GroupNo = Console.ReadLine();
                        Group group = new Group(GroupNo, StudentLimit);
                        while (!group.CheckGroupNo(GroupNo))
                        {
                            Console.Write("\nWrite Valid GroupNo:");
                            GroupNo = Console.ReadLine();
                        }
                        group.GroupNo = GroupNo;
                        
                        Console.WriteLine($"Group {group.GroupNo} has successfully created !");
                    
                        input = 0;
                        GroupCreating(group);
                        break;
                }
            }
                 
            
           
        }
        private static void GroupCreating(Group group)
        {
            int input2 = 1;
            while (input2 != 0)
            {
            Console.WriteLine("\n1. Show all students\n2. Get student by id\n 3. Add student\n n0. Quit");
             input2 = int.Parse(Console.ReadLine());
                switch (input2)
                {
                    case 1:
                    Student[] std = group.GetAllStudents();
                        foreach (Student item in std )
                        {
                            item.StudentInfo();
                        }
                        break;
                    case 2:
                        Console.Write("\nWrite ID:");
                        string id = Console.ReadLine();
                        group.GetStudent(int.Parse(id)).StudentInfo();
                        break;
                    case 3:
                        Console.WriteLine("\nNEW STUDENT'S INFO:");
                        string Name;
                        double Point;

                        Console.Write("Full Name:");
                        Name = Console.ReadLine();

                        Console.Write("Point :");
                        Point = double.Parse(Console.ReadLine());

                        Student student = new Student(Name, Point);
                        group.AddStudent(student);

                        Console.WriteLine($"\nStudent {Name} successfully created.");
                        break;
                    case 4:
                        break;
                }
            }
        }
    }
}
