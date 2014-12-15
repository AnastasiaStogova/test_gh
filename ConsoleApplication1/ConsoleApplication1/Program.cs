using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Student
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public double Rating { get; set; }

        public Student()
        {

        }
        public Student(string tname, DateTime tbirthday, double trating)
        {
            tname = Name;
            tbirthday = Birthday;
            trating = Rating;
        }

        private string RandomString(int size, Random rand)
        {
            StringBuilder builder = new StringBuilder();
            char c;
            for (int i = 0; i < size; i++)
            {
                c = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * rand.NextDouble() + 65)));
                builder.Append(c);
            }
            return builder.ToString();
        }

        public void Generate(Random rand)
        {
            Rating = rand.NextDouble() * 40 + 60;
            Birthday = new DateTime(rand.Next(10) + 1990, rand.Next(12) + 1, rand.Next(27) + 1);
            Name = RandomString(rand.Next(4) + 4, rand);
        }

        public void Print()
        {
            Console.WriteLine("{0} | {1} | {2:0.0}", Name, Birthday.ToString("dd/MM/yyyy"), Rating);
        }
    }
    class Program
    {
        static void Generate(ref List<Student> students, int count)
        {
            Random rand = new Random();
            for (int i = 0; i < count; i++)
            {
                Student s = new Student();
                s.Generate(rand);
                students.Add(s);
            }
        }
        static void Print(string message, IEnumerable<Student> array)
        {
            Console.WriteLine();
            Console.WriteLine("{0} ({1}):", message, array.Count());

            foreach (Student s in array)
            {
                s.Print();
            }

        }

        static void Task1_SQL(List<Student> array)
        {
            var temp = from s in array
                       where s.Birthday.Year >= 1996
                       orderby s.Rating descending, s.Name
                       select s;

            Print("Task1_SQL", temp);
        }

        static void Task1(List<Student> array)
        {
            var temp = array.Where(s => s.Birthday.Year >= 1996).OrderByDescending(s => s.Rating).ThenBy(s => s.Name).ToList();

            Print("Task1", temp);

            Console.WriteLine("First:");
            temp.First().Print();
            Console.WriteLine("Last:");
            temp.Last().Print();
            Console.WriteLine("Count:");
            Console.WriteLine(temp.Count());

        }

        static void Task2_SQL(List<Student> array)
        {
            Console.WriteLine();
            Console.WriteLine("Task2 SQL");

            var groups = from s in array
                         group s by s.Name[0] into g
                         select g;

            foreach (var g in groups)
            {
                Console.WriteLine("Group ({0}) size: {1}", g.Key, g.Count());
                foreach (var s in g)
                    s.Print();
                //hdflgsleg
                //drjh

                //ljkfghie
            }
        }

        static void Task2(List<Student> array)
        {
            Console.WriteLine();
            Console.WriteLine("Task2");

            var groups = array.GroupBy(s => s.Name[0]);

            foreach (var g in groups)
            {
                Console.WriteLine("Group ({0}) size: {1}", g.Key, g.Count());
                foreach (var s in g)
                    s.Print();
            }
        }
        static void Task3(List<Student> array)
        {
            Console.WriteLine();
            Func<Student, bool> rule = s => s.Rating >= 75;

            var temp = array.Where(rule);
            Print("Rule", temp);
        }

        static void Task4(List<Student> array)
        {
            Console.WriteLine();
            Console.WriteLine("Task4");

            Func<Student, bool>[] rules = 
            {   
             s => s.Rating >= 75,
             s => s.Birthday.Year<= 1998,
             s => s.Name[0]=='C'
            };

            Student result = array.FirstOrDefault(s => rules.All(rule => rule(s)));
            if (result != null)
                result.Print();
            else
                Console.WriteLine("Error");
        }

        

        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            Generate(ref students, 10);
            Print("All", students);

            Task1_SQL(students);
            Task1(students);

            Task2_SQL(students);
            Task2(students);

            Task3(students);

            Task4(students);
            

            Console.ReadLine();
        }
    }
    
}
