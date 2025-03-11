namespace task_ilk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region tesk4_for
            for (int i = 1; i < 100; i++) {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            #endregion


            #region tesk4_while
            int a = 1;
            while (a <100) 
            {
                if (a % 2 == 0)
                {
                    Console.WriteLine(a);
                }
                a++;
            }
            #endregion


            #region task5_for
                int[] Array = new int[25];
                int index = 0;
                for (int num = 2; index < 25; num++) 
                {
                    bool chek = true;
                    for (int j = 2; j * j <= num; j++) 
                    {
                        if (num % j == 0)
                        {
                            chek = false;
                            break;
                        }
                    }
                    if (chek) 
                    {
                        Array[index++] = num; 
                    }
                }
                foreach (int prime in Array)
                {
                    Console.Write(prime + " ");
                }
            #endregion

            Console.WriteLine(" ");

            #region task5_while
                int[] Array1 = new int[25]; 
                int index1 = 0;
                int num1 = 2; 
                while (index1 < 25) 
                {
                    bool chek1 = true;
                    int j = 2;
                    while (j * j <= num1) 
                    {
                        if (num1 % j == 0)
                        {
                            chek1 = false;
                            break;
                        }
                        j++;
                    }
                    if (chek1) 
                    {
                        Array1[index1++] = num1; 
                    }

                    num1++; 
                }
                foreach (int c in Array1)
                {
                    Console.Write(c + " ");
                }
        #endregion


    }
}
}
