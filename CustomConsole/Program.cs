using Framework;

namespace CustomConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            FrameworkBootStrapper.Create<MyStartupClass>((x) => {
                
            });
        }
    }
}
