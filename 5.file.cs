using System;
using System.IO;
namespace FileExample
{
    public class FileExample
    {
        public static void Main()
        {
            FileStream F = new FileStream("1.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);

           for (int i = 65; i <= 80; i++)
            {
                F.WriteByte((byte)i); //this will write to file
            }
            F.Position = 0;
            for (int i = 65; i <= 80; i++)
            {
                Console.Write(F.ReadByte() + " ");//this will read from file
            }
            F.Close();
        }
    }
}
