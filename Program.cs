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
                for(i=1;i<=n;i++)
                {
                    if(s==n/3 || s==(n/3)*2 )
                    {
                        Console.Write("*");
                    }
                    
                }
                Console.WriteLine(" ");
            }
        }
    }
}