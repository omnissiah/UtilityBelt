namespace UtilityBelt
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainPanel = new MetroFramework.Controls.MetroPanel();
            this.toolbarPanel = new MetroFramework.Controls.MetroPanel();
            this.btnRtf2Text = new MetroFramework.Controls.MetroTile();
            this.tileBase64Converter = new MetroFramework.Controls.MetroTile();
            this.tilePingTest = new MetroFramework.Controls.MetroTile();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolbarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.HorizontalScrollbarBarColor = true;
            this.mainPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.mainPanel.HorizontalScrollbarSize = 10;
            this.mainPanel.Location = new System.Drawing.Point(20, 145);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(954, 630);
            this.mainPanel.TabIndex = 0;
            this.mainPanel.VerticalScrollbarBarColor = true;
            this.mainPanel.VerticalScrollbarHighlightOnWheel = false;
            this.mainPanel.VerticalScrollbarSize = 10;
            // 
            // toolbarPanel
            // 
            this.toolbarPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.toolbarPanel.Controls.Add(this.btnRtf2Text);
            this.toolbarPanel.Controls.Add(this.tileBase64Converter);
            this.toolbarPanel.Controls.Add(this.tilePingTest);
            this.toolbarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolbarPanel.HorizontalScrollbarBarColor = true;
            this.toolbarPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.toolbarPanel.HorizontalScrollbarSize = 10;
            this.toolbarPanel.Location = new System.Drawing.Point(20, 60);
            this.toolbarPanel.Name = "toolbarPanel";
            this.toolbarPanel.Size = new System.Drawing.Size(954, 79);
            this.toolbarPanel.TabIndex = 1;
            this.toolbarPanel.VerticalScrollbarBarColor = true;
            this.toolbarPanel.VerticalScrollbarHighlightOnWheel = false;
            this.toolbarPanel.VerticalScrollbarSize = 10;
            // 
            // btnRtf2Text
            // 
            this.btnRtf2Text.ActiveControl = null;
            this.btnRtf2Text.Location = new System.Drawing.Point(209, 3);
            this.btnRtf2Text.Name = "btnRtf2Text";
            this.btnRtf2Text.Size = new System.Drawing.Size(111, 73);
            this.btnRtf2Text.Style = MetroFramework.MetroColorStyle.Green;
            this.btnRtf2Text.TabIndex = 4;
            this.btnRtf2Text.Text = "RTF <->  Text";
            this.btnRtf2Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRtf2Text.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnRtf2Text.UseSelectable = true;
            this.btnRtf2Text.UseStyleColors = true;
            this.btnRtf2Text.Click += new System.EventHandler(this.btnRtf2Text_Click);
            // 
            // tileBase64Converter
            // 
            this.tileBase64Converter.ActiveControl = null;
            this.tileBase64Converter.Location = new System.Drawing.Point(106, 3);
            this.tileBase64Converter.Name = "tileBase64Converter";
            this.tileBase64Converter.Size = new System.Drawing.Size(97, 73);
            this.tileBase64Converter.Style = MetroFramework.MetroColorStyle.Brown;
            this.tileBase64Converter.TabIndex = 3;
            this.tileBase64Converter.Text = "Base 64 \r\nConverter";
            this.tileBase64Converter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileBase64Converter.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tileBase64Converter.UseSelectable = true;
            this.tileBase64Converter.UseStyleColors = true;
            this.tileBase64Converter.Click += new System.EventHandler(this.tileBase64Converter_Click);
            // 
            // tilePingTest
            // 
            this.tilePingTest.ActiveControl = null;
            this.tilePingTest.Location = new System.Drawing.Point(3, 3);
            this.tilePingTest.Name = "tilePingTest";
            this.tilePingTest.Size = new System.Drawing.Size(97, 73);
            this.tilePingTest.TabIndex = 2;
            this.tilePingTest.Text = "Pinger";
            this.tilePingTest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tilePingTest.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tilePingTest.UseSelectable = true;
            this.tilePingTest.Click += new System.EventHandler(this.tilePingTest_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(136, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(994, 795);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolbarPanel);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = "Utility Belt";
            this.toolbarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel mainPanel;
        private MetroFramework.Controls.MetroPanel toolbarPanel;
        private MetroFramework.Controls.MetroTile tileBase64Converter;
        private MetroFramework.Controls.MetroTile tilePingTest;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTile btnRtf2Text;
    }
}

