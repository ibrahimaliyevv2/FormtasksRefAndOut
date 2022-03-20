using System;

namespace FormtasksCsRefAndOut
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Additions to tasks

            #region Formtask-1 Addition
            //Sum(out int num1, out int num2);
            #endregion

            #region Formtask-2 Addition
            //int[] numArray = { 1, 4, 6, 3, 2, 7 };
            //SwapMaxMin(numArray);
            #endregion

            #region Formtask-3 Addition
            //int[] numArray = { 1, 3, 3, 5, 7, 3, 2 };
            //RepeatNum(numArray);
            #endregion

            #endregion

        }

        #region Tasks(Methods)

        //Formtask-1: N-den m-e qeder ededlerin cemi(out ile)
        static void Sum(out int num1, out int num2)
        {
            Console.WriteLine("Eded daxil edin: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = num1; i < num2; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }


        //Formtask-2: Massivdeki en boyuk ve en kicik ededlerin yerini deyisen metod
        static void SwapMaxMin(int[] numbers)
        {
            int max = numbers[0];
            int min = numbers[0];
            int minIndex = 0;
            int maxIndex = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                    if (numbers[i] < min)
                    {
                        min = numbers[i];
                        minIndex = i;
                    }

                    if (numbers[i] > max)
                    {
                        max = numbers[i];
                        maxIndex = i;
                }
                numbers[maxIndex] = min;
                numbers[minIndex] = max;
            }
            

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }


        //Formtask-3: Verilmis massivde tekrar olunan ededlerin sayini cixarin
        static void RepeatNum(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                        break;
                    }
                }
                // Console.WriteLine($"{arr[i]} {count} defe tekrarlanir");

            }
            Console.WriteLine(count);
        }

        #endregion
    }
}
