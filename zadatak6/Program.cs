using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak6
{
    class Program
    {
        static void Main(string[] args)
        {
            long n,pen=0;
            


            Console.WriteLine("upisite broj do kuda ce se zbrajati: ");
            n=Convert.ToInt64(Console.ReadLine());
            for(long i = 0; i <= n; i++)
            {
                
                pen=pen+i;
                
            }
            Console.Write(pen);



            Console.ReadKey();

        }
    }
}
