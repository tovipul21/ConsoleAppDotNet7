using AccessModifierLibrary;
using AccessModifiersUI;
using System.ComponentModel;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
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
            //int[] nums1 = [0, 0, 1, 1, 1, 2, 2, 3, 3, 4];
            //int elementCount1 = RemoveDuplicate(nums1);
            //Console.WriteLine("elementCount1 = " + elementCount);

            // RemoveElement
            //int[] nums2 = [0, 1, 2, 2, 3, 0, 4, 2]; int val = 3;
            //int elementCount2 = RemoveElement(nums2, val);
            //Console.WriteLine(elementCount2);

            // FirstNonRepeating
            //int[] arr1 = [4, 5, 1, 2, 0, 4];
            //int[] arr1 = [4, 4, 2, 5, 5, 2];
            int[] arr1 = [3, 3, 4, 4, 5, 6, 6];
            int fnrv = FirstNonRepeatingElement(arr1);
            Console.WriteLine(fnrv);
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

        /// <summary>
        /// Given an integer array nums and an integer val, remove all occurrences of val in nums in-place. The order of the elements may be changed. Then return the number of elements in nums which are not equal to val.
        /// Consider the number of elements in nums which are not equal to val be k, to get accepted, you need to do the following things:
        /// Change the array nums such that the first k elements of nums contain the elements which are not equal to val.The remaining elements of nums are not important as well as the size of nums.
        /// Return k.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        static int RemoveElement(int[] nums, int val)
        {
            int res = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
                Console.WriteLine("===");
                Console.WriteLine();
                if (nums[i] != val)
                {
                    nums[res] = nums[i];
                    res++;
                    //Console.WriteLine(res++);
                    //Console.WriteLine();
                }
                
            }
            return res;
        }

        /// <summary>
        /// Given an array of integers, find the first non-repeating element in the array. If there is no non-repeating element, return -1.
        /// </summary>
        /// <param name="nums">integer array collection</param>
        /// <returns>non repeating element within the array</returns>
        static int FirstNonRepeatingElement(int[] nums)
        {
            //Console.WriteLine("4, 5, 1, 2, 0, 4");
            //Console.WriteLine("4, 4, 2, 5, 5, 2");
            Console.WriteLine("3, 3, 4, 4, 5, 6, 6");
            Console.WriteLine();
            bool isRepeated = false;
            //Array.Sort(nums);
            List<int> listarr = nums.ToList<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                isRepeated = false;
                //List<int> newLstArr = listarr.FindAll((num) => num == nums[i]);
                int elementCount = listarr.FindAll((num) => num == nums[i]).Count;

                if (elementCount > 1) isRepeated = true;

                if (elementCount <= 1)
                {
                    isRepeated = false;
                    return nums[i];
                }
                //Console.WriteLine("Main Index Value=" + nums[i] + "; IsRepeated = "+ isRepeated);
                //Console.WriteLine(isRepeated);

                //for (int j = i + 1; j < nums.Length; j++)
                //{
                //    Console.WriteLine("Main Index Value=" + nums[i] + "; Sub Index Value=" + nums[j]);
                //    if (nums[i] == nums[j])
                //    {
                //        isRepeated = true;
                //        break;
                //    }
                //}
                //Console.WriteLine("========================================");

                if (!isRepeated)
                {
                    return nums[i];
                }
            }
            return -1;
        }
    }
}
