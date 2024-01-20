using System;

public class DisposableResources : IDisposable
{
    public DisposableResources()
    {
        Console.WriteLine("Resource acquired");    
    }

    public void Dispose()
    {
        Console.WriteLine("Resource Released");
    }
}

class Program
{
    static void Main()
    {
        using (DisposableResources obj = new DisposableResources())
        {
            obj.Dispose();
        }

        GC.Collect();
        GC.WaitForPendingFinalizers();

        Console.WriteLine("End of the program");
    }
}