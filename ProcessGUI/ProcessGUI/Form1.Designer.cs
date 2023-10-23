namespace ProcessGUI
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
            this.txbLog = new System.Windows.Forms.TextBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnHidden = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbLog
            // 
            this.txbLog.Location = new System.Drawing.Point(71, 80);
            this.txbLog.Multiline = true;
            this.txbLog.Name = "txbLog";
            this.txbLog.Size = new System.Drawing.Size(312, 290);
            this.txbLog.TabIndex = 0;
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(445, 80);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(136, 26);
            this.btnProcess.TabIndex = 1;
            this.btnProcess.Text = "Get Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(445, 131);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(136, 28);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start ";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnHidden
            // 
            this.btnHidden.Location = new System.Drawing.Point(445, 192);
            this.btnHidden.Name = "btnHidden";
            this.btnHidden.Size = new System.Drawing.Size(136, 28);
            this.btnHidden.TabIndex = 3;
            this.btnHidden.Text = "Hidden";
            this.btnHidden.UseVisualStyleBackColor = true;
            this.btnHidden.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 450);
            this.Controls.Add(this.btnHidden);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.txbLog);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbLog;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnHidden;
    }
}

