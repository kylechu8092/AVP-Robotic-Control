using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RoboticControl;

namespace LoginForm.ServiceForms
{
    public partial class robotControlUI : UserControl
    {

        BrookRobot robot = new BrookRobot();
        
        public robotControlUI()
        {
            InitializeComponent();
        }

        private void upBtn_Click(object sender, EventArgs e)
        {
            try
            {
                robot.up();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void retractBtn_Click(object sender, EventArgs e)
        {
            try
            {
                robot.retract();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void extendBtn_Click(object sender, EventArgs e)
        {
            try
            {
                robot.extend();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void downBtn_Click(object sender, EventArgs e)
        {
            try
            {
                robot.down();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                robot.home();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
