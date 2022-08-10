using System.Numerics;

public class Problem4 {
    public static void Run() {
        int res = 0;

        for(int i = 999; i > 0; i--) {
            for(int j = 999; j > 0; j--) {
                if(IsPalindrome(i * j) && i * j > res)
                    res = i * j;
            }
        }

        Console.WriteLine(res);
    }

    public static bool IsPalindrome(int n) {
        if(n < 0)
            return false;

        string s = n.ToString();

        for(int i = 0; i < s.Length / 2; i++)
            if(s[i] != s[s.Length - 1 - i])
                return false;

        return true;
    }
}
