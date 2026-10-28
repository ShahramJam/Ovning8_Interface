using Övning8_Interface.Extra;

namespace Övning8_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var program1 = new Program1();
            var program2 = new Program2();

            // program1.Run();
            // program2.Go();

            program1.Start();
            program2.Start();
            program1.Stop();
            Console.WriteLine(Environment.NewLine);


            Console.WriteLine("===========Interface==========");
            // Vi kan använda interface-typen för att referera till objekten i t.ex. en lista eller array,
            // och anropa metoderna via interface-typen. Detta gör koden mer flexibel och lättare att underhålla.
            List<IStart> programs = [program1, program2];
            programs.ForEach(p => p.Start());
            programs.ForEach(p => (p as IStop)?.Stop());
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("===========ExtraProgram==========");
            var extra = new Extra.Extra();
            IReturnVoid voidRunner = extra;
            IReturnInt intRunner = extra;
            voidRunner.Run();
            int result = intRunner.Run();
            Console.WriteLine($"Returvärde från int Run(): {result}");
        }
    }
}
