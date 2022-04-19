class Q2A
{
    static int length, i=0;

    static int[] nums;
    static void Main()
    {
        bool errorCatch;
        Console.Write("How many numbers do you want in your array: ");
        errorCatch = int.TryParse(Console.ReadLine(), out length);

        nums = new int[length];

        for (int i = 0; i < nums.Length;)
        {
            Console.Write("\n\tEnter element ({0}): ", i + 1);
            errorCatch = int.TryParse(Console.ReadLine(), out nums[i]);

            if (errorCatch) { i++; }
        }

        Console.WriteLine("\nUsing the recursive method \'sum\' ");
        sum(i);
    }

    static int high=int.MinValue, low=int.MaxValue;
    static void sum(int i)
    {
        if (i == length)
        {
            Console.WriteLine("\nThe sum of the highest and lowest elements is {0}",high+low);
            return;
        }

        if (nums[i] > high) { high= nums[i]; }

        if (nums[i] < low) { low= nums[i]; }

        Console.WriteLine("\nAt this point the highest element is {0} and the lowest is {1} ",high,low);

        i++;

        sum(i);
    }
}
