class Result
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        var zero = 0;
        var negative = 0;
        var positive = 0;
        
        foreach(var num in arr)
        {
            if(num == 0) zero ++;
            if(num < 0) negative++;
            if(num > 0) positive++;
        }
        
        Console.WriteLine( ((decimal)positive/(decimal)arr.Count).ToString("0.######"));
        Console.WriteLine( ((decimal)negative/(decimal)arr.Count).ToString("0.######"));
        Console.WriteLine( ((decimal)zero/(decimal)arr.Count).ToString("0.######"));
        }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
