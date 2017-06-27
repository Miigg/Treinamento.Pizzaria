using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Treinamento.Pizzaria.Forms
{
    public partial class CadProduto : Form
    {
        public Produto Produto { get; set; }
        List<Produto> lstProduto { get; set; }
        public CadProduto()
        {
            InitializeComponent();
            Produto = new Produto();
            lstProduto = new List<Produto>();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            lstProduto.Clear();
            if (txtFiltrar.Text == "" || txtFiltrar.Text == string.Empty)
            {
                lstProduto = new List<Produto>();
                lstProduto.AddRange(Produto.LoadProduto());

            }
            else
            {
                lstProduto = new List<Produto>();
                lstProduto.Add(Produto.WhereProduto(Convert.ToInt32(txtFiltrar.Text)));
            }
            produtoBindingSource.DataSource = lstProduto;
            //gridProduto.DataSource = lstProduto;
            gridProduto.Refresh();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Produto = new Produto();
            Produto.NomeProduto = txtNome.Text;
            Produto.DescricaoProduto = txtDescricao.Text;
            Produto.Ativo = Convert.ToBoolean(checkAtivo.Checked);

            Produto.AdicionaProduto(Produto);
            produtoBindingSource.ResetBindings(true);
            MessageBox.Show("Produto Inserido!");
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Produto.IdProduto = Convert.ToInt32(txtIdPrd.Text);
            Produto.NomeProduto = txtNomePrd.Text;
            Produto.DescricaoProduto = txtDescPrd.Text;
            Produto.Ativo = Convert.ToBoolean(checkAtivoMod.Checked);

            Produto.ModificaProduto(Produto);

            produtoBindingSource.ResetBindings(true);
            txtIdPrd.Enabled = true;
            txtIdPrd.ReadOnly = false;
            txtIdPrd.Clear();
            txtNomePrd.Clear();
            checkAtivoMod.Checked = false;
            txtDescPrd.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtDelete.Text == "" || txtDelete.Text == string.Empty)
            {
                MessageBox.Show("Digite um Id para deletar");
            }
            else
            {
                Produto = (Produto)produtoBindingSource.Current;
                Produto.DeletaProduto(Produto);
                lstProduto.Remove(Produto);
                produtoBindingSource.ResetBindings(true);
                txtDelete.Enabled = true;
                txtDelete.ReadOnly = false;
                txtDelete.Clear();
            }
        }

        private void gridProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Modificar?", "Modificar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                txtIdPrd.Enabled = false;
                txtIdPrd.ReadOnly = true;
                tabControlProduto.SelectTab(tabModPrd);
                Produto = (Produto)produtoBindingSource.Current;
                txtIdPrd.Text = Convert.ToString(Produto.IdProduto);
                txtNomePrd.Text = Convert.ToString(Produto.NomeProduto);
                txtDescPrd.Text = Convert.ToString(Produto.DescricaoProduto);
                checkAtivoMod.Checked = Convert.ToBoolean(Produto.Ativo);
            }
            else
            {
                if ((MessageBox.Show("Deletar?", "Deletar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    txtDelete.Enabled = false;
                    txtDelete.ReadOnly = true;
                    tabControlProduto.SelectTab(tabDelPrd);
                    Produto = (Produto)produtoBindingSource.Current;
                    txtDelete.Text = Convert.ToString(Produto.IdProduto);
                }

            }
        }
    }
}

