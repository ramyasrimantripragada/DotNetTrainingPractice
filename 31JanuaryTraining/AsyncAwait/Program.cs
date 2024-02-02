using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwait
{
    internal class Program
    {
        public static async Task Main(string[] args)
        {
            Console.WriteLine("Time for which each task sleeps:");
            Console.WriteLine("Task-1(School): 8 seconds");
            Console.WriteLine("Task-2(Class11): 5 seconds");
            Console.WriteLine("Task-3(Class12): 2 seconds");

            Console.WriteLine("Executing all 3 simultaneously");
            await Demo1();
            Console.WriteLine("Waiting till Task-1 gets completed and executing task-2 & 3 simultaneously");
            await Demo2();
            Console.WriteLine("Waiting for Task-2,3 to complete before stopping stopwatch");
            await Demo3();
            Console.WriteLine("Waiting for each task to complete one after the other");
            await Demo4();
            Console.ReadLine();
        }

        public static async Task Demo1()
        {
            var watch = new System.Diagnostics.Stopwatch();
            Console.WriteLine("Starting stopwatch and executing tasks");
            watch.Start();
            var task1 = StartSchoolAssembly();
            var task2 = TeachClass11();
            var task3 = TeachClass12();
            Task.WaitAll(task1, task2, task3);
            watch.Stop();
            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");

        }

        public static async Task Demo2()
        {
            var watch = new System.Diagnostics.Stopwatch();
            Console.WriteLine("Starting stopwatch and executing tasks");
            watch.Start();
            var task1 = StartSchoolAssembly();
            task1.Wait();
            var task2 = TeachClass11();
            var task3 = TeachClass12();
            Task.WaitAll(task1,task2,task3);
            watch.Stop();
            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");

        }

        public static async Task Demo3()
        {
            var watch = new System.Diagnostics.Stopwatch();
            Console.WriteLine("Starting stopwatch and executing tasks");
            watch.Start();
            var task2 = TeachClass11();
            var task1 = StartSchoolAssembly();
            var task3 = TeachClass12();
            Task.WaitAll(task2, task3);
            watch.Stop();
            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");

        }

        public static async Task Demo4()
        {
            var watch = new System.Diagnostics.Stopwatch();
            Console.WriteLine("Starting stopwatch and executing tasks");
            watch.Start();
            var task2 = TeachClass11();
            task2.Wait();
            var task1 = StartSchoolAssembly();
            task1.Wait();
            var task3 = TeachClass12();
            task3.Wait();
            watch.Stop();
            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
        }



        public static async Task StartSchoolAssembly()
        {
            Console.WriteLine("Before run block in School started ");
            await Task.Run(() =>
            {
                Task.Delay(1000);
                Thread.Sleep(8000);
                Console.WriteLine("School Started");
            });
        }


        public static async Task TeachClass12()
        {
            Console.WriteLine("Before run block in Teach class 12");
            await Task.Run(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine("Taught class 12");
            });


        }

        public static async Task TeachClass11()
        {
            Console.WriteLine("Before run block in Teach class 11");

            await Task.Run(() =>
            {
                Thread.Sleep(5000);
                Console.WriteLine("Taught class 11");
            });


        }
    }
}
