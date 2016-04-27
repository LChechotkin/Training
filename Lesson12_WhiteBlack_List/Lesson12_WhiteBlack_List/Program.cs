using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Lesson12_WhiteBlack_List
{
    class Program
    {
        static void Main()
        {
            FilteringMethods FilterOut = new FilteringMethods();

            FilterOut.WhiteFilter(@"..\..\input.txt",@"..\..\white_output.txt",@"..\..\whitelist.txt");
            FilterOut.BlackFilter(@"..\..\input.txt", @"..\..\black_output.txt", @"..\..\blacklist.txt");
            FilterOut.BlackFilter(@"..\..\white_output.txt", @"..\..\black_white_output.txt", @"..\..\blacklist.txt");

            //Filtering with white list
            FilterOut.PrintFile(@"..\..\input.txt");
            FilterOut.PrintFile(@"..\..\white_output.txt");
            FilterOut.PrintFile(@"..\..\whitelist.txt");

            
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            //Filtering with black list
            FilterOut.PrintFile(@"..\..\black_output.txt");
            FilterOut.PrintFile(@"..\..\blacklist.txt");
            
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            //Filtering with black and white list
            FilterOut.PrintFile(@"..\..\black_white_output.txt");

            Console.ReadKey();
            

        }
    }
}
