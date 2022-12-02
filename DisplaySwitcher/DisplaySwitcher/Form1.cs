using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisplayChanger
{
    public partial class Form1 : Form
    {
        [DllImport("DwmApi")] //System.Runtime.InteropServices
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, int[] attrValue, int attrSize);

        protected override void OnHandleCreated(EventArgs e)
        {
            if (DwmSetWindowAttribute(Handle, 19, new[] { 1 }, 4) != 0)
                DwmSetWindowAttribute(Handle, 20, new[] { 1 }, 4);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void PCScreenOnly_Click(object sender, EventArgs e)
        {
            Process p = new Process();

            p.StartInfo.FileName = "Extension.exe";
            p.StartInfo.Arguments = "1";
            p.Start();
            p.WaitForExit();
        }
        private void Duplicate_Click(object sender, EventArgs e)
        {
            Process p = new Process();

            p.StartInfo.FileName = "Extension.exe";
            p.StartInfo.Arguments = "2";
            p.Start();
            p.WaitForExit();
        }

        private void Extend_Click(object sender, EventArgs e)
        {
            Process p = new Process();

            p.StartInfo.FileName = "Extension.exe";
            p.StartInfo.Arguments = "3";
            p.Start();
            p.WaitForExit();
        }
        private void SecondScreenOnly_Click(object sender, EventArgs e)
        {
            Process p = new Process();

            p.StartInfo.FileName = "Extension.exe";
            p.StartInfo.Arguments = "4";
            p.Start();
            p.WaitForExit();
        }


        private void topMostToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (topMostToolStripMenuItem.Checked == true)
            {
                this.TopMost = true;
            }
            else
            {
                this.TopMost = false;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pCScreenOnlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process p = new Process();

            p.StartInfo.FileName = "Extension.exe";
            p.StartInfo.Arguments = "1";
            p.Start();
            p.WaitForExit();
        }

        private void duplicateDisplayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process p = new Process();

            p.StartInfo.FileName = "Extension.exe";
            p.StartInfo.Arguments = "2";
            p.Start();
            p.WaitForExit();
        }

        private void extendDisplayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process p = new Process();

            p.StartInfo.FileName = "Extension.exe";
            p.StartInfo.Arguments = "3";
            p.Start();
            p.WaitForExit();
        }

        private void secondDisplayOnlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process p = new Process();

            p.StartInfo.FileName = "Extension.exe";
            p.StartInfo.Arguments = "4";
            p.Start();
            p.WaitForExit();
        }
    }
}
