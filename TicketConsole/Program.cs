using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketConsole.DataAccess;

namespace TicketConsole
{
    /// <summary>
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            FileManager manager = new FileManager();
            manager.Write("This is a line");

            manager.Read();
            Console.WriteLine(manager.Contents);

        }
    }
}
