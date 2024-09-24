namespace CoffeeShopApp
{
    partial class personInfoForm
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
            panel1 = new Panel();
            userNamelbl = new Label();
            textBox1 = new TextBox();
            panel2 = new Panel();
            textBox2 = new TextBox();
            namelbl = new Label();
            panel3 = new Panel();
            textBox3 = new TextBox();
            pwdlbl = new Label();
            panel4 = new Panel();
            textBox4 = new TextBox();
            newpwdlbl = new Label();
            panel5 = new Panel();
            textBox5 = new TextBox();
            reenterpwdlbl = new Label();
            updbtn = new Button();
            exitbtn = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(userNamelbl);
            panel1.Location = new Point(22, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(801, 74);
            panel1.TabIndex = 0;
            // 
            // userNamelbl
            // 
            userNamelbl.AutoSize = true;
            userNamelbl.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userNamelbl.Location = new Point(5, 18);
            userNamelbl.Name = "userNamelbl";
            userNamelbl.Size = new Size(155, 33);
            userNamelbl.TabIndex = 0;
            userNamelbl.Text = "UserName";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(263, 24);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(517, 27);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(namelbl);
            panel2.Location = new Point(22, 115);
            panel2.Name = "panel2";
            panel2.Size = new Size(801, 74);
            panel2.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(263, 24);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(517, 27);
            textBox2.TabIndex = 1;
            // 
            // namelbl
            // 
            namelbl.AutoSize = true;
            namelbl.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            namelbl.Location = new Point(5, 18);
            namelbl.Name = "namelbl";
            namelbl.Size = new Size(93, 33);
            namelbl.TabIndex = 0;
            namelbl.Text = "Name";
            namelbl.Click += label1_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(textBox3);
            panel3.Controls.Add(pwdlbl);
            panel3.Location = new Point(22, 209);
            panel3.Name = "panel3";
            panel3.Size = new Size(801, 74);
            panel3.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(263, 24);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(517, 27);
            textBox3.TabIndex = 1;
            // 
            // pwdlbl
            // 
            pwdlbl.AutoSize = true;
            pwdlbl.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pwdlbl.Location = new Point(5, 18);
            pwdlbl.Name = "pwdlbl";
            pwdlbl.Size = new Size(147, 33);
            pwdlbl.TabIndex = 0;
            pwdlbl.Text = "Password";
            pwdlbl.Click += pwdlbl_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(textBox4);
            panel4.Controls.Add(newpwdlbl);
            panel4.Location = new Point(22, 302);
            panel4.Name = "panel4";
            panel4.Size = new Size(801, 74);
            panel4.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(263, 24);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(517, 27);
            textBox4.TabIndex = 1;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // newpwdlbl
            // 
            newpwdlbl.AutoSize = true;
            newpwdlbl.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            newpwdlbl.Location = new Point(5, 18);
            newpwdlbl.Name = "newpwdlbl";
            newpwdlbl.Size = new Size(214, 33);
            newpwdlbl.TabIndex = 0;
            newpwdlbl.Text = "New Password";
            newpwdlbl.Click += newpwdlbl_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(textBox5);
            panel5.Controls.Add(reenterpwdlbl);
            panel5.Location = new Point(22, 399);
            panel5.Name = "panel5";
            panel5.Size = new Size(801, 74);
            panel5.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(269, 21);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(511, 27);
            textBox5.TabIndex = 1;
            // 
            // reenterpwdlbl
            // 
            reenterpwdlbl.AutoSize = true;
            reenterpwdlbl.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            reenterpwdlbl.Location = new Point(3, 15);
            reenterpwdlbl.Name = "reenterpwdlbl";
            reenterpwdlbl.Size = new Size(260, 33);
            reenterpwdlbl.TabIndex = 0;
            reenterpwdlbl.Text = "Reenter Password";
            // 
            // updbtn
            // 
            updbtn.Location = new Point(541, 495);
            updbtn.Name = "updbtn";
            updbtn.Size = new Size(124, 31);
            updbtn.TabIndex = 4;
            updbtn.Text = "Update";
            updbtn.UseVisualStyleBackColor = true;
            // 
            // exitbtn
            // 
            exitbtn.Location = new Point(699, 495);
            exitbtn.Name = "exitbtn";
            exitbtn.Size = new Size(124, 31);
            exitbtn.TabIndex = 5;
            exitbtn.Text = "Exit";
            exitbtn.UseVisualStyleBackColor = true;
            // 
            // personInfoForm
            // 
            AcceptButton = updbtn;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = exitbtn;
            ClientSize = new Size(837, 545);
            Controls.Add(exitbtn);
            Controls.Add(updbtn);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "personInfoForm";
            Text = "PersonalInformation";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBox1;
        private Label userNamelbl;
        private Panel panel2;
        private TextBox textBox2;
        private Label namelbl;
        private Panel panel3;
        private TextBox textBox3;
        private Label pwdlbl;
        private Panel panel4;
        private TextBox textBox4;
        private Label newpwdlbl;
        private Panel panel5;
        private TextBox textBox5;
        private Label reenterpwdlbl;
        private Button updbtn;
        private Button exitbtn;
    }
}