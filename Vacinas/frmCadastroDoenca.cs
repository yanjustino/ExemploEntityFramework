using System.Windows.Forms;

namespace Vacinas
{
    public partial class frmCadastroDoenca : Form
    {
        public int Id { get; set; }

        public string NomeDoenca 
        {
            set { txtNomeDoenca.Text = value; }
            get { return txtNomeDoenca.Text; } 
        }

        public frmCadastroDoenca()
        {
            InitializeComponent();
        }
    }
}
