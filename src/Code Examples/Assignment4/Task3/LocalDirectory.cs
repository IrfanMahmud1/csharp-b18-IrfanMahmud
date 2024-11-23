namespace Task3
{
    public class LocalDirectory
    {
        private readonly string _path;
        public LocalDirectory(string path)
        {
            _path = path;
            Directory.SetCurrentDirectory(path);
        }

        public void CreateFile(string name)
        {
            File.Create(name);
        }

        public bool isFileExist(string name)
        {
            if (File.Exists(name))
                return true;
            else
                return false;
        }

        public void WriteLine(string name,string[] text)
        {
            if (string.IsNullOrEmpty(name))
            {
                return;
            }
            File.WriteAllLines(name, text);
        }

        public string[] GetFileData(string name)
        {
            return File.ReadAllLines(name);
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
