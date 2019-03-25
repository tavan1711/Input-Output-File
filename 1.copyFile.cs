//This program will Copy Data from one file to another
//If Destination file doesnt exists it will create new otherwise overwrite
using System;
using System.IO;
class MyClass
{
    public static void Main()
    {
        string file1 = @"1.txt";
        string file2 = @"2.txt";
        using (StreamReader reader = new StreamReader(file1))
        using (StreamWriter writer = new StreamWriter(file2))
            writer.Write(reader.ReadToEnd());
    }
}