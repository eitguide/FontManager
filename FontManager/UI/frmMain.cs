using FontManager.Callback;
using FontManager.FontService;
using FontManager.Model;
using FontManager.Properties;
using FontManager.UI.Control;
using FontManager.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace FontManager.UI
{
    public partial class frmMain : Form
    {
        #region Khai bao cac thanh phan su dung cho viec Keo' di chuyen form
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        #endregion

        public event SearchtypeHandler listenter;

        #region PhucTV variable
        private enum MenuItem { AllFont, SystemFont, UserFont }
        private const int FORM_PADDING = 5;
        private const int FORM_BORDER_THICKNESS = 2;
        private Color RADIO_BTN_SELECTED_COLOR = ColorHelper.ConvertToARGB("#b1bcbd");
        private Color MENU_ITEM_SELECTED_COLOR = ColorHelper.ConvertToARGB("#518F9E");
        private Color TITLE_COLOR = ColorHelper.ConvertToARGB("#939e9f");
        private ContextMenuStrip cmSearchType = new ContextMenuStrip();
        private ContextMenu cmFontItem = new ContextMenu();
        private MenuItem selectedMenuItem;
        private FontFamily defaultFontFamilyViewSample = new FontFamily("Arial");
        private string selectedFontPath = null;

        #endregion

        #region NghiaVN Variable
        private FontManager.Manager.FontManager fontManager;
        private FontReading fontReading;
        private FontInstallation fontInstallation;
        private FileManager fileManager;

        #endregion

        public frmMain()
        {
            InitializeComponent();
            Load += FrmMain_Load;

            // Them callback cho viec Keo' di chuyen form
            #region
            pnlColumn1.MouseDown += DragMoveFormCallback;
            pnlColumn2.MouseDown += DragMoveFormCallback;
            pnlColumn3.MouseDown += DragMoveFormCallback;
            pnlColumn4.MouseDown += DragMoveFormCallback;
            listenter += SearchTypeClicked_listenter;
            #endregion

            // Set mau sac cho cac thanh phan cua form
            #region
            SetFormBorderColor(ColorHelper.ConvertToARGB("#7f8c8d"));
            pnlTitle.BackColor = TITLE_COLOR;
            pnlMenu.BackColor = ColorHelper.ConvertToARGB("#D6D6D6");
            pnlListFont.BackColor = ColorHelper.ConvertToARGB("#bdc3c7");
            pnlShowContent.BackColor = ColorHelper.ConvertToARGB("#ecf0f1");
            pnlSearchBox.BackColor = ColorHelper.ConvertToARGB("#9da8a9");
            txtSearchBox.BackColor = ColorHelper.ConvertToARGB("#9da8a9");
            btnViewAz09Sample.PerformClick();
            rtxtViewAz09Sample.BackColor = ColorHelper.ConvertToARGB("#ecf0f1");
            rtxtViewSentencesSample.BackColor = ColorHelper.ConvertToARGB("#ecf0f1");
            rtxtViewGridSample.BackColor = ColorHelper.ConvertToARGB("#ecf0f1");
            #endregion

            // Cac su kien cua cac control
            #region
            btnClose.Click += BtnClose_Click;
            btnMaximize.Click += BtnMaximize_Click;
            this.SizeChanged += FrmMain_SizeChanged;
            btnMinimize.Click += BtnMinimize_Click;
            btnViewAz09Sample.Click += BtnViewAz09Sample_Click;
            btnViewGridSample.Click += BtnViewGridSample_Click;
            btnViewSentencesSample.Click += BtnViewSentencesSample_Click;
            btnViewFontInfo.Click += BtnViewFontInfo_Click;
            picbxSearchOption.Click += PicbxSearchType_Click;
            cmSearchType.ItemClicked += CmSearchOption_ItemClicked;
            btnAddFonts.Click += BtnAddFonts_Click;
            btnDisOrEnableFont.Click += BtnDisOrEnableFont_Click;
            txtSearchBox.TextChanged += TxtSearchBox_TextChanged;
            btnAllFonts.Click += BtnAllFonts_Click;
            btnFontsSystem.Click += BtnFontsSystem_Click;
            btnFontsUser.Click += BtnFontsUser_Click;
            lbFonts.MouseDown += LbFonts_MouseDown;
            trbrEditSizeFontAz09View.Scroll += TrbrEditSizeFontAz09View_Scroll;
            trbrEditSizeFontSentencesView.Scroll += TrbrEditSizeFontSentencesView_Scroll;
            trbrEditSizeFontGridSampleView.Scroll += TrbrEditSizeFontGridSampleView_Scroll;
            #endregion

            // Khoi tao mot vai thanh phan
            #region
            MakeFormBackgroundTransparent(Color.MediumAquamarine);

            cmSearchType.Items.Add("All");
            cmSearchType.Items.Add("PostScript name");
            cmSearchType.Items.Add("Family");
            cmSearchType.Items.Add("Style");
            //cmSearchOption.Items.Add("Kind");
            cmSearchType.Items.Add("Copyright");
            cmSearchType.Items.Add("Language");
            cmSearchType.Items.Add("File name");
            cmSearchType.Items.Add("Manufacturer name");
            cmSearchType.Items.Add("Designer name");
            //cmSearchOption.Items.Add("Repertoire");

            cmFontItem.MenuItems.Add("Add Fonts...", new EventHandler(CmFontItemAddFont_Click));
            cmFontItem.MenuItems.Add("Enable/disable Font", new EventHandler(CmFontItemEnDisableFont_Click));
            cmFontItem.MenuItems.Add("Open file location", new EventHandler(CmFontItemOpenFileLocation_Click));

            ((ToolStripMenuItem)cmSearchType.Items[0]).Checked = true;
            selectedMenuItem = MenuItem.AllFont;

            // Khoi tao cac ky tu cho Grid Sample
            char c = '!'; int count = 1;
            do
            {
                rtxtViewGridSample.Text += "\t" + c++;
                count++;
            } while (count != 271);

            rtxtViewAz09Sample.SelectAll();
            rtxtViewAz09Sample.SelectionAlignment = HorizontalAlignment.Center;
            rtxtViewAz09Sample.Select(1, 0);
            #endregion
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

            BtnViewAz09Sample_Click(sender, e);
            BtnAllFonts_Click(sender, e);


            #region NghiaNV
            fileManager = FileManager.GetInstance();
            fontManager = FontManager.Manager.FontManager.GetInstance();
            fontInstallation = new FontInstallation();


            fontReading = new FontReading();
            fontInstallation = new FontInstallation();
            fontManager = FontManager.Manager.FontManager.GetInstance();
            fileManager = FileManager.GetInstance();

            lbFonts.SelectedIndex = -1;

            //setup font support
            SetupSupportFontFormat();

            SharedData.SharedData.FontInfos = fontInstallation.GetListFontInfoInstalled();
            lbFonts.DataSource = SharedData.SharedData.FontInfos;


            SharedData.SharedData.FontInfos.ForEach(i => Logger.d(i.FileNameInRegistry + ", "));
            lbFonts.SelectedIndexChanged += lbFonts_SelectedIndexChanged;

            lbFonts.BackColor = ColorHelper.ConvertToARGB("#95a5a6");
            #endregion
        }

        private void lbFonts_SelectedIndexChanged(object sender, EventArgs e)
        {
            FontInfo info = lbFonts.SelectedItem as FontInfo;
            Logger.d(info == null ? "" : info.NameInRegistry);

            string filePath = Path.Combine(fileManager.GetFontsSystemFolder(), info.FileNameInRegistry);
            fontReading.ReadingFontInfo(filePath, ref info);
            Logger.FontInfomation(info);

            selectedFontPath = filePath;

            // Cai font hien thi cho A-z 0-9 sample
            FontFamily ff = GetFontFamilyFromLocation(filePath);
            if (ff == null)
                rtxtViewAz09Sample.Font = new Font(defaultFontFamilyViewSample, rtxtViewAz09Sample.Font.Size);
            else
                rtxtViewAz09Sample.Font = new Font(ff, rtxtViewAz09Sample.Font.Size);

            // Cai font hien thi cho Sentences sample
            if (ff == null)
                rtxtViewSentencesSample.Font = new Font(defaultFontFamilyViewSample, rtxtViewSentencesSample.Font.Size);
            else
                rtxtViewSentencesSample.Font = new Font(ff, rtxtViewSentencesSample.Font.Size);

            // Cai font hien thi cho Grid sample
            if (ff == null)
                rtxtViewGridSample.Font = new Font(defaultFontFamilyViewSample, rtxtViewGridSample.Font.Size);
            else
                rtxtViewGridSample.Font = new Font(ff, rtxtViewGridSample.Font.Size);

            // Gan thong tin font cho panel font info
        }

        private void SetupSupportFontFormat()
        {
            fontManager.AddFontFormat(FontType.TTF);
            fontManager.AddFontFormat(FontType.OTF);
        }

        #region PhucTV
        private static FontFamily GetFontFamilyFromLocation(string pathFont)
        {
            if (File.Exists(pathFont) == false) return null;

            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(pathFont);
            return pfc.Families.Length > 0 ? pfc.Families[0] : null;
        }

        private void TrbrEditSizeFontAz09View_Scroll(object sender, EventArgs e)
        {
            switch (trbrEditSizeFontAz09View.Value)
            {
                case 1:
                    rtxtViewAz09Sample.Font = new Font(rtxtViewAz09Sample.Font.FontFamily, 14);
                    break;
                case 2:
                    rtxtViewAz09Sample.Font = new Font(rtxtViewAz09Sample.Font.FontFamily, 15);
                    break;
                case 3:
                    rtxtViewAz09Sample.Font = new Font(rtxtViewAz09Sample.Font.FontFamily, 17);
                    break;
                case 4:
                    rtxtViewAz09Sample.Font = new Font(rtxtViewAz09Sample.Font.FontFamily, 20);
                    break;
                case 5:
                    rtxtViewAz09Sample.Font = new Font(rtxtViewAz09Sample.Font.FontFamily, 24);
                    break;
                case 6:
                    rtxtViewAz09Sample.Font = new Font(rtxtViewAz09Sample.Font.FontFamily, 29);
                    break;
            }
        }

        private void TrbrEditSizeFontSentencesView_Scroll(object sender, EventArgs e)
        {
            switch (trbrEditSizeFontSentencesView.Value)
            {
                case 1:
                    rtxtViewSentencesSample.Font = new Font(rtxtViewSentencesSample.Font.FontFamily, 14);
                    break;
                case 2:
                    rtxtViewSentencesSample.Font = new Font(rtxtViewSentencesSample.Font.FontFamily, 15);
                    break;
                case 3:
                    rtxtViewSentencesSample.Font = new Font(rtxtViewSentencesSample.Font.FontFamily, 17);
                    break;
                case 4:
                    rtxtViewSentencesSample.Font = new Font(rtxtViewSentencesSample.Font.FontFamily, 20);
                    break;
                case 5:
                    rtxtViewSentencesSample.Font = new Font(rtxtViewSentencesSample.Font.FontFamily, 24);
                    break;
                case 6:
                    rtxtViewSentencesSample.Font = new Font(rtxtViewSentencesSample.Font.FontFamily, 29);
                    break;
            }
        }

        private void TrbrEditSizeFontGridSampleView_Scroll(object sender, EventArgs e)
        {
            switch (trbrEditSizeFontGridSampleView.Value)
            {
                case 1:
                    rtxtViewGridSample.Font = new Font(rtxtViewGridSample.Font.FontFamily, 14);
                    break;
                case 2:
                    rtxtViewGridSample.Font = new Font(rtxtViewGridSample.Font.FontFamily, 15);
                    break;
                case 3:
                    rtxtViewGridSample.Font = new Font(rtxtViewGridSample.Font.FontFamily, 17);
                    break;
                case 4:
                    rtxtViewGridSample.Font = new Font(rtxtViewGridSample.Font.FontFamily, 20);
                    break;
                case 5:
                    rtxtViewGridSample.Font = new Font(rtxtViewGridSample.Font.FontFamily, 24);
                    break;
                case 6:
                    rtxtViewGridSample.Font = new Font(rtxtViewGridSample.Font.FontFamily, 29);
                    break;
            }
        }

        private void LbFonts_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int index = this.lbFonts.IndexFromPoint(e.Location);
                lbFonts.SelectedIndex = index;
                cmFontItem.Show(sender as FontListBox, e.Location);
            }
        }

        private void CmSearchOption_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // Xu ly UI
            ToolStripItem itemClicked = e.ClickedItem;
            ((ToolStripMenuItem)itemClicked).Checked = true;
            int indexItemClicked = cmSearchType.Items.IndexOf(itemClicked);
            int i = 0;
            foreach (var item in cmSearchType.Items)
            {
                if (i++ != indexItemClicked)
                    ((ToolStripMenuItem)item).Checked = false;
            }

            if (listenter != null)
            {
                listenter.Invoke(sender, new SearchTypeEventArgs((SearchType)indexItemClicked));
            }
        }

        private void PicbxSearchType_Click(object sender, EventArgs e)
        {
            cmSearchType.Show(sender as PictureBox, new Point(picbxSearchOption.Location.X, picbxSearchOption.Location.Y + picbxSearchOption.Height));
        }
        #endregion

        #region Cac thanh phan co ban cua form: close, maximize, minimize, drag-move, resize,...
        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

                this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
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
        #endregion

        #region xu ly

        // xong
        #region 4 button đầu tiên ở thanh title
        private void BtnViewAz09Sample_Click(object sender, EventArgs e)
        {
            btnViewAz09Sample.BackColor = RADIO_BTN_SELECTED_COLOR;
            btnViewGridSample.BackColor = TITLE_COLOR;
            btnViewSentencesSample.BackColor = TITLE_COLOR;
            btnViewFontInfo.BackColor = TITLE_COLOR;

            pnlViewAz09Sample.Visible = true;
            pnlViewGridSample.Visible = false;
            pnlViewSentencesSample.Visible = false;
            pnlViewFontInfo.Visible = false;
        }

        private void BtnViewGridSample_Click(object sender, EventArgs e)
        {
            btnViewAz09Sample.BackColor = TITLE_COLOR;
            btnViewGridSample.BackColor = RADIO_BTN_SELECTED_COLOR;
            btnViewSentencesSample.BackColor = TITLE_COLOR;
            btnViewFontInfo.BackColor = TITLE_COLOR;

            pnlViewAz09Sample.Visible = false;
            pnlViewGridSample.Visible = true;
            pnlViewSentencesSample.Visible = false;
            pnlViewFontInfo.Visible = false;
        }

        private void BtnViewSentencesSample_Click(object sender, EventArgs e)
        {
            btnViewAz09Sample.BackColor = TITLE_COLOR;
            btnViewGridSample.BackColor = TITLE_COLOR;
            btnViewSentencesSample.BackColor = RADIO_BTN_SELECTED_COLOR;
            btnViewFontInfo.BackColor = TITLE_COLOR;

            pnlViewAz09Sample.Visible = false;
            pnlViewGridSample.Visible = false;
            pnlViewSentencesSample.Visible = true;
            pnlViewFontInfo.Visible = false;
        }

        private void BtnViewFontInfo_Click(object sender, EventArgs e)
        {
            btnViewAz09Sample.BackColor = TITLE_COLOR;
            btnViewGridSample.BackColor = TITLE_COLOR;
            btnViewSentencesSample.BackColor = TITLE_COLOR;
            btnViewFontInfo.BackColor = RADIO_BTN_SELECTED_COLOR;

            pnlViewAz09Sample.Visible = false;
            pnlViewGridSample.Visible = false;
            pnlViewSentencesSample.Visible = false;
            pnlViewFontInfo.Visible = true;
        }
        #endregion

        #region 2 button tiếp theo ở thanh title
        private void BtnAddFonts_Click(object sender, EventArgs e)
        {
            // Lay danh sach file da chon
            List<string> filesSeletedPath;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            DialogResult dr = ofd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                if (ofd.FileNames.Length > 0)
                {
                    filesSeletedPath = new List<string>();
                    foreach (string path in ofd.FileNames)
                        filesSeletedPath.Add(path);
                }
            }

            // Cai cat fonts tu cac file da chon
        }

        private void BtnDisOrEnableFont_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region khung tìm kiếm
        private void SearchTypeClicked_listenter(object sender, SearchTypeEventArgs e)
        {

        }

        private void TxtSearchBox_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region 3 button ở cột bên trái
        private void BtnAllFonts_Click(object sender, EventArgs e)
        {
            // xu ly UI
            selectedMenuItem = MenuItem.AllFont;
            btnAllFonts.Font = new Font(btnAllFonts.Font.Name, btnAllFonts.Font.Size, FontStyle.Bold);
            btnFontsSystem.Font = new Font(btnFontsSystem.Font.Name, btnFontsSystem.Font.Size, FontStyle.Regular);
            btnFontsUser.Font = new Font(btnFontsUser.Font.Name, btnFontsUser.Font.Size, FontStyle.Regular);
        }

        private void BtnFontsSystem_Click(object sender, EventArgs e)
        {
            // xu ly UI
            selectedMenuItem = MenuItem.SystemFont;
            btnAllFonts.Font = new Font(btnAllFonts.Font.Name, btnAllFonts.Font.Size, FontStyle.Regular);
            btnFontsSystem.Font = new Font(btnFontsSystem.Font.Name, btnFontsSystem.Font.Size, FontStyle.Bold);
            btnFontsUser.Font = new Font(btnFontsUser.Font.Name, btnFontsUser.Font.Size, FontStyle.Regular);
        }

        private void BtnFontsUser_Click(object sender, EventArgs e)
        {
            // xu ly UI
            selectedMenuItem = MenuItem.UserFont;
            btnAllFonts.Font = new Font(btnAllFonts.Font.Name, btnAllFonts.Font.Size, FontStyle.Regular);
            btnFontsSystem.Font = new Font(btnFontsSystem.Font.Name, btnFontsSystem.Font.Size, FontStyle.Regular);
            btnFontsUser.Font = new Font(btnFontsUser.Font.Name, btnFontsUser.Font.Size, FontStyle.Bold);
        }
        #endregion

        // xong
        #region context menu cho mỗi font thuộc list font
        private void CmFontItemAddFont_Click(object sender, EventArgs e)
        {
            BtnAddFonts_Click(sender, e);
        }

        private void CmFontItemEnDisableFont_Click(object sender, EventArgs e)
        {

        }

        private void CmFontItemOpenFileLocation_Click(object sender, EventArgs e)
        {
            if (selectedFontPath != null && File.Exists(selectedFontPath))
            {
                string fontsSysDir = Path.GetPathRoot(System.Environment.SystemDirectory) + @"Windows\Fonts";
                if (selectedFontPath.Contains(fontsSysDir))
                    Process.Start("explorer.exe", fontsSysDir);
                else
                    Process.Start("explorer.exe", "/select, " + selectedFontPath);
            }
        }
        #endregion

        #endregion
    }
}
