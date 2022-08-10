public class Problem5 {
    public static void Run() {
        int i = 20;
        while(true) {
            bool isOk = true;
            for(int j = 1; j <= 20; j++)
                if(i % j != 0) {
                    isOk = false;
                    break;
                }

            if(isOk) {
                break;
            }

            i += 2;
        }

        Console.WriteLine(i);
    }
}
