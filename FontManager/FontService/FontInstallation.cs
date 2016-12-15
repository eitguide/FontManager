using FontManager.Model;
using FontManager.Utils;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FontManager.FontService
{
    public class FontInstallation
    {
        [DllImport("gdi32.dll", EntryPoint = "AddFontResourceW", SetLastError = true)]
        public static extern int AddFontResource([In][MarshalAs(UnmanagedType.LPWStr)] string lpFileName);

        [DllImport("gdi32.dll", EntryPoint = "RemoveFontResourceW", SetLastError = true)]
        public static extern int RemoveFontResource([In][MarshalAs(UnmanagedType.LPWStr)]
                                            string lpFileName);

        private RegistryKey registryKey;
        private FileManager fileManager;

        public FontInstallation()
        {
            registryKey = Registry.LocalMachine.OpenSubKey(@"Software\Microsoft\Windows NT\CurrentVersion\Fonts", true);
            fileManager = FileManager.GetInstance();
        }

        public string[] GetListFontNameInstalled()
        {
            return registryKey.GetValueNames();
        }

        public List<FontInfo> GetListFontInfoInstalled()
        {
            String[] fontNames = GetListFontNameInstalled();
            Logger.d("######" + fontNames.Length.ToString());
            
            if (fontNames == null || fontNames.Length == 0)
                return null;


           

            List <FontInfo> infos = new List<FontInfo>();
            int count = fontNames.Length;
            for (int i = 0; i < count; i++)
            {
                object name = this.registryKey.GetValue(fontNames[i]);
                if (name != null)
                {
                    FontInfo info = new FontInfo();
                    info.NameInRegistry = fontNames[i];
                    info.FileNameInRegistry = name as string;
                    info.Disable = false;
                    infos.Add(info);
                }
            }

            return infos;
        }


        private bool CheckFontIntalledInRegistry(string fileNameNoExtenstoin, string fileName)
        {
            if (this.registryKey.GetValueNames().Contains(fileNameNoExtenstoin) && (string)this.registryKey.GetValue(fileNameNoExtenstoin) == fileName)
                return true;
            return false;
        }

        public InstallError InstallFont(string filepath)
        {
            string fileNoExtentsion = Path.GetFileNameWithoutExtension(filepath);
            string fileName = Path.GetFileName(filepath);

            string fontFolderSystem = fileManager.GetFontsSystemFolder();
            string destinationFontFile = Path.Combine(fontFolderSystem, fileName);

            if (File.Exists(destinationFontFile) && CheckFontIntalledInRegistry(fileNoExtentsion, fileName))
                return InstallError.INSTALL_DUPLICATE;
               
            fileManager.CopyFileTo(filepath, fontFolderSystem);
            this.registryKey.SetValue(fileNoExtentsion, fileName);

            return InstallError.INSTALL_SUSCESS;
        }

        public void RemoveFont(string fileName)
        {

            string fontFolderSystem = fileManager.GetFontsSystemFolder();
            string destinationFontFile = Path.Combine(fontFolderSystem, fileName);

            string key = Path.GetFileNameWithoutExtension(fileName);

            if (this.registryKey.GetValue(key) == null)
                return;

            this.registryKey.DeleteValue(key);

            if (File.Exists(destinationFontFile))
                fileManager.DeleteFile(destinationFontFile);
        }

    }


}
