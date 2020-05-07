using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula06_Ex01
{
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

            if (txtCodigo.Text == "" && txtNome.Text == "" || txtCodigo.Text == "" || txtNome.Text == "")
            {
                MessageBox.Show("Digite os dados do produto corretamente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            else
            {
                dgvTabela.Rows.Add(txtCodigo.Text, txtNome.Text);
                txtCodigo.Text = "";
                txtNome.Text = "";
                txtCodigo.Focus();
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (dgvTabela.Rows.Count != 0)
            {
                dgvTabela.Rows.RemoveAt(dgvTabela.CurrentRow.Index);
            }
            else 
            { 
                MessageBox.Show("Insira dados na tabela para poder excluir!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            dgvTabela.Rows.Clear();
        }

        private void btnLimparCad_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
            txtNome.Text = "";
            txtCodigo.Focus();
        }

        private void btnSairCad_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
                MessageBox.Show("Apenas números!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
