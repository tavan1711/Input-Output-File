//This program will open given file and print each line from the file with line number
using System;
using System.IO;
namespace streamreaderexample
{
    public class streamreaderexample
    {
        public static void Main()
        {
            try
            {
                StreamReader reader = new StreamReader("teststream.txt");
                using (reader)
                {
                    int lineNumber = 0;
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        lineNumber++;
                        Console.WriteLine("Line {0}: {1}", lineNumber, line);
                        line = reader.ReadLine();
                    }
                }
            }
            catch(FileNotFoundException e)
            {
                Console.WriteLine("Error: Where is the FILE?? {0} ",e.FileName);
            }
            
        }
    }
}