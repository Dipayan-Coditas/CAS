using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
            try
            {
                int a = 10;
                int b = 0;
                int r = a / b;
            }
                
            catch(Exception ex)
            {
                StreamWriter sr=new StreamWriter(@"C:\SampleFile\log.txt");
                sr.Write(ex.GetType().Name);
                sr.WriteLine(ex.Message);
                sr.Close();
            }
           } 
            catch(Exception e)
            {
                Console.WriteLine(e.GetType().Name);
                Console.WriteLine(e.InnerException.GetType().Name);

            }


            Console.ReadLine();

        }
    }
}
