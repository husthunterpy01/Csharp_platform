namespace PictureBoxGUI
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
            this.pcbImage = new System.Windows.Forms.PictureBox();
            this.cbImage = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbImage
            // 
            this.pcbImage.Location = new System.Drawing.Point(218, 40);
            this.pcbImage.Name = "pcbImage";
            this.pcbImage.Size = new System.Drawing.Size(260, 261);
            this.pcbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcbImage.TabIndex = 0;
            this.pcbImage.TabStop = false;
            this.pcbImage.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cbImage
            // 
            this.cbImage.FormattingEnabled = true;
            this.cbImage.Location = new System.Drawing.Point(31, 40);
            this.cbImage.Name = "cbImage";
            this.cbImage.Size = new System.Drawing.Size(156, 24);
            this.cbImage.TabIndex = 1;
            this.cbImage.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.cbImage.SelectedValueChanged += new System.EventHandler(this.cbImage_SelectedValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 450);
            this.Controls.Add(this.cbImage);
            this.Controls.Add(this.pcbImage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbImage;
        private System.Windows.Forms.ComboBox cbImage;
    }
}

