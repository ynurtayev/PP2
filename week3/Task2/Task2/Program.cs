using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task2
{
    class FarManager
    {
        public int cursor, sz;
        public bool ok;
        public string path;
        DirectoryInfo di = null;
        FileSystemInfo fsi = null;
        public FarManager()
        {
            cursor = 0;
        }
        public FarManager(string path)
        {
            cursor = 0;
            this.path = path;
            di = new DirectoryInfo(path);
            sz = di.GetFileSystemInfos().Length;
            ok = true;
        }
        public void Color(FileSystemInfo fs, int index)
        {
            if (cursor == index)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                fsi = fs;
            }
            else if (fs.GetType() == typeof(DirectoryInfo))
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.DarkYellow;
            }
        }
        public void Show()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            di = new DirectoryInfo(path);
            FileSystemInfo[] fs = di.GetFileSystemInfos();
            for (int i = 0, k = 0; i < fs.Length; i++)
            {
                if (ok == false && fs[i].Name[0] == '.')
                {
                    continue;
                }
                Color(fs[i], k);
                Console.WriteLine(fs[i].Name);
                k++;
            }
        }
        public void Up()
        {
            cursor--;
            if (cursor < 0)
                cursor = sz - 1;
        }
        public void Down()
        {
            cursor++;
            if (cursor == sz)
                cursor = 0;
        }

        public void CalcSz()
        {
            di = new DirectoryInfo(path);
            FileSystemInfo[] fs = di.GetFileSystemInfos();
            sz = fs.Length;
            if (ok == false)
            {
                for(int i = 0; i < fs.Length; i++)
                {
                    if (fs[i].Name[0] == '.')
                    {
                        sz--;
                    }
                }
            }
        }
        public void Delete(string dir)
        {
            string[] files = Directory.GetFiles(dir);
            string[] dirs = Directory.GetDirectories(dir);
            foreach(string file in files)
            {
                File.SetAttributes(file, FileAttributes.Normal);
                File.Delete(file);
            }
            foreach(string dirr in dirs)
            {
                Delete(dir);
            }
            Directory.Delete(dir, false);
        }
        public void Start()
        {
            ConsoleKeyInfo conskey = Console.ReadKey();
            while (conskey.Key != ConsoleKey.Escape)
            {
                CalcSz();
                Show();
                conskey = Console.ReadKey();
                if (conskey.Key == ConsoleKey.UpArrow) Up();
                if (conskey.Key == ConsoleKey.DownArrow) Down();
                if (conskey.Key == ConsoleKey.RightArrow)
                {
                    ok = false;
                    cursor = 0;
                }
                if (conskey.Key == ConsoleKey.LeftArrow)
                {
                    cursor = 0;
                    ok = true;
                }
                if (conskey.Key == ConsoleKey.Enter)
                {
                    if (fsi.GetType() == typeof(DirectoryInfo))
                    {
                        cursor = 0;
                        path = fsi.FullName;
                    }
                }
                if (conskey.Key == ConsoleKey.Backspace)
                {
                    cursor = 0;
                    path = di.Parent.FullName;
                }
                if (conskey.Key == ConsoleKey.D)
                {
                    if(fsi is DirectoryInfo)
                    {
                        Delete(fsi.FullName);
                    }
                    else
                    {
                        fsi.Delete();
                    }
                    cursor = 0;
                }
                if (conskey.Key == ConsoleKey.P)
                {
                    string oldname = fsi.FullName;
                    string newname = Console.ReadLine();
                    Directory.Move(oldname, path + "/" + newname);
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Ержан\Desktop";
            FarManager farManager = new FarManager(path);
            farManager.Start();
        }
    }
}
