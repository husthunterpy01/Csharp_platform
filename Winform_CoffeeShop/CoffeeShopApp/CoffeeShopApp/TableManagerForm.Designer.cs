namespace CoffeeShopApp
{
    partial class TableManagerForm
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
            menuStrip1 = new MenuStrip();
            adminToolStripMenuItem = new ToolStripMenuItem();
            accountInformationToolStripMenuItem = new ToolStripMenuItem();
            personalInformationToolStripMenuItem = new ToolStripMenuItem();
            signOutToolStripMenuItem = new ToolStripMenuItem();
            panel2 = new Panel();
            listView1 = new ListView();
            panel3 = new Panel();
            cbSwitch = new ComboBox();
            tblswitchBtn = new Button();
            numericUpDown1 = new NumericUpDown();
            btnDiscount = new Button();
            btnCheckout = new Button();
            panel4 = new Panel();
            nmFoodCount = new NumericUpDown();
            addBtn = new Button();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            flpTable = new FlowLayoutPanel();
            textBox1 = new TextBox();
            lblTotalPrice = new Label();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmFoodCount).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { adminToolStripMenuItem, accountInformationToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1099, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            adminToolStripMenuItem.Size = new Size(71, 24);
            adminToolStripMenuItem.Text = "Admin ";
            adminToolStripMenuItem.Click += adminToolStripMenuItem_Click;
            // 
            // accountInformationToolStripMenuItem
            // 
            accountInformationToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { personalInformationToolStripMenuItem, signOutToolStripMenuItem });
            accountInformationToolStripMenuItem.Name = "accountInformationToolStripMenuItem";
            accountInformationToolStripMenuItem.Size = new Size(159, 24);
            accountInformationToolStripMenuItem.Text = "Account Information";
            // 
            // personalInformationToolStripMenuItem
            // 
            personalInformationToolStripMenuItem.Name = "personalInformationToolStripMenuItem";
            personalInformationToolStripMenuItem.Size = new Size(229, 26);
            personalInformationToolStripMenuItem.Text = "Personal Information";
            personalInformationToolStripMenuItem.Click += personalInformationToolStripMenuItem_Click;
            // 
            // signOutToolStripMenuItem
            // 
            signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            signOutToolStripMenuItem.Size = new Size(229, 26);
            signOutToolStripMenuItem.Text = "Sign out";
            signOutToolStripMenuItem.Click += signOutToolStripMenuItem_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(listView1);
            panel2.Location = new Point(635, 168);
            panel2.Name = "panel2";
            panel2.Size = new Size(435, 350);
            panel2.TabIndex = 2;
            // 
            // listView1
            // 
            listView1.Location = new Point(0, -7);
            listView1.Name = "listView1";
            listView1.Size = new Size(435, 357);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(lblTotalPrice);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(cbSwitch);
            panel3.Controls.Add(tblswitchBtn);
            panel3.Controls.Add(numericUpDown1);
            panel3.Controls.Add(btnDiscount);
            panel3.Controls.Add(btnCheckout);
            panel3.Location = new Point(635, 537);
            panel3.Name = "panel3";
            panel3.Size = new Size(435, 82);
            panel3.TabIndex = 3;
            // 
            // cbSwitch
            // 
            cbSwitch.FormattingEnabled = true;
            cbSwitch.Location = new Point(2, 45);
            cbSwitch.Name = "cbSwitch";
            cbSwitch.Size = new Size(104, 28);
            cbSwitch.TabIndex = 6;
            // 
            // tblswitchBtn
            // 
            tblswitchBtn.Location = new Point(3, 3);
            tblswitchBtn.Name = "tblswitchBtn";
            tblswitchBtn.Size = new Size(104, 29);
            tblswitchBtn.TabIndex = 5;
            tblswitchBtn.Text = "Switch table";
            tblswitchBtn.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(113, 46);
            numericUpDown1.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(89, 27);
            numericUpDown1.TabIndex = 4;
            numericUpDown1.TextAlign = HorizontalAlignment.Center;
            // 
            // btnDiscount
            // 
            btnDiscount.Location = new Point(113, 3);
            btnDiscount.Name = "btnDiscount";
            btnDiscount.Size = new Size(89, 29);
            btnDiscount.TabIndex = 1;
            btnDiscount.Text = "Discount";
            btnDiscount.UseVisualStyleBackColor = true;
            btnDiscount.Click += btnDiscount_Click;
            // 
            // btnCheckout
            // 
            btnCheckout.Location = new Point(326, 3);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(106, 70);
            btnCheckout.TabIndex = 0;
            btnCheckout.Text = "Payment";
            btnCheckout.TextImageRelation = TextImageRelation.TextAboveImage;
            btnCheckout.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(nmFoodCount);
            panel4.Controls.Add(addBtn);
            panel4.Controls.Add(comboBox2);
            panel4.Controls.Add(comboBox1);
            panel4.Location = new Point(637, 47);
            panel4.Name = "panel4";
            panel4.Size = new Size(433, 115);
            panel4.TabIndex = 4;
            // 
            // nmFoodCount
            // 
            nmFoodCount.Location = new Point(370, 43);
            nmFoodCount.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            nmFoodCount.Name = "nmFoodCount";
            nmFoodCount.Size = new Size(60, 27);
            nmFoodCount.TabIndex = 3;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(260, 15);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(104, 81);
            addBtn.TabIndex = 2;
            addBtn.Text = "More services";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(14, 68);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(225, 28);
            comboBox2.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(14, 15);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(225, 28);
            comboBox1.TabIndex = 0;
            // 
            // flpTable
            // 
            flpTable.Location = new Point(22, 47);
            flpTable.Name = "flpTable";
            flpTable.Size = new Size(593, 572);
            flpTable.TabIndex = 5;
            flpTable.Paint += flpTable_Paint;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(218, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(101, 27);
            textBox1.TabIndex = 7;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalPrice.Location = new Point(209, 8);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(111, 24);
            lblTotalPrice.TabIndex = 8;
            lblTotalPrice.Text = "Total Price";
            // 
            // TableManagerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1099, 631);
            Controls.Add(flpTable);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "TableManagerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Coffee Management System";
            Load += TableManagerForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nmFoodCount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem adminToolStripMenuItem;
        private ToolStripMenuItem accountInformationToolStripMenuItem;
        private ToolStripMenuItem personalInformationToolStripMenuItem;
        private ToolStripMenuItem signOutToolStripMenuItem;
        private Panel panel2;
        private Panel panel3;
        private ListView listView1;
        private Panel panel4;
        private NumericUpDown nmFoodCount;
        private Button addBtn;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private FlowLayoutPanel flpTable;
        private ComboBox cbSwitch;
        private Button tblswitchBtn;
        private NumericUpDown numericUpDown1;
        private Button btnDiscount;
        private Button btnCheckout;
        private TextBox textBox1;
        private Label lblTotalPrice;
    }
}