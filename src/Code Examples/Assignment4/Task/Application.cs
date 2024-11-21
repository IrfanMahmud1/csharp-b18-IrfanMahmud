using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class Application
    {
        private ApplicationDbContext _db;

        public Application(ApplicationDbContext db)
        {
            _db = db;
        }

        public void InsertData(string data)
        {

        }
        public void Start()
        {
            LocalDirectory localDirectory = new LocalDirectory();
            string path = localDirectory.SelectPath();

            bool isExist = localDirectory.isFileExist(path);
            string[] data = [];
            if (!isExist)
            {
                localDirectory.CreateFile("Data.txt");
            }

            data = localDirectory.SelectData();
            localDirectory.WriteLine(path, data);
            string[] fileData = localDirectory.GetFileData();

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
