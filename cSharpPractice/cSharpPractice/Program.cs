using System;

namespace cSharpPractice
{
    public class Program : Employee
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

            //Student s2 = new Student();
            Student s2 = s1;
            s2.name = "shajid";
            s2.age = 21;

            Student s3 = s2;

            Console.WriteLine("Student 1 Name : {0} , Student 1 Age : {1}",s1.name , s1.age);
            Console.WriteLine("Student 2 Name : {0} , Student 2 Age : {1}",s2.name , s2.age);
            Console.WriteLine("Student 3 Name : {0} , Student 3 Age : {1}",s3.name , s3.age);

            Point point = new Point();
            point.x = 10;
            point.y = 20;

            Point point2 = new Point();
            point2.x = 40;
            point2.y = 50;

            Console.WriteLine("Point 1 X: {0} Point 1 Y: {1}", point.x , point.y);
            Console.WriteLine("Point 2 X: {0} Point 2 Y: {1}",point2.x, point2.y);

            Employee employee = new Employee();
            employee.x = 10;
            employee.a = 20; /// a is internal Type variable, 
        }
        public void DoNothing()
        {
            Employee employee1 = new Employee();
            employee1.x = 88;
            employee1.a = 66;
            ///employee1.z
            z = 10;
            Console.WriteLine(z);
        }
    }
    struct Point
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
