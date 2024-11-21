using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class LocalDirectory
    {
        private StringBuilder fileName;

        public LocalDirectory()
        {
            fileName = new StringBuilder("");
        }
        public void CreateFile(string path)
        {
            fileName = fileName.Append(path);
            File.Create(path);
        }

        public bool isFileExist(string path)
        {
            if (File.Exists(path))
                return true;
            else
                return false;
        }

        public void WriteLine(string path, string[] text)
        {
            if (string.IsNullOrEmpty(path))
            {
                return;
            }

            string directory = Directory.GetCurrentDirectory();
            if (!string.IsNullOrEmpty(directory))
            {
                Directory.SetCurrentDirectory(directory);
            }
            File.WriteAllLines(path, text);
        }

        public string SelectPath()
        {
            //string path = Console.ReadLine();
            string path = "Data.txt";
            return path;
        }

        public string[] GetFileData()
        {
            return File.ReadAllLines(fileName.ToString());
        }

        public string[] SelectData()
        {
            string[] textLine = new string[4];
            textLine[0] = "Abdullah 39 3.5";
            textLine[1] = "Hasan 34 4.2";
            textLine[2] = "Mamun 44 3.9";
            textLine[3] = "Tareq 23 4.0";

            // Or can use a parameter line to take the number of text line from the user
            //for (int i = 0; i < line; i++)
            //{
            //    textLine[i] = Console.ReadLine();

            //}
            return textLine;
        }
    }
}
