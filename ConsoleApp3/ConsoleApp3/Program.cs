// See https://aka.ms/new-console-template for more information

using System;
using System.ComponentModel.Design;
using System.Drawing;
using System.Xml.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        //Linear Search
        //int[] nums = { 1, 23, 3,5, 65,3, 1, 4 };
        //int rightAnswer = 3;
        //for (int i = 0; i < nums.Length; i++)
        //{
        //    if (nums[i] == rightAnswer)
        //    {
        //        Console.WriteLine(nums[i]);
        //        break;
        //    }
        //}




        //int[] nums = { 1, 23, 5, 65, 1, 4 };
        //for (int i = 0; i < nums.Length; i++)
        //{
        //    for (int j = 0; j < nums.Length; j++)
        //    {
        //        if (nums[i] < nums[j]) 
        //        {
        //            int nu;
        //            nu = nums[i];
        //            nums[i] = nums[j];
        //            nums[j] = nu;
        //        }
        //    }
        //}
        //for (int i = 0; i < nums.Length; i++)
        //{
        //    Console.WriteLine(nums[i]);
        //}
        //insertion sort
        int[] nums = { 1, 23, 5, 65, 1, 4 };
        for (int i = 1; i < nums.Length; i++)
        {
            int key = nums[i];
            int j = i - 1;
            while (j >= 0 && key < nums[j])
            {
                nums[j + 1] = nums[j];
                j--;
            }
            nums[j + 1] = key;
        }
        for (int i = 0; i < nums.Length; i++)
        {
            Console.Write(nums[i] + " ");
        }


        //Selection sort
        //int[] nums = { 1, 23, 5, 65, 1, 4 };
        //int minumIndex;
        //for (int i = 0; i < nums.Length; i++)
        //{
        //    minumIndex = i;
        //    for (int j = i; j < nums.Length; j++)
        //    {
        //        if (nums[minumIndex] > nums[j])
        //        {
        //            minumIndex = j;
        //        }
        //    }
        //    int nu;
        //    nu = nums[i];
        //    nums[i] = nums[minumIndex];
        //    nums[minumIndex] = nu;
        //}
        //foreach (int i in nums)
        //{
        //    Console.WriteLine(i);
        //}



        //int[] a = { 3, 19, 55, 64, 87, 96, 97, 98, 100, 101 };
        //int element =87;
        //int low = 0;
        //int jump = (int)Math.Sqrt(a.Length);
        //for (int i = low; i < a.Length; i += jump)
        //{
        //    Console.WriteLine(a[i] + "g");
        //    Console.WriteLine(i);
        //    if (a[i] == element)
        //    {
        //        Console.WriteLine(a[i]+"sdfg");
        //        Console.WriteLine(i);
        //        break;
        //    }
        //    else if (a[i] < element)
        //    {
        //        low += jump;
        //        Console.WriteLine("oxudu");
        //    }
        //    else
        //    {
        //        Console.WriteLine("s");
        //        low -= jump;
        //        i -= jump;
        //        for (int j = low; j < a.Length; j++)
        //        {

        //            i++;
        //            if (a[j] == element)
        //            {
        //                Console.WriteLine(a[j]+"fg");
        //                Console.WriteLine(i-1);
        //                break;
        //            }
        //        }
        //    }

        // }

        //{
        //    int[] a = { 3, 19, 55, 64, 87, 96, 97, 98, 100, 101 };
        //    int element = 101;

        //    int low = 0;
        //    int jump = (int)Math.Sqrt(a.Length);

        //    while (a[Math.Min(jump, a.Length) - 1] < element)
        //    {
        //        low = jump;
        //        jump += (int)Math.Sqrt(a.Length);
        //    }

        //    for (int i = low; i < Math.Min(jump, a.Length); i++)
        //    {

        //        if (a[i] == element)
        //        {
        //            Console.WriteLine("Öğe " + i + " indisinde bulundu.");
        //            return;
        //        }
        //    }

        //    Console.WriteLine("Öğe bulunamadı.");
        //}


        //int[] arr = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
        //int target = 17;
        //int low = 0;
        //int high = arr.Length - 1;
        //bool found = false;

        //while (low <= high && target >= arr[low] && target <= arr[high])
        //{
        //    int pos = low + ((target - arr[low]) * (high - low)) / (arr[high] - arr[low]);

        //    if (arr[pos] == target)
        //    {
        //        Console.WriteLine($"{target} dizinin {pos}. indeksinde bulundu.");
        //        found = true;
        //        break;
        //    }

        //    if (arr[pos] < target)
        //        low = pos + 1;
        //    else
        //        high = pos - 1;
        //}

        //if (!found)
        //{
        //    Console.WriteLine($"{target} dizide bulunamadı.");
        //}




    }
}




