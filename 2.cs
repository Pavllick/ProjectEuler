using System.Numerics;

public class Problem2 {
    public static void Run() {
        int res = 0;

        int n1 = 0;
        int n2 = 1;
        while(n2 < 4_000_000) {
            if(n2 % 2 == 0)
                res += n2;

            int tempN2 = n2;
            n2 = n1 + n2;
            n1 = tempN2;
        }

        Console.WriteLine(res);
    }
}
