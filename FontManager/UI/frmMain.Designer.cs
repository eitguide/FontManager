using FontManager.UI.Control;

namespace FontMananger.UI
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.tblPnlTitle = new System.Windows.Forms.TableLayoutPanel();
            this.pnlColumn1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlColumn2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlColumn3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlColumn4 = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tblPnlBody = new System.Windows.Forms.TableLayoutPanel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlListFont = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlShowContent = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlBorder = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lbFonts = new FontManager.UI.Control.FontListBox();
            this.pnlTitle.SuspendLayout();
            this.tblPnlTitle.SuspendLayout();
            this.pnlColumn1.SuspendLayout();
            this.pnlColumn2.SuspendLayout();
            this.pnlColumn3.SuspendLayout();
            this.pnlColumn4.SuspendLayout();
            this.tblPnlBody.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlListFont.SuspendLayout();
            this.pnlShowContent.SuspendLayout();
            this.pnlBorder.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlTitle.Controls.Add(this.tblPnlTitle);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(4, 5);
            this.pnlTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(1330, 50);
            this.pnlTitle.TabIndex = 0;
            // 
            // tblPnlTitle
            // 
            this.tblPnlTitle.ColumnCount = 4;
            this.tblPnlTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblPnlTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblPnlTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tblPnlTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tblPnlTitle.Controls.Add(this.pnlColumn1, 0, 0);
            this.tblPnlTitle.Controls.Add(this.pnlColumn2, 1, 0);
            this.tblPnlTitle.Controls.Add(this.pnlColumn3, 2, 0);
            this.tblPnlTitle.Controls.Add(this.pnlColumn4, 3, 0);
            this.tblPnlTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPnlTitle.Location = new System.Drawing.Point(0, 0);
            this.tblPnlTitle.Margin = new System.Windows.Forms.Padding(0);
            this.tblPnlTitle.Name = "tblPnlTitle";
            this.tblPnlTitle.RowCount = 1;
            this.tblPnlTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPnlTitle.Size = new System.Drawing.Size(1330, 50);
            this.tblPnlTitle.TabIndex = 0;
            // 
            // pnlColumn1
            // 
            this.pnlColumn1.Controls.Add(this.label4);
            this.pnlColumn1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlColumn1.Location = new System.Drawing.Point(0, 0);
            this.pnlColumn1.Margin = new System.Windows.Forms.Padding(0);
            this.pnlColumn1.Name = "pnlColumn1";
            this.pnlColumn1.Size = new System.Drawing.Size(266, 50);
            this.pnlColumn1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "<ComboBox here>";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlColumn2
            // 
            this.pnlColumn2.Controls.Add(this.button2);
            this.pnlColumn2.Controls.Add(this.button1);
            this.pnlColumn2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlColumn2.Location = new System.Drawing.Point(266, 0);
            this.pnlColumn2.Margin = new System.Windows.Forms.Padding(0);
            this.pnlColumn2.Name = "pnlColumn2";
            this.pnlColumn2.Size = new System.Drawing.Size(266, 50);
            this.pnlColumn2.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::FontManager.Properties.Resources.tick_box_1_;
            this.button2.Location = new System.Drawing.Point(56, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 50);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::FontManager.Properties.Resources.plus_symbol;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 50);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pnlColumn3
            // 
            this.pnlColumn3.Controls.Add(this.label6);
            this.pnlColumn3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlColumn3.Location = new System.Drawing.Point(532, 0);
            this.pnlColumn3.Margin = new System.Windows.Forms.Padding(0);
            this.pnlColumn3.Name = "pnlColumn3";
            this.pnlColumn3.Size = new System.Drawing.Size(598, 50);
            this.pnlColumn3.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "<Search here>";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlColumn4
            // 
            this.pnlColumn4.Controls.Add(this.btnMinimize);
            this.pnlColumn4.Controls.Add(this.btnMaximize);
            this.pnlColumn4.Controls.Add(this.btnClose);
            this.pnlColumn4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlColumn4.Location = new System.Drawing.Point(1130, 0);
            this.pnlColumn4.Margin = new System.Windows.Forms.Padding(0);
            this.pnlColumn4.Name = "pnlColumn4";
            this.pnlColumn4.Size = new System.Drawing.Size(200, 50);
            this.pnlColumn4.TabIndex = 3;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = global::FontManager.Properties.Resources.icon_minimize_16x16;
            this.btnMinimize.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMinimize.Location = new System.Drawing.Point(32, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(56, 50);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.UseVisualStyleBackColor = true;
            // 
            // btnMaximize
            // 
            this.btnMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximize.Image")));
            this.btnMaximize.Location = new System.Drawing.Point(88, 0);
            this.btnMaximize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(56, 50);
            this.btnMaximize.TabIndex = 1;
            this.btnMaximize.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::FontManager.Properties.Resources.icon_close_16x16;
            this.btnClose.Location = new System.Drawing.Point(144, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(56, 50);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // tblPnlBody
            // 
            this.tblPnlBody.ColumnCount = 3;
            this.tblPnlBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblPnlBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblPnlBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tblPnlBody.Controls.Add(this.pnlMenu, 0, 0);
            this.tblPnlBody.Controls.Add(this.pnlListFont, 1, 0);
            this.tblPnlBody.Controls.Add(this.pnlShowContent, 2, 0);
            this.tblPnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPnlBody.Location = new System.Drawing.Point(4, 55);
            this.tblPnlBody.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tblPnlBody.Name = "tblPnlBody";
            this.tblPnlBody.RowCount = 1;
            this.tblPnlBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPnlBody.Size = new System.Drawing.Size(1330, 803);
            this.tblPnlBody.TabIndex = 0;
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.label1);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(266, 803);
            this.pnlMenu.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "<menu here>";
            // 
            // pnlListFont
            // 
            this.pnlListFont.Controls.Add(this.lbFonts);
            this.pnlListFont.Controls.Add(this.label2);
            this.pnlListFont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlListFont.Location = new System.Drawing.Point(266, 0);
            this.pnlListFont.Margin = new System.Windows.Forms.Padding(0);
            this.pnlListFont.Name = "pnlListFont";
            this.pnlListFont.Size = new System.Drawing.Size(266, 803);
            this.pnlListFont.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 0;
            // 
            // pnlShowContent
            // 
            this.pnlShowContent.Controls.Add(this.label3);
            this.pnlShowContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlShowContent.Location = new System.Drawing.Point(532, 0);
            this.pnlShowContent.Margin = new System.Windows.Forms.Padding(0);
            this.pnlShowContent.Name = "pnlShowContent";
            this.pnlShowContent.Size = new System.Drawing.Size(798, 803);
            this.pnlShowContent.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "<Show content here>";
            // 
            // pnlBorder
            // 
            this.pnlBorder.AllowDrop = true;
            this.pnlBorder.Controls.Add(this.tblPnlBody);
            this.pnlBorder.Controls.Add(this.pnlTitle);
            this.pnlBorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBorder.Location = new System.Drawing.Point(6, 6);
            this.pnlBorder.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBorder.Name = "pnlBorder";
            this.pnlBorder.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlBorder.Size = new System.Drawing.Size(1338, 863);
            this.pnlBorder.TabIndex = 1;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lbFonts
            // 
            this.lbFonts.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lbFonts.FormattingEnabled = true;
            this.lbFonts.ItemHeight = 20;
            this.lbFonts.Location = new System.Drawing.Point(0, 3);
            this.lbFonts.Name = "lbFonts";
            this.lbFonts.Size = new System.Drawing.Size(263, 744);
            this.lbFonts.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 875);
            this.Controls.Add(this.pnlBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1350, 875);
            this.Name = "frmMain";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Font Manager";
            this.pnlTitle.ResumeLayout(false);
            this.tblPnlTitle.ResumeLayout(false);
            this.pnlColumn1.ResumeLayout(false);
            this.pnlColumn1.PerformLayout();
            this.pnlColumn2.ResumeLayout(false);
            this.pnlColumn3.ResumeLayout(false);
            this.pnlColumn3.PerformLayout();
            this.pnlColumn4.ResumeLayout(false);
            this.tblPnlBody.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.pnlListFont.ResumeLayout(false);
            this.pnlListFont.PerformLayout();
            this.pnlShowContent.ResumeLayout(false);
            this.pnlShowContent.PerformLayout();
            this.pnlBorder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.TableLayoutPanel tblPnlBody;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlListFont;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlShowContent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlBorder;
        private System.Windows.Forms.TableLayoutPanel tblPnlTitle;
        private System.Windows.Forms.Panel pnlColumn1;
        private System.Windows.Forms.Panel pnlColumn2;
        private System.Windows.Forms.Panel pnlColumn3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlColumn4;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button2;
        private FontManager.UI.Control.FontListBox lbFonts;
    }
}