using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerManagementSystem.BL;

namespace CustomerManagementSystem.UI
{
    internal class MainUI
    {
        public static void Header()
        {
            Console.Clear();
            Console.WriteLine("================================================");
            Console.WriteLine("          Sorting Algorithms Comparison         ");
            Console.WriteLine("================================================");
        }
        public static string getFirstOption()
        {
            Header();
            Console.WriteLine("1. Load 100 Records");
            Console.WriteLine("2. Load 1000 Records");
            Console.WriteLine("3. Load 10000 Records");
            Console.WriteLine("4. Load 100000 Records");
            Console.WriteLine("5. Load 500000 Records");
            Console.WriteLine("6. Exit");
            Console.Write("Enter your option: ");
            string opt = Console.ReadLine();
            return opt;
        }
        public static string getSecondOption()
        {
            Header();
            Console.WriteLine("1. Sort Data");
            Console.WriteLine("2. View Data");
            Console.WriteLine("3. Save Records");
            Console.WriteLine("4. Just Give Me CSV file for Sorted Records Time");
            Console.WriteLine("5. Just Give Me CSV file for UnSorted Records Time");
            Console.WriteLine("6. Go Back");
            Console.Write("Enter your option: ");
            string opt = Console.ReadLine();
            return opt;
        }
        public static string getSortingOption()
        {
            Header();
            Console.WriteLine("1.  Bubble Sort" );
            Console.WriteLine("2.  Selection Sort");
            Console.WriteLine("3.  Insertion Sort");
            Console.WriteLine("4.  Merge Sort");
            Console.WriteLine("5.  Quick Sort");
            Console.WriteLine("6.  Heap Sort");
            Console.WriteLine("7.  Counting Sort");
            Console.WriteLine("8.  Radix Sort");
            Console.WriteLine("9.  Bucket Sort");
            Console.WriteLine("10. Go Back");
            Console.Write("Enter your option: ");
            string opt = Console.ReadLine();
            return opt;
        }
        public static void Popup(string s)
        {
            Console.WriteLine(s);
            Console.ReadKey();
        }
        public static void PrintRecords(List<Organization> list)
        {
            Console.WriteLine("-----" + "\t\t" + "----------------" + "\t" + "--" + "\t\t\t" + "-----------------");
            Console.WriteLine("Index" + "\t\t" + "No. of Employees" + "\t" + "ID" + "\t\t\t" + "Organization Name");
            Console.WriteLine("-----" + "\t\t" + "----------------" + "\t" + "--" + "\t\t\t" + "-----------------");
            foreach (Organization t in list)
            {
                Console.WriteLine(t.index + "\t\t" + t.Employees + "\t\t\t" + t.OrganizationId + "\t\t" + t.Name);
            }
            Console.ReadKey();
        }
    }
}
