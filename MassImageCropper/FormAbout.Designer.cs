namespace MassImageCropper {
  partial class FormAbout {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
      this.okButton = new System.Windows.Forms.Button();
      this.tbAbout = new System.Windows.Forms.TextBox();
      this.lblProduct = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // okButton
      // 
      this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.okButton.Location = new System.Drawing.Point(547, 420);
      this.okButton.Name = "okButton";
      this.okButton.Size = new System.Drawing.Size(75, 23);
      this.okButton.TabIndex = 25;
      this.okButton.Text = "&OK";
      this.okButton.Click += new System.EventHandler(this.okButton_Click);
      // 
      // tbAbout
      // 
      this.tbAbout.BackColor = System.Drawing.Color.White;
      this.tbAbout.Location = new System.Drawing.Point(12, 35);
      this.tbAbout.Multiline = true;
      this.tbAbout.Name = "tbAbout";
      this.tbAbout.ReadOnly = true;
      this.tbAbout.Size = new System.Drawing.Size(610, 379);
      this.tbAbout.TabIndex = 26;
      this.tbAbout.Text = resources.GetString("tbAbout.Text");
      // 
      // lblProduct
      // 
      this.lblProduct.AutoSize = true;
      this.lblProduct.Location = new System.Drawing.Point(12, 9);
      this.lblProduct.Name = "lblProduct";
      this.lblProduct.Size = new System.Drawing.Size(231, 13);
      this.lblProduct.TabIndex = 27;
      this.lblProduct.Text = "Mass Image Cropper by Jay @ http://xandralite.net";
      // 
      // FormAbout
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(634, 455);
      this.Controls.Add(this.lblProduct);
      this.Controls.Add(this.tbAbout);
      this.Controls.Add(this.okButton);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "FormAbout";
      this.Padding = new System.Windows.Forms.Padding(9);
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "About";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button okButton;
    private System.Windows.Forms.TextBox tbAbout;
    private System.Windows.Forms.Label lblProduct;



  }
}
