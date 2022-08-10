using System.Numerics;

public class Problem7 {
    public static void Run() {
        int input = 10_001;

        int count = 1;
        BigInteger i = 1;
        while(count <= input - 1) {
            i += 2;

            if(IsPrime(i))
                count++;
        }

        Console.WriteLine(i);
    }

    private static bool IsPrime(BigInteger n) {
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
