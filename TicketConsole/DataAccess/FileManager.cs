using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketConsole.DataAccess
{
    public class FileManager
    {
        private readonly string _fileName;

        public string Contents { get; set; }

        public FileManager()
        {
            _fileName = AppDomain.CurrentDomain.BaseDirectory + "data.txt";
        }

        public void Read()
        {
            if (File.Exists(_fileName))
            {
                StreamReader ticketFile = new StreamReader(_fileName);

                while (!ticketFile.EndOfStream)
                {
                    Contents = ticketFile.ReadLine();
                }
            }
        }
        public void Write(string line)
        {
            StreamWriter writer = new StreamWriter(_fileName, append: true);
            writer.WriteLine($"{line}");
            writer.Close();
        }
    }
}
