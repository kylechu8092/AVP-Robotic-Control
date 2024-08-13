using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserManagement;

namespace LoginForm.ServiceForms
{
    public partial class Dashboard : UserControl
    {
        public Dashboard(UserDTO user)
        {
            InitializeComponent();
            displayDashBoard(user);
        }

        public void displayDashBoard(UserDTO user)
        {
            richTextBox1.Text = "Welcome";
            richTextBox1.AppendText(Environment.NewLine + user.userName);
            timeRichTxt.Text = "It is " + DateTime.Now.ToString();
        }

    }
}
