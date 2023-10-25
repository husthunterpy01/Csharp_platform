using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadData();
            AddBinding();
        }

        #region methods
        void AddBinding()
        {
            txbID.DataBindings.Add(new Binding("Text", dtgvData.DataSource, "ID"));
            txbName.DataBindings.Add(new Binding("Text", dtgvData.DataSource, "Name"));
        }
        void LoadData()
        {
            using (HelloEntities db = new HelloEntities())
            {
                var result = from c in db.Students
                                 //where c.ID > 1 && c.ID <4
                             select c;
                //var result = db.Students.Find(2); // Find the primary key

                dtgvData.DataSource = result.ToList();
            }
        }

        void AddStudents()
        {
            using (HelloEntities db = new HelloEntities())
            {
                db.Students.Add(new Students() { Name = "K9", IDClass = 1 });
                db.SaveChanges();
            }
        }
        void DeleteStudents()
        {

        }

        void EditStudents()
        {

        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            e.Cancel = true;
        }

          #region Events
       private void btnShow_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddStudents();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteStudents();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditStudents();
        }
        #endregion
    }
}
