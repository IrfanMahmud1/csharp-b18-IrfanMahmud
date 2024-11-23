using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Application
    {
        private readonly ApplicationDbContext _db;

        private string _name;
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
            _db.SaveChanges();
        }
        public string SelectPath()
        {
            //string path = Console.ReadLine();
            var path = "C:\\Users\\User\\source\\repos\\Assignment4\\Task3";
            return path;
        }
        public void SelectFileName()
        {
            //string name = Console.ReadLine();
            var name = "Data.txt";
            _name = name;
        }
        public void Start()
        {
            var path = SelectPath();
            LocalDirectory localDirectory = new LocalDirectory(path);

            SelectFileName();

            if (!localDirectory.isFileExist(_name))
            {
                localDirectory.CreateFile(_name);
            }

            var data = localDirectory.SelectData();
            localDirectory.WriteLine(_name,data.ToArray());
            var fileData = localDirectory.GetFileData(_name);

            for(int i = 0; i < fileData.Length; i++)
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
            //}C:\Users\User\source\repos\Assignment4\Task3\Task3.csproj

        }
    }
}
