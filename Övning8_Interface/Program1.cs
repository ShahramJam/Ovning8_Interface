namespace Övning8_Interface
{
    internal class Program1 : IStart, IStop
    {
        
        // public void Run()
        // {
        //     Console.WriteLine("Nu kör vi program 1");
        // }

        public void Start()
        {
            Console.WriteLine("Nu kör vi program 1");
        }

        public void Stop()
        {
            Console.WriteLine("Nu stoppar vi program 1");
        }
    }
}
