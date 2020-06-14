using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartSossuer
{
    public partial class PrincipalSS : Form
    {
        public PrincipalSS()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var entrar = new frmMenu();
            entrar.Show();
        }
    }
}
