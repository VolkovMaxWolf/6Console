using System;
using System.Linq;

namespace _6concole
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Задание 1");
                Console.WriteLine("Одномерный массив");
                Console.Write("Введите размер массива: ");

                int n = Convert.ToInt32(Console.ReadLine());
                int[] arr = new int[n];

                FillArray(arr);
                OutputArray(arr);

                if (CheckSum(arr)) Console.WriteLine("Сумма элементов - двузначное число");
                else Console.WriteLine("Сумма элементов - не двузначное число");

                Console.WriteLine("Двумерный массив");
                Console.WriteLine("Введите размер массива: ");
                Console.Write("i = ");
                int i = int.Parse(Console.ReadLine());
                Console.Write("k = ");
                int k = int.Parse(Console.ReadLine());
                int[,] twoArr = new int[i, k];
                FillArray(twoArr);
                OutputArray(twoArr);

                if (CheckSum(twoArr)) Console.WriteLine("Сумма элементов - двузначное число");
                else Console.WriteLine("Сумма элементов - не двузначное число");

                Console.WriteLine("Задание 2");
                Console.WriteLine("Количество элементов, значения которых больше значения предыдущего элемента: " + CountSum(arr));


                Console.WriteLine("Задание 3");
                if (CheckNegativeColumn(twoArr)) Console.WriteLine("Столбец, состоящий из отрицательнных элементов есть");
                else Console.WriteLine("Столбец, состоящий из отрицательнных элементов отсутсвует");

                Console.WriteLine("Задание 4");
                Console.WriteLine("Введите размерность массива");
                Console.Write("n = ");
                int n1 = int.Parse(Console.ReadLine());
                int[][] twoArr1 = FillArray(n1);
                OutputArray(twoArr1);
                int [] arr1 = GetMinMultFromRows(twoArr1);
                Console.WriteLine("Новый массив");
                for (int g = 0; g < arr1.Length; g++)
                {
                    Console.Write(arr1[g] + " ");
                }
                Console.WriteLine();
                Console.WriteLine("Минимальный элемент - " + arr1.Min().ToString());

            }
            catch (FormatException)
            {
                Console.WriteLine("Неверный формат ввода данных");
            }
            catch
            {
                Console.WriteLine("Неизвестная ошибка");
            }
        }

        private static int [] GetMinMultFromRows(int[][] twoArr)
        {
            int [] a = new int[twoArr.Length];
            for (int i = 0; i < twoArr.Length; ++i)
            {
                int temp = 1;
                
                for (int j = 0; j < twoArr[i].Length; ++j)
                {
                    temp *= twoArr[j][i];
                }
                a[i] = temp;
            }
            return a;
        }

        private static int[][] FillArray(int n)
        {
            int[][] a = new int[n][];
            for (int r = 0; r < n; ++r)
            {
                a[r] = new int[n];
                for (int j = 0; j < n; ++j)
                {
                    Console.Write("a[{0},{1}]= ", r, j);
                    a[r][j] = int.Parse(Console.ReadLine());
                }
            }
            return a;
        }

        private static bool CheckNegativeColumn(int[,] twoArr)
        {
            bool check = true;
            for (int i = 0; i < twoArr.GetLength(0); ++i)
            {
                check = true;
                for (int j = 0; j < twoArr.GetLength(1); ++j)
                {
                    if (twoArr[j, i] > 0) check = false;
                }
                if (check == true) return check;
            }
            return check;
        }

        private static bool CheckSum(int[,] twoArr)
        {
            int sum = 0;
            for (int i = 0; i < twoArr.GetLength(0); ++i)
            {
                for (int j = 0; j < twoArr.GetLength(1); ++j) { 
                sum+= twoArr[i, j];
            }
            }
            if (sum > -100 && sum < -9 || sum > 9 && sum < 100) return true;
            return false;
        }
        private static void OutputArray(int[,] twoArr)
        {
            for (int i = 0; i < twoArr.GetLength(0); ++i) 
            {
                Console.WriteLine();
                for (int j = 0; j < twoArr.GetLength(1); ++j)
                {
                    Console.Write("{0,5} ", twoArr[ i, j]);
                }
            }
            Console.WriteLine();

        }
        private static void OutputArray(int[][] twoArr)
        {
            for (int i = 0; i < twoArr.Length; ++i)
            {
                Console.WriteLine();
                for (int j = 0; j < twoArr[i].Length; ++j)
                {
                    Console.Write("{0,5} ", twoArr[i][j]);
                }
            }
            Console.WriteLine();

        }

        private static int CountSum(int[] arr)
        {
            int neededCount = 0;
            for (int i = 1; i < arr.Length; i++)
                if (arr[i] > arr[i - 1])
                    neededCount++;
            return neededCount;
        }

        private static void FillArray(int[,] twoArr)
        {
            for (int i = 0; i < twoArr.GetLength(0); ++i)
                for (int j = 0; j < twoArr.GetLength(1); ++j)
                {
                    Console.Write("a[{0},{1}]= ", i, j);
                    twoArr[i, j] = int.Parse(Console.ReadLine());
                }
        }

        private static bool CheckSum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; ++i) sum+=arr[i];
            if (sum > -100 && sum < -9 || sum > 9 && sum < 100) return true;
            return false;
        }

        private static void OutputArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; ++i) Console.Write("{0} ", arr[i]);
            Console.WriteLine();
        }

        private static void FillArray(int [] arr)
        {
            Console.WriteLine("Заполните массив");
            for (int i = 0; i < arr.Length; ++i)
            {
                Console.Write("a[{0}]= ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }
        }
    }
}
