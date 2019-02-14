using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task1
{
    class FarManager
    {
        public int cursor,sz;//declaring all variables 
        public bool ok;
        public string path;
        DirectoryInfo di = null;
        FileSystemInfo fsi = null;
        public FarManager()
        {
            cursor = 0;
        }
        public FarManager(string path)//the method that with all the main variables to run the program
        {
            this.path = path;
            cursor = 0;
            di = new DirectoryInfo(path);
            sz = di.GetFileSystemInfos().Length;
            ok = true;
        }
        public void Color(FileSystemInfo fs,int index)//colors 
        {
            if (cursor == index)//color the cursor
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                fsi = fs;
            }
            else if (fs.GetType() == typeof(DirectoryInfo))//the color of the folder or objects
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }
            else//anything
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.DarkYellow;
            }
        }
        public void Show()// method that can show the menu 
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            di = new DirectoryInfo(path);
            FileSystemInfo[] fs = di.GetFileSystemInfos();
            for(int i = 0, k = 0; i < fs.Length; i++)
            {
                if(ok==false && fs[i].Name[0] == '.')
                {
                    continue;
                }
                Color(fs[i], k);
                Console.WriteLine(fs[i].Name);
                k++;
            }
        }
        public void Up()//function to raise up
        {
            cursor--;
            if (cursor < 0)
                cursor = sz - 1;
        }
        public void Down()//function to reduce down
        {
            cursor++;
        if (cursor ==sz)
                cursor = 0;
        }
        public void CalcSz()//function which check  folder and idnexes
        {
            di = new DirectoryInfo(path);
            FileSystemInfo[] fs = di.GetFileSystemInfos();
            sz =fs.Length;
            if (ok == false)
            {
                for(int i = 0; i < fs.Length; i++)
                {
                    if (fs[i].Name[0] == '.')
                        sz--;
                }
            }
        }
        public void Start()
        {
            ConsoleKeyInfo conskey = Console.ReadKey();
            while (conskey.Key != ConsoleKey.Escape)//escape will terminate the program
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
                    cursor=0;
                    ok = true;
                }
                if (conskey.Key == ConsoleKey.Enter)
                {
                    if (fsi.GetType() == typeof(DirectoryInfo)){//if open the folder,then cursor is always top
                        cursor = 0;
                        path = fsi.FullName;
                    }
                }
                if (conskey.Key == ConsoleKey.Backspace)//for going back in folder
                {
                    cursor = 0;
                    path=di.Parent.FullName;//returns  previous folder
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Ержан";
            FarManager farManager = new FarManager(path);
            farManager.Start();
        }
    }
}
