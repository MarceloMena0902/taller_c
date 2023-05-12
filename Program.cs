namespace GITHUB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int s,i,n;
            n= int.Parse(Console.ReadLine());
           
            for (s=1;s<=n;s++) 
            {
                for(i=1;i<=s;i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }
        }
    }
}