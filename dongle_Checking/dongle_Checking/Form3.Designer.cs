namespace dongle_Checking
{
    partial class Form3
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
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.lbl5 = new System.Windows.Forms.Label();
            this.btn5 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(63, 98);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(638, 249);
            label1.TabIndex = 1;
            label1.Text = resources.GetString("label1.Text");
            // 
            // lbl5
            // 
            this.lbl5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.Location = new System.Drawing.Point(59, 40);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(563, 43);
            this.lbl5.TabIndex = 0;
            this.lbl5.Text = "Find and login into the system";
            this.lbl5.Click += new System.EventHandler(this.lbl5_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(642, 376);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(84, 30);
            this.btn5.TabIndex = 2;
            this.btn5.Text = "Back";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn5);
            this.Controls.Add(label1);
            this.Controls.Add(this.lbl5);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Button btn5;
    }
}