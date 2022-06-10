using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace arrraylist5
{
    class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int EmpSal { get; set; }
        public string EmpLoc { get; set; }


    }

    internal class ArrayListSample
    {
        static void Main(string[] args)
        {
            //object initilizer or collection initilizer
            //ArrayList e = new ArrayList();//non generic

            ArrayList e = new ArrayList()
                   {
new Employee{EmpId=1,EmpName="ram",EmpSal=30000,EmpLoc="Hyd"},
new Employee{EmpId=2,EmpName="vinay",EmpSal=60000,EmpLoc="andhra"},
new Employee{EmpId=3,EmpName="nikhil",EmpSal=81000,EmpLoc="delhi"},
new Employee{EmpId=3,EmpName="praveen",EmpSal=50000,EmpLoc="tamil"},



};
            foreach (Employee i in e)
            {
                Console.WriteLine(i.EmpId + " " + i.EmpName + " " + i.EmpSal + " " + i.EmpLoc);
            }
            Console.ReadKey();
        }
    }
}
