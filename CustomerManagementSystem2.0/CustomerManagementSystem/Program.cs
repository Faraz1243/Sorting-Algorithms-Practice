using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CustomerManagementSystem.BL;
using CustomerManagementSystem.DL;
using CustomerManagementSystem.UI;

namespace CustomerManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            firstMenu();
        }
        static void firstMenu()
        {
            string path = "";
            string opt = MainUI.getFirstOption();
            switch (opt)
            {
                case "1":
                    path = "organizations-100.csv";
                    break;
                case "2":
                    path = "organizations-1000.csv";
                    break;
                case "3":
                    path = "organizations-10000.csv";
                    break;
                case "4":
                    path = "organizations-100000.csv";
                    break;
                case "5":
                    path = "organizations-500000.csv";
                    break;
                case "6":
                    return;
                default:
                    MainUI.Popup("Invalid Option");
                    firstMenu();
                    break;
            }
            OrganizationCRUD.Load(path);
            SecondMenu();
        }
        static void SecondMenu()
        {
            string opt = UI.MainUI.getSecondOption();
            switch (opt)
            {
                case "1":
                    ThirdMenu();
                    break;
                case "2":
                    List<Organization> lst = OrganizationCRUD.GetAll();
                    MainUI.PrintRecords(lst);
                    break;
                case "3":
                    OrganizationCRUD.Save();
                    break;
                case "4":
                    SortedTime();
                    break;
                case "5":
                    UnsortedTime();
                    break;
                case "6":
                    firstMenu();
                    break;
                default:
                    MainUI.Popup("Invalid Option");
                    SecondMenu();
                    break;
            }
            SecondMenu();
        }
        static void ThirdMenu()
        {
            string opt = MainUI.getSortingOption();
            switch (opt)
            {
                case "1":
                    DateTime start = DateTime.Now;
                    OrganizationCRUD.BubbleSort();
                    DateTime end = DateTime.Now;
                    TimeSpan ts = end - start;
                    MainUI.Popup("Time taken: " + ts.TotalMilliseconds + " ms");
                    break;
                case "2":
                    start = DateTime.Now;
                    OrganizationCRUD.SelectionSort();
                    end = DateTime.Now;
                    ts = end - start;
                    MainUI.Popup("Time taken: " + ts.TotalMilliseconds + " ms");
                    break;
                case "3":
                    start = DateTime.Now;

                    OrganizationCRUD.InsertionSort();
                    end = DateTime.Now;
                    ts = end - start;
                    MainUI.Popup("Time taken: " + ts.TotalMilliseconds + " ms");
                    break;
                case "4":
                    start = DateTime.Now;
                    OrganizationCRUD.MergeSort();
                    end = DateTime.Now;
                    ts = end - start;
                    MainUI.Popup("Time taken: " + ts.TotalMilliseconds + " ms");
                    break;
                case "5":
                    start = DateTime.Now;
                    OrganizationCRUD.QuickSort();
                    end = DateTime.Now;
                    ts = end - start;
                    MainUI.Popup("Time taken: " + ts.TotalMilliseconds + " ms");
                    break;
                case "6":
                    start = DateTime.Now;
                    OrganizationCRUD.HeapSort();
                    end = DateTime.Now;
                    ts = end - start;
                    MainUI.Popup("Time taken: " + ts.TotalMilliseconds + " ms");
                    break;
                case "7":
                    start = DateTime.Now;
                    OrganizationCRUD.CountSort();
                    end = DateTime.Now;
                    ts = end - start;
                    MainUI.Popup("Time taken: " + ts.TotalMilliseconds + " ms");
                    break;
                case "8":
                    start = DateTime.Now;
                    OrganizationCRUD.RadixSort();
                    end = DateTime.Now;
                    ts = end - start;
                    MainUI.Popup("Time taken: " + ts.TotalMilliseconds + " ms");
                    break;
                case "9":
                    start = DateTime.Now;
                    OrganizationCRUD.BucketSort();
                    end = DateTime.Now;
                    ts = end - start;
                    MainUI.Popup("Time taken: " + ts.TotalMilliseconds + " ms");
                    break;
                case "10":
                    SecondMenu();
                    break;
                default:
                    MainUI.Popup("Invalid Option");
                    ThirdMenu();
                    break;
            }
            ThirdMenu();
        }
        static void SortedTime()
        {
            List<int> TimeSpan = new List<int>();

            OrganizationCRUD.Load("organizations-100.csv");
            OrganizationCRUD.MergeSort();
            Console.WriteLine("100 Records Loaded and Sorted\n");

            Console.WriteLine("Doing Bubble Sort...");
            DateTime start = DateTime.Now;
            OrganizationCRUD.BubbleSort();
            DateTime end = DateTime.Now;
            TimeSpan ts = end - start;
            TimeSpan.Add(Convert.ToInt32(ts.TotalMilliseconds));
            Console.WriteLine("Time taken: " + ts.TotalMilliseconds + " ms\n");
            Console.WriteLine("Bubble Sort Completed!\n");


            Console.WriteLine("Doing Selection Sort...");
            start = DateTime.Now;
            OrganizationCRUD.SelectionSort();
            end = DateTime.Now;
            ts = end - start;
            TimeSpan.Add(Convert.ToInt32(ts.TotalMilliseconds));
            Console.WriteLine("Time taken: " + ts.TotalMilliseconds + " ms\n");
            Console.WriteLine("Selection Sort Completed!\n");

            Console.WriteLine("Doing Insertion Sort...");
            start = DateTime.Now;
            OrganizationCRUD.InsertionSort();
            end = DateTime.Now;
            ts = end - start;
            TimeSpan.Add(Convert.ToInt32(ts.TotalMilliseconds));
            Console.WriteLine("Time taken: " + ts.TotalMilliseconds + " ms\n");
            Console.WriteLine("Insertion Sort Completed!\n");

            Console.WriteLine("Doing Merge Sort...");
            start = DateTime.Now;
            OrganizationCRUD.MergeSort();
            end = DateTime.Now;
            ts = end - start;
            TimeSpan.Add(Convert.ToInt32(ts.TotalMilliseconds));
            Console.WriteLine("Time taken: " + ts.TotalMilliseconds + " ms\n");
            Console.WriteLine("Merge Sort Completed!\n");

            Console.WriteLine("Doing Quick Sort...");
            start = DateTime.Now;
            OrganizationCRUD.QuickSort();
            end = DateTime.Now;
            ts = end - start;
            TimeSpan.Add(Convert.ToInt32(ts.TotalMilliseconds));
            Console.WriteLine("Time taken: " + ts.TotalMilliseconds + " ms\n");
            Console.WriteLine("Quick Sort Completed!\n");

            Console.WriteLine("Doing Heap Sort...");
            start = DateTime.Now;
            OrganizationCRUD.HeapSort();
            end = DateTime.Now;
            ts = end - start;
            TimeSpan.Add(Convert.ToInt32(ts.TotalMilliseconds));
            Console.WriteLine("Time taken: " + ts.TotalMilliseconds + " ms\n");
            Console.WriteLine("Heap Sort Completed!\n");

            Console.WriteLine("Doing Count Sort...");
            start = DateTime.Now;
            OrganizationCRUD.CountSort();
            end = DateTime.Now;
            ts = end - start;
            TimeSpan.Add(Convert.ToInt32(ts.TotalMilliseconds));
            Console.WriteLine("Time taken: " + ts.TotalMilliseconds + " ms\n");
            Console.WriteLine("Count Sort Completed!\n");

            Console.WriteLine("Doing Radix Sort...");
            start = DateTime.Now;
            OrganizationCRUD.RadixSort();
            end = DateTime.Now;
            ts = end - start;
            TimeSpan.Add(Convert.ToInt32(ts.TotalMilliseconds));
            Console.WriteLine("Time taken: " + ts.TotalMilliseconds + " ms\n");
            Console.WriteLine("Radix Sort Completed!\n");

            Console.WriteLine("Doing Bucket Sort...");
            start = DateTime.Now;
            OrganizationCRUD.BucketSort();
            end = DateTime.Now;
            ts = end - start;
            TimeSpan.Add(Convert.ToInt32(ts.TotalMilliseconds));
            Console.WriteLine("Time taken: " + ts.TotalMilliseconds + " ms\n");
            Console.WriteLine("Bucket Sort Completed!\n");
            Console.WriteLine("=======================================\n\n");

            //1000 records


            OrganizationCRUD.Load("organizations-1000.csv");
            OrganizationCRUD.RadixSort();
            Console.WriteLine("1000 Records Loaded and Sorted!\n");

            Console.WriteLine("Doing Bubble Sort...");
            start = DateTime.Now;
            OrganizationCRUD.BubbleSort();
            end = DateTime.Now;
            ts = end - start;
            TimeSpan.Add(Convert.ToInt32(ts.TotalMilliseconds));
            Console.WriteLine("Time taken: " + ts.TotalMilliseconds + " ms\n");
            Console.WriteLine("Bubble Sort Completed!\n");

            Console.WriteLine("Doing Selection Sort...");
            start = DateTime.Now;
            OrganizationCRUD.SelectionSort();
            end = DateTime.Now;
            ts = end - start;
            TimeSpan.Add(Convert.ToInt32(ts.TotalMilliseconds));
            Console.WriteLine("Time taken: " + ts.TotalMilliseconds + " ms\n");
            Console.WriteLine("Selection Sort Completed!\n");

            Console.WriteLine("Doing Insertion Sort...");
            start = DateTime.Now;
            OrganizationCRUD.InsertionSort();
            end = DateTime.Now;
            ts = end - start;
            TimeSpan.Add(Convert.ToInt32(ts.TotalMilliseconds));
            Console.WriteLine("Time taken: " + ts.TotalMilliseconds + " ms\n");
            Console.WriteLine("Insertion Sort Completed!\n");

            Console.WriteLine("Doing Merge Sort...");
            start = DateTime.Now;
            OrganizationCRUD.MergeSort();
            end = DateTime.Now;
            ts = end - start;
            TimeSpan.Add(Convert.ToInt32(ts.TotalMilliseconds));
            Console.WriteLine("Time taken: " + ts.TotalMilliseconds + " ms\n");
            Console.WriteLine("Merge Sort Completed!\n");

            Console.WriteLine("Doing Quick Sort...");
            start = DateTime.Now;
            OrganizationCRUD.QuickSort();
            end = DateTime.Now;
            ts = end - start;
            TimeSpan.Add(Convert.ToInt32(ts.TotalMilliseconds));
            Console.WriteLine("Time taken: " + ts.TotalMilliseconds + " ms\n");
            Console.WriteLine("Quick Sort Completed!\n");

            Console.WriteLine("Doing Heap Sort...");
            start = DateTime.Now;
            OrganizationCRUD.HeapSort();
            end = DateTime.Now;
            ts = end - start;
            TimeSpan.Add(Convert.ToInt32(ts.TotalMilliseconds));
            Console.WriteLine("Time taken: " + ts.TotalMilliseconds + " ms\n");
            Console.WriteLine("Heap Sort Completed!\n");

            Console.WriteLine("Doing Count Sort...");
            start = DateTime.Now;
            OrganizationCRUD.CountSort();
            end = DateTime.Now;
            ts = end - start;
            TimeSpan.Add(Convert.ToInt32(ts.TotalMilliseconds));
            Console.WriteLine("Time taken: " + ts.TotalMilliseconds + " ms\n");
            Console.WriteLine("Count Sort Completed!\n");

            Console.WriteLine("Doing Radix Sort...");
            start = DateTime.Now;
            OrganizationCRUD.RadixSort();
            end = DateTime.Now;
            ts = end - start;
            TimeSpan.Add(Convert.ToInt32(ts.TotalMilliseconds));
            Console.WriteLine("Time taken: " + ts.TotalMilliseconds + " ms\n");
            Console.WriteLine("Radix Sort Completed!\n");

            Console.WriteLine("Doing Bucket Sort...");
            start = DateTime.Now;
            OrganizationCRUD.BucketSort();
            end = DateTime.Now;
            ts = end - start;
            TimeSpan.Add(Convert.ToInt32(ts.TotalMilliseconds));
            Console.WriteLine("Time taken: " + ts.TotalMilliseconds + " ms\n");
            Console.WriteLine("Bucket Sort Completed!\n");
            Console.WriteLine("=======================================\n\n");


            //10000 records


            OrganizationCRUD.Load("organizations-10000.csv");
            OrganizationCRUD.BucketSort();
            Console.WriteLine("10000 Records Loaded and Sorted\n");

            Console.WriteLine("Doing Bubble Sort...");
            start = DateTime.Now;
            OrganizationCRUD.BubbleSort();
            end = DateTime.Now;
            ts = end - start;
            TimeSpan.Add(Convert.ToInt32(ts.TotalMilliseconds));
            Console.WriteLine("Time taken: " + ts.TotalMilliseconds + " ms\n");
            Console.WriteLine("Bubble Sort Completed!\n");

            Console.WriteLine("Doing Selection Sort...");
            start = DateTime.Now;
            OrganizationCRUD.SelectionSort();
            end = DateTime.Now;
            ts = end - start;
            TimeSpan.Add(Convert.ToInt32(ts.TotalMilliseconds));
            Console.WriteLine("Time taken: " + ts.TotalMilliseconds + " ms\n");
            Console.WriteLine("Selection Sort Completed!\n");

            Console.WriteLine("Doing Insertion Sort...");
            start = DateTime.Now;
            OrganizationCRUD.InsertionSort();
            end = DateTime.Now;
            ts = end - start;
            TimeSpan.Add(Convert.ToInt32(ts.TotalMilliseconds));
            Console.WriteLine("Time taken: " + ts.TotalMilliseconds + " ms\n");
            Console.WriteLine("Insertion Sort Completed!\n");

            Console.WriteLine("Doing Merge Sort...");
            start = DateTime.Now;
            OrganizationCRUD.MergeSort();
            end = DateTime.Now;
            ts = end - start;
            TimeSpan.Add(Convert.ToInt32(ts.TotalMilliseconds));
            Console.WriteLine("Time taken: " + ts.TotalMilliseconds + " ms\n");
            Console.WriteLine("Merge Sort Completed!\n");

            Console.WriteLine("Doing Quick Sort...");
            start = DateTime.Now;
            OrganizationCRUD.QuickSort();
            end = DateTime.Now;
            ts = end - start;
            TimeSpan.Add(Convert.ToInt32(ts.TotalMilliseconds));
            Console.WriteLine("Time taken: " + ts.TotalMilliseconds + " ms\n");
            Console.WriteLine("Quick Sort Completed!\n");

            Console.WriteLine("Doing Heap Sort...");
            start = DateTime.Now;
            OrganizationCRUD.HeapSort();
            end = DateTime.Now;
            ts = end - start;
            TimeSpan.Add(Convert.ToInt32(ts.TotalMilliseconds));
            Console.WriteLine("Time taken: " + ts.TotalMilliseconds + " ms\n");
            Console.WriteLine("Heap Sort Completed!\n");

            Console.WriteLine("Doing Count Sort...");
            start = DateTime.Now;
            OrganizationCRUD.CountSort();
            end = DateTime.Now;
            ts = end - start;
            TimeSpan.Add(Convert.ToInt32(ts.TotalMilliseconds));
            Console.WriteLine("Time taken: " + ts.TotalMilliseconds + " ms\n");
            Console.WriteLine("Count Sort Completed!\n");

            Console.WriteLine("Doing Radix Sort...");
            start = DateTime.Now;
            OrganizationCRUD.RadixSort();
            end = DateTime.Now;
            ts = end - start;
            TimeSpan.Add(Convert.ToInt32(ts.TotalMilliseconds));
            Console.WriteLine("Time taken: " + ts.TotalMilliseconds + " ms\n");
            Console.WriteLine("Radix Sort Completed!\n");

            Console.WriteLine("Doing Bucket Sort...");
            start = DateTime.Now;
            OrganizationCRUD.BucketSort();
            end = DateTime.Now;
            ts = end - start;
            TimeSpan.Add(Convert.ToInt32(ts.TotalMilliseconds));
            Console.WriteLine("Time taken: " + ts.TotalMilliseconds + " ms\n");
            Console.WriteLine("Bucket Sort Completed!\n");
            Console.WriteLine("=======================================\n\n");


            //100000 records

            OrganizationCRUD.Load("organizations-100000.csv");
            OrganizationCRUD.BucketSort();
            Console.WriteLine("100000 Records Loaded and Sorted\n");

            Console.WriteLine("Doing Bubble Sort...");
            start = DateTime.Now;
            OrganizationCRUD.BubbleSort();
            end = DateTime.Now;
            ts = end - start;
            TimeSpan.Add(Convert.ToInt32(ts.TotalMilliseconds));
            Console.WriteLine("Time taken: " + ts.TotalMilliseconds + " ms\n");
            Console.WriteLine("Bubble Sort Completed!\n");

            Console.WriteLine("Doing Selection Sort...");
            start = DateTime.Now;
            OrganizationCRUD.SelectionSort();
            end = DateTime.Now;
            ts = end - start;
            TimeSpan.Add(Convert.ToInt32(ts.TotalMilliseconds));
            Console.WriteLine("Time taken: " + ts.TotalMilliseconds + " ms\n");
            Console.WriteLine("Selection Sort Completed!\n");

            Console.WriteLine("Doing Insertion Sort...");
            start = DateTime.Now;
            OrganizationCRUD.InsertionSort();
            end = DateTime.Now;
            ts = end - start;
            TimeSpan.Add(Convert.ToInt32(ts.TotalMilliseconds));
            Console.WriteLine("Time taken: " + ts.TotalMilliseconds + " ms\n");
            Console.WriteLine("Insertion Sort Completed!\n");

            Console.WriteLine("Doing Merge Sort...");
            start = DateTime.Now;
            OrganizationCRUD.MergeSort();
            end = DateTime.Now;
            ts = end - start;
            TimeSpan.Add(Convert.ToInt32(ts.TotalMilliseconds));
            Console.WriteLine("Time taken: " + ts.TotalMilliseconds + " ms\n");
            Console.WriteLine("Merge Sort Completed!\n");

            Console.WriteLine("Doing Quick Sort...");
            start = DateTime.Now;
            OrganizationCRUD.QuickSort();
            end = DateTime.Now;
            ts = end - start;
            TimeSpan.Add(Convert.ToInt32(ts.TotalMilliseconds));
            Console.WriteLine("Time taken: " + ts.TotalMilliseconds + " ms\n");
            Console.WriteLine("Quick Sort Completed!\n");

            Console.WriteLine("Doing Heap Sort...");
            start = DateTime.Now;
            OrganizationCRUD.HeapSort();
            end = DateTime.Now;
            ts = end - start;
            TimeSpan.Add(Convert.ToInt32(ts.TotalMilliseconds));
            Console.WriteLine("Time taken: " + ts.TotalMilliseconds + " ms\n");
            Console.WriteLine("Heap Sort Completed!\n");

            Console.WriteLine("Doing Count Sort...");
            start = DateTime.Now;
            OrganizationCRUD.CountSort();
            end = DateTime.Now;
            ts = end - start;
            TimeSpan.Add(Convert.ToInt32(ts.TotalMilliseconds));
            Console.WriteLine("Time taken: " + ts.TotalMilliseconds + " ms\n");
            Console.WriteLine("Count Sort Completed!\n");

            Console.WriteLine("Doing Radix Sort...");
            start = DateTime.Now;
            OrganizationCRUD.RadixSort();
            end = DateTime.Now;
            ts = end - start;
            TimeSpan.Add(Convert.ToInt32(ts.TotalMilliseconds));
            Console.WriteLine("Time taken: " + ts.TotalMilliseconds + " ms\n");
            Console.WriteLine("Radix Sort Completed!\n");

            Console.WriteLine("Doing Bucket Sort...");
            start = DateTime.Now;
            OrganizationCRUD.BucketSort();
            end = DateTime.Now;
            ts = end - start;
            TimeSpan.Add(Convert.ToInt32(ts.TotalMilliseconds));
            Console.WriteLine("Time taken: " + ts.TotalMilliseconds + " ms\n");
            Console.WriteLine("Bucket Sort Completed!\n");
            Console.WriteLine("=======================================\n\n");



            //saving timeSpan to file
            StreamWriter sw = new StreamWriter("SortedTimeSpan.csv");
            sw.WriteLine(" ,Bubble Sort, Selection Sort, Insertion Sort, Merge Sort, Quick Sort, Heap Sort, Counting Sort, Radix Sort, Bucket Sort");
            sw.WriteLine("100 Records," + TimeSpan[0] + "," + TimeSpan[1] + "," + TimeSpan[2] + "," + TimeSpan[3] + "," + TimeSpan[4] + "," + TimeSpan[5] + "," + TimeSpan[6] + "," + TimeSpan[7] + "," + TimeSpan[8]);
            sw.WriteLine("1000 Records," + TimeSpan[9] + "," + TimeSpan[10] + "," + TimeSpan[11] + "," + TimeSpan[12] + "," + TimeSpan[13] + "," + TimeSpan[14] + "," + TimeSpan[15] + "," + TimeSpan[16] + "," + TimeSpan[17]);
            sw.WriteLine("10000 Records," + TimeSpan[18] + "," + TimeSpan[19] + "," + TimeSpan[20] + "," + TimeSpan[21] + "," + TimeSpan[22] + "," + TimeSpan[23] + "," + TimeSpan[24] + "," + TimeSpan[25] + "," + TimeSpan[26]);
            sw.WriteLine("100000 Records," + TimeSpan[27] + "," + TimeSpan[28] + "," + TimeSpan[29] + "," + TimeSpan[30] + "," + TimeSpan[31] + "," + TimeSpan[32] + "," + TimeSpan[33] + "," + TimeSpan[34] + "," + TimeSpan[35]);
            sw.WriteLine("500000");
            sw.Close();


            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Congratulations!");
            Console.WriteLine("TimeSpan Saved to SortedTimeSpan.csv");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();

        }
        static void UnsortedTime()
        {
            List<int> TimeSpan = new List<int>();
            OrganizationCRUD.Load("organizations-100.csv");
            Console.WriteLine("100 Unsorted Records Loaded!\n");

            Console.WriteLine("Doing Bubble Sort...");
            DateTime start = DateTime.Now;
            OrganizationCRUD.BubbleSort();
            DateTime end = DateTime.Now;
            TimeSpan ts = end - start;
            TimeSpan.Add(Convert.ToInt32(ts.TotalMilliseconds));
            Console.WriteLine("Time taken: " + ts.TotalMilliseconds + " ms\n");
            Console.WriteLine("Bubble Sort Completed!\n");


            OrganizationCRUD.Load("organizations-100.csv");
            Console.WriteLine("100 Unsorted Records Loaded!\n");
            Console.WriteLine("Doing Selection Sort...");
            start = DateTime.Now;
            OrganizationCRUD.SelectionSort();
            end = DateTime.Now;
            ts = end - start;
            TimeSpan.Add(Convert.ToInt32(ts.TotalMilliseconds));
            Console.WriteLine("Time taken: " + ts.TotalMilliseconds + " ms\n");
            Console.WriteLine("Selection Sort Completed!\n");

            OrganizationCRUD.Load("organizations-100.csv");
            Console.WriteLine("100 Unsorted Records Loaded!\n");
            Console.WriteLine("Doing Insertion Sort...");
            start = DateTime.Now;
            OrganizationCRUD.InsertionSort();
            end = DateTime.Now;
            ts = end - start;
            TimeSpan.Add(Convert.ToInt32(ts.TotalMilliseconds));
            Console.WriteLine("Time taken: " + ts.TotalMilliseconds + " ms\n");
            Console.WriteLine("Insertion Sort Completed!\n");

            OrganizationCRUD.Load("organizations-100.csv");
            Console.WriteLine("100 Unsorted Records Loaded!\n");
            Console.WriteLine("Doing Merge Sort...");
            start = DateTime.Now;
            OrganizationCRUD.MergeSort();
            end = DateTime.Now;
            ts = end - start;
            TimeSpan.Add(Convert.ToInt32(ts.TotalMilliseconds));
            Console.WriteLine("Time taken: " + ts.TotalMilliseconds + " ms\n");
            Console.WriteLine("Merge Sort Completed!\n");


            OrganizationCRUD.Load("organizations-100.csv");
            Console.WriteLine("1000 Unsorted Records Loaded!\n");
            Console.WriteLine("Doing Quick Sort...");
            start = DateTime.Now;
            OrganizationCRUD.QuickSort();
            end = DateTime.Now;
            ts = end - start;
            TimeSpan.Add(Convert.ToInt32(ts.TotalMilliseconds));
            Console.WriteLine("Time taken: " + ts.TotalMilliseconds + " ms\n");
            Console.WriteLine("Quick Sort Completed!\n");

            OrganizationCRUD.Load("organizations-100.csv");
            Console.WriteLine("100 Unsorted Records Loaded!\n");
            Console.WriteLine("Doing Heap Sort...");
            start = DateTime.Now;
            OrganizationCRUD.HeapSort();
            end = DateTime.Now;
            ts = end - start;
            TimeSpan.Add(Convert.ToInt32(ts.TotalMilliseconds));
            Console.WriteLine("Time taken: " + ts.TotalMilliseconds + " ms\n");
            Console.WriteLine("Heap Sort Completed!\n");

            OrganizationCRUD.Load("organizations-100.csv");
            Console.WriteLine("100 Unsorted Records Loaded!\n");
            Console.WriteLine("Doing Counting Sort...");
            start = DateTime.Now;
            OrganizationCRUD.CountSort();
            end = DateTime.Now;
            ts = end - start;
            TimeSpan.Add(Convert.ToInt32(ts.TotalMilliseconds));
            Console.WriteLine("Time taken: " + ts.TotalMilliseconds + " ms\n");
            Console.WriteLine("Counting Sort Completed!\n");

            OrganizationCRUD.Load("organizations-100.csv");
            Console.WriteLine("100 Unsorted Records Loaded!\n");
            Console.WriteLine("Doing Radix Sort...");
            start = DateTime.Now;
            OrganizationCRUD.RadixSort();
            end = DateTime.Now;
            ts = end - start;
            TimeSpan.Add(Convert.ToInt32(ts.TotalMilliseconds));
            Console.WriteLine("Time taken: " + ts.TotalMilliseconds + " ms\n");
            Console.WriteLine("Radix Sort Completed!\n");

            OrganizationCRUD.Load("organizations-100.csv");
            Console.WriteLine("100 Unsorted Records Loaded!\n");
            Console.WriteLine("Doing Bucket Sort...");
            start = DateTime.Now;
            OrganizationCRUD.BucketSort();
            end = DateTime.Now;
            ts = end - start;
            TimeSpan.Add(Convert.ToInt32(ts.TotalMilliseconds));
            Console.WriteLine("Time taken: " + ts.TotalMilliseconds + " ms\n");
            Console.WriteLine("Bucket Sort Completed!\n");

            Console.WriteLine("=======================================\n\n");


            //1000 records


            OrganizationCRUD.Load("organizations-1000.csv");
            Console.WriteLine("1000 Unsorted Records Loaded!\n");

            Console.WriteLine("Doing Bubble Sort...");
            start = DateTime.Now;
            OrganizationCRUD.BubbleSort();
            end = DateTime.Now;
            ts = end - start;
            TimeSpan.Add(Convert.ToInt32(ts.TotalMilliseconds));
            Console.WriteLine("Time taken: " + ts.TotalMilliseconds + " ms\n");
            Console.WriteLine("Bubble Sort Completed!\n");

            OrganizationCRUD.Load("organizations-1000.csv");
            Console.WriteLine("1000 Unsorted Records Loaded!\n");
            Console.WriteLine("Doing Selection Sort...");
            start = DateTime.Now;
            OrganizationCRUD.SelectionSort();
            end = DateTime.Now;
            ts = end - start;
            TimeSpan.Add(Convert.ToInt32(ts.TotalMilliseconds));
            Console.WriteLine("Time taken: " + ts.TotalMilliseconds + " ms\n");
            Console.WriteLine("Selection Sort Completed!\n");

            OrganizationCRUD.Load("organizations-1000.csv");
            Console.WriteLine("1000 Unsorted Records Loaded!\n");
            Console.WriteLine("Doing Insertion Sort...");
            start = DateTime.Now;
            OrganizationCRUD.InsertionSort();
            end = DateTime.Now;
            ts = end - start;
            TimeSpan.Add(Convert.ToInt32(ts.TotalMilliseconds));
            Console.WriteLine("Time taken: " + ts.TotalMilliseconds + " ms\n");
            Console.WriteLine("Insertion Sort Completed!\n");

            OrganizationCRUD.Load("organizations-1000.csv");
            Console.WriteLine("1000 Unsorted Records Loaded!\n");
            Console.WriteLine("Doing Merge Sort...");
            start = DateTime.Now;
            OrganizationCRUD.MergeSort();
            end = DateTime.Now;
            ts = end - start;
            TimeSpan.Add(Convert.ToInt32(ts.TotalMilliseconds));
            Console.WriteLine("Time taken: " + ts.TotalMilliseconds + " ms\n");
            Console.WriteLine("Merge Sort Completed!\n");

            OrganizationCRUD.Load("organizations-1000.csv");
            Console.WriteLine("1000 Unsorted Records Loaded!\n");
            Console.WriteLine("Doing Quick Sort...");
            start = DateTime.Now;
            OrganizationCRUD.QuickSort();
            end = DateTime.Now;
            ts = end - start;
            TimeSpan.Add(Convert.ToInt32(ts.TotalMilliseconds));
            Console.WriteLine("Time taken: " + ts.TotalMilliseconds + " ms\n");
            Console.WriteLine("Quick Sort Completed!\n");

            OrganizationCRUD.Load("organizations-1000.csv");
            Console.WriteLine("1000 Unsorted Records Loaded!\n");
            Console.WriteLine("Doing Heap Sort...");
            start = DateTime.Now;
            OrganizationCRUD.HeapSort();
            end = DateTime.Now;
            ts = end - start;
            TimeSpan.Add(Convert.ToInt32(ts.TotalMilliseconds));
            Console.WriteLine("Time taken: " + ts.TotalMilliseconds + " ms\n");
            Console.WriteLine("Heap Sort Completed!\n");

            OrganizationCRUD.Load("organizations-1000.csv");
            Console.WriteLine("1000 Unsorted Records Loaded!\n");
            Console.WriteLine("Doing Counting Sort...");
            start = DateTime.Now;
            OrganizationCRUD.CountSort();
            end = DateTime.Now;
            ts = end - start;
            TimeSpan.Add(Convert.ToInt32(ts.TotalMilliseconds));
            Console.WriteLine("Time taken: " + ts.TotalMilliseconds + " ms\n");
            Console.WriteLine("Counting Sort Completed!\n");

            OrganizationCRUD.Load("organizations-1000.csv");
            Console.WriteLine("1000 Unsorted Records Loaded!\n");
            Console.WriteLine("Doing Radix Sort...");
            start = DateTime.Now;
            OrganizationCRUD.RadixSort();
            end = DateTime.Now;
            ts = end - start;
            TimeSpan.Add(Convert.ToInt32(ts.TotalMilliseconds));
            Console.WriteLine("Time taken: " + ts.TotalMilliseconds + " ms\n");
            Console.WriteLine("Radix Sort Completed!\n");

            OrganizationCRUD.Load("organizations-1000.csv");
            Console.WriteLine("1000 Unsorted Records Loaded!\n");
            Console.WriteLine("Doing Bucket Sort...");
            start = DateTime.Now;
            OrganizationCRUD.BucketSort();
            end = DateTime.Now;
            ts = end - start;
            TimeSpan.Add(Convert.ToInt32(ts.TotalMilliseconds));
            Console.WriteLine("Time taken: " + ts.TotalMilliseconds + " ms\n");
            Console.WriteLine("Bucket Sort Completed!\n");

            Console.WriteLine("=======================================\n\n");

            //10000 records


            OrganizationCRUD.Load("organizations-10000.csv");
            Console.WriteLine("10000 Unsorted Records Loaded!\n");

            Console.WriteLine("Doing Bubble Sort...");
            start = DateTime.Now;
            OrganizationCRUD.BubbleSort();
            end = DateTime.Now;
            ts = end - start;
            TimeSpan.Add(Convert.ToInt32(ts.TotalMilliseconds));
            Console.WriteLine("Time taken: " + ts.TotalMilliseconds + " ms\n");
            Console.WriteLine("Bubble Sort Completed!\n");

            OrganizationCRUD.Load("organizations-10000.csv");
            Console.WriteLine("10000 Unsorted Records Loaded!\n");
            Console.WriteLine("Doing Selection Sort...");
            start = DateTime.Now;
            OrganizationCRUD.SelectionSort();
            end = DateTime.Now;
            ts = end - start;
            TimeSpan.Add(Convert.ToInt32(ts.TotalMilliseconds));
            Console.WriteLine("Time taken: " + ts.TotalMilliseconds + " ms\n");
            Console.WriteLine("Selection Sort Completed!\n");

            OrganizationCRUD.Load("organizations-10000.csv");
            Console.WriteLine("10000 Unsorted Records Loaded!\n");
            Console.WriteLine("Doing Insertion Sort...");
            start = DateTime.Now;
            OrganizationCRUD.InsertionSort();
            end = DateTime.Now;
            ts = end - start;
            TimeSpan.Add(Convert.ToInt32(ts.TotalMilliseconds));
            Console.WriteLine("Time taken: " + ts.TotalMilliseconds + " ms\n");
            Console.WriteLine("Insertion Sort Completed!\n");

            OrganizationCRUD.Load("organizations-10000.csv");
            Console.WriteLine("10000 Unsorted Records Loaded!\n");
            Console.WriteLine("Doing Merge Sort...");
            start = DateTime.Now;
            OrganizationCRUD.MergeSort();
            end = DateTime.Now;
            ts = end - start;
            TimeSpan.Add(Convert.ToInt32(ts.TotalMilliseconds));
            Console.WriteLine("Time taken: " + ts.TotalMilliseconds + " ms\n");
            Console.WriteLine("Merge Sort Completed!\n");

            OrganizationCRUD.Load("organizations-10000.csv");
            Console.WriteLine("10000 Unsorted Records Loaded!\n");
            Console.WriteLine("Doing Quick Sort...");
            start = DateTime.Now;
            OrganizationCRUD.QuickSort();
            end = DateTime.Now;
            ts = end - start;
            TimeSpan.Add(Convert.ToInt32(ts.TotalMilliseconds));
            Console.WriteLine("Time taken: " + ts.TotalMilliseconds + " ms\n");
            Console.WriteLine("Quick Sort Completed!\n");

            OrganizationCRUD.Load("organizations-10000.csv");
            Console.WriteLine("10000 Unsorted Records Loaded!\n");
            Console.WriteLine("Doing Heap Sort...");
            start = DateTime.Now;
            OrganizationCRUD.HeapSort();
            end = DateTime.Now;
            ts = end - start;
            TimeSpan.Add(Convert.ToInt32(ts.TotalMilliseconds));
            Console.WriteLine("Time taken: " + ts.TotalMilliseconds + " ms\n");
            Console.WriteLine("Heap Sort Completed!\n");

            OrganizationCRUD.Load("organizations-10000.csv");
            Console.WriteLine("10000 Unsorted Records Loaded!\n");
            Console.WriteLine("Doing Counting Sort...");
            start = DateTime.Now;
            OrganizationCRUD.CountSort();
            end = DateTime.Now;
            ts = end - start;
            TimeSpan.Add(Convert.ToInt32(ts.TotalMilliseconds));
            Console.WriteLine("Time taken: " + ts.TotalMilliseconds + " ms\n");
            Console.WriteLine("Counting Sort Completed!\n");

            OrganizationCRUD.Load("organizations-10000.csv");
            Console.WriteLine("10000 Unsorted Records Loaded!\n");
            Console.WriteLine("Doing Radix Sort...");
            start = DateTime.Now;
            OrganizationCRUD.RadixSort();
            end = DateTime.Now;
            ts = end - start;
            TimeSpan.Add(Convert.ToInt32(ts.TotalMilliseconds));
            Console.WriteLine("Time taken: " + ts.TotalMilliseconds + " ms\n");
            Console.WriteLine("Radix Sort Completed!\n");

            OrganizationCRUD.Load("organizations-10000.csv");
            Console.WriteLine("10000 Unsorted Records Loaded!\n");
            Console.WriteLine("Doing Bucket Sort...");
            start = DateTime.Now;
            OrganizationCRUD.BucketSort();
            end = DateTime.Now;
            ts = end - start;
            TimeSpan.Add(Convert.ToInt32(ts.TotalMilliseconds));
            Console.WriteLine("Time taken: " + ts.TotalMilliseconds + " ms\n");
            Console.WriteLine("Bucket Sort Completed!\n");

            Console.WriteLine("=======================================\n\n");


            //100000 records

            OrganizationCRUD.Load("organizations-100000.csv");
            Console.WriteLine("100000 Unsorted Records Loaded!\n");

            Console.WriteLine("Doing Bubble Sort...");
            start = DateTime.Now;
            OrganizationCRUD.BubbleSort();
            end = DateTime.Now;
            ts = end - start;
            TimeSpan.Add(Convert.ToInt32(ts.TotalMilliseconds));
            Console.WriteLine("Time taken: " + ts.TotalMilliseconds + " ms\n");
            Console.WriteLine("Bubble Sort Completed!\n");

            OrganizationCRUD.Load("organizations-100000.csv");
            Console.WriteLine("100000 Unsorted Records Loaded!\n");
            Console.WriteLine("Doing Selection Sort...");
            start = DateTime.Now;
            OrganizationCRUD.SelectionSort();
            end = DateTime.Now;
            ts = end - start;
            TimeSpan.Add(Convert.ToInt32(ts.TotalMilliseconds));
            Console.WriteLine("Time taken: " + ts.TotalMilliseconds + " ms\n");
            Console.WriteLine("Selection Sort Completed!\n");

            OrganizationCRUD.Load("organizations-100000.csv");
            Console.WriteLine("100000 Unsorted Records Loaded!\n");
            Console.WriteLine("Doing Insertion Sort...");
            start = DateTime.Now;
            OrganizationCRUD.InsertionSort();
            end = DateTime.Now;
            ts = end - start;
            TimeSpan.Add(Convert.ToInt32(ts.TotalMilliseconds));
            Console.WriteLine("Time taken: " + ts.TotalMilliseconds + " ms\n");
            Console.WriteLine("Insertion Sort Completed!\n");

            OrganizationCRUD.Load("organizations-100000.csv");
            Console.WriteLine("100000 Unsorted Records Loaded!\n");
            Console.WriteLine("Doing Merge Sort...");
            start = DateTime.Now;
            OrganizationCRUD.MergeSort();
            end = DateTime.Now;
            ts = end - start;
            TimeSpan.Add(Convert.ToInt32(ts.TotalMilliseconds));
            Console.WriteLine("Time taken: " + ts.TotalMilliseconds + " ms\n");
            Console.WriteLine("Merge Sort Completed!\n");

            OrganizationCRUD.Load("organizations-100000.csv");
            Console.WriteLine("100000 Unsorted Records Loaded!\n");
            Console.WriteLine("Doing Quick Sort...");
            start = DateTime.Now;
            OrganizationCRUD.QuickSort();
            end = DateTime.Now;
            ts = end - start;
            TimeSpan.Add(Convert.ToInt32(ts.TotalMilliseconds));
            Console.WriteLine("Time taken: " + ts.TotalMilliseconds + " ms\n");
            Console.WriteLine("Quick Sort Completed!\n");

            OrganizationCRUD.Load("organizations-100000.csv");
            Console.WriteLine("100000 Unsorted Records Loaded!\n");
            Console.WriteLine("Doing Heap Sort...");
            start = DateTime.Now;
            OrganizationCRUD.HeapSort();
            end = DateTime.Now;
            ts = end - start;
            TimeSpan.Add(Convert.ToInt32(ts.TotalMilliseconds));
            Console.WriteLine("Time taken: " + ts.TotalMilliseconds + " ms\n");
            Console.WriteLine("Heap Sort Completed!\n");

            OrganizationCRUD.Load("organizations-100000.csv");
            Console.WriteLine("100000 Unsorted Records Loaded!\n");
            Console.WriteLine("Doing Counting Sort...");
            start = DateTime.Now;
            OrganizationCRUD.CountSort();
            end = DateTime.Now;
            ts = end - start;
            TimeSpan.Add(Convert.ToInt32(ts.TotalMilliseconds));
            Console.WriteLine("Time taken: " + ts.TotalMilliseconds + " ms\n");
            Console.WriteLine("Counting Sort Completed!\n");

            OrganizationCRUD.Load("organizations-100000.csv");
            Console.WriteLine("100000 Unsorted Records Loaded!\n");
            Console.WriteLine("Doing Radix Sort...");
            start = DateTime.Now;
            OrganizationCRUD.RadixSort();
            end = DateTime.Now;
            ts = end - start;
            TimeSpan.Add(Convert.ToInt32(ts.TotalMilliseconds));
            Console.WriteLine("Time taken: " + ts.TotalMilliseconds + " ms\n");
            Console.WriteLine("Radix Sort Completed!\n");

            OrganizationCRUD.Load("organizations-100000.csv");
            Console.WriteLine("100000 Unsorted Records Loaded!\n");
            Console.WriteLine("Doing Bucket Sort...");
            start = DateTime.Now;
            OrganizationCRUD.BucketSort();
            end = DateTime.Now;
            ts = end - start;
            TimeSpan.Add(Convert.ToInt32(ts.TotalMilliseconds));
            Console.WriteLine("Time taken: " + ts.TotalMilliseconds + " ms\n");
            Console.WriteLine("Bucket Sort Completed!\n");
            Console.WriteLine("=======================================\n\n");




            //saving timeSpan to file
            StreamWriter sw = new StreamWriter("UnSortedTimeSpan.csv");
            sw.WriteLine(" ,Bubble Sort, Selection Sort, Insertion Sort, Merge Sort, Quick Sort, Heap Sort, Counting Sort, Radix Sort, Bucket Sort");
            sw.WriteLine("1000," + TimeSpan[0] + "," + TimeSpan[1] + "," + TimeSpan[2] + "," + TimeSpan[3] + "," + TimeSpan[4] + "," + TimeSpan[5] + "," + TimeSpan[6] + "," + TimeSpan[7] + "," + TimeSpan[8]);
            sw.WriteLine("10000," + TimeSpan[9] + "," + TimeSpan[10] + "," + TimeSpan[11] + "," + TimeSpan[12] + "," + TimeSpan[13] + "," + TimeSpan[14] + "," + TimeSpan[15] + "," + TimeSpan[16] + "," + TimeSpan[17]);
            sw.WriteLine("100000," + TimeSpan[18] + "," + TimeSpan[19] + "," + TimeSpan[20] + "," + TimeSpan[21] + "," + TimeSpan[22] + "," + TimeSpan[23] + "," + TimeSpan[24] + "," + TimeSpan[25] + "," + TimeSpan[26]);

            sw.WriteLine("500000");
            sw.Close();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Congratulations!");
            Console.WriteLine("TimeSpan Saved to UnSortedTimeSpan.csv");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
        }

    }
}
