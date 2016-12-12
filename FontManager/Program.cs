using FontMananger.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FontManager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            String fontFile = @Environment.CurrentDirectory + "\\Cabin-Bold.ttf";
            String name = Path.GetFileName(fontFile);
            String destination = Directory.GetParent(Environment.CurrentDirectory).FullName;


            //FileManager manager = FileManager.GetInstance();

            //  manager.CopyFileTo(fontFile, manager.GetFontsSystemFolder());

            //String path = Path.Combine(manager.GetCurrentFolderWorking(), Path.GetFileName(fontFile));
            //FontManager.Manager.FontManager.GetInstance().
            //     ActiveFont(path);

            //List<FileInfo> infos = (List<FileInfo>)manager.GetListFiles(manager.GetFontsSystemFolder());
            //for (int i = 0; i < infos.Count; i++)
            //{
            //    Console.WriteLine(infos[i].Name);
            //}



            
          

            Application.Run(new frmMain());

        }
    }
}
