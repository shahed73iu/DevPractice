using System;
using System.Collections.Generic;
using System.Text;

namespace cSharpPractice
{
    public class Employee
    {
        public int x;
        private int y; /// Private "Y" only ei employee class ei bebohar kora jabe onno kono class e impossible 
        protected int z; /// eta k employee class er child class e eta k pabo amra
        internal int a; /// Same assembly te thakle pabo noile pabona
        public void CalculateSalary(int bonus, int age)
        {
            int t = a + x + y + z; /// Employee Class er moddhe tai shob variable kei paitesi 
                                   /// Program Class e gele only "x" & "a" ke pabo others gula pabona 
        }
    }
    public class SpecialEmployee : Employee
    {
        public void DoSomething()
        {
            int g = a + x + z ; // "Y" is not accessable 
        }

    }
}