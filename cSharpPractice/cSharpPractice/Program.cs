using System;

namespace cSharpPractice
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a;            // This All Are Value Type
            char b;          // This All Are Value Type
            short c;          // This All Are Value Type
            long d;         // This All Are Value Type
            DateTime xxxxe;    // This All Are Value Type
            float f;          // This All Are Value Type
            double g;         // This All Are Value Type
            uint h;          // This All Are Value Type
            bool i;          // This All Are Value Type
            decimal j;       // This All Are Value Type

            string k;  /// only string ta holo reference type 

            //Making Student Class
            Student s1 = new Student();
            s1.name = "shahed";
            s1.age = 25;

            Student s2 = new Student();
            s2.name = "shajid";
            s2.age = 21;

            Console.WriteLine(");


        }
    }
    struct point
    {
        public int x;
        public int y;
    }
    class Student
    {
        public string name;
        public int age;
    }
}
