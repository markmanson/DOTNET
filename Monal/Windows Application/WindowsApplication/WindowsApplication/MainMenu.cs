using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication
{
    public partial class MainMenu : Form
    {      
        public MainMenu()
        {
            InitializeComponent();
        }

        private void registrationFormToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            RegisterForm objRmForm = new RegisterForm();
            objRmForm.Show();
        }

        private void listScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            SearchForm objsearchform = new SearchForm();
            objsearchform.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose(true);
        }
    }
}
