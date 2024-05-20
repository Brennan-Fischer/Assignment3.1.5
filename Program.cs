namespace Assignment3._1._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 1, 1, 2, 3, 4, 1, 1, 2, 3, 2 };
            Console.WriteLine("This is the initial Array");
            foreach (int x in myArray)
            {
                Console.Write($"{x} , ");
            }
            for(int i=0; i< myArray.Length; i++)
            {
                if( myArray[i]== 1 && myArray[i+1] == 1 )
                {
                    myArray[i] = 0;
                    myArray[i + 1] = 0;
                }
            }
            Console.WriteLine("\n This is the Array with any occurance of two 1s in a row being replaced with 0s");
            foreach (int b in myArray)
            {
                Console.Write($"{b} , ");
            }

        }
    }
}
