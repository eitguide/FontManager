using FontManager;
using FontManager.FontService;
using FontManager.Model;
using FontManager.Properties;
using FontManager.SharedData;
using FontManager.Utils;
using SharpFont;
using SharpFont.TrueType;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace FontMananger.UI
{
    public partial class frmMain : Form
    {
        // Khai bao cac thanh phan su dung cho viec Keo' di chuyen form
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private const int FORM_PADDING = 5;
        private const int FORM_BORDER_THICKNESS = 4;

        private FontManager.Manager.FontManager fontManager;
        private FontReading fontReading;
        private FontInstallation fontInstallation;
        private FileManager fileManager;


        public frmMain()
        {
            InitializeComponent();
            Load += FrmMain_Load;

            // Set mau sac cho cac thanh phan cua form
            SetFormBorderColor(Color.FromArgb(127, 140, 141));          // #7f8c8d
            pnlTitle.BackColor = Color.FromArgb(147, 158, 159);         // #939e9f
            pnlMenu.BackColor = Color.FromArgb(149, 165, 166);          // #95a5a6
            pnlListFont.BackColor = Color.FromArgb(189, 195, 199);      // #bdc3c7
            pnlShowContent.BackColor = Color.FromArgb(236, 240, 241);   // #ecf0f1

            // Them callback cho viec Keo' di chuyen form
            pnlColumn1.MouseDown += DragMoveFormCallback;
            pnlColumn2.MouseDown += DragMoveFormCallback;
            pnlColumn3.MouseDown += DragMoveFormCallback;
            pnlColumn4.MouseDown += DragMoveFormCallback;

            MakeFormBackgroundTransparent(Color.MediumAquamarine);

            btnClose.Click += BtnClose_Click;
            btnMaximize.Click += BtnMaximize_Click;
            this.SizeChanged += FrmMain_SizeChanged;
            btnMinimize.Click += BtnMinimize_Click;

            //set icon for application
            this.Icon = FontManager.Properties.Resources.icon_application;

          

         
            fontReading = new FontReading();
            fontInstallation = new FontInstallation();
            fontManager = FontManager.Manager.FontManager.GetInstance();
            fileManager = FileManager.GetInstance();
            

            lbFonts.SelectedIndex = -1;

            //setup font support
            SetupSupportFontFormat();
        }

      

        private void SetupSupportFontFormat()
        {
            fontManager.AddFontFormat(FontType.TTF);
            fontManager.AddFontFormat(FontType.OTF);
        }

       

        private void FrmMain_Load(object sender, EventArgs e)
        {

            SharedData.FontInfos = fontInstallation.GetListFontInfoInstalled();
            lbFonts.DataSource = SharedData.FontInfos;


            SharedData.FontInfos.ForEach(i => Logger.d(i.FileNameInRegistry + ", "));
            lbFonts.SelectedIndexChanged += lbFonts_SelectedIndexChanged;
            //List<FileInfo> files = (List<FileInfo>)fontManager.GetAllFontsIntalled();

            //for (int i = 0; i < 10 /*files.Count*/; i++)
            //{
            //    Logger.d("FontPath: " + files[i].FullName);
            //    FontInfo fontInfo = fontReading.ReadingFontInfo(files[i].FullName);
            //    Logger.FontInfomation(fontInfo);
            //}
        }

        //private void TestFont()
        //{
        //    Library lib = new Library();

        //    FontManager.Manager.FontManager fontManager = FontManager.Manager.FontManager.GetInstance();
        //    string fontFolderPath = FileManager.GetInstance().GetFontsFolderProject();

        //    string fontPath = Path.Combine(Path.Combine(fontFolderPath, "Actived"), "Cousine-Regular-Latin.ttf");

        //    FontInfo info = fontReading.ReadingFontInfo(fontPath);
        //    Logger.FontInfomation(info);
        //    Face face = new Face(lib, fontPath);

        //    for (int i = 0; i < face.CharmapsCount; i++)
        //    {
        //        Console.WriteLine(face.CharMaps[i].PlatformId);
        //        Console.WriteLine(face.CharMaps[i].Encoding);
        //        Console.WriteLine(face.CharMaps[i].EncodingId);
        //    }

        //  //  PrintSfnt(face);
        //}

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FrmMain_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
                btnMaximize.Image = Resources.icon_maximize_exit_16x16;
                this.Padding = new Padding(0);
                DisableFormBorder(true);
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Normal;
                btnMaximize.Image = Resources.icon_maximize_16x16;
                this.Padding = new Padding(FORM_PADDING);
                DisableFormBorder(false);
            }
        }

        private void BtnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                btnMaximize.Image = Resources.icon_maximize_exit_16x16;
                this.Padding = new Padding(0);
                DisableFormBorder(true);
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                btnMaximize.Image = Resources.icon_maximize_16x16;
                this.Padding = new Padding(FORM_PADDING);
                DisableFormBorder(false);
            }
        }

        private void DisableFormBorder(bool toggle)
        {
            if (toggle == true)
            {
                pnlBorder.Padding = new Padding(0);
            }
            else
            {
                pnlBorder.Padding = new Padding(FORM_BORDER_THICKNESS);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MakeFormBackgroundTransparent(Color colorNeedToAvoid)
        {
            this.BackColor = colorNeedToAvoid;
            this.TransparencyKey = colorNeedToAvoid;
            //this.BackColor = Color.FromArgb(0, 255, 255, 255);
        }

        // Chuc nang resize form
        protected override void WndProc(ref Message m)
        {
            const int wmNcHitTest = 0x84;
            const int htLeft = 10;
            const int htRight = 11;
            const int htTop = 12;
            const int htTopLeft = 13;
            const int htTopRight = 14;
            const int htBottom = 15;
            const int htBottomLeft = 16;
            const int htBottomRight = 17;

            if (m.Msg == wmNcHitTest)
            {
                int x = (int)(m.LParam.ToInt64() & 0xFFFF);
                int y = (int)((m.LParam.ToInt64() & 0xFFFF0000) >> 16);
                Point pt = PointToClient(new Point(x, y));
                Size clientSize = ClientSize;
                ///allow resize on the lower right corner
                if (pt.X >= clientSize.Width - 16 && pt.Y >= clientSize.Height - 16 && clientSize.Height >= 16)
                {
                    m.Result = (IntPtr)(IsMirrored ? htBottomLeft : htBottomRight);
                    return;
                }
                ///allow resize on the lower left corner
                if (pt.X <= 16 && pt.Y >= clientSize.Height - 16 && clientSize.Height >= 16)
                {
                    m.Result = (IntPtr)(IsMirrored ? htBottomRight : htBottomLeft);
                    return;
                }
                ///allow resize on the upper right corner
                if (pt.X <= 16 && pt.Y <= 16 && clientSize.Height >= 16)
                {
                    m.Result = (IntPtr)(IsMirrored ? htTopRight : htTopLeft);
                    return;
                }
                ///allow resize on the upper left corner
                if (pt.X >= clientSize.Width - 16 && pt.Y <= 16 && clientSize.Height >= 16)
                {
                    m.Result = (IntPtr)(IsMirrored ? htTopLeft : htTopRight);
                    return;
                }
                ///allow resize on the top border
                if (pt.Y <= 16 && clientSize.Height >= 16)
                {
                    m.Result = (IntPtr)(htTop);
                    return;
                }
                ///allow resize on the bottom border
                if (pt.Y >= clientSize.Height - 16 && clientSize.Height >= 16)
                {
                    m.Result = (IntPtr)(htBottom);
                    return;
                }
                ///allow resize on the left border
                if (pt.X <= 16 && clientSize.Height >= 16)
                {
                    m.Result = (IntPtr)(htLeft);
                    return;
                }
                ///allow resize on the right border
                if (pt.X >= clientSize.Width - 16 && clientSize.Height >= 16)
                {
                    m.Result = (IntPtr)(htRight);
                    return;
                }
            }

            base.WndProc(ref m);
        }

        // Chuc nang keo title de di chuyen form
        private void DragMoveFormCallback(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        // Chinh mau sac cho Vien` form
        private void SetFormBorderColor(Color color)
        {
            pnlBorder.BackColor = color;
        }

        private void lbFonts_SelectedIndexChanged(object sender, EventArgs e)
        {
            FontInfo info = lbFonts.SelectedItem as FontInfo;
            Logger.d(info == null ? "" : info.NameInRegistry);

           
            string filePath = Path.Combine(fileManager.GetFontsSystemFolder(), info.FileNameInRegistry);
            fontReading.ReadingFontInfo(filePath, ref info);
            Logger.FontInfomation(info);
        }

       
    }
}
