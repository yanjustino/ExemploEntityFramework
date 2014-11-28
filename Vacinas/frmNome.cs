using System.Windows.Forms;

namespace Vacinas
{
    public partial class frmNome : Form
    {
        public int Id { get; set; }

        public string Nome 
        {
            set { txtNome.Text = value; }
            get { return txtNome.Text; } 
        }

        public frmNome()
        {
            InitializeComponent();
            this.DialogResult = System.Windows.Forms.DialogResult.None;
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }
    }
}
