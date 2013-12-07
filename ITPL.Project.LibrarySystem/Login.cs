using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITPL.Project.LibrarySystem.Properties;
using ITPL.Project.LibrarySystem.Forms.Book;

namespace ITPL.Project.LibrarySystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text.Trim() == Settings.Default.username && tbPassword.Text.Trim() == Settings.Default.password)
            {
                 var frmManage = new Manage();
                 frmManage.Show();
                 this.Hide();
            }
            else
            {
                MessageBox.Show(
                    Resources.Login_Validation_Message,
                    Resources.Login_Validation_Message_Title,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}
