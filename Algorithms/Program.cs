using System;

namespace Algorithms
{
    public  class Program
    {

        public static void Main(string[] args)
        {
            int[] input = { 3, 4, 5, 6, 7, 8, 9 };
            int n=input.Length;
            int x = 4;
            Console.WriteLine("The index "+ x +" found is "+BinarySearch(input, n, x));
        }
        public static int BinarySearch(int[] arr,int n,int x)
        {
            int start=0,end=n-1;
            while (start <= end)
            {
                int mid=(start+end)/2;
                if (arr[mid] == x)
                {
                    return mid;
                }
                else if(x<arr[mid])
                {
                    end=mid-1;
                }
                else
                {
                    start=mid+1;
                }
            }
            return -1;
        }
    }
}
