using System.Numerics;

public class Problem10 {
    public static void Run() {
        int upperBord = 2_000_000;

        BigInteger res = 2;
        int prime = 1;

        int i = 1;
        while(i < upperBord) {
            i += 2;

            if(IsPrime(i)) {
                prime = i;
                res += prime;
            }
        }

        Console.WriteLine(res);
    }

    private static bool IsPrime(int n) {
        if(n == 2 || n == 3)
            return true;

        if(n <= 1 || n % 2 == 0 || n % 3 == 0)
            return false;

        for(int i = 5; i * i <= n; i += 6) {
            if(n % i == 0 || n % (i + 2) == 0)
                return false;
        }

        return true;
    }
}
