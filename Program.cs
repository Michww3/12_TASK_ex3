class Program
{
    private static readonly string MutexName = "Global\\UniqueApplicationNameMutex";

    static void Main()
    {
        using (Mutex mutex = new Mutex(false, MutexName, out bool isNewInstance))
        {
            if (!isNewInstance)
            {
                Console.WriteLine("Another instance of this application is already running. Exiting the application.");
                //Console.ReadLine();
                return;
            }

            Console.WriteLine("This is the only instance of the application running.");
            Console.ReadLine();
        }
    }
}
