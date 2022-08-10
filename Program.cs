class ProjectEuler {
    static void Main(string[] args) {
        var watch = System.Diagnostics.Stopwatch.StartNew();

        Problem7.Run();

        watch.Stop();

        Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
    }
}
