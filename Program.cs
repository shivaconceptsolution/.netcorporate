using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConsoleApp
{
    class Program
    {
        int [] arr;
        int[,] arr1;
        int[][] arr2;
        int r, c;
        void AcceptArr(int [] arr)   //One Dimension Array
        {
            this.arr = arr;

        }

        void AcceptArr1(int[,] arr1,int r,int c) // //Multi Dimension Array
        {
            this.r = r;
            this.c = c;
            this.arr1 = arr1;

        }

        void AcceptArr2(int[][] arr2) //Jagged Array
        {
            this.arr2 = arr2;

        }

        void DisplayArr()
        {
            foreach (int result in arr)
            {
                Console.WriteLine(result);
            }

        }
        void DisplayArr1()
        {
            for (int i = 0; i < r;i++ )
            {
                for(int j=0;j<c;j++)
                {
                    Console.Write(arr1[i,j] + " ");
                }
                Console.WriteLine();
            }

        }
        void DisplayArr2()
        {
            foreach (int [] result in arr2)
            {
                foreach (int res in result)
                {
                    Console.Write(res + " ");
                }
                Console.WriteLine();
            }

        }

        int [] SortArr()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            return arr;

        }
        static void Main(string[] args)
        {
           /* Program p = null;
            p=new Program();
            int[] arr = { 12, 23, 34, 78, 89, 11 };
            p.AcceptArr(arr);
            p.DisplayArr();
            Console.WriteLine("After Sorting");
           int [] arr1= p.SortArr();
            foreach(int arr2 in arr1)
            {
                Console.WriteLine(arr2);
            }*/
            Console.WriteLine("MultiDimension Array");
            int[,] arr = { { 2, 3 }, { 3, 4 } };
            Program parr = new Program();
            parr.AcceptArr1(arr,2,2);
            parr.DisplayArr1();

            Console.WriteLine("Jagged Array");
            int[][] arr1 = new int[3][];
            arr1[0] = new int[3] { 1, 4, 8 };
            arr1[1] = new int[5] { 2, 3, 4, 9, 11 };
            arr1[2] = new int[2] { 2, 3};
            parr.AcceptArr2(arr1);
            parr.DisplayArr2();
            Console.ReadKey();
        }
    }
}
