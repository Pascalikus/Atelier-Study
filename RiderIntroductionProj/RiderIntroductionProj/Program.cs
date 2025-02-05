using System;
namespace RiderIntroductionProj;
internal static class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
        Item newIt = new Item();
        int testInt = 0;
        newIt.CallEffectFunctions(testInt);
    }
}