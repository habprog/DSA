using DSA.Solutions;

internal class Program
{
    private static void Main(string[] args)
    {
        var res = new TwoSumSolution();
        int[] nums = new[] { 3, 2, 4 };
        var r = res.TwoSum(nums, 6);
        Console.WriteLine("{0}, {1}", r[0], r[1]);
    }
}
