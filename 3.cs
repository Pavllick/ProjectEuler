using System.Numerics;

public class Problem3 {
    public static void Run() {
        BigInteger input = 600851475143;

        BigInteger res = 0;

        for(BigInteger i = 2; i < input; i++) {
            BigInteger val = input / i;

            if(input % i == 0 && IsPrime(val)) {
                res = val;
                break;
            }
        }

        Console.WriteLine(res);
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
