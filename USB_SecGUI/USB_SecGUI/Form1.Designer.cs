namespace USB_SecGUI
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
            this.lbl_continue = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_exit = new System.Windows.Forms.Button();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.lbl_status = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.interfaceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_continue
            // 
            this.lbl_continue.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_continue.Location = new System.Drawing.Point(652, 208);
            this.lbl_continue.Name = "lbl_continue";
            this.lbl_continue.Size = new System.Drawing.Size(117, 32);
            this.lbl_continue.TabIndex = 0;
            this.lbl_continue.Text = "Continue";
            this.lbl_continue.UseVisualStyleBackColor = true;
            this.lbl_continue.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.interfaceType,
            this.Model,
            this.serialnumber});
            this.dataGridView1.Location = new System.Drawing.Point(28, 208);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(609, 212);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "USB insertation checking";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_exit
            // 
            this.lbl_exit.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_exit.Location = new System.Drawing.Point(652, 261);
            this.lbl_exit.Name = "lbl_exit";
            this.lbl_exit.Size = new System.Drawing.Size(117, 29);
            this.lbl_exit.TabIndex = 5;
            this.lbl_exit.Text = "Exit";
            this.lbl_exit.UseVisualStyleBackColor = true;
            this.lbl_exit.Click += new System.EventHandler(this.lbl_exit_Click);
            // 
            // pb1
            // 
            this.pb1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pb1.Image = global::USB_SecGUI.Properties.Resources._4;
            this.pb1.Location = new System.Drawing.Point(652, 29);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(127, 117);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb1.TabIndex = 6;
            this.pb1.TabStop = false;
            // 
            // lbl_status
            // 
            this.lbl_status.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.ForeColor = System.Drawing.Color.DarkViolet;
            this.lbl_status.Location = new System.Drawing.Point(239, 100);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_status.Size = new System.Drawing.Size(211, 56);
            this.lbl_status.TabIndex = 7;
            this.lbl_status.Text = "Locked";
            this.lbl_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_status.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = "Devices list";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LimeGreen;
            this.label2.Location = new System.Drawing.Point(104, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(499, 52);
            this.label2.TabIndex = 9;
            this.label2.Text = "Welcome to our system";
            // 
            // interfaceType
            // 
            this.interfaceType.DataPropertyName = "InterfaceType";
            this.interfaceType.HeaderText = "Iterface Type";
            this.interfaceType.MinimumWidth = 6;
            this.interfaceType.Name = "interfaceType";
            this.interfaceType.ReadOnly = true;
            this.interfaceType.Width = 200;
            // 
            // Model
            // 
            this.Model.DataPropertyName = "Model";
            this.Model.HeaderText = "Model";
            this.Model.MinimumWidth = 6;
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            this.Model.Width = 140;
            // 
            // serialnumber
            // 
            this.serialnumber.DataPropertyName = "SerialNumber";
            this.serialnumber.HeaderText = "Serial number";
            this.serialnumber.MinimumWidth = 6;
            this.serialnumber.Name = "serialnumber";
            this.serialnumber.ReadOnly = true;
            this.serialnumber.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.lbl_exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_continue);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button lbl_continue;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button lbl_exit;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn interfaceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialnumber;
    }
}

