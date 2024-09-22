namespace CoffeeShopApp
{
    partial class AdminForm
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
            tabAccount = new TabControl();
            tbIncome = new TabPage();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            btnAnaylysis = new Button();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            tbFood = new TabPage();
            panel6 = new Panel();
            panel10 = new Panel();
            numericUpDown1 = new NumericUpDown();
            PriceFoodlbl = new Label();
            IdFoodlbl = new Label();
            panel9 = new Panel();
            comboBox1 = new ComboBox();
            CategoryFoodlbl = new Label();
            panel8 = new Panel();
            textBox3 = new TextBox();
            FoodNamelbl = new Label();
            panel7 = new Panel();
            textBox2 = new TextBox();
            panel5 = new Panel();
            dtgvFood = new DataGridView();
            panel4 = new Panel();
            textBox1 = new TextBox();
            btnFindFood = new Button();
            panel3 = new Panel();
            btnViewFood = new Button();
            btnModifyFood = new Button();
            btnAddFood = new Button();
            btnDeleteFood = new Button();
            tbFoodCategory = new TabPage();
            panel11 = new Panel();
            lbIdCategory = new Label();
            panel13 = new Panel();
            tbCategoryName = new TextBox();
            lbCategoryName = new Label();
            panel15 = new Panel();
            tbIdCategory = new TextBox();
            panel16 = new Panel();
            dgvCategory = new DataGridView();
            panel18 = new Panel();
            btnViewCategory = new Button();
            btnModifyCategory = new Button();
            btnAddCategory = new Button();
            btnDeleteCategory = new Button();
            tabTable = new TabPage();
            panel12 = new Panel();
            panel21 = new Panel();
            cbTableStatus = new ComboBox();
            lblTableStatus = new Label();
            lblIdTable = new Label();
            panel14 = new Panel();
            tbTableCategory = new TextBox();
            lblCategoryTable = new Label();
            panel17 = new Panel();
            tbIdTable = new TextBox();
            panel19 = new Panel();
            dgvTable = new DataGridView();
            panel20 = new Panel();
            btnViewTable = new Button();
            btnModifyTable = new Button();
            btnAddTable = new Button();
            btnDeleteTable = new Button();
            tbAccount = new TabPage();
            panel22 = new Panel();
            btnResetPwd = new Button();
            panel27 = new Panel();
            tbRole = new TextBox();
            lblRole = new Label();
            lblAccountName = new Label();
            panel23 = new Panel();
            tbName = new TextBox();
            lblAccountDisplayName = new Label();
            panel24 = new Panel();
            tbAccountName = new TextBox();
            pnlAccount = new Panel();
            dtgvAccount = new DataGridView();
            panel26 = new Panel();
            btnAccountView = new Button();
            btnAccountModify = new Button();
            btnAccountAdd = new Button();
            btnAccountDelete = new Button();
            tabAccount.SuspendLayout();
            tbIncome.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            tbFood.SuspendLayout();
            panel6.SuspendLayout();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvFood).BeginInit();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            tbFoodCategory.SuspendLayout();
            panel11.SuspendLayout();
            panel13.SuspendLayout();
            panel15.SuspendLayout();
            panel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategory).BeginInit();
            panel18.SuspendLayout();
            tabTable.SuspendLayout();
            panel12.SuspendLayout();
            panel21.SuspendLayout();
            panel14.SuspendLayout();
            panel17.SuspendLayout();
            panel19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTable).BeginInit();
            panel20.SuspendLayout();
            tbAccount.SuspendLayout();
            panel22.SuspendLayout();
            panel27.SuspendLayout();
            panel23.SuspendLayout();
            panel24.SuspendLayout();
            pnlAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvAccount).BeginInit();
            panel26.SuspendLayout();
            SuspendLayout();
            // 
            // tabAccount
            // 
            tabAccount.Controls.Add(tbIncome);
            tabAccount.Controls.Add(tbFood);
            tabAccount.Controls.Add(tbFoodCategory);
            tabAccount.Controls.Add(tabTable);
            tabAccount.Controls.Add(tbAccount);
            tabAccount.Location = new Point(0, 0);
            tabAccount.Name = "tabAccount";
            tabAccount.SelectedIndex = 0;
            tabAccount.Size = new Size(834, 438);
            tabAccount.TabIndex = 0;
            // 
            // tbIncome
            // 
            tbIncome.Controls.Add(panel2);
            tbIncome.Controls.Add(panel1);
            tbIncome.Location = new Point(4, 29);
            tbIncome.Name = "tbIncome";
            tbIncome.Padding = new Padding(3);
            tbIncome.Size = new Size(826, 405);
            tbIncome.TabIndex = 0;
            tbIncome.Text = "Income";
            tbIncome.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(8, 55);
            panel2.Name = "panel2";
            panel2.Size = new Size(770, 344);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(764, 341);
            dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnAnaylysis);
            panel1.Controls.Add(dateTimePicker2);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Location = new Point(8, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(773, 43);
            panel1.TabIndex = 0;
            // 
            // btnAnaylysis
            // 
            btnAnaylysis.Location = new Point(310, 3);
            btnAnaylysis.Name = "btnAnaylysis";
            btnAnaylysis.Size = new Size(159, 27);
            btnAnaylysis.TabIndex = 2;
            btnAnaylysis.Text = "Customer Analyze";
            btnAnaylysis.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(520, 3);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(3, 3);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 0;
            // 
            // tbFood
            // 
            tbFood.Controls.Add(panel6);
            tbFood.Controls.Add(panel5);
            tbFood.Controls.Add(panel4);
            tbFood.Controls.Add(panel3);
            tbFood.Location = new Point(4, 29);
            tbFood.Name = "tbFood";
            tbFood.Padding = new Padding(3);
            tbFood.Size = new Size(826, 405);
            tbFood.TabIndex = 1;
            tbFood.Text = "Food";
            tbFood.UseVisualStyleBackColor = true;
            tbFood.Click += tbFood_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(panel10);
            panel6.Controls.Add(IdFoodlbl);
            panel6.Controls.Add(panel9);
            panel6.Controls.Add(panel8);
            panel6.Controls.Add(panel7);
            panel6.Location = new Point(482, 89);
            panel6.Name = "panel6";
            panel6.Size = new Size(335, 310);
            panel6.TabIndex = 3;
            // 
            // panel10
            // 
            panel10.Controls.Add(numericUpDown1);
            panel10.Controls.Add(PriceFoodlbl);
            panel10.Location = new Point(3, 224);
            panel10.Name = "panel10";
            panel10.Size = new Size(323, 48);
            panel10.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(98, 11);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(222, 27);
            numericUpDown1.TabIndex = 2;
            // 
            // PriceFoodlbl
            // 
            PriceFoodlbl.AutoSize = true;
            PriceFoodlbl.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PriceFoodlbl.Location = new Point(6, 11);
            PriceFoodlbl.Name = "PriceFoodlbl";
            PriceFoodlbl.Size = new Size(58, 24);
            PriceFoodlbl.TabIndex = 1;
            PriceFoodlbl.Text = "Price";
            // 
            // IdFoodlbl
            // 
            IdFoodlbl.AutoSize = true;
            IdFoodlbl.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IdFoodlbl.Location = new Point(9, 32);
            IdFoodlbl.Name = "IdFoodlbl";
            IdFoodlbl.Size = new Size(27, 24);
            IdFoodlbl.TabIndex = 0;
            IdFoodlbl.Text = "Id";
            IdFoodlbl.Click += IdFoodlbl_Click;
            // 
            // panel9
            // 
            panel9.Controls.Add(comboBox1);
            panel9.Controls.Add(CategoryFoodlbl);
            panel9.Location = new Point(0, 157);
            panel9.Name = "panel9";
            panel9.Size = new Size(329, 48);
            panel9.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(101, 9);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(222, 28);
            comboBox1.TabIndex = 3;
            // 
            // CategoryFoodlbl
            // 
            CategoryFoodlbl.AutoSize = true;
            CategoryFoodlbl.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CategoryFoodlbl.Location = new Point(3, 9);
            CategoryFoodlbl.Name = "CategoryFoodlbl";
            CategoryFoodlbl.Size = new Size(96, 24);
            CategoryFoodlbl.TabIndex = 2;
            CategoryFoodlbl.Text = "Category";
            // 
            // panel8
            // 
            panel8.Controls.Add(textBox3);
            panel8.Controls.Add(FoodNamelbl);
            panel8.Location = new Point(3, 87);
            panel8.Name = "panel8";
            panel8.Size = new Size(326, 48);
            panel8.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(98, 7);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(225, 27);
            textBox3.TabIndex = 2;
            // 
            // FoodNamelbl
            // 
            FoodNamelbl.AutoSize = true;
            FoodNamelbl.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FoodNamelbl.Location = new Point(3, 10);
            FoodNamelbl.Name = "FoodNamelbl";
            FoodNamelbl.Size = new Size(58, 24);
            FoodNamelbl.TabIndex = 1;
            FoodNamelbl.Text = "Food";
            // 
            // panel7
            // 
            panel7.Controls.Add(textBox2);
            panel7.Location = new Point(6, 21);
            panel7.Name = "panel7";
            panel7.Size = new Size(323, 48);
            panel7.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(95, 11);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(225, 27);
            textBox2.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Controls.Add(dtgvFood);
            panel5.Location = new Point(8, 89);
            panel5.Name = "panel5";
            panel5.Size = new Size(468, 310);
            panel5.TabIndex = 2;
            // 
            // dtgvFood
            // 
            dtgvFood.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvFood.Location = new Point(3, 3);
            dtgvFood.Name = "dtgvFood";
            dtgvFood.RowHeadersWidth = 51;
            dtgvFood.Size = new Size(465, 310);
            dtgvFood.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(textBox1);
            panel4.Controls.Add(btnFindFood);
            panel4.Location = new Point(485, 6);
            panel4.Name = "panel4";
            panel4.Size = new Size(332, 77);
            panel4.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 28);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(229, 27);
            textBox1.TabIndex = 5;
            // 
            // btnFindFood
            // 
            btnFindFood.Location = new Point(238, 3);
            btnFindFood.Name = "btnFindFood";
            btnFindFood.Size = new Size(97, 71);
            btnFindFood.TabIndex = 4;
            btnFindFood.Text = "Find";
            btnFindFood.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnViewFood);
            panel3.Controls.Add(btnModifyFood);
            panel3.Controls.Add(btnAddFood);
            panel3.Controls.Add(btnDeleteFood);
            panel3.Location = new Point(8, 6);
            panel3.Name = "panel3";
            panel3.Size = new Size(468, 77);
            panel3.TabIndex = 0;
            // 
            // btnViewFood
            // 
            btnViewFood.Location = new Point(362, 3);
            btnViewFood.Name = "btnViewFood";
            btnViewFood.Size = new Size(94, 71);
            btnViewFood.TabIndex = 3;
            btnViewFood.Text = "View";
            btnViewFood.UseVisualStyleBackColor = true;
            // 
            // btnModifyFood
            // 
            btnModifyFood.Location = new Point(241, 3);
            btnModifyFood.Name = "btnModifyFood";
            btnModifyFood.Size = new Size(94, 71);
            btnModifyFood.TabIndex = 2;
            btnModifyFood.Text = "Modify";
            btnModifyFood.UseVisualStyleBackColor = true;
            // 
            // btnAddFood
            // 
            btnAddFood.Location = new Point(13, 3);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(94, 71);
            btnAddFood.TabIndex = 1;
            btnAddFood.Text = "Add";
            btnAddFood.UseVisualStyleBackColor = true;
            // 
            // btnDeleteFood
            // 
            btnDeleteFood.Location = new Point(130, 3);
            btnDeleteFood.Name = "btnDeleteFood";
            btnDeleteFood.Size = new Size(94, 71);
            btnDeleteFood.TabIndex = 0;
            btnDeleteFood.Text = "Delete";
            btnDeleteFood.UseVisualStyleBackColor = true;
            // 
            // tbFoodCategory
            // 
            tbFoodCategory.Controls.Add(panel11);
            tbFoodCategory.Controls.Add(panel16);
            tbFoodCategory.Controls.Add(panel18);
            tbFoodCategory.Location = new Point(4, 29);
            tbFoodCategory.Name = "tbFoodCategory";
            tbFoodCategory.Padding = new Padding(3);
            tbFoodCategory.Size = new Size(826, 405);
            tbFoodCategory.TabIndex = 2;
            tbFoodCategory.Text = "Food Category";
            tbFoodCategory.UseVisualStyleBackColor = true;
            // 
            // panel11
            // 
            panel11.Controls.Add(lbIdCategory);
            panel11.Controls.Add(panel13);
            panel11.Controls.Add(panel15);
            panel11.Location = new Point(483, 89);
            panel11.Name = "panel11";
            panel11.Size = new Size(335, 310);
            panel11.TabIndex = 7;
            // 
            // lbIdCategory
            // 
            lbIdCategory.AutoSize = true;
            lbIdCategory.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbIdCategory.Location = new Point(9, 32);
            lbIdCategory.Name = "lbIdCategory";
            lbIdCategory.Size = new Size(27, 24);
            lbIdCategory.TabIndex = 0;
            lbIdCategory.Text = "Id";
            // 
            // panel13
            // 
            panel13.Controls.Add(tbCategoryName);
            panel13.Controls.Add(lbCategoryName);
            panel13.Location = new Point(5, 75);
            panel13.Name = "panel13";
            panel13.Size = new Size(329, 48);
            panel13.TabIndex = 1;
            // 
            // tbCategoryName
            // 
            tbCategoryName.Location = new Point(105, 9);
            tbCategoryName.Name = "tbCategoryName";
            tbCategoryName.Size = new Size(219, 27);
            tbCategoryName.TabIndex = 3;
            // 
            // lbCategoryName
            // 
            lbCategoryName.AutoSize = true;
            lbCategoryName.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCategoryName.Location = new Point(3, 9);
            lbCategoryName.Name = "lbCategoryName";
            lbCategoryName.Size = new Size(96, 24);
            lbCategoryName.TabIndex = 2;
            lbCategoryName.Text = "Category";
            // 
            // panel15
            // 
            panel15.Controls.Add(tbIdCategory);
            panel15.Location = new Point(6, 21);
            panel15.Name = "panel15";
            panel15.Size = new Size(323, 48);
            panel15.TabIndex = 0;
            // 
            // tbIdCategory
            // 
            tbIdCategory.Location = new Point(104, 11);
            tbIdCategory.Name = "tbIdCategory";
            tbIdCategory.Size = new Size(216, 27);
            tbIdCategory.TabIndex = 1;
            // 
            // panel16
            // 
            panel16.Controls.Add(dgvCategory);
            panel16.Location = new Point(9, 89);
            panel16.Name = "panel16";
            panel16.Size = new Size(468, 310);
            panel16.TabIndex = 6;
            // 
            // dgvCategory
            // 
            dgvCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategory.Location = new Point(3, 3);
            dgvCategory.Name = "dgvCategory";
            dgvCategory.RowHeadersWidth = 51;
            dgvCategory.Size = new Size(465, 310);
            dgvCategory.TabIndex = 0;
            // 
            // panel18
            // 
            panel18.Controls.Add(btnViewCategory);
            panel18.Controls.Add(btnModifyCategory);
            panel18.Controls.Add(btnAddCategory);
            panel18.Controls.Add(btnDeleteCategory);
            panel18.Location = new Point(9, 6);
            panel18.Name = "panel18";
            panel18.Size = new Size(468, 77);
            panel18.TabIndex = 4;
            // 
            // btnViewCategory
            // 
            btnViewCategory.Location = new Point(362, 3);
            btnViewCategory.Name = "btnViewCategory";
            btnViewCategory.Size = new Size(94, 71);
            btnViewCategory.TabIndex = 3;
            btnViewCategory.Text = "View";
            btnViewCategory.UseVisualStyleBackColor = true;
            // 
            // btnModifyCategory
            // 
            btnModifyCategory.Location = new Point(241, 3);
            btnModifyCategory.Name = "btnModifyCategory";
            btnModifyCategory.Size = new Size(94, 71);
            btnModifyCategory.TabIndex = 2;
            btnModifyCategory.Text = "Modify";
            btnModifyCategory.UseVisualStyleBackColor = true;
            // 
            // btnAddCategory
            // 
            btnAddCategory.Location = new Point(13, 3);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(94, 71);
            btnAddCategory.TabIndex = 1;
            btnAddCategory.Text = "Add";
            btnAddCategory.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCategory
            // 
            btnDeleteCategory.Location = new Point(130, 3);
            btnDeleteCategory.Name = "btnDeleteCategory";
            btnDeleteCategory.Size = new Size(94, 71);
            btnDeleteCategory.TabIndex = 0;
            btnDeleteCategory.Text = "Delete";
            btnDeleteCategory.UseVisualStyleBackColor = true;
            // 
            // tabTable
            // 
            tabTable.Controls.Add(panel12);
            tabTable.Controls.Add(panel19);
            tabTable.Controls.Add(panel20);
            tabTable.Location = new Point(4, 29);
            tabTable.Name = "tabTable";
            tabTable.Padding = new Padding(3);
            tabTable.Size = new Size(826, 405);
            tabTable.TabIndex = 3;
            tabTable.Text = "Table";
            tabTable.UseVisualStyleBackColor = true;
            // 
            // panel12
            // 
            panel12.Controls.Add(panel21);
            panel12.Controls.Add(lblIdTable);
            panel12.Controls.Add(panel14);
            panel12.Controls.Add(panel17);
            panel12.Location = new Point(483, 89);
            panel12.Name = "panel12";
            panel12.Size = new Size(335, 310);
            panel12.TabIndex = 10;
            // 
            // panel21
            // 
            panel21.Controls.Add(cbTableStatus);
            panel21.Controls.Add(lblTableStatus);
            panel21.Location = new Point(3, 131);
            panel21.Name = "panel21";
            panel21.Size = new Size(329, 48);
            panel21.TabIndex = 2;
            // 
            // cbTableStatus
            // 
            cbTableStatus.FormattingEnabled = true;
            cbTableStatus.Location = new Point(104, 9);
            cbTableStatus.Name = "cbTableStatus";
            cbTableStatus.Size = new Size(222, 28);
            cbTableStatus.TabIndex = 4;
            // 
            // lblTableStatus
            // 
            lblTableStatus.AutoSize = true;
            lblTableStatus.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTableStatus.Location = new Point(3, 9);
            lblTableStatus.Name = "lblTableStatus";
            lblTableStatus.Size = new Size(71, 24);
            lblTableStatus.TabIndex = 2;
            lblTableStatus.Text = "Status";
            // 
            // lblIdTable
            // 
            lblIdTable.AutoSize = true;
            lblIdTable.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIdTable.Location = new Point(9, 32);
            lblIdTable.Name = "lblIdTable";
            lblIdTable.Size = new Size(27, 24);
            lblIdTable.TabIndex = 0;
            lblIdTable.Text = "Id";
            // 
            // panel14
            // 
            panel14.Controls.Add(tbTableCategory);
            panel14.Controls.Add(lblCategoryTable);
            panel14.Location = new Point(5, 75);
            panel14.Name = "panel14";
            panel14.Size = new Size(329, 48);
            panel14.TabIndex = 1;
            // 
            // tbTableCategory
            // 
            tbTableCategory.Location = new Point(105, 9);
            tbTableCategory.Name = "tbTableCategory";
            tbTableCategory.Size = new Size(219, 27);
            tbTableCategory.TabIndex = 3;
            // 
            // lblCategoryTable
            // 
            lblCategoryTable.AutoSize = true;
            lblCategoryTable.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategoryTable.Location = new Point(3, 9);
            lblCategoryTable.Name = "lblCategoryTable";
            lblCategoryTable.Size = new Size(96, 24);
            lblCategoryTable.TabIndex = 2;
            lblCategoryTable.Text = "Category";
            // 
            // panel17
            // 
            panel17.Controls.Add(tbIdTable);
            panel17.Location = new Point(6, 21);
            panel17.Name = "panel17";
            panel17.Size = new Size(323, 48);
            panel17.TabIndex = 0;
            // 
            // tbIdTable
            // 
            tbIdTable.Location = new Point(104, 11);
            tbIdTable.Name = "tbIdTable";
            tbIdTable.Size = new Size(216, 27);
            tbIdTable.TabIndex = 1;
            // 
            // panel19
            // 
            panel19.Controls.Add(dgvTable);
            panel19.Location = new Point(9, 89);
            panel19.Name = "panel19";
            panel19.Size = new Size(468, 310);
            panel19.TabIndex = 9;
            // 
            // dgvTable
            // 
            dgvTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTable.Location = new Point(3, 3);
            dgvTable.Name = "dgvTable";
            dgvTable.RowHeadersWidth = 51;
            dgvTable.Size = new Size(465, 310);
            dgvTable.TabIndex = 0;
            // 
            // panel20
            // 
            panel20.Controls.Add(btnViewTable);
            panel20.Controls.Add(btnModifyTable);
            panel20.Controls.Add(btnAddTable);
            panel20.Controls.Add(btnDeleteTable);
            panel20.Location = new Point(9, 6);
            panel20.Name = "panel20";
            panel20.Size = new Size(468, 77);
            panel20.TabIndex = 8;
            // 
            // btnViewTable
            // 
            btnViewTable.Location = new Point(362, 3);
            btnViewTable.Name = "btnViewTable";
            btnViewTable.Size = new Size(94, 71);
            btnViewTable.TabIndex = 3;
            btnViewTable.Text = "View";
            btnViewTable.UseVisualStyleBackColor = true;
            // 
            // btnModifyTable
            // 
            btnModifyTable.Location = new Point(241, 3);
            btnModifyTable.Name = "btnModifyTable";
            btnModifyTable.Size = new Size(94, 71);
            btnModifyTable.TabIndex = 2;
            btnModifyTable.Text = "Modify";
            btnModifyTable.UseVisualStyleBackColor = true;
            // 
            // btnAddTable
            // 
            btnAddTable.Location = new Point(13, 3);
            btnAddTable.Name = "btnAddTable";
            btnAddTable.Size = new Size(94, 71);
            btnAddTable.TabIndex = 1;
            btnAddTable.Text = "Add";
            btnAddTable.UseVisualStyleBackColor = true;
            // 
            // btnDeleteTable
            // 
            btnDeleteTable.Location = new Point(130, 3);
            btnDeleteTable.Name = "btnDeleteTable";
            btnDeleteTable.Size = new Size(94, 71);
            btnDeleteTable.TabIndex = 0;
            btnDeleteTable.Text = "Delete";
            btnDeleteTable.UseVisualStyleBackColor = true;
            // 
            // tbAccount
            // 
            tbAccount.Controls.Add(panel22);
            tbAccount.Controls.Add(pnlAccount);
            tbAccount.Controls.Add(panel26);
            tbAccount.Location = new Point(4, 29);
            tbAccount.Name = "tbAccount";
            tbAccount.Padding = new Padding(3);
            tbAccount.Size = new Size(826, 405);
            tbAccount.TabIndex = 4;
            tbAccount.Text = "Account";
            tbAccount.UseVisualStyleBackColor = true;
            tbAccount.Click += tbAccount_Click;
            // 
            // panel22
            // 
            panel22.Controls.Add(btnResetPwd);
            panel22.Controls.Add(panel27);
            panel22.Controls.Add(lblAccountName);
            panel22.Controls.Add(panel23);
            panel22.Controls.Add(panel24);
            panel22.Location = new Point(483, 89);
            panel22.Name = "panel22";
            panel22.Size = new Size(335, 310);
            panel22.TabIndex = 10;
            // 
            // btnResetPwd
            // 
            btnResetPwd.Location = new Point(250, 185);
            btnResetPwd.Name = "btnResetPwd";
            btnResetPwd.Size = new Size(79, 65);
            btnResetPwd.TabIndex = 3;
            btnResetPwd.Text = "Reset Password";
            btnResetPwd.UseVisualStyleBackColor = true;
            // 
            // panel27
            // 
            panel27.Controls.Add(tbRole);
            panel27.Controls.Add(lblRole);
            panel27.Location = new Point(3, 131);
            panel27.Name = "panel27";
            panel27.Size = new Size(329, 48);
            panel27.TabIndex = 2;
            // 
            // tbRole
            // 
            tbRole.Location = new Point(105, 9);
            tbRole.Name = "tbRole";
            tbRole.Size = new Size(219, 27);
            tbRole.TabIndex = 3;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRole.Location = new Point(3, 9);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(52, 24);
            lblRole.TabIndex = 2;
            lblRole.Text = "Role";
            // 
            // lblAccountName
            // 
            lblAccountName.AutoSize = true;
            lblAccountName.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAccountName.Location = new Point(9, 32);
            lblAccountName.Name = "lblAccountName";
            lblAccountName.Size = new Size(88, 24);
            lblAccountName.TabIndex = 0;
            lblAccountName.Text = "Account";
            // 
            // panel23
            // 
            panel23.Controls.Add(tbName);
            panel23.Controls.Add(lblAccountDisplayName);
            panel23.Location = new Point(5, 75);
            panel23.Name = "panel23";
            panel23.Size = new Size(329, 48);
            panel23.TabIndex = 1;
            // 
            // tbName
            // 
            tbName.Location = new Point(105, 9);
            tbName.Name = "tbName";
            tbName.Size = new Size(219, 27);
            tbName.TabIndex = 3;
            // 
            // lblAccountDisplayName
            // 
            lblAccountDisplayName.AutoSize = true;
            lblAccountDisplayName.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAccountDisplayName.Location = new Point(3, 9);
            lblAccountDisplayName.Name = "lblAccountDisplayName";
            lblAccountDisplayName.Size = new Size(63, 24);
            lblAccountDisplayName.TabIndex = 2;
            lblAccountDisplayName.Text = "Name";
            // 
            // panel24
            // 
            panel24.Controls.Add(tbAccountName);
            panel24.Location = new Point(6, 21);
            panel24.Name = "panel24";
            panel24.Size = new Size(323, 48);
            panel24.TabIndex = 0;
            // 
            // tbAccountName
            // 
            tbAccountName.Location = new Point(104, 11);
            tbAccountName.Name = "tbAccountName";
            tbAccountName.Size = new Size(216, 27);
            tbAccountName.TabIndex = 1;
            // 
            // pnlAccount
            // 
            pnlAccount.Controls.Add(dtgvAccount);
            pnlAccount.Location = new Point(9, 89);
            pnlAccount.Name = "pnlAccount";
            pnlAccount.Size = new Size(468, 310);
            pnlAccount.TabIndex = 9;
            // 
            // dtgvAccount
            // 
            dtgvAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvAccount.Location = new Point(3, 3);
            dtgvAccount.Name = "dtgvAccount";
            dtgvAccount.RowHeadersWidth = 51;
            dtgvAccount.Size = new Size(465, 310);
            dtgvAccount.TabIndex = 0;
            // 
            // panel26
            // 
            panel26.Controls.Add(btnAccountView);
            panel26.Controls.Add(btnAccountModify);
            panel26.Controls.Add(btnAccountAdd);
            panel26.Controls.Add(btnAccountDelete);
            panel26.Location = new Point(9, 6);
            panel26.Name = "panel26";
            panel26.Size = new Size(468, 77);
            panel26.TabIndex = 8;
            // 
            // btnAccountView
            // 
            btnAccountView.Location = new Point(362, 3);
            btnAccountView.Name = "btnAccountView";
            btnAccountView.Size = new Size(94, 71);
            btnAccountView.TabIndex = 3;
            btnAccountView.Text = "View";
            btnAccountView.UseVisualStyleBackColor = true;
            // 
            // btnAccountModify
            // 
            btnAccountModify.Location = new Point(241, 3);
            btnAccountModify.Name = "btnAccountModify";
            btnAccountModify.Size = new Size(94, 71);
            btnAccountModify.TabIndex = 2;
            btnAccountModify.Text = "Modify";
            btnAccountModify.UseVisualStyleBackColor = true;
            // 
            // btnAccountAdd
            // 
            btnAccountAdd.Location = new Point(13, 3);
            btnAccountAdd.Name = "btnAccountAdd";
            btnAccountAdd.Size = new Size(94, 71);
            btnAccountAdd.TabIndex = 1;
            btnAccountAdd.Text = "Add";
            btnAccountAdd.UseVisualStyleBackColor = true;
            // 
            // btnAccountDelete
            // 
            btnAccountDelete.Location = new Point(130, 3);
            btnAccountDelete.Name = "btnAccountDelete";
            btnAccountDelete.Size = new Size(94, 71);
            btnAccountDelete.TabIndex = 0;
            btnAccountDelete.Text = "Delete";
            btnAccountDelete.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 450);
            Controls.Add(tabAccount);
            Name = "AdminForm";
            Text = "AdminForm";
            tabAccount.ResumeLayout(false);
            tbIncome.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            tbFood.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvFood).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            tbFoodCategory.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            panel15.ResumeLayout(false);
            panel15.PerformLayout();
            panel16.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCategory).EndInit();
            panel18.ResumeLayout(false);
            tabTable.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel21.ResumeLayout(false);
            panel21.PerformLayout();
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            panel17.ResumeLayout(false);
            panel17.PerformLayout();
            panel19.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTable).EndInit();
            panel20.ResumeLayout(false);
            tbAccount.ResumeLayout(false);
            panel22.ResumeLayout(false);
            panel22.PerformLayout();
            panel27.ResumeLayout(false);
            panel27.PerformLayout();
            panel23.ResumeLayout(false);
            panel23.PerformLayout();
            panel24.ResumeLayout(false);
            panel24.PerformLayout();
            pnlAccount.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvAccount).EndInit();
            panel26.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabAccount;
        private TabPage tbIncome;
        private TabPage tbFood;
        private TabPage tbFoodCategory;
        private TabPage tabTable;
        private TabPage tbAccount;
        private Panel panel2;
        private Panel panel1;
        private DataGridView dataGridView1;
        private Button btnAnaylysis;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Panel panel6;
        private DataGridView dtgvFood;
        private Button btnViewFood;
        private Button btnModifyFood;
        private Button btnAddFood;
        private Button btnDeleteFood;
        private Button btnFindFood;
        private Panel panel7;
        private TextBox textBox1;
        private Panel panel10;
        private NumericUpDown numericUpDown1;
        private Label PriceFoodlbl;
        private Panel panel9;
        private ComboBox comboBox1;
        private Label CategoryFoodlbl;
        private Panel panel8;
        private TextBox textBox3;
        private Label FoodNamelbl;
        private TextBox textBox2;
        private Label IdFoodlbl;
        private ComboBox cbTableStatus;
        private Panel panel11;
        private Label lbIdCategory;
        private Panel panel13;
        private TextBox tbCategoryName;
        private Label lbCategoryName;
        private Panel panel15;
        private TextBox tbIdCategory;
        private Panel panel16;
        private DataGridView dgvCategory;
        private Panel panel18;
        private Button btnViewCategory;
        private Button btnModifyCategory;
        private Button btnAddCategory;
        private Button btnDeleteCategory;
        private Panel panel12;
        private Panel panel21;
        private Label lblTableStatus;
        private Label lblIdTable;
        private Panel panel14;
        private TextBox tbTableCategory;
        private Label lblCategoryTable;
        private Panel panel17;
        private TextBox tbIdTable;
        private Panel panel19;
        private DataGridView dgvTable;
        private Panel panel20;
        private Button btnViewTable;
        private Button btnModifyTable;
        private Button btnAddTable;
        private Button btnDeleteTable;
        private Panel panel22;
        private Button btnResetPwd;
        private Panel panel27;
        private TextBox tbRole;
        private Label lblRole;
        private Label lblAccountName;
        private Panel panel23;
        private TextBox tbName;
        private Label lblAccountDisplayName;
        private Panel panel24;
        private TextBox tbAccountName;
        private Panel pnlAccount;
        private DataGridView dtgvAccount;
        private Panel panel26;
        private Button btnAccountView;
        private Button btnAccountModify;
        private Button btnAccountAdd;
        private Button btnAccountDelete;
    }
}