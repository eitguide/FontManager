using SharpFont;
using SharpFont.TrueType;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontManager;
using System.IO;
using FontManager.Board;
using FontManager.Model;

namespace FontManager
{
    public partial class MainForm : Form
    {
        FontService.FontService fontService;
        private Board.Board mBoard;


     
        public MainForm()
        {
            InitializeComponent();
           


            mBoard = new Board.Board(25, 25, this.Width, this.Height);
            Load += MainForm_Load;
            fontService = new FontService.FontService();
            fontService.SetFont(@"C:\\Windows\\Fonts\\consolai.ttf");
            fontService.SetSize(30);

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Console.WriteLine("MainForm_Load");
            //mBoard.Draw(this.CreateGraphics(), this);
          
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            
            Console.WriteLine("OnPaint");
            base.OnPaint(e);
            //mBoard.Draw(e.Graphics, this);
            //mBoard.Invalidation(this);
        }

        protected override void OnSizeChanged(EventArgs e)
        {
           
            CreateGraphics().Clear(Color.White);

            //base.OnSizeChanged(e);
            if (mBoard != null)
            {
                mBoard.Width = this.Width;
                mBoard.Height = this.Height;
                //mBoard.Draw(this.CreateGraphics(), this);
            }
        }
    }
}
