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

        const string LOCAL_PATH = "C:/Users/felix/Desktop";
        const string REMOTE_PATH = "E:/Test";

        static List<string> filesLocal;
        static List<string> foldersLocal;

        static List<string> filesRemote;
        static List<string> foldersRemote;

        static void Main(string[] args)
        {
            /**
            var stringBuilder = new StringBuilder();
            foreach (var arg in args)
                stringBuilder.Append(arg);
            PATH = stringBuilder.ToString().Replace("\"", String.Empty);
            */

            //foldersLocal = GetFolders(LOCAL_PATH);
            //filesLocal = GetFiles(LOCAL_PATH);

            //foldersRemote = GetFolders(REMOTE_PATH);
            //filesRemote = GetFiles(REMOTE_PATH);

            filesLocal = GetFiles(LOCAL_PATH, LOCAL_PATH.Length);
            filesRemote = GetFiles(REMOTE_PATH, REMOTE_PATH.Length);

            foldersLocal = GetFolders(LOCAL_PATH, LOCAL_PATH.Length);
            foldersRemote = GetFolders(REMOTE_PATH, REMOTE_PATH.Length);

            Sync();


            Console.ReadKey();
        }

        

        static void Sync()
        {
            
            foreach(var f in filesLocal)
            {
                var file = new FileInfo(f);
                
                if(!filesRemote.Contains(f))
                {
                    new DirectoryInfo(MakeAbsolute(new FileInfo(f).DirectoryName, REMOTE_PATH)).Create();
                    file.CopyTo(MakeAbsolute(f, REMOTE_PATH));
                }
            }
        }



        static List<string> GetFiles_(string path, string prefix)
        {
            var list = new List<string>();

            foreach(var file in Directory.GetFiles(path))
            {
                if (!File.Exists(file) || !HasFileAccess(path))
                    continue;

                list.Add(MakeRelative(file, prefix.Length));
            }
            foreach(var folder in foldersLocal)
            {
                foreach(var file in Directory.GetFiles(MakeAbsolute(folder, prefix)))
                {
                    if (!File.Exists(file) || !HasFileAccess(path))
                        continue;

                    list.Add(MakeRelative(file, prefix.Length));
                }
            }
            
            return list;
        }

        static List<string> GetFiles(string path, int prefixLength)
        {
            var list = new List<string>();

            if (!Directory.Exists(path) || !HasDirectoryAccess(path))
                return list;

            foreach(var f in Directory.GetFiles(path))
            {
                if (!File.Exists(f) || !HasFileAccess(path))
                    continue;

                list.Add(MakeRelative(f, prefixLength));
            }

            foreach(var dir in Directory.GetDirectories(path))
            {
                list.AddRange(GetFiles(dir, prefixLength));
            }

            return list;
        }

        static List<string> GetFolders(string path, int prefixLength)
        {
            var list = new List<string>();

            if (!Directory.Exists(path) || !HasDirectoryAccess(path))
                return list;

            foreach(var dir in Directory.GetDirectories(path))
            {
                list.Add(MakeRelative(dir, prefixLength));
                list.AddRange(GetFolders(dir, prefixLength));
            }

            return list;
        }

        static string MakeRelative(string path, int prefixLength)
        {
            return path.Substring(prefixLength);
        }

        static string MakeAbsolute(string path, string prefix)
        {
            return prefix + ((prefix[prefix.Length - 1] == '/' || prefix[prefix.Length - 1] == '\\') ? "" : Path.DirectorySeparatorChar.ToString()) + path;
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
