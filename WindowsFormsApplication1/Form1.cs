using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            if(username_textbox.Text.Equals("Zaki") && password_textBox.Text.Equals("123"))
            {

            }
            else
            {
                MessageBox.Show("Wrong username/password !!");
            }
        }
    }
}
