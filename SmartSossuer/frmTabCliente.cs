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
    public partial class frmTabCliente : Form
    {
        public frmTabCliente()
        {
            InitializeComponent();
        }

        private void btnSairTabClie_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
