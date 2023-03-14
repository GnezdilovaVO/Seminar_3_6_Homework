public static class Library
{
    public static int GetNumber(string text)
    {
        Console.WriteLine(text);
        return Convert.ToInt32(Console.ReadLine());
    }
    public static double[] GetResult(double b1, double k1, double b2, double k2)
    {
        double[] array = new double[2];
        array[0] = (b2-b1)/(k1-k2);
        array[1] = k1*(b2-b1)/(k1-k2) + b1;
        return array;
    }
    public static string PrintArray(double[] array1)
    {
        string elArray = String.Empty;
        for (int i = 0; i < array1.Length; i++)
        {
            elArray = elArray + array1[i] + " ";
        }
        return elArray;
    }
    //public static string GetResult(double b1, double k1, double b2, double k2)
    // {
    //     string result = String.Empty;
    //     double x = (b2-b1)/(k1-k2);
    //     double y = (k1*x) + b1;
    //     result = result + x + " " + y + " ";
    //     return result;
    // }
}