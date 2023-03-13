public static class Library
{
    public static int GetM(string text)
    {
        Console.WriteLine(text);
        return Convert.ToInt32(Console.ReadLine());
    }
    public static int GetPositiv(int[] array)
    {
        int countPositiv = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0) 
            {
                countPositiv++;
            }
        }
        return countPositiv;
    }
    public static string PrintArray(int[] array1)
    {
        string elArray = String.Empty;
        for (int i =0; i< array1.Length; i++)
        {
            elArray = elArray + array1[i] + " ";
        }
        return elArray;
    }
}