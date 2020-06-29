using System;

namespace AlgorithmOnLineSolve
{
    class Program
    {
        static void Main(string[] args)
        {
            BJ_10828_StackBasic bJ_10828_StackBasic = new BJ_10828_StackBasic();
        }
    }

    class BJ_10992_Star
    {
        public void ReadInput()
        {
            Console.Write("정수를 입력해 주세요 :");
            if (Console.ReadLine().GetType() == typeof(int))
            {
                Console.WriteLine("r");
                ReadInput();
                return;
            }
        }
    }

    #region 스택_온라인강의
    class BJ_9093_ReverseWord
    {
        public BJ_9093_ReverseWord()
        {
           
              
        }

    }

    class BJ_10828_StackBasic
    {

        public BJ_10828_StackBasic()
        {
            int orderCount;
            int size = 0;

            Console.WriteLine("배열크기입력 1=<N=<10000수를 입력하라");
            orderCount = int.Parse(Console.ReadLine());
            int[] stack = new int[orderCount];

            while (orderCount-- > 0)
            {
                string cmd = Console.ReadLine();
                if (cmd.Equals("push"))
                {
                    int num = int.Parse(Console.ReadLine());
                    stack[size++] = num;
                }
                else if (cmd.Equals("top"))
                {
                    if (size == 0)
                        Console.WriteLine("-1");
                    else
                    {
                        Console.WriteLine(stack[size - 1]);
                    }
                }
                else if (cmd.Equals("size"))
                {
                    Console.WriteLine(size);
                }
                else if (cmd.Equals("empty"))
                {
                    if (size > 0)
                        Console.WriteLine("0");
                    else
                        Console.WriteLine("1");
                }
                else if (cmd.Equals("pop"))
                {
                    if (size > 0)
                    {
                        Console.WriteLine(stack[size - 1]);
                        size -= 1;
                    }

                    else
                        Console.WriteLine("-1");
                }
            }
        }
    }
    #endregion
}

