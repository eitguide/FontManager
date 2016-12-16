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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.tblPnlTitle = new System.Windows.Forms.TableLayoutPanel();
            this.pnlColumn1 = new System.Windows.Forms.Panel();
            this.btnViewFontInfo = new System.Windows.Forms.Button();
            this.btnViewSentencesSample = new System.Windows.Forms.Button();
            this.btnViewGridSample = new System.Windows.Forms.Button();
            this.btnViewSimpleSample = new System.Windows.Forms.Button();
            this.pnlColumn2 = new System.Windows.Forms.Panel();
            this.btnDisOrEnableFont = new System.Windows.Forms.Button();
            this.btnAddFonts = new System.Windows.Forms.Button();
            this.pnlColumn3 = new System.Windows.Forms.Panel();
            this.pnlSearchBox = new System.Windows.Forms.Panel();
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            this.picbxSearchOption = new System.Windows.Forms.PictureBox();
            this.pnlColumn4 = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tblPnlBody = new System.Windows.Forms.TableLayoutPanel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlListFont = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlShowContent = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlBorder = new System.Windows.Forms.Panel();
            this.btnAllFonts = new System.Windows.Forms.Button();
            this.btnFontsSystem = new System.Windows.Forms.Button();
            this.btnFontsUser = new System.Windows.Forms.Button();
            this.pnlTitle.SuspendLayout();
            this.tblPnlTitle.SuspendLayout();
            this.pnlColumn1.SuspendLayout();
            this.pnlColumn2.SuspendLayout();
            this.pnlColumn3.SuspendLayout();
            this.pnlSearchBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbxSearchOption)).BeginInit();
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
            this.pnlTitle.Location = new System.Drawing.Point(4, 4);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(1182, 40);
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
            this.tblPnlTitle.Size = new System.Drawing.Size(1182, 40);
            this.tblPnlTitle.TabIndex = 0;
            // 
            // pnlColumn1
            // 
            this.pnlColumn1.Controls.Add(this.btnViewFontInfo);
            this.pnlColumn1.Controls.Add(this.btnViewSentencesSample);
            this.pnlColumn1.Controls.Add(this.btnViewGridSample);
            this.pnlColumn1.Controls.Add(this.btnViewSimpleSample);
            this.pnlColumn1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlColumn1.Location = new System.Drawing.Point(0, 0);
            this.pnlColumn1.Margin = new System.Windows.Forms.Padding(0);
            this.pnlColumn1.Name = "pnlColumn1";
            this.pnlColumn1.Size = new System.Drawing.Size(236, 40);
            this.pnlColumn1.TabIndex = 0;
            // 
            // btnViewFontInfo
            // 
            this.btnViewFontInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnViewFontInfo.FlatAppearance.BorderSize = 0;
            this.btnViewFontInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewFontInfo.Image = global::FontManager.Properties.Resources.icon_info_16x16;
            this.btnViewFontInfo.Location = new System.Drawing.Point(150, 0);
            this.btnViewFontInfo.Name = "btnViewFontInfo";
            this.btnViewFontInfo.Size = new System.Drawing.Size(50, 40);
            this.btnViewFontInfo.TabIndex = 5;
            this.btnViewFontInfo.UseVisualStyleBackColor = true;
            // 
            // btnViewSentencesSample
            // 
            this.btnViewSentencesSample.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnViewSentencesSample.FlatAppearance.BorderSize = 0;
            this.btnViewSentencesSample.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewSentencesSample.Image = global::FontManager.Properties.Resources.icon_font_24x24;
            this.btnViewSentencesSample.Location = new System.Drawing.Point(100, 0);
            this.btnViewSentencesSample.Name = "btnViewSentencesSample";
            this.btnViewSentencesSample.Size = new System.Drawing.Size(50, 40);
            this.btnViewSentencesSample.TabIndex = 4;
            this.btnViewSentencesSample.UseVisualStyleBackColor = true;
            // 
            // btnViewGridSample
            // 
            this.btnViewGridSample.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnViewGridSample.FlatAppearance.BorderSize = 0;
            this.btnViewGridSample.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewGridSample.Image = global::FontManager.Properties.Resources.icon_grid_layout_24x24;
            this.btnViewGridSample.Location = new System.Drawing.Point(50, 0);
            this.btnViewGridSample.Name = "btnViewGridSample";
            this.btnViewGridSample.Size = new System.Drawing.Size(50, 40);
            this.btnViewGridSample.TabIndex = 3;
            this.btnViewGridSample.UseVisualStyleBackColor = true;
            // 
            // btnViewSimpleSample
            // 
            this.btnViewSimpleSample.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnViewSimpleSample.FlatAppearance.BorderSize = 0;
            this.btnViewSimpleSample.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewSimpleSample.Image = global::FontManager.Properties.Resources.icon_center_alignment_2_24x24;
            this.btnViewSimpleSample.Location = new System.Drawing.Point(0, 0);
            this.btnViewSimpleSample.Name = "btnViewSimpleSample";
            this.btnViewSimpleSample.Size = new System.Drawing.Size(50, 40);
            this.btnViewSimpleSample.TabIndex = 2;
            this.btnViewSimpleSample.UseVisualStyleBackColor = true;
            // 
            // pnlColumn2
            // 
            this.pnlColumn2.Controls.Add(this.btnDisOrEnableFont);
            this.pnlColumn2.Controls.Add(this.btnAddFonts);
            this.pnlColumn2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlColumn2.Location = new System.Drawing.Point(236, 0);
            this.pnlColumn2.Margin = new System.Windows.Forms.Padding(0);
            this.pnlColumn2.Name = "pnlColumn2";
            this.pnlColumn2.Size = new System.Drawing.Size(236, 40);
            this.pnlColumn2.TabIndex = 1;
            // 
            // btnDisOrEnableFont
            // 
            this.btnDisOrEnableFont.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDisOrEnableFont.FlatAppearance.BorderSize = 0;
            this.btnDisOrEnableFont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisOrEnableFont.Image = global::FontManager.Properties.Resources.icon_checkbox_16x16;
            this.btnDisOrEnableFont.Location = new System.Drawing.Point(50, 0);
            this.btnDisOrEnableFont.Name = "btnDisOrEnableFont";
            this.btnDisOrEnableFont.Size = new System.Drawing.Size(50, 40);
            this.btnDisOrEnableFont.TabIndex = 1;
            this.btnDisOrEnableFont.UseVisualStyleBackColor = true;
            // 
            // btnAddFonts
            // 
            this.btnAddFonts.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddFonts.FlatAppearance.BorderSize = 0;
            this.btnAddFonts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFonts.Image = global::FontManager.Properties.Resources.icon_plus_16x16;
            this.btnAddFonts.Location = new System.Drawing.Point(0, 0);
            this.btnAddFonts.Name = "btnAddFonts";
            this.btnAddFonts.Size = new System.Drawing.Size(50, 40);
            this.btnAddFonts.TabIndex = 0;
            this.btnAddFonts.UseVisualStyleBackColor = true;
            // 
            // pnlColumn3
            // 
            this.pnlColumn3.Controls.Add(this.pnlSearchBox);
            this.pnlColumn3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlColumn3.Location = new System.Drawing.Point(472, 0);
            this.pnlColumn3.Margin = new System.Windows.Forms.Padding(0);
            this.pnlColumn3.Name = "pnlColumn3";
            this.pnlColumn3.Size = new System.Drawing.Size(531, 40);
            this.pnlColumn3.TabIndex = 2;
            // 
            // pnlSearchBox
            // 
            this.pnlSearchBox.Controls.Add(this.txtSearchBox);
            this.pnlSearchBox.Controls.Add(this.picbxSearchOption);
            this.pnlSearchBox.Location = new System.Drawing.Point(0, 0);
            this.pnlSearchBox.Name = "pnlSearchBox";
            this.pnlSearchBox.Size = new System.Drawing.Size(396, 40);
            this.pnlSearchBox.TabIndex = 1;
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBox.Location = new System.Drawing.Point(39, 11);
            this.txtSearchBox.Margin = new System.Windows.Forms.Padding(0);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(357, 19);
            this.txtSearchBox.TabIndex = 1;
            // 
            // picbxSearchOption
            // 
            this.picbxSearchOption.BackgroundImage = global::FontManager.Properties.Resources.icon_down_arrow_16x16;
            this.picbxSearchOption.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picbxSearchOption.Dock = System.Windows.Forms.DockStyle.Left;
            this.picbxSearchOption.Location = new System.Drawing.Point(0, 0);
            this.picbxSearchOption.Name = "picbxSearchOption";
            this.picbxSearchOption.Size = new System.Drawing.Size(40, 40);
            this.picbxSearchOption.TabIndex = 0;
            this.picbxSearchOption.TabStop = false;
            // 
            // pnlColumn4
            // 
            this.pnlColumn4.Controls.Add(this.btnMinimize);
            this.pnlColumn4.Controls.Add(this.btnMaximize);
            this.pnlColumn4.Controls.Add(this.btnClose);
            this.pnlColumn4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlColumn4.Location = new System.Drawing.Point(1003, 0);
            this.pnlColumn4.Margin = new System.Windows.Forms.Padding(0);
            this.pnlColumn4.Name = "pnlColumn4";
            this.pnlColumn4.Size = new System.Drawing.Size(179, 40);
            this.pnlColumn4.TabIndex = 3;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = global::FontManager.Properties.Resources.icon_minimize_2_16x16;
            this.btnMinimize.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMinimize.Location = new System.Drawing.Point(29, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(50, 40);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.UseVisualStyleBackColor = true;
            // 
            // btnMaximize
            // 
            this.btnMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximize.Image")));
            this.btnMaximize.Location = new System.Drawing.Point(79, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(50, 40);
            this.btnMaximize.TabIndex = 1;
            this.btnMaximize.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::FontManager.Properties.Resources.icon_close_16x16;
            this.btnClose.Location = new System.Drawing.Point(129, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 40);
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
            this.tblPnlBody.Location = new System.Drawing.Point(4, 44);
            this.tblPnlBody.Name = "tblPnlBody";
            this.tblPnlBody.RowCount = 1;
            this.tblPnlBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPnlBody.Size = new System.Drawing.Size(1182, 642);
            this.tblPnlBody.TabIndex = 0;
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.btnFontsUser);
            this.pnlMenu.Controls.Add(this.btnFontsSystem);
            this.pnlMenu.Controls.Add(this.btnAllFonts);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(236, 642);
            this.pnlMenu.TabIndex = 0;
            // 
            // pnlListFont
            // 
            this.pnlListFont.Controls.Add(this.label2);
            this.pnlListFont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlListFont.Location = new System.Drawing.Point(236, 0);
            this.pnlListFont.Margin = new System.Windows.Forms.Padding(0);
            this.pnlListFont.Name = "pnlListFont";
            this.pnlListFont.Size = new System.Drawing.Size(236, 642);
            this.pnlListFont.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "<list font here>";
            // 
            // pnlShowContent
            // 
            this.pnlShowContent.Controls.Add(this.label3);
            this.pnlShowContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlShowContent.Location = new System.Drawing.Point(472, 0);
            this.pnlShowContent.Margin = new System.Windows.Forms.Padding(0);
            this.pnlShowContent.Name = "pnlShowContent";
            this.pnlShowContent.Size = new System.Drawing.Size(710, 642);
            this.pnlShowContent.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "<Show content here>";
            // 
            // pnlBorder
            // 
            this.pnlBorder.AllowDrop = true;
            this.pnlBorder.Controls.Add(this.tblPnlBody);
            this.pnlBorder.Controls.Add(this.pnlTitle);
            this.pnlBorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBorder.Location = new System.Drawing.Point(5, 5);
            this.pnlBorder.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBorder.Name = "pnlBorder";
            this.pnlBorder.Padding = new System.Windows.Forms.Padding(4);
            this.pnlBorder.Size = new System.Drawing.Size(1190, 690);
            this.pnlBorder.TabIndex = 1;
            // 
            // btnAllFonts
            // 
            this.btnAllFonts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAllFonts.FlatAppearance.BorderSize = 0;
            this.btnAllFonts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllFonts.Image = global::FontManager.Properties.Resources.icon_center_alignment_2_24x24;
            this.btnAllFonts.Location = new System.Drawing.Point(0, 0);
            this.btnAllFonts.Name = "btnAllFonts";
            this.btnAllFonts.Size = new System.Drawing.Size(236, 40);
            this.btnAllFonts.TabIndex = 3;
            this.btnAllFonts.UseVisualStyleBackColor = true;
            // 
            // btnFontsSystem
            // 
            this.btnFontsSystem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFontsSystem.FlatAppearance.BorderSize = 0;
            this.btnFontsSystem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFontsSystem.Image = global::FontManager.Properties.Resources.icon_center_alignment_2_24x24;
            this.btnFontsSystem.Location = new System.Drawing.Point(0, 40);
            this.btnFontsSystem.Name = "btnFontsSystem";
            this.btnFontsSystem.Size = new System.Drawing.Size(236, 40);
            this.btnFontsSystem.TabIndex = 4;
            this.btnFontsSystem.UseVisualStyleBackColor = true;
            // 
            // btnFontsUser
            // 
            this.btnFontsUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFontsUser.FlatAppearance.BorderSize = 0;
            this.btnFontsUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFontsUser.Image = global::FontManager.Properties.Resources.icon_center_alignment_2_24x24;
            this.btnFontsUser.Location = new System.Drawing.Point(0, 80);
            this.btnFontsUser.Name = "btnFontsUser";
            this.btnFontsUser.Size = new System.Drawing.Size(236, 40);
            this.btnFontsUser.TabIndex = 5;
            this.btnFontsUser.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.pnlBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "frmMain";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Font Manager";
            this.pnlTitle.ResumeLayout(false);
            this.tblPnlTitle.ResumeLayout(false);
            this.pnlColumn1.ResumeLayout(false);
            this.pnlColumn2.ResumeLayout(false);
            this.pnlColumn3.ResumeLayout(false);
            this.pnlSearchBox.ResumeLayout(false);
            this.pnlSearchBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbxSearchOption)).EndInit();
            this.pnlColumn4.ResumeLayout(false);
            this.tblPnlBody.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
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
        private System.Windows.Forms.Panel pnlListFont;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlShowContent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlBorder;
        private System.Windows.Forms.TableLayoutPanel tblPnlTitle;
        private System.Windows.Forms.Panel pnlColumn1;
        private System.Windows.Forms.Panel pnlColumn2;
        private System.Windows.Forms.Panel pnlColumn3;
        private System.Windows.Forms.Panel pnlColumn4;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAddFonts;
        private System.Windows.Forms.Button btnDisOrEnableFont;
        private System.Windows.Forms.PictureBox picbxSearchOption;
        private System.Windows.Forms.TextBox txtSearchBox;
        private System.Windows.Forms.Panel pnlSearchBox;
        private System.Windows.Forms.Button btnViewGridSample;
        private System.Windows.Forms.Button btnViewSimpleSample;
        private System.Windows.Forms.Button btnViewFontInfo;
        private System.Windows.Forms.Button btnViewSentencesSample;
        private System.Windows.Forms.Button btnFontsUser;
        private System.Windows.Forms.Button btnFontsSystem;
        private System.Windows.Forms.Button btnAllFonts;
    }
}