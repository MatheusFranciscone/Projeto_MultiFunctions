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
    public partial class frmPedidos : Form
    {
        public frmPedidos()
        {
            InitializeComponent();
        }

        double totalprecolinha = 0;

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtProduto.Text != "" || txtQuantidade.Text != "" || txtValorUni.Text == "")
                {

                    string nome = txtProduto.Text;
                    int qtd, vUnit, vTotal;

                    vUnit = Convert.ToInt32(txtValorUni.Text);
                    qtd = Convert.ToInt32(txtQuantidade.Text);
                    vTotal = vUnit * qtd;

                    totalprecolinha = 0;

                    dgvPedidos.Rows.Add(nome, vUnit, qtd, vTotal);

                    foreach (DataGridViewRow row in dgvPedidos.Rows)
                    {
                        totalprecolinha += Convert.ToInt32(row.Cells["total"].Value);
                    }
                    txtProduto.Text = "";
                    txtQuantidade.Text = "";
                    txtValorUni.Text = "";

                    txtTotal.Text = Convert.ToDouble(totalprecolinha).ToString("C");
                    txtProduto.Focus();
                }
                else
                {
                    MessageBox.Show("Insira todos os campos!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Insira todos os campos corretamente!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
            private void btnExcluir_Click(object sender, EventArgs e)
        {
            totalprecolinha = 0;
            dgvPedidos.Rows.RemoveAt(dgvPedidos.CurrentRow.Index);

            foreach (DataGridViewRow row in dgvPedidos.Rows)
            {
                totalprecolinha += Convert.ToDouble(row.Cells["total"].Value);
            }


            txtTotal.Text = Convert.ToDouble(totalprecolinha).ToString("C");
        }

        private void btnLimparList_Click(object sender, EventArgs e)
        {
            dgvPedidos.Rows.Clear();
            txtTotal.Text = "";
            txtProduto.Focus();
        }
    }
}
