using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FontAwesome;
using ReaLTaiizor;

namespace LoginForm.Forms
{
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
        }

        
        bool menuExpand = false;

        private void menuTransition_Tick(object sender, EventArgs e)
        {
            /*
            if (menuExpand == false)
            {
                menuContainer.Height += 10;
                if (menuContainer.Height >= 165)
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                menuContainer.Height -= 10;
                if (menuContainer.Height <= 53)
                {
                    menuTransition.Stop();
                    menuExpand = false;
                }
            }
            */
        }
        

        bool sidebarExpand = true;
        private void siderbarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebarContainer.Width -= 10;
                if (sidebarContainer.Width <= 52)
                {
                    sidebarExpand = false;
                    siderbarTransition.Stop();
                }
            }
            else
            {
                sidebarContainer.Width += 10;
                if (sidebarContainer.Width >= 180)
                {
                    sidebarExpand = true;
                    siderbarTransition.Stop();
                }
            }
        }

        private void sidebarContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuhamBtn_Click(object sender, EventArgs e)
        {
            siderbarTransition.Start();
        }

        
        private void armControlBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
