using FontManager.FontService;
using FontManager.Utils;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FontManager.UI
{
    public partial class TestActiveFont : Form
    {
        private FontManager.Manager.FontManager fontManager;
        private FontInstallation fontInstallation;
      
        
        public TestActiveFont()
        {
            InitializeComponent();
            fontManager = FontManager.Manager.FontManager.GetInstance();
            fontInstallation = new FontInstallation();
           

            Load += TestActiveFont_Load;
        }

        private void TestActiveFont_Load(object sender, EventArgs e)
        {
            ///SharedData.SharedData.FontInfos = fontInstallation.GetListFontInfoInstalled();
        }

        private void btnActive_Click(object sender, EventArgs e)
        {
            string fontName = "VNF-Strangelove-text.ttf";
            string fontFolderPath = FileManager.GetInstance().GetFontsFolderProject();
            string fontPath = Path.Combine(Path.Combine(fontFolderPath, "Disable"), fontName);
            Logger.d(fontInstallation.InstallFont(fontPath).ToString());
        }

        private void btnDisable_Click(object sender, EventArgs e)
        {
            string pathFont = Path.Combine(FileManager.GetInstance().GetFontsSystemFolder(), "Ubuntu-Bold.ttf");
            fontInstallation.RemoveFont(Path.GetFileName(pathFont));
        }
    }
}
