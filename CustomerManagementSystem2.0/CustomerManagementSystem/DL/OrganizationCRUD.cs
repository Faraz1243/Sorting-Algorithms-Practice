using CustomerManagementSystem.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;

namespace CustomerManagementSystem.DL
{
    public class OrganizationCRUD
    {
        static List<Organization> organizations = new List<Organization>();
        public static void Load(string s)
        {
            DateTime start = DateTime.Now;
            
            StreamReader sr = new StreamReader(s);
            string str;
            int count = 0;
            while ((str = sr.ReadLine()) != null)
            {
                if (count == 0)
                {
                    count++;
                    continue;
                }
                count++;
                
                string[] arr = str.Split(',');

                int index = Convert.ToInt32(arr[0]);
                string id = arr[1];
                string site = arr[2];
                string country = arr[3];
                string description = arr[4];
                string founded = arr[5];
                string industry = arr[6];
                int employees = int.Parse(arr[7]);
                string name = arr[8];

                Organization o = new Organization(index, id, name, site, country, description, founded, industry, employees);
                Add(o);
                //Console.WriteLine(index);
            }
            sr.Close();

            //get system time
            DateTime end = DateTime.Now;
            TimeSpan ts = end - start;
            Console.WriteLine("Time taken to load {0} records: {1}", count, ts);
            Console.ReadKey();
        }
        public static void Add(Organization o)
        {
            organizations.Add(o);
        }
        public static List<Organization> GetAll()
        {
            return organizations;
        }
        public static void Save()
        {
            StreamWriter sw = new StreamWriter("organizations.csv");
            sw.WriteLine("Index,Id,Site,Country,Description,Founded,Industry,Employees,Name");
            foreach (Organization o in organizations)
            {
                sw.WriteLine(o.index + "," + o.OrganizationId + "," + o.Website + "," + o.Country + "," + o.Description + "," + o.Founded + "," + o.Industry + "," + o.Employees + "," + o.Name);
            }
            sw.Close();
        }
         
        public static void BubbleSort()
        {
            for (int i = 0; i < organizations.Count; i++)
            {
                for (int j = 0; j < organizations.Count - 1; j++)
                {
                    if (organizations[j].Employees > organizations[j + 1].Employees)
                    {
                        Organization temp = organizations[j];
                        organizations[j] = organizations[j + 1];
                        organizations[j + 1] = temp;
                    }
                }
            }
        }
        public static void SelectionSort()
        {
            for (int i = 0; i < organizations.Count; i++)
            {
                int min = i;
                for (int j = i + 1; j < organizations.Count; j++)
                {
                    if (organizations[j].Employees < organizations[min].Employees)
                    {
                        min = j;
                    }
                }
                Organization temp = organizations[i];
                organizations[i] = organizations[min];
                organizations[min] = temp;
            }
        }
        public static void InsertionSort()
        {
            for (int i = 1; i < organizations.Count; i++)
            {
                Organization temp = organizations[i];
                int j = i - 1;
                while (j >= 0 && organizations[j].Employees > temp.Employees)
                {
                    organizations[j + 1] = organizations[j];
                    j--;
                }
                organizations[j + 1] = temp;
            }
        }
        public static void MergeSort()
        {
            MergeSort(organizations, 0, organizations.Count - 1);
        }
        public static void MergeSort(List<Organization> organizations, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;
                MergeSort(organizations, left, middle);
                MergeSort(organizations, middle + 1, right);
                Merge(organizations, left, middle, right);
            }
        }
        public static void Merge(List<Organization> organizations, int left, int middle, int right)
        {
            int leftLength = middle - left + 1;
            int rightLength = right - middle;

            List<Organization> leftList = new List<Organization>();
            List<Organization> rightList = new List<Organization>();

            for (int i = 0; i < leftLength; i++)
            {
                leftList.Add(organizations[left + i]);
            }
            for (int j = 0; j < rightLength; j++)
            {
                rightList.Add(organizations[middle + 1 + j]);
            }

            int i1 = 0;
            int j1 = 0;
            int k = left;

            while (i1 < leftLength && j1 < rightLength)
            {
                if (leftList[i1].Employees <= rightList[j1].Employees)
                {
                    organizations[k] = leftList[i1];
                    i1++;
                }
                else
                {
                    organizations[k] = rightList[j1];
                    j1++;
                }
                k++;
            }

            while (i1 < leftLength)
            {
                organizations[k] = leftList[i1];
                i1++;
                k++;
            }

            while (j1 < rightLength)
            {
                organizations[k] = rightList[j1];
                j1++;
                k++;
            }
        }
        //quick sort iterative
        public static void QuickSort()
        {
            QuickSort(organizations, 0, organizations.Count - 1);
        }
        public static void QuickSort(List<Organization> organizations, int left, int right)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(left);
            stack.Push(right);

