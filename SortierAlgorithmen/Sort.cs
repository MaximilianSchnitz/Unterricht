using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortierAlgorithmen
{
    public class Sort
    {
        public static void BubbleSort(int[] array)
        {
            for(int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - (i + 1); j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }
        
        public static void InsertionSort(int[] array)
        {
            for(int i = 1; i < array.Length; i++)
            {
                for(int j = i; j > 0; j--)
                {
                    if (array[j - 1] > array[j])
                    {
                        int temp = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = temp;
                    }
                }
            }
        }

        public static void SelectionSort(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                int current = array[i];

                for(int j = i + 1; j < array.Length; j++)
                {
                    if(array[j] < current)
                    {
                        int temp = array[j];
                        array[j] = current;

                        current = temp;
                    }
                }
                array[i] = current;
            }
        }

        public static int[] MergeSort(int[] array)
        {
            if (array.Length <= 1)
                return array;

            int middle = array.Length / 2;

            int[] leftArray = new int[middle];
            int[] rightArray = new int[array.Length - middle];

            for (int i = 0; i < middle; i++)
                leftArray[i] = array[i];

            for (int i = 0; i < array.Length - middle; i++)
                rightArray[i] = array[i + middle];

            MergeSort(leftArray);
            MergeSort(rightArray);
            return Merge(leftArray, rightArray);
        }

        private static int[] Merge(int[] leftArray, int[] rightArray)
        {
            int[] array = new int[leftArray.Length + rightArray.Length];

            for (int i = 0; i < leftArray.Length; i++)
                array[i] = leftArray[i];

            for (int i = 0; i < rightArray.Length; i++)
                array[i + leftArray.Length] = rightArray[i];

            BubbleSort(array);
            return array;
        }

        //?????
        public static void QuickSort(int[] array)
        {
            int pivot = 4;
            SwapElements(array, pivot, array.Length - 1);
            //pivot = array.Length - 1;

            Console.WriteLine(array[pivot]);

            int itemFromLeft = 0;
            int itemFromRight = array.Length - 1;

            while(itemFromLeft <= itemFromRight)
            {
                //Item from left
                for(int i = 0; i < array.Length - 1; i++)
                {
                    if(array[i] > array[pivot])
                    {
                        itemFromLeft = i;
                        break;
                    }
                }

                //Item from right
                for (int i = array.Length - 1; i > 0; i--)
                {
                    if (array[i] < array[pivot])
                    {
                        itemFromRight = i;
                        break;
                    }
                }
                SwapElements(array, itemFromLeft, itemFromRight);
            }

            SwapElements(array, itemFromLeft, pivot);


        }

        private static void SwapElements(int[] array, int firstIndex, int secondIndex)
        {
            int temp = array[firstIndex];
            array[firstIndex] = array[secondIndex];
            array[secondIndex] = temp;
        }

    }
}
