class Result
{

    /*
     * Complete the 'diagonalDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */

    public static int diagonalDifference(List<List<int>> arr)
    {
        var n = arr[0].Count -1;
        var leftSum = 0;
        var rightSum = 0;
        
        for(int i = 0; i < arr.Count; i++)
        {
            for(int j = 0; j < arr[0].Count; j++)
            {
                if(i == j)
                {
                    leftSum += arr[i][j];
                }
                
                if(i == n - j)
                {
                    rightSum += arr[i][j];
                }
            }
        }
        
        return Math.Abs(leftSum - rightSum);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < n; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        int result = Result.diagonalDifference(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
