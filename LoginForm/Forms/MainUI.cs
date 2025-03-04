﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using FontAwesome;
using LoginForm.ServiceForms;
using ReaLTaiizor;
using SerialTerminal;
using UserManagement;
using SocketManager;

namespace LoginForm.Forms
{
    public partial class MainUI : Form
    {
        UserDTO currUser;
        Socket robotConnection;
        public MainUI(UserDTO currUser)
        {
            InitializeComponent();
            this.currUser = currUser;
            setPermissions();
            setInitialDisplay();
            SharedSocket s = new SharedSocket();
            robotConnection = s.getSocket();
        }

        public void setInitialDisplay()
        {
            Dashboard dash = new Dashboard(currUser);
            displayPanel.Dock = DockStyle.Fill;
            displayPanel.Controls.Clear();
            displayPanel.Controls.Add(dash);
        }
        public void setPermissions()
        {
            if (currUser.role.Equals("ADMIN"))
            {
                //Allow for anything
            }
            else
            {
                
            }
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
            try
            {
                robotControlUI robotControlUI = new robotControlUI(robotConnection);
                displayPanel.Controls.Clear();
                displayPanel.Controls.Add(robotControlUI);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void packetCaptureBtn_Click(object sender, EventArgs e)
        {
            try
            {
                PacketUI packetUI = new PacketUI();
                displayPanel.Controls.Clear();
                displayPanel.Controls.Add(packetUI);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SettingsUI settingsUI = new SettingsUI();
                displayPanel.Controls.Clear();
                displayPanel.Controls.Add(settingsUI);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void terminalBtn_Click(object sender, EventArgs e)
        {
            try
            {
                terminalUI terminalUI = new terminalUI(robotConnection);
                displayPanel.Controls.Clear();
                displayPanel.Controls.Add(terminalUI);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}   

