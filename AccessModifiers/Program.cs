using AccessModifierLibrary;
using AccessModifiersUI;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("-----------------------------------------------------------------------");
            //Console.WriteLine("Start instantiate from the UI console (InheritanceWithinAccessDemoClass)");
            //Console.WriteLine("-----------------------------------------------------------------------");

            //InheritanceWithinAccessDemoClass withinAccessDemoClass = new();
            //withinAccessDemoClass.CallingMethodWithinAccessLibrary();

            //Console.WriteLine("---------------------------------------------------------------------");
            //Console.WriteLine("End instantiate from the UI console (InheritanceWithinAccessDemoClass)");
            //Console.WriteLine("---------------------------------------------------------------------");

            //Console.WriteLine("---------------------------------------------------------------------");

            //Console.WriteLine("----------------------------------------------------------------------");
            //Console.WriteLine("Start instantiate from the UI console (InheritanceOutsideAccessLibrary)");
            //Console.WriteLine("---------------------------------------------------------------------");

            //InheritanceOutsideAccessLibrary inheritanceOutsideAccessLibrary = new();
            //inheritanceOutsideAccessLibrary.CallingMethodOutsideAccessLibrary();

            //Console.WriteLine("---------------------------------------------------------------------");
            //Console.WriteLine("End instantiate from the UI console (InheritanceOutsideAccessLibrary)");
            //Console.WriteLine("---------------------------------------------------------------------");

            // RemoveDuplicate
            int[] nums = [0, 0, 1, 1, 1, 2, 2, 3, 3, 4];
            int elementCount = RemoveDuplicate(nums);
            Console.WriteLine("elementCount = " + elementCount);
        }

        /// <summary>
        /// Given the head of a sorted linked list, delete all duplicates such that each element appears only once. Return the linked list sorted as well.
        /// https://leetcode.com/problems/remove-duplicates-from-sorted-list/description/
        /// </summary>
        /// <param name="nums"></param>
        /// <returns>Total unique count of the int elements</returns>
        static int RemoveDuplicate(int[] nums)
        {
            var numbersList = nums.ToList();
            numbersList.Sort();
            //numbersList.DistinctBy(num => num);
            //return numbersList.Count();
            //numbersList.di
            Array.Sort(nums);
            for (int i = 0; i < nums.Length; i++) 
            {
                Console.WriteLine("Main Line - " + nums[i]);
                Console.WriteLine("==========================");

                for (int j = i+1; j <= nums.Length - 1; j++)
                {
                    Console.WriteLine("Sub line - " + nums[j]);

                    if (nums[i] == nums[j])
                    {
                        numbersList.RemoveAt(nums[j]);
                    }
                }
                Console.WriteLine();
            }
            
            nums = numbersList.ToArray();

            for (int p = 0; p < nums.Length; p++)
            {
                Console.WriteLine("New Line = " + nums[p]);
            }

            return nums.Length;
        }
    }
}
