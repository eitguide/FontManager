using FontManager.Callback;
using FontManager.FontService;
using FontManager.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public event SearchtypeHandler listenter;
        // Khai bao cac thanh phan su dung cho viec Keo' di chuyen form
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

       
        private const int FORM_PADDING = 5;
        private const int FORM_BORDER_THICKNESS = 4;
        private Color RADIO_BTN_SELECTED_COLOR = Color.FromArgb(177, 188, 189);
        private Color TITLE_COLOR = Color.FromArgb(137, 148, 149);      // #939e9f
        private ContextMenuStrip cmSearchType = new ContextMenuStrip();
       
        

        public frmMain()
        {
            InitializeComponent();
            Load += FrmMain_Load;
           
            
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            // Set mau sac cho cac thanh phan cua form
            SetFormBorderColor(Color.FromArgb(127, 140, 141));          // #7f8c8d
            pnlTitle.BackColor = TITLE_COLOR;
            pnlMenu.BackColor = Color.FromArgb(149, 165, 166);          // #95a5a6
            pnlListFont.BackColor = Color.FromArgb(189, 195, 199);      // #bdc3c7
            pnlShowContent.BackColor = Color.FromArgb(236, 240, 241);   // #ecf0f1
            pnlSearchBox.BackColor = Color.FromArgb(157, 168, 169);     // dua tren mau sac cua pnlTitle +20
            txtSearchBox.BackColor = Color.FromArgb(157, 168, 169);     // dua tren mau sac cua pnlTitle +20
            btnViewSimpleSample.PerformClick();

            // Them callback cho viec Keo' di chuyen form
            pnlColumn1.MouseDown += DragMoveFormCallback;
            pnlColumn2.MouseDown += DragMoveFormCallback;
            pnlColumn3.MouseDown += DragMoveFormCallback;
            pnlColumn4.MouseDown += DragMoveFormCallback;
            listenter += SearchTypeClicked_listenter;


            // Cac su kien cua cac control
            btnClose.Click += BtnClose_Click;
            btnMaximize.Click += BtnMaximize_Click;
            this.SizeChanged += FrmMain_SizeChanged;
            btnMinimize.Click += BtnMinimize_Click;
            btnViewSimpleSample.Click += BtnViewSimpleSample_Click;
            btnViewGridSample.Click += BtnViewGridSample_Click;
            btnViewSentencesSample.Click += BtnViewSentencesSample_Click;
            btnViewFontInfo.Click += BtnViewFontInfo_Click;
            picbxSearchOption.Click += PicbxSearchType_Click;
            cmSearchType.ItemClicked += CmSearchOption_ItemClicked;
            btnAddFonts.Click += BtnAddFonts_Click;
            btnDisOrEnableFont.Click += BtnDisOrEnableFont_Click;
            txtSearchBox.TextChanged += TxtSearchBox_TextChanged;

            // Khoi tao mot vai thanh phan
            MakeFormBackgroundTransparent(Color.MediumAquamarine);
            BtnViewSimpleSample_Click(sender, e);

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
            ((ToolStripMenuItem)cmSearchType.Items[0]).Checked = true;
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

        #region xu ly

        private void BtnViewSimpleSample_Click(object sender, EventArgs e)
        {
            btnViewSimpleSample.BackColor = RADIO_BTN_SELECTED_COLOR;
            btnViewGridSample.BackColor = TITLE_COLOR;
            btnViewSentencesSample.BackColor = TITLE_COLOR;
            btnViewFontInfo.BackColor = TITLE_COLOR;

            // Xy ly khi click button 1
        }

        private void BtnViewGridSample_Click(object sender, EventArgs e)
        {
            btnViewSimpleSample.BackColor = TITLE_COLOR;
            btnViewGridSample.BackColor = RADIO_BTN_SELECTED_COLOR;
            btnViewSentencesSample.BackColor = TITLE_COLOR;
            btnViewFontInfo.BackColor = TITLE_COLOR;

            // Xy ly khi click button 2
        }

        private void BtnViewSentencesSample_Click(object sender, EventArgs e)
        {
            btnViewSimpleSample.BackColor = TITLE_COLOR;
            btnViewGridSample.BackColor = TITLE_COLOR;
            btnViewSentencesSample.BackColor = RADIO_BTN_SELECTED_COLOR;
            btnViewFontInfo.BackColor = TITLE_COLOR;

            // Xy ly khi click button 3
        }

        private void BtnViewFontInfo_Click(object sender, EventArgs e)
        {
            btnViewSimpleSample.BackColor = TITLE_COLOR;
            btnViewGridSample.BackColor = TITLE_COLOR;
            btnViewSentencesSample.BackColor = TITLE_COLOR;
            btnViewFontInfo.BackColor = RADIO_BTN_SELECTED_COLOR;

            // Xy ly khi click button 4
        }


        private void BtnAddFonts_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnDisOrEnableFont_Click(object sender, EventArgs e)
        {
            
        }

        private void SearchTypeClicked_listenter(object sender, SearchTypeEventArgs e)
        {

        }

        private void TxtSearchBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        #endregion

    }
}
