using System.Data;
using System.Runtime.InteropServices;
using Computer_Builder.Interfaces;
using Computer_Builder.Computer;
namespace Computer_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var director = new Director();
            var builder = new BuilderGaming();
            director.Builder = builder;
            Console.WriteLine("Собираем пеку");
            director.BuildComputer();

        }
        
    }
}

