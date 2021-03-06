﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuTemplate.Forms
{
    public partial class cFRT110010 : Form
    {
        #region "CONSTRUCTOR"
        public cFRT110010()
        {
            InitializeComponent();
        }
        #endregion

        #region "EVENTS"
        private void MinWindowsPictureBox_Click(object sender, EventArgs e)
        {
            
        }

        private void MaxWindowsPictureBox_Click(object sender, EventArgs e)
        {
            
        }

        private void CloseWindowsPictureBox_Click(object sender, EventArgs e)
        {
            
        }

        private void Minimizebutton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MaximizeButton_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }

        private void Closebutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region "METHODS"
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wsmg, int wparam, int lparam);
        #endregion
    }
}
