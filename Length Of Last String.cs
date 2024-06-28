public class Solution
{
    public int LengthOfLastWord(string s)
    {
        s = s.Trim();
        int count = 0;
        for (int i = s.Length-1;i >= 0;i--)
        {
            if(s[i] == ' ')
            {
                break;
            }
            else
            {
                count++;
            }
        }
        return count;
    }
}
public class Last
{
    public static void Main(string[] args)
    {
        Solution s = new Solution();
        Console.WriteLine(s.LengthOfLastWord("Pass your input here  "));
        Console.ReadKey();
    }
}
