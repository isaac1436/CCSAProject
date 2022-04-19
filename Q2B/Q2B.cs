class Q2B
{
    static void Main()
    {
        Console.Write("Please enter an alphanumerical phrase :  ");
        string phrase = Console.ReadLine();
        int length=phrase.Length;
        int strlength=0;
        char[] splitters = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        string[] split=phrase.Split(splitters, StringSplitOptions.RemoveEmptyEntries);
        
        for(int i=0; i<split.Length; i++)
        {
            strlength+=split[i].Length;
        }
        int numLength = length - strlength;

        Console.WriteLine("In the phrase provided there are {0} alphabets and {1} numbers",strlength,numLength);
    }
}