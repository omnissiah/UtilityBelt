namespace Rtf2PlainConverter
{
    partial class pnlRtf2TextConverter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSource = new MetroFramework.Controls.MetroTextBox();
            this.btnConvert = new MetroFramework.Controls.MetroTile();
            this.txtDest = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // txtSource
            // 
            this.txtSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSource.Lines = new string[0];
            this.txtSource.Location = new System.Drawing.Point(0, 0);
            this.txtSource.MaxLength = 32767;
            this.txtSource.Multiline = true;
            this.txtSource.Name = "txtSource";
            this.txtSource.PasswordChar = '\0';
            this.txtSource.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSource.SelectedText = "";
            this.txtSource.Size = new System.Drawing.Size(616, 211);
            this.txtSource.TabIndex = 0;
            this.txtSource.UseSelectable = true;
            this.txtSource.UseStyleColors = true;
            // 
            // btnConvert
            // 
            this.btnConvert.ActiveControl = null;
            this.btnConvert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConvert.Location = new System.Drawing.Point(0, 217);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(613, 26);
            this.btnConvert.TabIndex = 1;
            this.btnConvert.Text = "Convert";
            this.btnConvert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnConvert.UseSelectable = true;
            this.btnConvert.UseStyleColors = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // txtDest
            // 
            this.txtDest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDest.Lines = new string[0];
            this.txtDest.Location = new System.Drawing.Point(0, 249);
            this.txtDest.MaxLength = 32767;
            this.txtDest.Multiline = true;
            this.txtDest.Name = "txtDest";
            this.txtDest.PasswordChar = '\0';
            this.txtDest.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDest.SelectedText = "";
            this.txtDest.Size = new System.Drawing.Size(616, 208);
            this.txtDest.TabIndex = 2;
            this.txtDest.UseSelectable = true;
            this.txtDest.UseStyleColors = true;
            // 
            // pnlRtf2TextConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtDest);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtSource);
            this.Name = "pnlRtf2TextConverter";
            this.Size = new System.Drawing.Size(616, 457);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtSource;
        private MetroFramework.Controls.MetroTile btnConvert;
        private MetroFramework.Controls.MetroTextBox txtDest;
    }
}
