namespace Övning_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] listOne = { 2, 3, 4, 5, 7, 9, 2, 5, 2, 6, 7, 3, 2 };
            int[] listTwo = { 18, 14, 56, 32, 14, 96, 3, 2, 5, 4, 5, 6, 215, 215, 11, 51, 32 };
            
            int max = listTwo.Length - 1;
            
            for (int i = 0; i < max; i++)
            {
                int nrLeft = max - i;

               for (int j = 0; j < nrLeft; j++)
                {
                    if (listTwo[j] > listTwo[j + 1])
                    {
                        int temp = listTwo[j];
                        listTwo[j] = listTwo[j + 1];
                        listTwo[j + 1] = temp;
                    }
                }
            }

            for (int i = 0; i < listTwo.Length; i++)
            {
                Console.WriteLine(listTwo[i]);
            }
        }
    }
}