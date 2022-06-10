using System;


namespace FirstConsoleApplication
{
    class Assignemnt

    {

        class salary
        {
            int eno, basic;
            string eName;
            double da, hra, totsal;

            public salary(int eno, int basic, string ename)
            {
                this.eno = eno;
                this.basic = basic;
                this.eName = ename;

            }

            public void DA()
            {
                da = basic * 40 / 100;
                hra = basic * 40 / 100;
                totsal = basic + da + hra;
                Console.WriteLine("Employee nuber {0}", eno);
                Console.WriteLine("Employee name {0}", eName);
                Console.WriteLine("Employee Basic salary {0}", basic);
                Console.WriteLine("Employee DA{0}", da);
                Console.WriteLine("Employee HRA {0}", hra);
                Console.WriteLine("Employee Total Salary {0}", totsal);


            }
        }
        static void Main(string[] arg)
        {
            int eno, basic;
            string ename;
            Console.WriteLine("Enter Employee Number");
            eno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Employee Name");
            ename = Console.ReadLine();


            Console.WriteLine("Enter Employee Basic");
            basic = Convert.ToInt32(Console.ReadLine());

            salary s = new salary(eno, basic, ename);
            s.DA();







        }
    }
}
