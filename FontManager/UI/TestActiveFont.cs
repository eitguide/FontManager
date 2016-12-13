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
        }

        private void btnActive_Click(object sender, EventArgs e)
        {

            string fontName = "Ubuntu-Bold.ttf";
            string fontFolderPath = FileManager.GetInstance().GetFontsFolderProject();
            string fontPath = Path.Combine(Path.Combine(fontFolderPath, "Actived"), fontName);
           // Logger.d(fontInstallation.InstallFont(fontPath).ToString());

          fontInstallation.RemoveFont(Path.GetFileName(fontPath));

        }

        private void btnDisable_Click(object sender, EventArgs e)
        {
            string pathFont = Path.Combine(FileManager.GetInstance().GetFontsSystemFolder(), "RobotoSlab-Thin.ttf");
            fontManager.DisableFont(pathFont);

        }
    }
}
