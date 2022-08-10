public class Problem1 {
    public static void Run() {
        int res = 0;

        for(int i = 3; i < 1000; i++)
            if(i % 3 == 0 || i % 5 == 0)
                res += i;

        Console.WriteLine(res);
    }
}
