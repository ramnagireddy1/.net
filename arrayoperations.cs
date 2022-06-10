using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOperations5
{

    internal class Program

    {
        static void Main(string[] args)
        {

            char option;
            string[] stringArray = new string[3];
            Console.WriteLine("Enter string Array values:");
            for (int i = 0; i < stringArray.Length; i++)
            {
                stringArray[i] = Console.ReadLine();
                //Console.WriteLine(stringArray[i]);
            }
            int[] intArray = new int[3];
            Console.WriteLine("Enter int Array values:");
            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine(intArray[i]);

            }
            do
            {
                Console.WriteLine("Enter your choice : Reverse: 0  Copy: 1  Sort: 2  Clear:3 :");

                int op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 0:
                        {
                            //reverse
                            String[] strtemp = stringArray;
                            Array.Reverse(strtemp);
                            Console.Write("Reversed string Array is: ");
                            foreach (String j in strtemp)
                            {
                                Console.Write(j + " ");

                            }
                            int[] arrtemp = intArray;
                            Array.Reverse(arrtemp);
                            Console.Write("\nReversed Array is: ");
                            foreach (int j in arrtemp)
                            {
                                Console.Write(j + " ");
                            }
                            break;
                        }
                    case 1:
                        {
                            //copy of string and array

                            string[] copystr = new string[3];
                            Array.Copy(stringArray, 0, copystr, 0, 3);
                            Console.WriteLine("copied String Array...");
                            foreach (string j in copystr)
                            {
                                Console.WriteLine(j);
                            }

                            int[] copyarr = new int[3];
                            Array.Copy(intArray, 0, copyarr, 0, 3);
                            Console.WriteLine("copied integer Array...");
                            foreach (int i in copyarr)
                            {
                                Console.WriteLine(i);
                            }
                            break;
                        }
                    case 2:
                        {

                            //sorting

                            Array.Sort(stringArray, StringComparer.InvariantCulture);
                            Console.WriteLine("Sorted string array is:");
                            Array.ForEach(stringArray, x => Console.WriteLine(x));

                            Array.Sort(intArray, StringComparer.InvariantCulture);
                            Console.WriteLine("Sorted integer array is:");
                            Array.ForEach(intArray, x => Console.WriteLine(x));

                            break;
                        }
                    case 3:
                        {

                            //Clear of string and int array

                            Array.Clear(stringArray, 0, stringArray.Length);

                            if (stringArray.Contains(""))
                            {
                                System.Console.WriteLine("String Array is not  empty");
                            }
                            else
                            {
                                System.Console.WriteLine("String Array is empty");
                            }


                            Array.Clear(intArray, 0, intArray.Length);
                            if (intArray.Contains(1))
                            {
                                System.Console.WriteLine("Integer Array  is not Empty");
                            }
                            else
                            {
                                System.Console.WriteLine("Integer Array  is Empty");
                            }
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid choice ");
                            break;
                        }
                        Console.WriteLine("\nDo you want to continue this program? (yes/no)");
                        option = Convert.ToChar(Console.ReadLine());

                }
                Console.WriteLine("\nDo you want to continue this program? (yes/no)");
                option = Convert.ToChar(Console.ReadLine());


            } while (option == 'y');
            // Console.ReadLine();

        }


    }


}
