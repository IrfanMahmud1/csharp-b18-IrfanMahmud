using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Application
    {
        private readonly ApplicationDbContext _db;
        public Application()
        {
            _db = new ApplicationDbContext();
        }
        public void InsertData(string data)
        {
            var student = new Student();

            var s = data.Split(' ');

            student.Name = s[0];
            student.Age = int.Parse(s[1]);
            student.CGPA = double.Parse(s[2]);

            _db.Students.Add(student);
        }
        public string SelectPath()
        {
            //string path = Console.ReadLine();
            var path = "C:\\Users\\User\\source\\repos\\c# devskill\\csharp-b18-IrfanMahmud\\src\\Code Examples\\Assignment4\\Task\\Data.txt";
            return path;
        }
        public void Start()
        {
            var path = SelectPath();
            LocalDirectory localDirectory = new LocalDirectory(path);

            var isExist = localDirectory.isFileExist(path);

            if (!isExist)
            {
                localDirectory.CreateFile(path);
            }

            var data = localDirectory.SelectData();
            localDirectory.WriteLine(path, data.ToArray());
            var fileData = localDirectory.GetFileData();

            for (int i = 0; i < fileData.Length; i++)
            {
                InsertData(fileData[i]);
            }
            // Or we can use a while loop to check untill the given file exists.
            //while(isExist)
            //{
            //    if (isExist)
            //    {
            //        path = Console.ReadLine();
            //    }
            //    if (!localDirectory.isFileExist(path))
            //    {
            //        localDirectory.CreateFile("Data.txt");
            //        string[] data = localDirectory.SelectData();
            //        localDirectory.WriteLine(path, data);
            //        break;
            //    }
            //}

        }
    }
}
