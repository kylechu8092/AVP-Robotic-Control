using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SerialTerminal;
using System.Net.Sockets;
using SocketManager;

namespace LoginForm.ServiceForms
{
    public partial class terminalUI : UserControl
    {
        String connectionType = null;
        TCPSend terminal;

        public terminalUI(Socket connection)
        {
            InitializeComponent();
            terminal = new TCPSend(connection);

        }
       
        public void intializeButtons()
        {
            skyButton1.Enabled = false;
        }
        
        //Connection type
        private void skyButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (connectionCombo.SelectedItem.Equals("Ethernet Connection"))
                {
                    skyButton1.Enabled = true;
                    connectionType = "ETHERNET";
                    MessageBox.Show("Connected to ethernet");
                }
                else if (connectionCombo.SelectedText.Equals("Serial Connection"))
                {
                    skyButton1.Enabled = true;
                    connectionType = "SERIAL";
                }
                else
                {
                    MessageBox.Show("Select connection type");
                }
            }
            catch (Exception ex)
            {

            }
        }

        //Send cmd
        private void skyButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if(connectionType == null)
                {
                    MessageBox.Show("Select connection type");
                }
                else if (cmdTxt.Text.Equals(""))
                {
                    MessageBox.Show("Enter a valid command");
                }
                
                else
                {
                    if (connectionType.Equals("ETHERNET"))
                    {
                        terminal.serialSend(cmdTxt.Text);
                        displayCmdRichTxt.AppendText(cmdTxt.Text + Environment.NewLine);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Command error");
            }
        }

        private void cmdTxt_Click(object sender, EventArgs e)
        {

        }

        private void cmdTxt_Leave(object sender, EventArgs e)
        {
            if(cmdTxt.Text.Equals(""))
            {
                cmdTxt.Text = "Enter a command";
            }
        }

        private void cmdTxt_Enter(object sender, EventArgs e)
        {
            if(cmdTxt.Text.Equals("Enter a command"))
            {
                cmdTxt.Text = "";
            }
        }
    }
}
