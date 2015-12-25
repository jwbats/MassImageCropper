namespace MassImageCropper
{
    partial class frmMassImageCropper
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMassImageCropper));
			this.tbXRes = new System.Windows.Forms.TextBox();
			this.tbYRes = new System.Windows.Forms.TextBox();
			this.lblResolution = new System.Windows.Forms.Label();
			this.tbSourceFolder = new System.Windows.Forms.TextBox();
			this.fbDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.btnPickSource = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.lblDestFolder = new System.Windows.Forms.Label();
			this.tbDestFolder = new System.Windows.Forms.TextBox();
			this.btnPickDestination = new System.Windows.Forms.Button();
			this.btnMassCrop = new System.Windows.Forms.Button();
			this.progressBar = new System.Windows.Forms.ProgressBar();
			this.hsbQuality = new System.Windows.Forms.HScrollBar();
			this.tbQuality = new System.Windows.Forms.TextBox();
			this.lblQuality = new System.Windows.Forms.Label();
			this.cbInterpolation = new System.Windows.Forms.ComboBox();
			this.lblInterpolation = new System.Windows.Forms.Label();
			this.lblImageType = new System.Windows.Forms.Label();
			this.cbImageType = new System.Windows.Forms.ComboBox();
			this.panel = new System.Windows.Forms.Panel();
			this.cbKeepAspectRatio = new System.Windows.Forms.CheckBox();
			this.lblSmoothing = new System.Windows.Forms.Label();
			this.cbSmoothing = new System.Windows.Forms.ComboBox();
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel.SuspendLayout();
			this.menuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// tbXRes
			// 
			this.tbXRes.Location = new System.Drawing.Point(112, 172);
			this.tbXRes.Name = "tbXRes";
			this.tbXRes.Size = new System.Drawing.Size(37, 20);
			this.tbXRes.TabIndex = 7;
			this.tbXRes.Text = "200";
			this.tbXRes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.tbXRes.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tbXRes_MouseUp);
			// 
			// tbYRes
			// 
			this.tbYRes.Location = new System.Drawing.Point(155, 172);
			this.tbYRes.Name = "tbYRes";
			this.tbYRes.ReadOnly = true;
			this.tbYRes.Size = new System.Drawing.Size(37, 20);
			this.tbYRes.TabIndex = 8;
			this.tbYRes.Text = "150";
			this.tbYRes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.tbYRes.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tbYRes_MouseUp);
			// 
			// lblResolution
			// 
			this.lblResolution.AutoSize = true;
			this.lblResolution.Location = new System.Drawing.Point(11, 175);
			this.lblResolution.Name = "lblResolution";
			this.lblResolution.Size = new System.Drawing.Size(89, 13);
			this.lblResolution.TabIndex = 0;
			this.lblResolution.Text = "Resolution (X, Y):";
			// 
			// tbSourceFolder
			// 
			this.tbSourceFolder.AllowDrop = true;
			this.tbSourceFolder.Location = new System.Drawing.Point(112, 40);
			this.tbSourceFolder.Name = "tbSourceFolder";
			this.tbSourceFolder.ReadOnly = true;
			this.tbSourceFolder.Size = new System.Drawing.Size(407, 20);
			this.tbSourceFolder.TabIndex = 0;
			this.tbSourceFolder.TabStop = false;
			this.tbSourceFolder.DragDrop += new System.Windows.Forms.DragEventHandler(this.tbFolder_DragDrop);
			this.tbSourceFolder.DragEnter += new System.Windows.Forms.DragEventHandler(this.tbFolder_DragEnter);
			// 
			// btnPickSource
			// 
			this.btnPickSource.Location = new System.Drawing.Point(525, 40);
			this.btnPickSource.Name = "btnPickSource";
			this.btnPickSource.Size = new System.Drawing.Size(94, 20);
			this.btnPickSource.TabIndex = 2;
			this.btnPickSource.Text = "Pick Source";
			this.btnPickSource.UseVisualStyleBackColor = true;
			this.btnPickSource.Click += new System.EventHandler(this.btnPickFolder_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(11, 43);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(76, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "Source Folder:";
			// 
			// lblDestFolder
			// 
			this.lblDestFolder.AutoSize = true;
			this.lblDestFolder.Location = new System.Drawing.Point(11, 69);
			this.lblDestFolder.Name = "lblDestFolder";
			this.lblDestFolder.Size = new System.Drawing.Size(95, 13);
			this.lblDestFolder.TabIndex = 0;
			this.lblDestFolder.Text = "Destination Folder:";
			// 
			// tbDestFolder
			// 
			this.tbDestFolder.AllowDrop = true;
			this.tbDestFolder.Location = new System.Drawing.Point(112, 66);
			this.tbDestFolder.Name = "tbDestFolder";
			this.tbDestFolder.ReadOnly = true;
			this.tbDestFolder.Size = new System.Drawing.Size(407, 20);
			this.tbDestFolder.TabIndex = 0;
			this.tbDestFolder.TabStop = false;
			this.tbDestFolder.DragDrop += new System.Windows.Forms.DragEventHandler(this.tbFolder_DragDrop);
			this.tbDestFolder.DragEnter += new System.Windows.Forms.DragEventHandler(this.tbFolder_DragEnter);
			// 
			// btnPickDestination
			// 
			this.btnPickDestination.Location = new System.Drawing.Point(525, 66);
			this.btnPickDestination.Name = "btnPickDestination";
			this.btnPickDestination.Size = new System.Drawing.Size(94, 20);
			this.btnPickDestination.TabIndex = 3;
			this.btnPickDestination.Text = "Pick Destination";
			this.btnPickDestination.UseVisualStyleBackColor = true;
			this.btnPickDestination.Click += new System.EventHandler(this.btnPickDestination_Click);
			// 
			// btnMassCrop
			// 
			this.btnMassCrop.Location = new System.Drawing.Point(525, 198);
			this.btnMassCrop.Name = "btnMassCrop";
			this.btnMassCrop.Size = new System.Drawing.Size(94, 23);
			this.btnMassCrop.TabIndex = 9;
			this.btnMassCrop.Text = "Start Cropping";
			this.btnMassCrop.UseVisualStyleBackColor = true;
			this.btnMassCrop.Click += new System.EventHandler(this.btnMassCrop_Click);
			// 
			// progressBar
			// 
			this.progressBar.Location = new System.Drawing.Point(14, 198);
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new System.Drawing.Size(505, 23);
			this.progressBar.TabIndex = 0;
			// 
			// hsbQuality
			// 
			this.hsbQuality.LargeChange = 1;
			this.hsbQuality.Location = new System.Drawing.Point(112, 92);
			this.hsbQuality.Minimum = 1;
			this.hsbQuality.Name = "hsbQuality";
			this.hsbQuality.Size = new System.Drawing.Size(368, 20);
			this.hsbQuality.TabIndex = 0;
			this.hsbQuality.Value = 85;
			this.hsbQuality.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsbQuality_Scroll);
			// 
			// tbQuality
			// 
			this.tbQuality.Location = new System.Drawing.Point(483, 92);
			this.tbQuality.Name = "tbQuality";
			this.tbQuality.Size = new System.Drawing.Size(36, 20);
			this.tbQuality.TabIndex = 4;
			this.tbQuality.Text = "85";
			this.tbQuality.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.tbQuality.Leave += new System.EventHandler(this.tbQuality_Leave);
			// 
			// lblQuality
			// 
			this.lblQuality.AutoSize = true;
			this.lblQuality.Location = new System.Drawing.Point(11, 95);
			this.lblQuality.Name = "lblQuality";
			this.lblQuality.Size = new System.Drawing.Size(42, 13);
			this.lblQuality.TabIndex = 0;
			this.lblQuality.Text = "Quality:";
			// 
			// cbInterpolation
			// 
			this.cbInterpolation.FormattingEnabled = true;
			this.cbInterpolation.Location = new System.Drawing.Point(112, 118);
			this.cbInterpolation.Name = "cbInterpolation";
			this.cbInterpolation.Size = new System.Drawing.Size(407, 21);
			this.cbInterpolation.TabIndex = 5;
			// 
			// lblInterpolation
			// 
			this.lblInterpolation.AutoSize = true;
			this.lblInterpolation.Location = new System.Drawing.Point(11, 121);
			this.lblInterpolation.Name = "lblInterpolation";
			this.lblInterpolation.Size = new System.Drawing.Size(68, 13);
			this.lblInterpolation.TabIndex = 0;
			this.lblInterpolation.Text = "Interpolation:";
			// 
			// lblImageType
			// 
			this.lblImageType.AutoSize = true;
			this.lblImageType.Location = new System.Drawing.Point(11, 16);
			this.lblImageType.Name = "lblImageType";
			this.lblImageType.Size = new System.Drawing.Size(92, 13);
			this.lblImageType.TabIndex = 0;
			this.lblImageType.Text = "Input image Type:";
			// 
			// cbImageType
			// 
			this.cbImageType.FormattingEnabled = true;
			this.cbImageType.Location = new System.Drawing.Point(112, 13);
			this.cbImageType.Name = "cbImageType";
			this.cbImageType.Size = new System.Drawing.Size(407, 21);
			this.cbImageType.TabIndex = 1;
			// 
			// panel
			// 
			this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel.Controls.Add(this.cbKeepAspectRatio);
			this.panel.Controls.Add(this.lblSmoothing);
			this.panel.Controls.Add(this.cbSmoothing);
			this.panel.Controls.Add(this.lblImageType);
			this.panel.Controls.Add(this.tbXRes);
			this.panel.Controls.Add(this.cbImageType);
			this.panel.Controls.Add(this.tbYRes);
			this.panel.Controls.Add(this.lblInterpolation);
			this.panel.Controls.Add(this.lblResolution);
			this.panel.Controls.Add(this.cbInterpolation);
			this.panel.Controls.Add(this.tbSourceFolder);
			this.panel.Controls.Add(this.lblQuality);
			this.panel.Controls.Add(this.btnPickSource);
			this.panel.Controls.Add(this.tbQuality);
			this.panel.Controls.Add(this.label3);
			this.panel.Controls.Add(this.hsbQuality);
			this.panel.Controls.Add(this.tbDestFolder);
			this.panel.Controls.Add(this.progressBar);
			this.panel.Controls.Add(this.lblDestFolder);
			this.panel.Controls.Add(this.btnMassCrop);
			this.panel.Controls.Add(this.btnPickDestination);
			this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel.Location = new System.Drawing.Point(0, 24);
			this.panel.Margin = new System.Windows.Forms.Padding(0);
			this.panel.Name = "panel";
			this.panel.Size = new System.Drawing.Size(624, 232);
			this.panel.TabIndex = 0;
			// 
			// cbKeepAspectRatio
			// 
			this.cbKeepAspectRatio.AutoSize = true;
			this.cbKeepAspectRatio.Checked = true;
			this.cbKeepAspectRatio.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbKeepAspectRatio.Location = new System.Drawing.Point(198, 175);
			this.cbKeepAspectRatio.Name = "cbKeepAspectRatio";
			this.cbKeepAspectRatio.Size = new System.Drawing.Size(109, 17);
			this.cbKeepAspectRatio.TabIndex = 11;
			this.cbKeepAspectRatio.Text = "Keep aspect ratio";
			this.cbKeepAspectRatio.UseVisualStyleBackColor = true;
			this.cbKeepAspectRatio.CheckedChanged += new System.EventHandler(this.cbKeepAspectRatio_CheckedChanged);
			// 
			// lblSmoothing
			// 
			this.lblSmoothing.AutoSize = true;
			this.lblSmoothing.Location = new System.Drawing.Point(11, 148);
			this.lblSmoothing.Name = "lblSmoothing";
			this.lblSmoothing.Size = new System.Drawing.Size(60, 13);
			this.lblSmoothing.TabIndex = 0;
			this.lblSmoothing.Text = "Smoothing:";
			// 
			// cbSmoothing
			// 
			this.cbSmoothing.FormattingEnabled = true;
			this.cbSmoothing.Location = new System.Drawing.Point(112, 145);
			this.cbSmoothing.Name = "cbSmoothing";
			this.cbSmoothing.Size = new System.Drawing.Size(407, 21);
			this.cbSmoothing.TabIndex = 6;
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(624, 24);
			this.menuStrip.TabIndex = 1;
			this.menuStrip.Text = "menuStrip1";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
			this.aboutToolStripMenuItem.Text = "About";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// frmMassImageCropper
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(624, 256);
			this.Controls.Add(this.panel);
			this.Controls.Add(this.menuStrip);
			this.HelpButton = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip;
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(640, 295);
			this.MinimumSize = new System.Drawing.Size(640, 295);
			this.Name = "frmMassImageCropper";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Mass Image Cropper,  by Jay @ Xandralite.net";
			this.panel.ResumeLayout(false);
			this.panel.PerformLayout();
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbXRes;
        private System.Windows.Forms.TextBox tbYRes;
        private System.Windows.Forms.Label lblResolution;
        private System.Windows.Forms.TextBox tbSourceFolder;
        private System.Windows.Forms.FolderBrowserDialog fbDialog;
        private System.Windows.Forms.Button btnPickSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDestFolder;
        private System.Windows.Forms.TextBox tbDestFolder;
        private System.Windows.Forms.Button btnPickDestination;
        private System.Windows.Forms.Button btnMassCrop;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.HScrollBar hsbQuality;
        private System.Windows.Forms.TextBox tbQuality;
        private System.Windows.Forms.Label lblQuality;
        private System.Windows.Forms.ComboBox cbInterpolation;
        private System.Windows.Forms.Label lblInterpolation;
        private System.Windows.Forms.Label lblImageType;
        private System.Windows.Forms.ComboBox cbImageType;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label lblSmoothing;
        private System.Windows.Forms.ComboBox cbSmoothing;
		private System.Windows.Forms.CheckBox cbKeepAspectRatio;
    }
}

