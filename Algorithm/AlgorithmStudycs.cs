using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmBook
{
    class Program
    {

        static void Main(string[] args)
        {


            BJoon_10992_Star bJoon_10992_Star = new BJoon_10992_Star();
            bJoon_10992_Star.ReadInput();


        }



    }

    #region 백준
    class BaekJoon
    {
        public void BJoon_BlackJack()
        {



            Console.WriteLine("3이상 100이하의 수를 써라");
            int cardNum = int.Parse(Console.ReadLine());
            while (cardNum < 3 || cardNum > 100)
            {
                Console.WriteLine("3이상 100이하의 수를 써라");
                cardNum = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("10이상 300000이하의 수를 써라");
            int dealerCallNum = int.Parse(Console.ReadLine());
            while (dealerCallNum < 10 || dealerCallNum > 300000)
            {
                Console.WriteLine("10이상 300000이하의 수를 써라");
                dealerCallNum = int.Parse(Console.ReadLine());
            }


            Console.WriteLine("원소를 적으시오");
            int[] cards = new int[cardNum];
            for (int i = 0; i < cards.Length; i++)
            {
                cards[i] = int.Parse(Console.ReadLine());
                while (cards[i] > 100000)
                {
                    Console.WriteLine("10만 밑으로 숫자를 적으세요");
                    cards[i] = int.Parse(Console.ReadLine());
                }
            }


            int max = 0;
            GetBestNum(cards);
            void GetBestNum(int[] card)
            {
                for (int i = 0; i < cardNum - 2; i++)
                {
                    for (int j = i + 1; j < cardNum - 1; j++)
                    {
                        for (int k = j + 1; k < cardNum; k++)
                        {
                            int sum = cards[i] + cards[j] + cards[k];
                            if (sum <= dealerCallNum)
                            {
                                max = Math.Max(max, sum);

                                ////Math.Max를 만들어봄
                                //if (max > sum)
                                //    return;
                                //else if (max < sum)
                                //    max = sum;
                            }
                            if (max == dealerCallNum)
                                break;
                        }
                    }
                }

                Console.WriteLine(max);
            }

        }
    }
    class BJoon_10992_Star
    {
        public void ReadInput()
        {
            if (Console.ReadLine().GetType != typeof(int))
            {
                Console.WriteLine("정수를 써주세요");
                return ReadInput();
            }
        }

        public string SetStar()
        {
            return "★";
        }
    }

    #endregion

    #region 기초
    class SelectionSort
    {
        public void SelectiontSort(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                int lowestNumberIndex = i;
                for(int j = i+1; j <array.Length; j++)
                {
                    if (array[j] < array[lowestNumberIndex])
                        lowestNumberIndex = j;
                }
            }
        }

    }
    #endregion

    class ArrayKaf
    {
        int i = 0;
        List<int> kafikarList;
        List<int> AllNum;

        public void Kafikar()
        {
            int Kthousand = 1001;
            int Khundred = 101;
            int Kdecima = 11;
            int Kone = 1;
            int Ksum = 0;

            int thousand = 1000;
            int hundred = 100;
            int decima = 10;
            int one = 1;
            int sum = 0;
            int max = 9;
            kafikarList = new List<int>();
            AllNum = new List<int>();

            for (int x = 0; x < max; x++)
            {
                Kthousand *= x;
                thousand *= x;
                for (int y = 0; y < max; y++)
                {
                    Khundred *= y;
                    hundred *= y;
                    for (int z = 0; z < max; z++)
                    {
                        Kdecima *= z;
                        decima *= z;
                        for (int f = 0; f < max; f++)
                        {
                            Kone *= f;
                            one *= f;
                            Ksum = Kthousand + Khundred + Kdecima + Kone;
                            sum = thousand + hundred + decima + one;
                            if (Ksum < 10000)
                            {
                                kafikarList.Add(Ksum);
                                AllNum.Add(sum);


                            }
                        }
                    }
                }
            }

            for (i = 0; i < 10000; i++)
            {
                //for(async kafikarList)
                //if (i != kafikarList[i])
                //{
                //    Console.WriteLine(i);
                //}
            }
        }
    }

    class Print_Array
    {
        public static void PrintArray(int[] value, int count)
        {
            int i = 0;
            for (i = 0; i < count; i++)
            {
                Console.WriteLine("{0}", value[i]);
            }
            Console.WriteLine("\n");
        }

        public static void PrintQuickSortArray(int[] value, int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.WriteLine("{0}", value[i]);
            }
        }


    }//프린트 스태틱으로 만듬(재사용하기)

    class SelectionSortProgram
    {
        public void SelecctionSort(int[] value, int count)
        {
            int i, j = 0;
            int min, temp = 0;
            for (i = 0; i < count - 1; i++) //2개 2개씩 비교하기 위해서
            {
                min = i;    //min에는 앞번째 순서의 자료가 들어가게 한다
                for (j = i + 1; j < count; j++)
                {
                    if (value[j] < value[min])       //value[min] 은 비교할 모 대상임. value[j]<- 순서대로 체크하면서 작으면 위치를 바꿔버린다.
                    {
                        min = j;    //배열의 위치를 값에 영향을 주지 않으면서 바꿈.
                    }
                }
                temp = value[i];            //temp에 일단 무조건 첫번째의 값을 넣어준다. 
                value[i] = value[min];   //value[i]는 j보다 작은 값임. 그래서 작은 값을 넣어줌.
                value[min] = temp;      //작다고 비교되던 그 위치의 값과 교환.

                Console.WriteLine("Step - {0} ,", i + 1);
                Print_Array.PrintArray(value, count);
            }
        }


    }   //선택정렬
    class QuickSorotProgram
    {
        public void QuickSort(int[] value, int start, int end)
        {
            int pivot = 0;
            if (start < end)
            {
                pivot = PartitionQuickSort(value, start, end);
                QuickSort(value, start, pivot - 1);
                QuickSort(value, pivot + 1, end);
            }
        }

        int PartitionQuickSort(int[] value, int start, int end)
        {
            int pivot = end;
            int right = end;
            int left = start;
            int temp = 0;

            while (left < right)
            {
                while (value[left] < value[pivot] && (left < right))
                {
                    left++;
                }
                while (value[right] >= value[pivot] && (left < right))
                {
                    right--;
                }

                if (left < right)
                {
                    Console.WriteLine("정렬 범위: {0}~{1}, 피봇-[{2}], Left({3})-Right({4}) 교환전,", start, end, value[pivot], value[left], value[right]);
                    Print_Array.PrintQuickSortArray(value, start, end);

                    temp = value[left];
                    value[left] = value[right];
                    value[right] = temp;

                    Console.WriteLine("정렬 범위 : {0}~{1}, 피봇-({3}), 교환 후,", start, end, value[pivot]);
                    Print_Array.PrintQuickSortArray(value, start, end);
                }
            }

            Console.WriteLine("정렬 범위 : {0}~{1}, 피봇-({3}), 교환 전,", start, end, value[right]);
            Print_Array.PrintQuickSortArray(value, start, end);

            temp = value[pivot];
            value[pivot] = value[right];
            value[right] = temp;

            Console.WriteLine("정렬 범위 : {0}~{1}, 피봇 교환 gn,", start, end);
            Print_Array.PrintQuickSortArray(value, start, end);


            return right;
        }



    }
}
