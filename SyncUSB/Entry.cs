using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncUSB
{
    class Entry
    {

        private string fromPath;
        private string toPath;

        public string FromPath { get => fromPath; }
        public string ToPath { get => toPath; }

        public Entry(string fromPath, string toPath)
        {
            this.fromPath = fromPath;
            this.toPath = toPath;
        }

        public static Entry CompareFiles(string fileOne, string fileTwo)
        {
            var fiOne = new FileInfo(fileOne);
            var fiTwo = new FileInfo(fileOne);

            return CompareFiles(fiOne, fiTwo);
        }

        public static Entry CompareFiles(FileInfo fileOne, FileInfo fileTwo)
        {
            if(fileOne.LastWriteTime.CompareTo(fileTwo.LastWriteTime) < 0)
            {
                return new Entry(fileOne.FullName, fileTwo.FullName);
            }
            else if(fileOne.LastAccessTime.CompareTo(fileTwo.LastAccessTime) == 0)
            {
                return null;
            }
            else
            {
                return new Entry(fileTwo.FullName, fileOne.FullName);
            }
        }

    }
}