            while (stack.Count > 0)
            {
                int end = stack.Pop();
                int start = stack.Pop();

                int p = Partition(organizations, start, end);

                if (p - 1 > start)
                {
                    stack.Push(start);
                    stack.Push(p - 1);
                }
                if (p + 1 < end)
                {
                    stack.Push(p + 1);
                    stack.Push(end);
                }
            }
        }
        public static int Partition(List<Organization> organizations, int left, int right)
        {
            int pivot = organizations[right].Employees;
            int i = left - 1;
            for (int j = left; j < right; j++)
            {
                if (organizations[j].Employees <= pivot)
                {
                    i++;
                    Organization temp = organizations[i];
                    organizations[i] = organizations[j];
                    organizations[j] = temp;
                }
            }
            Organization temp1 = organizations[i + 1];
            organizations[i + 1] = organizations[right];
            organizations[right] = temp1;
            return i + 1;
        }
        //heap sort
        public static void HeapSort()
        {
            int n = organizations.Count;
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(organizations, n, i);
            }
            for (int i = n - 1; i >= 0; i--)
            {
                Organization temp = organizations[0];
                organizations[0] = organizations[i];
                organizations[i] = temp;
                Heapify(organizations, i, 0);
            }
        }
        public static void Heapify(List<Organization> organizations, int n, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;
            if (left < n && organizations[left].Employees > organizations[largest].Employees)
            {
                largest = left;
            }
            if (right < n && organizations[right].Employees > organizations[largest].Employees)
            {
                largest = right;
            }
            if (largest != i)
            {
                Organization temp = organizations[i];
                organizations[i] = organizations[largest];
                organizations[largest] = temp;
                Heapify(organizations, n, largest);
            }
        }
        //count sort
        public static void CountSort()
        {
            int max = 0;
            for (int i = 0; i < organizations.Count; i++)
            {
                if (organizations[i].Employees > max)
                {
                    max = organizations[i].Employees;
                }
            }
            int[] count = new int[max + 1];
            for (int i = 0; i < organizations.Count; i++)
            {
                count[organizations[i].Employees]++;
            }
            for (int i = 1; i < count.Length; i++)
            {
                count[i] += count[i - 1];
            }
            Organization[] output = new Organization[organizations.Count];
            for (int i = organizations.Count - 1; i >= 0; i--)
            {
                output[count[organizations[i].Employees] - 1] = organizations[i];
                count[organizations[i].Employees]--;
            }
            for (int i = 0; i < organizations.Count; i++)
            {
                organizations[i] = output[i];
            }
        }
        //radix sort
        public static void RadixSort()
        {
            int max = 0;
            for (int i = 0; i < organizations.Count; i++)
            {
                if (organizations[i].Employees > max)
                {
                    max = organizations[i].Employees;
                }
            }
            for (int exp = 1; max / exp > 0; exp *= 10)
            {
                CountSort(organizations, exp);
            }
        }
        public static void CountSort(List<Organization> organizations, int exp)
        {
            int[] count = new int[10];
            for (int i = 0; i < organizations.Count; i++)
            {
                count[(organizations[i].Employees / exp) % 10]++;
            }
            for (int i = 1; i < count.Length; i++)
            {
                count[i] += count[i - 1];
            }
            Organization[] output = new Organization[organizations.Count];
            for (int i = organizations.Count - 1; i >= 0; i--)
            {
                output[count[(organizations[i].Employees / exp) % 10] - 1] = organizations[i];
                count[(organizations[i].Employees / exp) % 10]--;
            }
            for (int i = 0; i < organizations.Count; i++)
            {
                organizations[i] = output[i];
            }
        }
        //bucket sort
        public static void BucketSort()
        {
            //bari value nikali employees ki
            int max = 0;
            for (int i = 0; i < organizations.Count; i++)
            {
                if (organizations[i].Employees > max)
                {
                    max = organizations[i].Employees;
                }
            }

            List<Organization>[] buckets = new List<Organization>[max + 1];

            for (int i = 0; i < buckets.Length; i++)
            {
                buckets[i] = new List<Organization>();
            }


            for (int i = 0; i < organizations.Count; i++)
            {
                buckets[organizations[i].Employees].Add(organizations[i]);
            }
            int k = 0;
            for (int i = 0; i < buckets.Length; i++)
            {
                for (int j = 0; j < buckets[i].Count; j++)
                {
                    organizations[k] = buckets[i][j];
                    k++;
                }
            }
        }
    }
}
