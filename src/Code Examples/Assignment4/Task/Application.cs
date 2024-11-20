using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class Application
    {
        public void Start()
        {
            LocalDirectory localDirectory = new LocalDirectory();
            string path = localDirectory.SelectPath();

            bool isExist = localDirectory.isFileExist(path);

            if (!isExist)
            {
                localDirectory.CreateFile("Data.txt");
                string[] data = localDirectory.SelectData();
                localDirectory.WriteLine(path, data);
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
            //        break;
            //    }
            //}

        }
    }
}
