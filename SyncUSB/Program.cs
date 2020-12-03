using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncUSB
{
    class Program
    {

        static string PATH;

        static List<string> files;
        static List<string> folders;

        static void Main(string[] args)
        {
            var stringBuilder = new StringBuilder();
            foreach (var arg in args)
                stringBuilder.Append(arg);
            PATH = stringBuilder.ToString().Replace("\"", String.Empty);



            Console.ReadKey();
        }

        

        static void Sync(string path1, string path2)
        {
            
        }

        static List<string> GetFiles(string path)
        {
            var list = new List<string>();

            foreach(var file in Directory.GetFiles(path))
            {
                if (!File.Exists(file) || !HasFileAccess(path))
                    continue;

                list.Add(MakeRelative(file));
            }
            foreach(var folder in folders)
            {
                foreach(var file in Directory.GetFiles(MakeAbsolute(folder)))
                {
                    if (!File.Exists(file) || !HasFileAccess(path))
                        continue;

                    list.Add(MakeRelative(file));
                }
            }
            
            return list;
        }

        static List<string> GetFolders(string path)
        {
            var list = new List<string>();

            if (!Directory.Exists(path) || !HasDirectoryAccess(path))
                return null;

            foreach(var dir in Directory.GetDirectories(path))
            {
                list.Add(MakeRelative(dir));
                list.AddRange(GetFolders(dir));
            }

            return list;
        }

        static string MakeRelative(string path)
        {
            return path.Substring(PATH.Length);
        }

        static string MakeAbsolute(string path)
        {
            return PATH + path;
        }

        static bool HasFileAccess(string path)
        {
            try
            {
                var file = new FileInfo(path);
                file.GetAccessControl();
                return true;
            }
            catch
            {
                return false;
            }
        }

        static bool HasDirectoryAccess(string path)
        {
            try
            {
                var di = new DirectoryInfo(path);
                di.GetAccessControl();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
