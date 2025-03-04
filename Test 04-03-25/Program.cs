using System.Collections;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace Test_04_03_25
{
    public class Student:IComparable
    {
        public int Roll { get; set; }
        public string Name { get; set; }
        public double TotalMarks { get; set; }
       
    
            public void Show()
        {
            
            Console.WriteLine($"{Name}   {TotalMarks}   {Roll}");
        }
        

        public int CompareTo(object? obj)
        {
            Student S1 = this;
            Student temp = (Student)obj;
            if (temp.TotalMarks < S1.TotalMarks)
            {
                return -1;
            }
            else if (temp.TotalMarks > S1.TotalMarks)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How Many Students Data you want to Enter");
            int n = int.Parse(Console.ReadLine());
            ArrayList student = new ArrayList();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter Roll No, Name, Total marks");
                student.Add(new Student()
                {
                    Roll = int.Parse(Console.ReadLine()),
                    Name = Console.ReadLine(),
                    TotalMarks = double.Parse(Console.ReadLine())

                });
            }
            student.Sort();
            foreach (var item in student)
            {
                Student studentqw = item as Student;
                studentqw.Show();
            }
        }
    }
}
