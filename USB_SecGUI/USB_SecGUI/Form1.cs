using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace USB_SecGUI
{
    public partial class Form1 : Form
    {
        public static Form1 instance;
        public Form1()
        {
            InitializeComponent();
            instance = this;
            panel = new GlassyPanel();
            panel.Dock = DockStyle.Fill;
            this.Controls.Add(panel);
        }
        GlassyPanel panel;
        private const string USB_SERIAL_ALLOW_APP = "EE06D45159E8"; // Enter the serial number of the USB
        private const int DBT_DEVICEARRIVAL = 0x8000;
        private const int DBT_DEVICEREMOVECOMPLETE = 0x8004;
        private const int DBT_DEVTYP_VOLUME = 0x00000002;
        public bool flag = true;

        protected override void WndProc(ref Message m)
        {
            int devType;
            base.WndProc(ref m);

            switch (m.WParam.ToInt32())
            {
                case DBT_DEVICEARRIVAL:
                    devType = Marshal.ReadInt32(m.LParam, 4); // New device detected
                    if (devType == DBT_DEVTYP_VOLUME)
                    {
                        DisableOrEnableForm();
                    }
                    break;
                case DBT_DEVICEREMOVECOMPLETE:
                    devType = Marshal.ReadInt32(m.LParam, 4); // Remove deivde
                    if (devType == DBT_DEVTYP_VOLUME)
                    {
                        DisableOrEnableForm();
                    }
                    break;

                default: // chạy chỉ 1 lần 
                    if (flag)
                    {
                        flag = false;
                        DisableOrEnableForm();
                    }
                    break;
            }
        }

        public async void DisableOrEnableForm()
        {
            var detected = await DetectUSB(USB_SERIAL_ALLOW_APP);
            if (detected)
            {
                this.BeginInvoke(new Action(() => {
                    lbl_status.Text = "UNLOCKED";
                    lbl_status.ForeColor = Color.Purple;
                    panel.SendToBack();
                }));
            }
            else
            {
                this.BeginInvoke(new Action(() => {
                    lbl_status.Text = "LOCKED";
                    lbl_status.ForeColor = Color.Blue;
                    panel.BringToFront();
                }));
            }
            dataGridView1.DataSource = GetListUSBDrive();
        }

        public class HardDrive
        {
            public string InterfaceType { set; get; }
            public string SerialNumber { set; get; }
            public string Model { set; get; }
            public HardDrive(string interfaceType, string serialNumber, string model)
            {
                this.InterfaceType = interfaceType;
                this.SerialNumber = serialNumber;
                this.Model = model;
            }

            public HardDrive() { }
        }

        public Task<bool> DetectUSB(string serialUSB)
        {
            var task = Task<bool>.Factory.StartNew(() => {
                var listDrive = GetListUSBDrive();
                if (listDrive.Count == 0)
                {
                    return false; // No USB found
                }
                foreach (var item in listDrive)
                {
                    if (item.SerialNumber == serialUSB)
                    {
                        return true;
                    }
                }
                return false;
            });
            return task;
        }
        public List<HardDrive> GetListUSBDrive()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive where InterfaceType='USB'");
            List<HardDrive> listDrive = new List<HardDrive>();

            try
            {
                var listHD = searcher.Get();
                foreach (ManagementObject wmi_HD in listHD)
                {
                    var hardDrive = new HardDrive();
                    hardDrive.InterfaceType = wmi_HD["InterfaceType"].ToString();
                    hardDrive.SerialNumber = wmi_HD["SerialNumber"].ToString();
                    hardDrive.Model = wmi_HD["Model"].ToString();
                    listDrive.Add(hardDrive);
                }
            }
            catch (Exception)
            {
                return new List<HardDrive>();
            }
            searcher.Dispose();
            return listDrive;
        }

        public class GlassyPanel : Panel
        {
            const int WS_EX_TRANSPARENT = 0x20;

            int opacity = 80;

            public int Opacity
            {
                get
                {
                    return opacity;
                }
                set
                {
                    if (value < 0 || value > 100) throw new ArgumentException("Value must be between 0 and 100");
                    opacity = value;
                }
            }

            protected override CreateParams CreateParams
            {
                get
                {
                    var cp = base.CreateParams;
                    cp.ExStyle = cp.ExStyle | WS_EX_TRANSPARENT;

                    return cp;
                }
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                using (var b = new SolidBrush(Color.FromArgb(opacity * 255 / 100, BackColor)))
                {
                    e.Graphics.FillRectangle(b, ClientRectangle);
                }

                base.OnPaint(e);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbl_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
