// See https://aka.ms/new-console-template for more information
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int r;
            float A, P;
            const float PI = 3.14f;
            Console.WriteLine("Enter the Raduis:");
            r= int .Parse(Console.ReadLine());
            A = PI * r * r;
            P = PI * 2 * r;
            Console.WriteLine("Area is :"+A);
            Console.WriteLine("Pear is :"+P);
            Console.ReadLine();
        }
    }
}
