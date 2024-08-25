var parallelLoopResult1 = Parallel.For(1, 5, Fibonacci);
var parallelLoopResult2 = Parallel.For(2, 7, Fibonacci);
var parallelLoopResult3 = Parallel.For(9, 13, Fibonacci);
var parallelLoopResult4 = Parallel.For(17, 29, Fibonacci);
var parallelLoopResult5 = Parallel.For(44, 50, Fibonacci);

void Fibonacci(int value, ParallelLoopState parallelLoopState)
{
    Console.WriteLine($"Выполняется задача {Task.CurrentId}");

    int fib1 = 0;
    int fib2 = 1;
    int fibRes = 1;

    for (int i = 0; i < value; i++)
    {
        if (fibRes == 100)
        {
            parallelLoopState.Break();
        }
        fibRes = fib1 + fib2;
        fib1 = fib2;
        fib2 = fibRes;
    }

    Thread.Sleep(1500);

    Console.WriteLine(fibRes);
}