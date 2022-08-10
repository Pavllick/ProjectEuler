using System.Numerics;

public class Problem9 {
    public static void Run() {
        Console.WriteLine(GetProd());
    }

    private static int GetProd() {
        for(int a = 1; a <= 1000 - 4; a++)
            for(int b = a + 1; a + b <= 1000 - 3; b++)
                for(int c = b + 1; a + b + c <= 1000; c++)
                    if(a + b + c == 1000 && a * a + b * b == c * c) {
                        Console.WriteLine(a);
                        Console.WriteLine(b);
                        Console.WriteLine(c);

                        return a * b * c;
                    }

        return 0;
    }
}
