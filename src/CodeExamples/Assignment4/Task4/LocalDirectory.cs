using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class LocalDirectory
    {
        private string fileName;

        public LocalDirectory(string path)
        {
            fileName = path;
        }

        public void CreateFile(string path)
        {
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

            var directory = Directory.GetCurrentDirectory();
            if (!string.IsNullOrEmpty(directory))
            {
                Directory.SetCurrentDirectory(directory);
            }
            File.WriteAllLines(path, text);
        }

        public string[] GetFileData()
        {
            var path = fileName.ToString();
            return File.ReadAllLines(path);
        }

        public List<string> SelectData()
        {
            var textLine = new List<string>();
            textLine.Add("Abdullah 39 3.5");
            textLine.Add("Hasan 34 4.2");
            textLine.Add("Mamun 44 3.9");
            textLine.Add("Tareq 23 4.0");

            // Or can use a parameter line to take the number of text line from the user
            //for (int i = 0; i < line; i++)
            //{
            //    textLine[i] = Console.ReadLine();

            //}
            return textLine;
        }
    }
}
