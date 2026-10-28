namespace Övning8_Interface.Extra
{
    public class Extra : IReturnVoid, IReturnInt
    {
        void IReturnVoid.Run()
        {
            Console.WriteLine("Nu Kör vi Run med void return");
        }

        int IReturnInt.Run()
        {
            Console.WriteLine("Nu Kör vi Run med int return");
            return 7;
        }
    }
}
