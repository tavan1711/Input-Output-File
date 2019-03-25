using System;
using System.IO;

public class CopyFile
{
    public void copyFile(string file1, string file2)
    { 
        using(StreamReader reader = new StreamReader(file1))
        using (StreamWriter writer = new StreamWriter(file2))
        {
            string line = null;
            while ((line = reader.ReadLine()) != null)
                writer.WriteLine(line);
        }
    }
}
class MainClass
{
    public static void Main()
    {
        CopyFile cp = new CopyFile();
        string file1 = @"C:\Users\CRP\Google Drive\Subjects\DOT NET\Topics\File\1.txt";
        string file2 = @"C:\Users\CRP\Google Drive\Subjects\DOT NET\Topics\File\2.txt";
        cp.copyFile(file1,file2);
    }
}