using System;
using System.Windows.Forms;
using Vacinas.Application;
using Vacinas.DataModel;
using Vacinas.DataModel.Contracts;

namespace Vacinas
{
    public partial class frmListaDoencas : Form
    {
        ICRUD<doenca> crud = ServiceLocator.CrudDoenca;

        public frmListaDoencas()
        {
            InitializeComponent();
            grdDoenca.DataSource = crud.Listar();
        }

        private void lnkAdicionar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmNome frmCadDoenca = new frmNome();
            frmCadDoenca.ShowDialog();

            if (frmCadDoenca.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                var doencaModel = new doenca
                {
                    nomedoenca = frmCadDoenca.Nome
                };

                crud.Criar(doencaModel);
                crud.Salvar();

                grdDoenca.DataSource = crud.Listar();
            }
        }

        private void lnkAlterar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmNome frmCadDoenca = new frmNome();
            frmCadDoenca.Id = Convert.ToInt32(grdDoenca.CurrentRow.Cells[0].Value);
            frmCadDoenca.Nome = grdDoenca.CurrentRow.Cells[1].Value.ToString();
            frmCadDoenca.ShowDialog();

            if (frmCadDoenca.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                var doencaModel = crud.Buscar(frmCadDoenca.Id);
                doencaModel.nomedoenca = frmCadDoenca.Nome;

                crud.Alterar(doencaModel);
                crud.Salvar();

                grdDoenca.DataSource = crud.Listar();
            }
        }

        private void lnkExcluir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var id = Convert.ToInt32(grdDoenca.CurrentRow.Cells[0].Value);

            crud.Excluir(id);
            crud.Salvar();

            grdDoenca.DataSource = crud.Listar();
        }
    }
}
