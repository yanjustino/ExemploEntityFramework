using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vacinas
{
    public partial class frmListaDoencas : Form
    {
        CRUD<doenca> crud = new CRUD<doenca>();

        public frmListaDoencas()
        {
            InitializeComponent();
            grdDoenca.DataSource = crud.Listar();
        }

        /// <summary>
        /// Adicionando Doencas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lnkAdicionar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Chamando formulário
            frmCadastroDoenca frmCadDoenca = new frmCadastroDoenca();
            frmCadDoenca.ShowDialog();

            // Recuperando dados do formulário
            var doencaModel = new doenca
            {
                nomedoenca = frmCadDoenca.NomeDoenca
            };

            // Gravando
            crud.Criar(doencaModel);
            crud.Salvar();

            // Listar no grid
            grdDoenca.DataSource = crud.Listar();
        }

        /// <summary>
        /// Alterando Doença
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lnkAlterar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Chamando formulário e passando dados para alteração
            frmCadastroDoenca frmCadDoenca = new frmCadastroDoenca();
            frmCadDoenca.Id = Convert.ToInt32(grdDoenca.CurrentRow.Cells[0].Value);
            frmCadDoenca.NomeDoenca = grdDoenca.CurrentRow.Cells[1].Value.ToString();
            frmCadDoenca.ShowDialog();

            // Preparando dados para alterar no banco
            var doencaModel = crud.Buscar(frmCadDoenca.Id);
            doencaModel.nomedoenca = frmCadDoenca.NomeDoenca;

            // Alterando dados
            crud.Alterar(doencaModel);
            crud.Salvar();

            // Listar no grid
            grdDoenca.DataSource = crud.Listar();
        }

        /// <summary>
        /// Excluindo Doença
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lnkExcluir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // recuperando id no grid
            var id = Convert.ToInt32(grdDoenca.CurrentRow.Cells[0].Value);

            // excluindo no banco
            crud.Excluir(id);
            crud.Salvar();

            // atualizando grid
            grdDoenca.DataSource = crud.Listar();
        }
    }
}
