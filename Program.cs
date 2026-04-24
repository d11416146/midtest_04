using Microsoft.Win32.SafeHandles;

namespace midtest_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Console.WriteLine(p1.name);

            Person p2 = new Person("New Person");
            Console.WriteLine(p2.name);

            Student s1= new Student();
            Console.WriteLine(s1.name);

            Student s2 = new Student("New Student");
            Console.WriteLine(s2.name);
        }
    }
    public  class Person
    {
        public string name;

        public Person()
        {
            name = "Person";
        }
        public Person(string name)
        {
            this.name = name;
        }
    }

    public class Student:Person
    {
        public Student():base()
        {

        }

        public Student(string name): base(name) 
        {

        }
    }
}
