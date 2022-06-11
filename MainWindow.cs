using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example_Forms
{
    public partial class MainWindow : Form
    {
        // Dark Title Bar
        [DllImport("DwmApi")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, int[] attrValue, int attrSize);

        protected override void OnHandleCreated(EventArgs e)
        {
            if (DwmSetWindowAttribute(Handle, 19, new[] { 1 }, 4) != 0)
                DwmSetWindowAttribute(Handle, 20, new[] { 1 }, 4);
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void darkButton1_Click(object sender, EventArgs e)
        {
            CustomMessageBox msgBox = new CustomMessageBox();
            msgBox.ShowDialog();
        }

        private void darkButton3_Click(object sender, EventArgs e)
        {
            CustomMessageBox2 msgBox2 = new CustomMessageBox2();
            msgBox2.ShowDialog();
        }

        private void darkButton2_Click(object sender, EventArgs e)
        {
            CustomMessageBox3 msgBox3 = new CustomMessageBox3();
            msgBox3.ShowDialog();
        }
    }
}
