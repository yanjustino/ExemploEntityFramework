namespace Vacinas
{
    partial class frmListaDoencas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grdDoenca = new System.Windows.Forms.DataGridView();
            this.lnkAdicionar = new System.Windows.Forms.LinkLabel();
            this.lnkAlterar = new System.Windows.Forms.LinkLabel();
            this.lnkExcluir = new System.Windows.Forms.LinkLabel();
            this.doencaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grdDoenca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doencaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grdDoenca
            // 
            this.grdDoenca.AllowUserToAddRows = false;
            this.grdDoenca.AllowUserToDeleteRows = false;
            this.grdDoenca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDoenca.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grdDoenca.Location = new System.Drawing.Point(0, 66);
            this.grdDoenca.Name = "grdDoenca";
            this.grdDoenca.ReadOnly = true;
            this.grdDoenca.Size = new System.Drawing.Size(358, 260);
            this.grdDoenca.TabIndex = 0;
            // 
            // lnkAdicionar
            // 
            this.lnkAdicionar.AutoSize = true;
            this.lnkAdicionar.Location = new System.Drawing.Point(23, 13);
            this.lnkAdicionar.Name = "lnkAdicionar";
            this.lnkAdicionar.Size = new System.Drawing.Size(51, 13);
            this.lnkAdicionar.TabIndex = 1;
            this.lnkAdicionar.TabStop = true;
            this.lnkAdicionar.Text = "Adicionar";
            this.lnkAdicionar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAdicionar_LinkClicked);
            // 
            // lnkAlterar
            // 
            this.lnkAlterar.AutoSize = true;
            this.lnkAlterar.Location = new System.Drawing.Point(85, 13);
            this.lnkAlterar.Name = "lnkAlterar";
            this.lnkAlterar.Size = new System.Drawing.Size(37, 13);
            this.lnkAlterar.TabIndex = 2;
            this.lnkAlterar.TabStop = true;
            this.lnkAlterar.Text = "Alterar";
            this.lnkAlterar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAlterar_LinkClicked);
            // 
            // lnkExcluir
            // 
            this.lnkExcluir.AutoSize = true;
            this.lnkExcluir.Location = new System.Drawing.Point(139, 13);
            this.lnkExcluir.Name = "lnkExcluir";
            this.lnkExcluir.Size = new System.Drawing.Size(38, 13);
            this.lnkExcluir.TabIndex = 3;
            this.lnkExcluir.TabStop = true;
            this.lnkExcluir.Text = "Excluir";
            this.lnkExcluir.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkExcluir_LinkClicked);
            // 
            // doencaBindingSource
            // 
            this.doencaBindingSource.DataSource = typeof(Vacinas.doenca);
            // 
            // frmListaDoencas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 326);
            this.Controls.Add(this.lnkExcluir);
            this.Controls.Add(this.lnkAlterar);
            this.Controls.Add(this.lnkAdicionar);
            this.Controls.Add(this.grdDoenca);
            this.Name = "frmListaDoencas";
            this.Text = "frmListaDoencas";
            ((System.ComponentModel.ISupportInitialize)(this.grdDoenca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doencaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource doencaBindingSource;
        private System.Windows.Forms.DataGridView grdDoenca;
        private System.Windows.Forms.LinkLabel lnkAdicionar;
        private System.Windows.Forms.LinkLabel lnkAlterar;
        private System.Windows.Forms.LinkLabel lnkExcluir;

    }
}