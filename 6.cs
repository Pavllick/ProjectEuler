using System.Numerics;

public class Problem6 {
    public static void Run() {
        BigInteger sqOfSum = 0;
        for(int i = 1; i <= 100; i++)
            sqOfSum += i;
        sqOfSum *= sqOfSum;

        BigInteger sumOfSq = 0;
        for(int i = 1; i <= 100; i++)
            sqOfSum -= i * i;

        Console.WriteLine(sqOfSum);
    }
}
