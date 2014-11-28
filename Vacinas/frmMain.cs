using System;
using System.Windows.Forms;

namespace Vacinas
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmListaDoencas frmDoencas = new frmListaDoencas();
            frmDoencas.ShowDialog();
            frmDoencas.Dispose();
        }
    }
}
