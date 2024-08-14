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

namespace LoginForm.ServiceForms
{
    public partial class terminalUI : UserControl
    {
        String connectionType = null;
        StartServer server;

        public terminalUI()
        {
            InitializeComponent();
            server = new StartServer();
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
                if (connectionCombo.SelectedIndex.Equals("Ethernet Connection"))
                {
                    skyButton1.Enabled = true;
                    connectionType = "ETHERNET";
                }
                else if (connectionCombo.SelectedIndex.Equals("Serial Connection"))
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
                if (cmdTxt.Text.Equals(""))
                {
                    MessageBox.Show("Enter a valid command");
                }
                else
                {
                    if (connectionType.Equals("SERIAL"))
                    {
                        server.sender.serialSend(cmdTxt.Text);
                        displayCmdRichTxt.AppendText(cmdTxt.Text + Environment.NewLine);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Command error");
            }
        }
    }
}
